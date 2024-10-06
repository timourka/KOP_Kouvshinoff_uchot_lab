using UchetLabBusinessLogic.BuinessLogic;
using UchetLabContracts.BusinessLogicsContracts;

namespace KOP_Kouvshinoff_uchot_lab
{
    public partial class MainForm : Form
    {
        private ILabLogic _labLogic;
        public MainForm()
        {
            _labLogic = new LabLogic(SingletonDatabase.LabStorage);
            InitializeComponent();
            customTree.ContextMenuStrip = contextMenuStrip;
            customTree.Hierarcy = new List<string>
            {
                 "Difficulty",
                 "AverageScore",
                 "Id",
                 "Theme"
            };
            fillTree();
        }

        private void добавлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LabForm labForm = new LabForm();
            labForm.ShowDialog();
        }

        private void редактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO получение айдишника
            LabForm labForm = new LabForm();
            labForm.ShowDialog();
        }

        private void удалениеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fillTree()
        {
            var labs = _labLogic.ReadList(new());
            if (labs == null)
            {
                return;
            }
            foreach (var lab in labs)
            {
                customTree.AddNode(lab);
            }
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fillTree();
        }

        private void справочникСложностейToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
