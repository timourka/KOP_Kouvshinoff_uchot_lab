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
            throw new NotImplementedException();
        }

        public LabViewModel? ReadElement(LabSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<LabViewModel>? ReadList(LabSearchModel? model)
        {
            throw new NotImplementedException();
        }

        public bool Update(LabBidingModel model)
        {
            throw new NotImplementedException();
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
            if (string.IsNullOrEmpty(model.Dificulty))
            {
                throw new ArgumentNullException("Нет сложности лабораторной", nameof(model.Dificulty));
            }
        }
    }
}
