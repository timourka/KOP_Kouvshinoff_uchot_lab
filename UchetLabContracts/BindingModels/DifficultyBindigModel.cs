using UchetLabDataModels.Models;

namespace UchetLabContracts.BindingModels
{
    public class DifficultyBindigModel : IDifficultyModel
    {
        public int Id { get; set; }
        public string Text { get; set; } = string.Empty;
    }
}
