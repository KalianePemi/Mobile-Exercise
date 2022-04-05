using System;
using System.Collections.Generic;
using System.Text;

namespace PhilotesApp.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Raca { get; set; }
        public int Cor { get; set; }
        public int Porte { get; set; }
        public int Sexo { get; set; }
        public string Descricao { get; set; }
        public string FotoURL { get; set; }

    }
}