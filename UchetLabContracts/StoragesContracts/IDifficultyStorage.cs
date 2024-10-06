using UchetLabContracts.BindingModels;
using UchetLabContracts.SearchModels;
using UchetLabContracts.ViewModels;

namespace UchetLabContracts.StoragesContracts
{
    public interface IDifficultyStorage
    {
        List<DifficultyViewModel> GetFullList();
        List<DifficultyViewModel> GetFilteredList(DifficultySearchModel model);
        DifficultyViewModel? GetElement(DifficultySearchModel model);
        DifficultyViewModel? Insert(DifficultyBindigModel model);
        DifficultyViewModel? Update(DifficultyBindigModel model);
        DifficultyViewModel? Delete(DifficultyBindigModel model);
    }
}
