
   Menu();

static void Menu()
{
    Console.Clear();

    Console.WriteLine("Escolha que tipo de calculo deseja fazer:");
    Console.WriteLine("0 - Soma");
    Console.WriteLine("1 - Subtração");
    Console.WriteLine("2 - Multiplicação");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Sair");
    Console.WriteLine("_________________________________________");
    Console.WriteLine("Digite o numero correspondente a opção desejada:");

    short resultado =  short.Parse(Console.ReadLine());


    switch (resultado)
    {
        case 0:
            Soma();
            break;
        case 1:
            Subtracao();
            break;
        case 2:
            Multiplicacao();
            break;
        case 3:
            Divisao();
            break;
        case 4:
            System.Environment.Exit(0);
            break;
        default:
            Menu();
            break;
    }
}




static void Soma()
{   
    Console.Clear();

    Console.WriteLine("Digite o primeiro numero: ");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo numero: ");
    float v2 = float.Parse(Console.ReadLine());
    Console.WriteLine($"O resultado da soma é: {v1 + v2}");
    Console.ReadKey();
    Menu();
}

static void Subtracao()
{
    Console.Clear();

    Console.WriteLine("Digite o primeiro numero: ");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo numero: ");
    float v2 = float.Parse(Console.ReadLine());
    Console.WriteLine($"O resultado da subtração é: {v1 - v2}");
    Console.ReadKey();
    Menu();
}

static void Multiplicacao()
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro numero: ");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo numero: ");
    float v2 = float.Parse(Console.ReadLine());
    Console.WriteLine($"O resultado da multiplicação é: {v1 * v2}");
    Console.ReadKey();
    Menu();
}

static void Divisao()
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro numero: ");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo numero: ");
    float v2 = float.Parse(Console.ReadLine());
    Console.WriteLine($"O resultado da divisão é: {v1 / v2}");
    Console.ReadKey();
    Menu();
}

