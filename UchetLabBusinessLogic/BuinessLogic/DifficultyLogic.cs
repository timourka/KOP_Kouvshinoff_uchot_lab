using UchetLabContracts.BindingModels;
using UchetLabContracts.BusinessLogicsContracts;
using UchetLabContracts.SearchModels;
using UchetLabContracts.StoragesContracts;
using UchetLabContracts.ViewModels;

namespace UchetLabBusinessLogic.BuinessLogic
{
    public class DifficultyLogic : IDifficultyLogic
    {
        IDifficultyStorage _difficultyStorage;

        public DifficultyLogic(IDifficultyStorage difficultyStorage)
        {
            _difficultyStorage = difficultyStorage;
        }

        public bool Create(DifficultyBindigModel model)
        {
            CheckModel(model);
            if (_difficultyStorage.Insert(model) == null)
            {
                return false;
            }
            return true;
        }

        public bool Delete(DifficultyBindigModel model)
        {
            CheckModel(model, false);
            if (_difficultyStorage.Delete(model) == null)
            {
                return false;
            }
            return true;
        }

        public DifficultyViewModel? ReadElement(DifficultySearchModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            var element = _difficultyStorage.GetElement(model);
            if (element == null)
            {
                return null;
            }
            return element;
        }

        public List<DifficultyViewModel>? ReadList(DifficultySearchModel? model)
        {
            var list = model == null ? _difficultyStorage.GetFullList() : _difficultyStorage.GetFilteredList(model);
            if (list == null)
            {
                return null;
            }
            return list;
        }

        public bool Update(DifficultyBindigModel model)
        {
            CheckModel(model);
            if (_difficultyStorage.Update(model) == null)
            {
                return false;
            }
            return true;
        }
        private void CheckModel(DifficultyBindigModel model, bool withParams = true)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            if (!withParams)
            {
                return;
            }
            if (string.IsNullOrEmpty(model.Text))
            {
                throw new ArgumentNullException("сложность пуста", nameof(model.Text));
            }
        }
    }
}
