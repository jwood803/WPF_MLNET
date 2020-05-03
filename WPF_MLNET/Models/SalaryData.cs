using Microsoft.ML.Data;

namespace WPF_MLNET_ImagePredictions
{
    public class SalaryData
    {
        [LoadColumn(0)]
        public float YearsExperience;

        [LoadColumn(1)]
        public float Salary;
    }
}