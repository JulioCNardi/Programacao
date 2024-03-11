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

/// Substituindo conteudo da string 👍👍

string nomeCompleto = "Julio Cesar Nardi";
nomeCompleto = nomeCompleto.Replace("Nardi", "Pastel");
Console.WriteLine(nomeCompleto);

// Comparação de Strings `(*>﹏<*)′

bool isNomeEqual = (nomeCompleto == "Julio Cesar Nardi");

Console.WriteLine(isNomeEqual);

bool isNomeEqual2 = string.Equals(nomeCompleto, "Julio Cesar Pastel");

Console.WriteLine(isNomeEqual2);

// ヾ(•ω•`)o TIPOS NUMERICOS ヾ(•ω•`)o
/*
    sbyte - armazena entre -128 a 127
    short  -32,768 a 32,767
    int - -2.147,483,648 a 2.147,483,647 (°ー°〃)
    long - -9.233.372.036.854.775.808 a 9.233.372.036.854.775.807
*/

float Myfloat = 10f;
double myDouble = 5f;
decimal myDecimal = 7m;
int myInteger = 0;


// Alteração para branch