using KOP_Kouvshinoff_uchot_lab.HelpingModels;
using KOP_Labs;
using Non_visual_components_Kouvshinoff;
using PluginsConventionLibraryNet60;
using UchetLabBusinessLogic.BuinessLogic;
using UchetLabContracts.BindingModels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using UchetLabContracts.SearchModels;
using ComponentsLibraryNet60.DocumentWithTable;
using UchetLabContracts.BusinessLogicsContracts;
using CustomComponents.NonVisualComponents;

namespace KOP_Kouvshinoff_uchot_lab
{
    public class KouvshinoffUchotLabPlugin : IPluginsConvention
    {
        MainForm mainForm = new();
        public string PluginName => "KouvshinoffUchotLabPlugin";
        public UserControl GetControl => mainForm.customTree;

        public PluginsConventionElement GetElement => new() { Id = mainForm.customTree.GetSelectedNode<HelpingLab>().id } ;

        public bool CreateChartDocument(PluginsConventionSaveDocument saveDocument)
        {
            var labs = mainForm.labLogic.ReadList(new LabSearchModel());
            if (labs == null)
            {
                return false;
            }

            Dictionary<string, double> KDif = new();
            foreach (var lab in labs)
            {
                if (KDif.ContainsKey(lab.Difficulty))
                {
                    KDif[lab.Difficulty]++;
                }
                else
                {
                    KDif.Add(lab.Difficulty, 1);
                }
            }
            List<(double, string)> items = KDif.Select(x => (x.Value / labs.Count, x.Key)).ToList();

            mainForm.pdfPieChart.CreatePieChart(new CustomComponents.Helpers.DataForPieChart(
                saveDocument.FileName, "сколько сдаваемых лабораторных какой сложности", "сложности лабораторных",
                CustomComponents.Helpers.DiagramLegendEnum.Bottom, "legend", items));
            return true;
        }

        public bool CreateSimpleDocument(PluginsConventionSaveDocument saveDocument)
        {
            var labs = mainForm.labLogic.ReadList(new LabSearchModel());
            if (labs == null)
            {
                return false;
            }
            mainForm.customComponentExcelBigText.createExcel(saveDocument.FileName, "Excel по лабораторным, которые не сдавали студенты",
            labs.Where(x => !x.AverageScore.HasValue).Select(x => $"тема: {x.Theme}, задание: {x.Task}").ToArray());
            return true;
        }

        public bool CreateTableDocument(PluginsConventionSaveDocument saveDocument)
        {
            var labs = mainForm.labLogic.ReadList(new LabSearchModel());
            if (labs == null)
            {
                return false;
            }
            var headers = new List<(int ColumnIndex, int RowIndex, string Header, string PropertyName)>()
                    {
                            new(){ ColumnIndex = 0, RowIndex = 0, Header = "ID", PropertyName = "Id"},
                            new(){ ColumnIndex = 1, RowIndex = 0, Header = "тема лабораторной", PropertyName = "Theme"},
                            new(){ ColumnIndex = 2, RowIndex = 0, Header = "сложность работы", PropertyName = "Difficulty"},
                            new(){ ColumnIndex = 3, RowIndex = 0, Header = "средний балл сдававших", PropertyName = "AverageScore"},
                        };
            var columnsWidth = new List<(int Column, int Row)>();
            for (int i = 0; i < 4; i++)
            {
                columnsWidth.Add(new() { Column = 10, Row = 10 });
            }
            var config = new ComponentsLibraryNet60.Models.ComponentDocumentWithTableHeaderDataConfig<HelpingLab>()
            {
                FilePath = saveDocument.FileName,
                Header = "отчет в Word с информацией по всем лабораторным",
                UseUnion = false,
                Data = labs.Select(x => mainForm.toHelpingLab(x)).ToList(),
                ColumnsRowsDataCount = new() { Columns = 4, Rows = labs.Count },
                Headers = headers,
                ColumnsRowsWidth = columnsWidth,
                ColumnUnion = new List<(int StartIndex, int Count)>(),
            };
            mainForm.componentDocumentWithTableMultiHeaderWord.CreateDoc(config);
            return true;
        }

        public bool DeleteElement(PluginsConventionElement element)
        {
            if (element.Id == -1)
            {
                return false;
            }
            mainForm.labLogic.Delete(new LabBidingModel()
            {
                Id = element.Id,
            });
            mainForm.fillTree();
            return true;
        }

        public Form GetForm(PluginsConventionElement element)
        {
            return element.Id == -1 ? new LabForm() : new LabForm(element.Id);
        }

        public Form GetThesaurus()
        {
            return new DifficultiesForm();
        }

        public void ReloadData()
        {
            mainForm.fillTree();
        }
    }
}
