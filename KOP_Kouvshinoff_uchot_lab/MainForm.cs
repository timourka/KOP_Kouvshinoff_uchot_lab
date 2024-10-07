using DocumentFormat.OpenXml.Wordprocessing;
using KOP_Kouvshinoff_uchot_lab.HelpingModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;
using Non_visual_components_Kouvshinoff;
using UchetLabBusinessLogic.BuinessLogic;
using UchetLabContracts.BindingModels;
using UchetLabContracts.BusinessLogicsContracts;
using UchetLabContracts.SearchModels;
using UchetLabContracts.ViewModels;

namespace KOP_Kouvshinoff_uchot_lab
{
    public partial class MainForm : Form
    {
        private ILabLogic _labLogic;
        private HelpingLab toHelpingLab(LabViewModel labViewModel)
        {
            return new HelpingLab()
            {
                Id = labViewModel.Id.ToString(),
                Theme = labViewModel.Theme,
                Task = labViewModel.Task,
                Difficulty = labViewModel.Difficulty,
                AverageScore = labViewModel.AverageScore.HasValue ? labViewModel.AverageScore.Value.ToString() : "не сдавали",
            };
        }
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
                customTree.AddNode(toHelpingLab(lab));
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
            using var dialog = new SaveFileDialog { Filter = "xlsx|*.xlsx" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var labs = _labLogic.ReadList(new LabSearchModel());
                    if (labs == null)
                    {
                        MessageBox.Show("не удалось считать данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    customComponentExcelBigText.createExcel(dialog.FileName, "Excel по лабораторным, которые не сдавали студенты",
                    labs.Where(x => !x.AverageScore.HasValue).Select(x => $"тема: {x.Theme}, задание: {x.Task}").ToArray());

                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CreateDocumentWithTable()
        {
            using var dialog = new SaveFileDialog { Filter = "doc|*.docx" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var labs = _labLogic.ReadList(new LabSearchModel());
                    if (labs == null)
                    {
                        MessageBox.Show("не удалось считать данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var headers = new List<(int ColumnIndex, int RowIndex, string Header, string PropertyName)>()
                    {
                            new(){ ColumnIndex = 0, RowIndex = 0, Header = "ID", PropertyName = "Id"},
                            new(){ ColumnIndex = 1, RowIndex = 0, Header = "тема лабораторной", PropertyName = "Theme"},
                            new(){ ColumnIndex = 2, RowIndex = 0, Header = "сложность работы", PropertyName = "Difficulty"},
                            new(){ ColumnIndex = 3, RowIndex = 0, Header = "средний балл сдававших", PropertyName = "AverageScore"},
                        };
                    var columnsWidth = new List<(int Column, int Row)>();
                    for ( int i = 0; i < 4; i++ )
                    {
                        columnsWidth.Add(new() { Column = 10, Row = 10 });
                    }
                    var config = new ComponentsLibraryNet60.Models.ComponentDocumentWithTableHeaderDataConfig<HelpingLab>()
                    {
                        FilePath = dialog.FileName,
                        Header = "отчет в Word с информацией по всем лабораторным",
                        UseUnion = false,
                        Data = labs.Select(x => toHelpingLab(x)).ToList(),
                        ColumnsRowsDataCount = new() { Columns = 4, Rows = labs.Count },
                        Headers = headers,
                        ColumnsRowsWidth = columnsWidth,
                        ColumnUnion = new List<(int StartIndex, int Count)>(),
                    };
                    componentDocumentWithTableMultiHeaderWord.CreateDoc(config);

                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
