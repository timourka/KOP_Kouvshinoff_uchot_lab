using UchetLabContracts.StoragesContracts;
using UchetLabDatabaseImplement.Implements;

namespace KOP_Kouvshinoff_uchot_lab
{
    internal static class SingletonDatabase
    {
        private static ILabStorage? _labStorage = null;
        public static ILabStorage LabStorage {
            get
            {
                if (_labStorage == null)
                    _labStorage = new LabStorage();
                return _labStorage;
            }
        }

        private static IDifficultyStorage? _difficultyStorage = null;
        public static IDifficultyStorage DifficultyStorage
        {
            get
            {
                if (_difficultyStorage == null)
                    _difficultyStorage= new DifficultyStorage();
                return _difficultyStorage;
            }
        }
    }
}
