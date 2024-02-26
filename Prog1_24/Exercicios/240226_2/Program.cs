// Trabalhando com variaveis em C#

// Strings 
// Declarando variavel em inicialização
string message1 = "1";

// Inicializando variavel com nulo
string message2 = null;

// inicializando a string vazia

string message3 = System.String.Empty; // "";

// Declarar uma string com valor implicito

var message4 = "PASTEL";

Console.WriteLine(message4);

// Concatenando Strings
string concat = message1 + " " + message2 + " " + message3 + " " + message4;
Console.WriteLine("\n " + concat);