using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MLNET_ImagePredictions
{
    public interface IPredictionService
    {
        SalaryPrediction Predict(float yearsOfExperience);
    }
}
