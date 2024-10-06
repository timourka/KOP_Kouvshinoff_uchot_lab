using UchetLabContracts.BindingModels;
using UchetLabContracts.SearchModels;
using UchetLabContracts.StoragesContracts;
using UchetLabContracts.ViewModels;
using UchetLabDatabaseImplement.Models;

namespace UchetLabDatabaseImplement.Implements
{
    public class DifficultyStorage : IDifficultyStorage
    {
        public DifficultyViewModel? Delete(DifficultyBindigModel model)
        {
            using var context = new UchetLabDatabase();
            var element = context.Difficulties.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Difficulties.Remove(element);
                context.SaveChanges();
                return element.GetViewModel;
            }
            return null;
        }

        public DifficultyViewModel? GetElement(DifficultySearchModel model)
        {
            if (!model.Id.HasValue)
            {
                return null;
            }
            using var context = new UchetLabDatabase();
            return context.Difficulties.FirstOrDefault(x => x.Id == model.Id)?.GetViewModel;
        }

        public List<DifficultyViewModel> GetFilteredList(DifficultySearchModel model)
        {
            using var context = new UchetLabDatabase();
            return context.Difficulties
            .Select(x => x.GetViewModel)
            .ToList();
        }

        public List<DifficultyViewModel> GetFullList()
        {
            using var context = new UchetLabDatabase();
            return context.Difficulties
            .Select(x => x.GetViewModel)
            .ToList();
        }

        public DifficultyViewModel? Insert(DifficultyBindigModel model)
        {
            using var context = new UchetLabDatabase();
            using var transaction = context.Database.BeginTransaction();
            {
                try
                {
                    var newEl = Difficulty.Create(model);
                    if (newEl == null)
                    {
                        transaction.Rollback();
                        return null;
                    }
                    context.Difficulties.Add(newEl);

                    context.SaveChanges();
                    context.Database.CommitTransaction();

                    return newEl.GetViewModel;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return null;
                }
            }
        }

        public DifficultyViewModel? Update(DifficultyBindigModel model)
        {
            using var context = new UchetLabDatabase();
            using var transaction = context.Database.BeginTransaction();
            {
                try
                {
                    var el = context.Difficulties.FirstOrDefault(x => x.Id == model.Id);
                    if (el == null)
                    {
                        transaction.Rollback();
                        return null;
                    }
                    el.Update(model);

                    context.SaveChanges();
                    context.Database.CommitTransaction();

                    return el.GetViewModel;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return null;
                }
            }
        }
    }
}
