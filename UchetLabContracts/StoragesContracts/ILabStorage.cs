using UchetLabContracts.BindingModels;
using UchetLabContracts.SearchModels;
using UchetLabContracts.ViewModels;

namespace UchetLabContracts.StoragesContracts
{
    public interface ILabStorage
    {
        List<LabViewModel> GetFullList();
        List<LabViewModel> GetFilteredList(LabSearchModel model);
        LabViewModel? GetElement(LabSearchModel model);
        LabViewModel? Insert(LabBidingModel model);
        LabViewModel? Update(LabBidingModel model);
        LabViewModel? Delete(LabBidingModel model);
    }
}
