namespace KOP_Kouvshinoff_uchot_lab.HelpingModels
{
    public class HelpingLab
    {
        public int id { get; set; } = -1;
        public string Id
        {
            get
            {
                return id.ToString();
            }
            set
            {
                if (int.TryParse(value, out int parsedValue))
                {
                    id = parsedValue;
                }
                else
                {
                    throw new ArgumentException("Invalid value for Id");
                }
            }
        }
        public string Theme { get; set; } = string.Empty;
        public string Task { get; set; } = string.Empty;
        public string Difficulty { get; set; } = string.Empty;
        public string AverageScore
        {
            get
            {
                return averageScore.HasValue ? averageScore.Value.ToString() : "не сдавали";
            }
            set
            {
                if (value.Equals("не сдавали"))
                {
                    averageScore = null;
                }
                else
                {
                    if (double.TryParse(value, out double parsedValue))
                    {
                        averageScore = parsedValue;
                    }
                    else
                    {
                        throw new ArgumentException("Invalid value for AverageScore");
                    }
                }
            }
        }

        public double? averageScore;
    }
}
