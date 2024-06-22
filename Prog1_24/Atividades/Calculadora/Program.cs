// Lê o primeiro valor
Console.WriteLine("Determine o valor do primeiro numero");
double FirstValue = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Determine o valor do primeiro numero");
double SecondValue = Convert.ToDouble(Console.ReadLine());

double result = 0;

bool aux = true;
do{
    Console.WriteLine("Selecione a operação");
    Console.WriteLine("1 - Adição");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Potênciação");
    Console.WriteLine("0 - Sair");

    int menu = 0;

    try
    {
        menu = Convert.ToInt32(Console.ReadLine());

        switch(menu)
        {
            case 1:
                result  = FirstValue + SecondValue;
                Console.WriteLine($"O resultado é igual a {result}");

            break;
            case 2:
                result  = FirstValue - SecondValue;
                Console.WriteLine($"O resultado é igual a {result}");
            break;
            case 3:
                result  = FirstValue * SecondValue;
                Console.WriteLine($"O resultado é igual a {result}");
            break;
            case 4:
                result  = FirstValue / SecondValue;
                if (SecondValue != 0) 
                    	Console.WriteLine($"O resultado é igual a {result}");
                else Console.WriteLine("Selecionar valor diferente de 0.");
            break;
            case 5:
                result = Math.Pow(FirstValue, SecondValue);
                Console.WriteLine($"O resultado é igual a {result}");
            break;
            case 0:

                aux = false;
            break;

            default:
                                        
            break;
        }
    }
    catch
    {
        Console.WriteLine("Opção inválida.");
        menu = -1;
        aux = true;
    }

}while(aux);
