using UchetLabBusinessLogic.BuinessLogic;
using UchetLabContracts.BusinessLogicsContracts;

namespace KOP_Kouvshinoff_uchot_lab
{
    public partial class LabForm : Form
    {
        private IDifficultyLogic _difficultyLogic;
        public LabForm()
        {
            _difficultyLogic = new DifficultyLogic(SingletonDatabase.DifficultyStorage);
            InitializeComponent();
        }
    }
}
