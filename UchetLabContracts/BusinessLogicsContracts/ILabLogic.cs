using UchetLabContracts.BindingModels;
using UchetLabContracts.SearchModels;
using UchetLabContracts.ViewModels;

namespace UchetLabContracts.BusinessLogicsContracts
{
    public interface ILabLogic
    {
        List<LabViewModel>? ReadList(LabSearchModel? model);
        LabViewModel? ReadElement(LabSearchModel model);
        bool Create(LabBidingModel model);
        bool Update(LabBidingModel model);
        bool Delete(LabBidingModel model);
    }
}
