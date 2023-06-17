using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorMVVM.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculatorMVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculatorDemo : ContentPage
    {
        public CalculatorDemo()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.CalculatorDemoViewModel();
        }
    }
}