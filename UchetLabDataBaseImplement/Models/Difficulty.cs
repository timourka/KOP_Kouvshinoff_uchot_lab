using System.ComponentModel.DataAnnotations;
using UchetLabContracts.BindingModels;
using UchetLabContracts.ViewModels;
using UchetLabDataModels.Models;

namespace UchetLabDatabaseImplement.Models
{
    internal class Difficulty : IDifficultyModel
    {
        internal int Id { get; private set; }
        [Required]
        public string Text { get; private set; } = string.Empty;
        internal static Difficulty? Create(DifficultyBindigModel model)
        {
            return new Difficulty()
            {
                Id = model.Id,
                Text = model.Text,
            };
        }

        internal void Update(DifficultyBindigModel model)
        {
            Text = model.Text;
        }
        internal DifficultyViewModel GetViewModel => new()
        {
            Id = Id,
            Text = Text,
        };
    }
}
