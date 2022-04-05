using PhilotesApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace PhilotesApp.Services
{
    public class PetService : Request
    {
        private readonly Request _request;

        public PetService()
        {
            _request = new Request();
        }

        public async Task<ObservableCollection<Pet>> GetPetsAsync()
        {
            ObservableCollection<Pet> listaPets = await
            _request.GetAsync<ObservableCollection<Pet>>("http://DB-DS-PHILOTESAPP.somee.com/api/Pet/GetAll", "");
            return listaPets;
        }
    }
}
