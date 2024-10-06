using UchetLabContracts.BindingModels;
using UchetLabContracts.BusinessLogicsContracts;
using UchetLabContracts.SearchModels;
using UchetLabContracts.StoragesContracts;
using UchetLabContracts.ViewModels;

namespace UchetLabBusinessLogic.BuinessLogic
{
    public class LabLogic : ILabLogic
    {
        ILabStorage _labStorage;

        public LabLogic(ILabStorage labStorage)
        {
            _labStorage = labStorage;
        }

        public bool Create(LabBidingModel model)
        {
            CheckModel(model);
            if (_labStorage.Insert(model) == null)
            {
                return false;
            }
            return true;
        }

        public bool Delete(LabBidingModel model)
        {
            CheckModel(model, false);
            if (_labStorage.Delete(model) == null)
            {
                return false;
            }
            return true;
        }

        public LabViewModel? ReadElement(LabSearchModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            var element = _labStorage.GetElement(model);
            if (element == null)
            {
                return null;
            }
            return element;
        }

        public List<LabViewModel>? ReadList(LabSearchModel? model)
        {
            var list = model == null ? _labStorage.GetFullList() : _labStorage.GetFilteredList(model);
            if (list == null)
            {
                return null;
            }
            return list;
        }

        public bool Update(LabBidingModel model)
        {
            CheckModel(model);
            if (_labStorage.Update(model) == null)
            {
                return false;
            }
            return true;
        }

        private void CheckModel(LabBidingModel model, bool withParams = true)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            if (!withParams)
            {
                return;
            }
            if (string.IsNullOrEmpty(model.Theme))
            {
                throw new ArgumentNullException("Нет темы лабораторной", nameof(model.Theme));
            }
            if (string.IsNullOrEmpty(model.Task))
            {
                throw new ArgumentNullException("Нет задания лабораторной", nameof(model.Task));
            }
            if (string.IsNullOrEmpty(model.Difficulty))
            {
                throw new ArgumentNullException("Нет сложности лабораторной", nameof(model.Difficulty));
            }
        }
    }
}
