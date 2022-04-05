using PhilotesApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhilotesApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListagemView : ContentPage
    {
        private ListagemPetViewModel viewModel;
        public ListagemView()
        {
            InitializeComponent();
            viewModel = new ListagemPetViewModel();
            BindingContext = viewModel;
        }
    }
}