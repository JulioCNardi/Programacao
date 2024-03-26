using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240325_clinica.models
{
    public class Atendimento
    {
        public int ID {get; set;}
        public DateTime DataAtendimento {get; set;}
        public Animal Animal {get; set;}
        public Veterinario Veterinario {get; set;}
        public string Obseracao {get; set;}

    }
}