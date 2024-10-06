using UchetLabContracts.BindingModels;
using UchetLabContracts.SearchModels;
using UchetLabContracts.ViewModels;

namespace UchetLabContracts.BusinessLogicsContracts
{
    public interface IDifficultyLogic
    {
        List<DifficultyViewModel>? ReadList(DifficultySearchModel? model);
        DifficultyViewModel? ReadElement(DifficultySearchModel model);
        bool Create(DifficultyBindigModel model);
        bool Update(DifficultyBindigModel model);
        bool Delete(DifficultyBindigModel model);
    }
}
