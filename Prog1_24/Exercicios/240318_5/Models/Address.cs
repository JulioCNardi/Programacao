using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240318_5.Models
{
    public class Address
    {   
        public int AdressId {get; set;}
        public string Street  {get; set;}
        public string District {get; set;}
        public int Number {get; set;}
        public string City {get; set;}
        public string FederalState {get; set;}
        public string Country {get; set;}
        public string ZipCode {get; set;}

        public AddressType AddressType {get; set;}
 
    }

    public enum AddressType
    {
        Commercial,
        Residential
    }
}