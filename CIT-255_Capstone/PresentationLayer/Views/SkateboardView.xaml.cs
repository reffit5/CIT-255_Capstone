using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CIT_255_Capstone.PresentationLayer.ViewModel;

namespace CIT_255_Capstone.PresentationLayer.Views
{
    /// <summary>
    /// Interaction logic for SkateboardView.xaml
    /// </summary>
    public partial class SkateboardView : Window
    {
        public SkateboardView()
        {
            InitializeComponent();
        }

        private void ListBox_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}
