using semana10.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using semana10.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace semana10.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Operaciones : ContentPage
    {
        public Operaciones()
        {
            InitializeComponent();

            this.BindingContext = new ViewModels.OperacionesViewModel();
;
        }
    }
}