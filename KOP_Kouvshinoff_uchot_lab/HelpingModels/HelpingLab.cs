namespace KOP_Kouvshinoff_uchot_lab.HelpingModels
{
    public class HelpingLab
    {
        public int Id { get; set; } = -1;
        public string Theme { get; set; } = string.Empty;
        public string Task { get; set; } = string.Empty;
        public string Difficulty { get; set; } = string.Empty;
        public string AverageScore
        {
            get
            {
                return averageScore.HasValue ? averageScore.Value.ToString() : "null";
            }
            set
            {
                if (value.Equals("null"))
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
