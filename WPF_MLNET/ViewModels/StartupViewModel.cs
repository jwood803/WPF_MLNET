using Caliburn.Micro;
using Microsoft.ML;

namespace WPF_MLNET_ImagePredictions.ViewModels
{
    public class StartupViewModel : Screen
    {
		private readonly IPredictionService _predictionService;

		private string _yearsOfExperience;
		private string _result;

		public StartupViewModel(IPredictionService predictionService)
		{
			_predictionService = predictionService;
		}

		public string YearsOfExperience
		{
			get { return _yearsOfExperience; }
			set 
			{ 
				_yearsOfExperience = value;
			}
		}

		public string Result
		{
			get { return _result; }
			set 
			{ 
				_result = value;
				NotifyOfPropertyChange(() => this.Result);
			}
		}

		public void Predict()
		{
			var prediction = _predictionService.Predict(float.Parse(this.YearsOfExperience));

			this.Result = $"Predicted salary is {prediction.PredictedSalary.ToString("c")}";
		}
	}
}
