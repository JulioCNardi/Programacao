// See https://aka.ms/new-console-template for more information


// Variaveis:

int opcao;

String nome;
String email;
String nascimento;
String genero;
// Endereço (⌐■_■)
String pais;
String estado;
String cidade;
String bairro;
String rua;
String numero;
String cep;

// Recebimento de Valores

Console.WriteLine("Informe seu nome");
nome = Console.ReadLine();

Console.WriteLine("Informe seu e-mail");
email = Console.ReadLine();

Console.WriteLine("Informe sua data de nascimento");
nascimento = Console.ReadLine();

Console.WriteLine("Informe seu genero");
genero = Console.ReadLine();

Console.WriteLine("Informe seu pais de origem");
pais = Console.ReadLine();

Console.WriteLine("Informe seu estado de origem");
estado = Console.ReadLine();

Console.WriteLine("Informe sua cidade de origem");
cidade = Console.ReadLine();

Console.WriteLine("Informe sua rua");
rua = Console.ReadLine();

Console.WriteLine("Informe o numero da sua casa");
numero = Console.ReadLine();

Console.WriteLine("Informe seu cep");
cep = Console.ReadLine();


// Escreve o formulario (～￣▽￣)～

Console.WriteLine(
    "--------------------------------\n" +
    "---- Formulario De Cadastro ----\n" +
    $"---- Nome: {nome}\n" +
    $"---- Email: {email}\n" +
    $"---- Nascimento: {nascimento}\n" +
    $"---- Genero: {genero}\n" +
    "----        Endereco        ----\n" +
    $"---- Pais: {pais}\n" +
    $"---- Estado: {estado}\n" +
    $"---- Cidade: {cidade}\n" +
    $"---- Rua: {rua}\n" +
    $"---- Numero: {numero}\n" +
    $"---- CEP: {cep}\n" +
    "--------------------------------");


