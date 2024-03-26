using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240325_clinica.models
{
    public class Animal
    {
        public int ID {get; set;}
        public string Breed {get; set;}
        public DateTime DataNascimento {get; set;}
        public string Nome {get; set;}
        public string NomeTutor {get; set;}
        public string FoneTutor {get; set;}
        public float Peso {get; set;}
        public float Altura {get; set;}


        public bool Validar() 
        {
            var isValid = true;
            // Caso o IF tenha apeanas uma instrução não existe a necessidade de chaves
            if ( string.IsNullOrWhiteSpace(Nome))
                isValid = false; 
            
            if ( string.IsNullOrWhiteSpace(NomeTutor))
                isValid = false;

            return isValid;
        }

    }

    
}