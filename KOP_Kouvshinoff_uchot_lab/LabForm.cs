using UchetLabBusinessLogic.BuinessLogic;
using UchetLabContracts.BindingModels;
using UchetLabContracts.BusinessLogicsContracts;
using UchetLabContracts.SearchModels;
using UchetLabContracts.ViewModels;

namespace KOP_Kouvshinoff_uchot_lab
{
    public partial class LabForm : Form
    {
        private IDifficultyLogic _difficultyLogic;
        private ILabLogic _labLogic;
        private int? Id;
        private bool cancelWithoutQueschions = false;

        private string? themeField;
        private string? taskField;
        private string? difField;
        private double? scrField;

        private void LoadDifficulties()
        {
            var difficulties = _difficultyLogic.ReadList(new());
            if (difficulties == null)
            {
                MessageBox.Show("не загрузились данные");
                this.Close();
                return;
            }
            customComboBoxDifficulty.clearList();
            foreach (var difficulty in difficulties)
            {
                customComboBoxDifficulty.addString(difficulty.Text);
            }
        }

        /// <summary>
        /// форма редактирования лабы
        /// </summary>
        /// <param name="id"> указываем айдишник лабы</param>
        public LabForm(int id)
        {
            _difficultyLogic = new DifficultyLogic(SingletonDatabase.DifficultyStorage);
            _labLogic = new LabLogic(SingletonDatabase.LabStorage);
            Id = id;

            InitializeComponent();

            LoadDifficulties();
            LabViewModel? labViewModel = _labLogic.ReadElement(new LabSearchModel() { Id = Id });
            if (labViewModel == null)
            {
                MessageBox.Show("Данные не загрузились", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            textBoxTheme.Text = labViewModel.Theme;
            textBoxTask.Text = labViewModel.Task;
            customComboBoxDifficulty.selectedString = labViewModel.Difficulty;
            controlInputNullableDoubleAverageScore.Value = labViewModel.AverageScore;
            this.Text = "редактирование лабы";

            memFields();
        }

        /// <summary>
        /// форма создания лабы
        /// </summary>
        public LabForm()
        {
            _difficultyLogic = new DifficultyLogic(SingletonDatabase.DifficultyStorage);
            _labLogic = new LabLogic(SingletonDatabase.LabStorage);

            InitializeComponent();

            LoadDifficulties();
            buttonSave.Text = "закрыть с созданием";
            buttonCancel.Text = "закрыть без создания";
            this.Text = "создание лабы";

            memFields();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveObject();
            this.Close();
        }
        private void SaveObject()
        {
            cancelWithoutQueschions = true;
            try
            {
                if (Id.HasValue)
                {
                    if (!_labLogic.Update(new LabBidingModel()
                    {
                        Id = Id.Value,
                        Theme = textBoxTheme.Text,
                        Task = textBoxTask.Text,
                        Difficulty = customComboBoxDifficulty.selectedString,
                        AverageScore = controlInputNullableDoubleAverageScore.Value
                    }))
                    {
                        MessageBox.Show("Данные не сохранены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!_labLogic.Create(new LabBidingModel()
                    {
                        Theme = textBoxTheme.Text,
                        Task = textBoxTask.Text,
                        Difficulty = customComboBoxDifficulty.selectedString,
                        AverageScore = controlInputNullableDoubleAverageScore.Value
                    }))
                    {
                        MessageBox.Show("Данные не сохранены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                MessageBox.Show("Данные успешно сохранены.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void memFields()
        {
            themeField = textBoxTheme.Text;
            taskField = textBoxTask.Text;
            difField = customComboBoxDifficulty.selectedString;
            scrField = controlInputNullableDoubleAverageScore.Value;
        }

        private bool isAnyChanges()
        {
            return themeField != textBoxTheme.Text ||
                taskField != textBoxTask.Text ||
                difField != customComboBoxDifficulty.selectedString ||
                scrField != controlInputNullableDoubleAverageScore.Value;
        }

        private void LabForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cancelWithoutQueschions)
                return;
            if (!isAnyChanges())
                return;

            // Показываем диалог с вопросом "Сохранить изменения?"
            DialogResult result = MessageBox.Show(Id.HasValue ? "Сохранить изменения перед закрытием?" : "Создать лабу перед закрытием",
                "Закрытие формы", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    // Если пользователь выбрал "Да", сохраняем изменения и закрываем форму
                    SaveObject();
                    break;

                case DialogResult.No:
                    // Если пользователь выбрал "Нет", просто закрываем форму, ничего не сохраняя
                    break;

                case DialogResult.Cancel:
                    // Если пользователь выбрал "Отмена", отменяем закрытие формы
                    e.Cancel = true; // Это предотвращает закрытие формы
                    break;
            }
        }
    }
}
