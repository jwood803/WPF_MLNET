using Caliburn.Micro;
using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using WPF_MLNET_ImagePredictions.ViewModels;

namespace WPF_MLNET_ImagePredictions
{
    public class Bootstrapper : BootstrapperBase
    {
        private SimpleContainer _container = new SimpleContainer();

        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<StartupViewModel>();
        }
        
        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }

        protected override void Configure()
        {
            _container.Singleton<IWindowManager, WindowManager>();
            _container.Singleton<IEventAggregator, EventAggregator>();
            _container.Singleton<IPredictionService, PredictionService>();

            _container.RegisterPerRequest(typeof(StartupViewModel), null, typeof(StartupViewModel));
        }
    }
}
