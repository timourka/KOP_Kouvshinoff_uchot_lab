using KOP_Kouvshinoff_uchot_lab.HelpingModels;
using UchetLabBusinessLogic.BuinessLogic;
using UchetLabContracts.BindingModels;
using UchetLabContracts.BusinessLogicsContracts;

namespace KOP_Kouvshinoff_uchot_lab
{
    public partial class MainForm : Form
    {
        private ILabLogic _labLogic;
        private void fillTree()
        {
            var labs = _labLogic.ReadList(new());
            if (labs == null)
            {
                return;
            }
            customTree.Clear();
            foreach (var lab in labs)
            {
                HelpingLab helpingLab = new()
                {
                    Id = lab.Id.ToString(),
                    Theme = lab.Theme,
                    Task = lab.Task,
                    Difficulty = lab.Difficulty,
                    AverageScore = lab.AverageScore.HasValue ? lab.AverageScore.Value.ToString() : "null",
                };
                customTree.AddNode(helpingLab);
            }
        }
        public MainForm()
        {
            _labLogic = new LabLogic(SingletonDatabase.LabStorage);
            InitializeComponent();
            customTree.Hierarcy = new List<string>
            {
                 "Difficulty",
                 "AverageScore",
                 "Id",
                 "Theme"
            };
            fillTree();
        }
        private void CreateNewRecord()
        {
            LabForm labForm = new LabForm();
            labForm.ShowDialog();
            fillTree();
        }

        private void EditSelectedRecord()
        {
            HelpingLab helpingLab = customTree.GetSelectedNode<HelpingLab>();
            if (helpingLab.id == -1)
            {
                MessageBox.Show("пожалуйста выберите id", "нет id", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            LabForm labForm = new LabForm(helpingLab.id);
            labForm.ShowDialog();
            fillTree();
        }

        private void DeleteSelectedRecord()
        {
            HelpingLab helpingLab = customTree.GetSelectedNode<HelpingLab>();
            if (helpingLab.id == -1)
            {
                MessageBox.Show("пожалуйста выберите id", "нет id", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _labLogic.Delete(new LabBidingModel()
            {
                Id = helpingLab.id,
            });
            fillTree();
        }

        private void CreateSimpleDocument()
        {
        }

        private void CreateDocumentWithTable()
        {
        }

        private void CreateDocumentWithChart()
        {
        }

        private void добавлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewRecord();
        }

        private void редактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSelectedRecord();
        }

        private void удалениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedRecord();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fillTree();
        }

        private void справочникСложностейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DifficultiesForm difficultiesForm = new DifficultiesForm();
            difficultiesForm.ShowDialog();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        CreateNewRecord(); // Ctrl+A - создание новой записи
                        e.SuppressKeyPress = true; // предотвращаем дальнейшую обработку клавиш
                        break;

                    case Keys.U:
                        EditSelectedRecord(); // Ctrl+U - редактирование выбранной записи
                        e.SuppressKeyPress = true;
                        break;

                    case Keys.D:
                        DeleteSelectedRecord(); // Ctrl+D - удаление выбранной записи
                        e.SuppressKeyPress = true;
                        break;

                    case Keys.S:
                        CreateSimpleDocument(); // Ctrl+S - создание простого документа
                        e.SuppressKeyPress = true;
                        break;

                    case Keys.T:
                        CreateDocumentWithTable(); // Ctrl+T - создание документа с таблицей
                        e.SuppressKeyPress = true;
                        break;

                    case Keys.C:
                        CreateDocumentWithChart(); // Ctrl+C - создание документа с диаграммой
                        e.SuppressKeyPress = true;
                        break;
                }
            }
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateSimpleDocument();
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateDocumentWithTable();
        }

        private void pdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateDocumentWithChart();
        }
    }
}
