namespace UchetLabDataModels.Models
{
    public interface ILabModel
    {
        public string Theme { get; }
        public string Task { get; }
        public string Difficulty { get; }
        public double? AverageScore { get; }
    }
}
