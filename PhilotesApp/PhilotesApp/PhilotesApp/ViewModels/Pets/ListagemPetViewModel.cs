using PhilotesApp.Models;
using PhilotesApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PhilotesApp.ViewModels
{
    public class ListagemPetViewModel : BaseViewModel
    {
        private PetService pService;
        public ObservableCollection<Pet> Pets { get; set; }

        //ctor + TAB + TAB: atalho para criar o construtor
        public ListagemPetViewModel()
        {
            pService = new PetService();
            Pets = new ObservableCollection<Pet>();
            _ = ListarPets();
        }

        public async Task ListarPets()
        {
            try
            {
                Pets = await pService.GetPetsAsync();
                OnPropertyChanged(nameof(Pets));
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Informação", ex.Message + " Detalhes: " + ex.InnerException, "Ok");
            }
        }

    }
}
