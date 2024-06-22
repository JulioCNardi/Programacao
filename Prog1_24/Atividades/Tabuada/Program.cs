// Lê o primeiro valor
Console.WriteLine("Determine o valor do primeiro numero");
double FirstValue = Convert.ToDouble(Console.ReadLine());


double result = 0;

bool aux = true;
do{
    Console.WriteLine("Selecione a operação");
    Console.WriteLine("1 - Adição");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("0 - Sair");

    int menu = 0;

    try
    {
        menu = Convert.ToInt32(Console.ReadLine());

        switch(menu)
        {
            case 1:
                for (int i = 1; i <= 9; i++) 
                {
                    result = FirstValue + i;
                    Console.WriteLine($"Tabuada de soma de {FirstValue} + {i} = {result}");
                }

            break;
            case 2:
                for (int i = 1; i <= 9; i++) 
                {
                    result = FirstValue - i;
                    Console.WriteLine($"Tabuada de soma de {FirstValue} - {i} = {result}");
                }
            break;
            case 3:
                for (int i = 1; i <= 9; i++) 
                {
                    result = FirstValue * i;
                    Console.WriteLine($"Tabuada de soma de {FirstValue} * {i} = {result}");
                }
            break;
            case 4:
                if (FirstValue != 0) 
                    for (int i = 1; i <= 104; i++) 
                    {
                        result = FirstValue / i;
                        Console.WriteLine($"Tabuada de soma de {FirstValue} / {i} = {result}");
                    }
                else Console.WriteLine("Selecionar valor diferente de 0.");
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