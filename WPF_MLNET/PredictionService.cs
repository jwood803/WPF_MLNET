using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MLNET_ImagePredictions
{
    public class PredictionService : IPredictionService
    {
        private readonly PredictionEngine<SalaryData, SalaryPrediction> _predictionEngine;

        public PredictionService()
        {
            var context = new MLContext();

            var model = context.Model.Load("./MLModel/salary-model.zip", out DataViewSchema inputSchema);

            _predictionEngine = context.Model.CreatePredictionEngine<SalaryData, SalaryPrediction>(model, inputSchema);
        }

        public SalaryPrediction Predict(float yearsOfExperience)
        {
            return _predictionEngine.Predict(new SalaryData
            {
                YearsExperience = yearsOfExperience
            });
        }
    }
}
