using System.ComponentModel.DataAnnotations;
using UchetLabContracts.BindingModels;
using UchetLabContracts.ViewModels;
using UchetLabDataModels.Models;

namespace UchetLabDatabaseImplement.Models
{
    public class Lab : ILabModel
    {
        public int Id { get; private set; }
        [Required]
        public string Theme { get; private set; } = string.Empty;
        [Required]
        public string Task { get; private set; } = string.Empty;
        [Required]
        public string Dificulty { get; private set; } = string.Empty;
        public double? AverageScore { get; private set; }

        public static Lab? Create(LabBidingModel model)
        {
            return new Lab()
            {
                Id = model.Id,
                Theme = model.Theme,
                Task = model.Task,
                Dificulty = model.Dificulty,
                AverageScore = model.AverageScore,
            };
        }

        public void Update(LabBidingModel model)
        {
            Theme = model.Theme;
            Task = model.Task;
            Dificulty = model.Dificulty;
            AverageScore = model.AverageScore;
        }
        public LabViewModel GetViewModel => new()
        {
            Id = Id,
            Theme = Theme,
            Task = Task,
            Dificulty = Dificulty,
            AverageScore = AverageScore,
        };
    }
}
