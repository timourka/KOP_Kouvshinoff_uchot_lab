using System.Windows.Forms;
using UchetLabBusinessLogic.BuinessLogic;
using UchetLabContracts.BindingModels;
using UchetLabContracts.BusinessLogicsContracts;
using UchetLabContracts.SearchModels;

namespace KOP_Kouvshinoff_uchot_lab
{
    public partial class DifficultiesForm : Form
    {
        private IDifficultyLogic _difficultyLogic;

        public DifficultiesForm()
        {
            _difficultyLogic = new DifficultyLogic(SingletonDatabase.DifficultyStorage);
            InitializeComponent();
            loadData();
        }

        // Обработчик нажатий клавиш
        private void DataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                // Добавляем новую строку
                dataGridView.Rows.Add();
                dataGridView.CurrentCell = dataGridView.Rows[dataGridView.Rows.Count - 1].Cells["Difficulty"]; // Ставим фокус на новую строку
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Delete && dataGridView.SelectedRows.Count > 0)
            {
                // Подтверждение удаления
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?",
                                                      "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        foreach (DataGridViewRow row in dataGridView.SelectedRows)
                        {
                            if (!row.IsNewRow) // Не даём удалять последнюю "пустую" строку
                            {
                                // Получаем Id из столбца "Id"
                                int id = Convert.ToInt32(row.Cells["Id"].Value); // Приводим значение Id к типу int

                                // Удаляем запись через логику
                                _difficultyLogic.Delete(new DifficultyBindigModel()
                                {
                                    Id = id
                                });

                                // Удаляем строку из DataGridView
                                dataGridView.Rows.Remove(row);
                            }
                        }

                        // Сообщаем об успешном удалении
                        MessageBox.Show("Запись успешно удалена", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                    catch (Exception ex)
                    {
                        // Выводим сообщение об ошибке
                        MessageBox.Show($"Ошибка при удалении записи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                e.Handled = true;
            }
        }


        // Валидация данных в ячейке (запрет на сохранение пустых строк)
        private void DataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string? userInput = e.FormattedValue.ToString();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                MessageBox.Show("Нельзя сохранять пустую запись!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true; // Отменяем завершение редактирования, если строка пустая
            }
        }

        // Обработка окончания редактирования ячейки (сохранение)
        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Получаем текущую строку
                DataGridViewRow currentRow = dataGridView.Rows[e.RowIndex];

                // Проверяем, есть ли у строки ID (если его нет, считаем запись новой)
                if (currentRow.Cells["Id"].Value == null || Convert.ToInt32(currentRow.Cells["Id"].Value) == 0)
                {
                    // Создание новой записи
                    _difficultyLogic.Create(new DifficultyBindigModel()
                    {
                        Text = currentRow.Cells["Difficulty"].Value.ToString() // Достаём текст из строки
                    });
                }
                else
                {
                    // Обновление существующей записи
                    _difficultyLogic.Update(new DifficultyBindigModel()
                    {
                        Id = Convert.ToInt32(currentRow.Cells["Id"].Value), // Достаём Id для обновления
                        Text = currentRow.Cells["Difficulty"].Value.ToString() // Достаём текст из строки
                    });
                }
                // Сообщаем пользователю об успешном сохранении
                MessageBox.Show("Запись успешно сохранена", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Отложенный вызов функции загрузки данных
                this.BeginInvoke(new MethodInvoker(loadData));
            }
            catch (Exception ex)
            {
                // Выводим сообщение об ошибке
                MessageBox.Show($"Ошибка при сохранении записи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadData()
        {
            try
            {
                var difficulties = _difficultyLogic.ReadList(new DifficultySearchModel());
                if (difficulties == null)
                {
                    MessageBox.Show("не удалось загрузить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dataGridView.Rows.Clear();
                foreach (var difficulty in difficulties)
                {
                    dataGridView.Rows.Add();
                    dataGridView.Rows[dataGridView.Rows.Count - 1].Cells["Id"].Value = difficulty.Id;
                    dataGridView.Rows[dataGridView.Rows.Count - 1].Cells["Difficulty"].Value = difficulty.Text;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
