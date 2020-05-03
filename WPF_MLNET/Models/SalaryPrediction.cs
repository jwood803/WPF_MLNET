using Microsoft.ML.Data;

namespace WPF_MLNET_ImagePredictions
{
    public class SalaryPrediction
    {
        [ColumnName("Score")]
        public float PredictedSalary { get; set; }
    }
}