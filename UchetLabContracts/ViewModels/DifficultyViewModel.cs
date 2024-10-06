using UchetLabDataModels.Models;

namespace UchetLabContracts.ViewModels
{
    public class DifficultyViewModel : IDifficultyModel
    {
        public int Id { get; set; }
        public string Text {  get; set; } = string.Empty;
    }
}
