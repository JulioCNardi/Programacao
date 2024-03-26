using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240325_clinica.models
{
    public class Clinica
    {
        public int ID {get; set;}
        public string Nome {get; set;}

        public static int InstanceCount {get; set;}
        public int ObjectCount {get; set;}
        public List<Atendimento> Atendimentos {get; set;}
    }
}