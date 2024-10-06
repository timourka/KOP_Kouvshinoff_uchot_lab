using System.ComponentModel.DataAnnotations;
using UchetLabContracts.BindingModels;
using UchetLabContracts.ViewModels;
using UchetLabDataModels.Models;

namespace UchetLabDatabaseImplement.Models
{
    internal class Lab : ILabModel
    {
        internal int Id { get; private set; }
        [Required]
        public string Theme { get; private set; } = string.Empty;
        [Required]
        public string Task { get; private set; } = string.Empty;
        [Required]
        public string Difficulty { get; private set; } = string.Empty;
        public double? AverageScore { get; private set; }

        internal static Lab? Create(LabBidingModel model)
        {
            return new Lab()
            {
                Id = model.Id,
                Theme = model.Theme,
                Task = model.Task,
                Difficulty = model.Difficulty,
                AverageScore = model.AverageScore,
            };
        }

        internal void Update(LabBidingModel model)
        {
            Theme = model.Theme;
            Task = model.Task;
            Difficulty = model.Difficulty;
            AverageScore = model.AverageScore;
        }
        internal LabViewModel GetViewModel => new()
        {
            Id = Id,
            Theme = Theme,
            Task = Task,
            Difficulty = Difficulty,
            AverageScore = AverageScore,
        };
    }
}
