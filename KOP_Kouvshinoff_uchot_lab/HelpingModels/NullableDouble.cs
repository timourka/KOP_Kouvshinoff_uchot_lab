namespace KOP_Kouvshinoff_uchot_lab.HelpingModels
{
    public class NullableDouble
    {
        public double Value { get; set; }
        public bool HasValue { get; set; } = false;

        public override string ToString()
        {
            return HasValue ? Value.ToString() : "null";
        }

        // Неявное приведение NullableDouble к строке
        public static implicit operator string(NullableDouble nullableDouble)
        {
            return nullableDouble.ToString();
        }
    }
}
