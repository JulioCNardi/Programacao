using _240318_05.Models;
using _240318_5.Models;

Customer c1 = new Customer();

c1.CustomerId = 1;
c1.FirstName = "Jonas";
c1.LastName = "Broder";
c1.BirthDate = new DateTime();
c1.EmailAddress = "emailTeste@muitoBom.com";

Address address1 = new Address();
address1.AdressId = 1;
address1.ZipCode = "333-3333";
address1.Street = "Rua maneira";
address1.District = "Bairro";
address1.City = "Cidade";
address1.Number = 666;
address1.FederalState = "Santa Catarina";
address1.Country = "Brasil";

c1.Addresses.Add(address1);

Console.WriteLine($"Nome: {c1.FirstName} {c1.LastName}");
Console.WriteLine($"E-mail: {c1.EmailAddress}");

foreach(var ad in c1.Addresses)
{
    Console.WriteLine($"Rua: {ad.Street}");
    Console.WriteLine($"Bairro: {ad.District}");
    Console.WriteLine($"Numero: {ad.Number}");
    Console.WriteLine($"Cidade: {ad.City}");
    Console.WriteLine($"Estado: {ad.FederalState}");
    Console.WriteLine($"Pais: {ad.Country}");
}