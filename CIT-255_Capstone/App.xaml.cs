using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using CIT_255_Capstone.BusinessLayer;
using CIT_255_Capstone.PresentationLayer.ViewModel;
using CIT_255_Capstone.PresentationLayer.Views;



namespace CIT_255_Capstone
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            SkateboardBusiness sbBusiness = new SkateboardBusiness();

            SkateboardViewModel skateboardViewModel = new SkateboardViewModel(sbBusiness);

            SkateboardView skateboardView = new SkateboardView();
            skateboardView.Show();
       
        }
    }
}
