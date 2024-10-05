using UchetLabDataModels.Models;

namespace UchetLabContracts.ViewModels
{
    public class LabViewModel : ILabModel
    {
        public int Id { get; set; }
        public string Theme { get; set; } = string.Empty;
        public string Task { get; set; } = string.Empty;
        public string Dificulty { get; set; } = string.Empty;
        public double? AverageScore { get; set; }
    }
}
