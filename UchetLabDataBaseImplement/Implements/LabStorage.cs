﻿using UchetLabContracts.BindingModels;
using UchetLabContracts.SearchModels;
using UchetLabContracts.StoragesContracts;
using UchetLabContracts.ViewModels;
using UchetLabDatabaseImplement.Models;

namespace UchetLabDatabaseImplement.Implements
{
    public class LabStorage : ILabStorage
    {
        public LabViewModel? Delete(LabBidingModel model)
        {
            using var context = new UchetLabDatabase();
            var element = context.Labs.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Labs.Remove(element);
                context.SaveChanges();
                return element.GetViewModel;
            }
            return null;
        }

        public LabViewModel? GetElement(LabSearchModel model)
        {
            if (!model.Id.HasValue)
            {
                return null;
            }
            using var context = new UchetLabDatabase();
            return context.Labs.FirstOrDefault(x => x.Id == model.Id)?.GetViewModel;
        }

        public List<LabViewModel> GetFilteredList(LabSearchModel model)
        {
            using var context = new UchetLabDatabase();
            return context.Labs
            .Select(x => x.GetViewModel)
            .ToList();
        }

        public List<LabViewModel> GetFullList()
        {
            using var context = new UchetLabDatabase();
            return context.Labs
            .Select(x => x.GetViewModel)
            .ToList();
        }

        public LabViewModel? Insert(LabBidingModel model)
        {
            using var context = new UchetLabDatabase();
            using var transaction = context.Database.BeginTransaction();
            {
                try
                {
                    var newEl = Lab.Create(model);
                    if (newEl == null)
                    {
                        transaction.Rollback();
                        return null;
                    }
                    context.Labs.Add(newEl);

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

        public LabViewModel? Update(LabBidingModel model)
        {
            using var context = new UchetLabDatabase();
            using var transaction = context.Database.BeginTransaction();
            {
                try
                {
                    var el = context.Labs.FirstOrDefault(x => x.Id == model.Id);
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
