using UchetLabDataModels.Models;

namespace UchetLabContracts.BindingModels
{
    public class LabBidingModel : ILabModel
    {
        public int Id { get; set; }
        public string Theme { get; set; } = string.Empty;

        public string Task { get; set; } = string.Empty;

        public string Difficulty { get; set; } = string.Empty;
        public double? AverageScore { get; set; }
    }
}
