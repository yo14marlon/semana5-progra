
bool repetir = true;
Console.BackgroundColor = ConsoleColor.DarkBlue;

while (repetir)
{
    Console.WriteLine("\nIngresa el primer Valor: ");
    int num1 = Int32.Parse(Console.ReadLine());

    Console.WriteLine("\nIngresa el segundo Valor: ");
    int num2 = Int32.Parse(Console.ReadLine());


    Console.WriteLine("\nEstos son los numeros pares que hay dentro de los dos valores que ingresaste: ");

    //Esto comprueba que variable es
    if (num1 < num2)
    {
        for (int i = num1; i <= num2; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("\n" + i);
            }
        }
    }
    else if (num2 < num1)
    {
        for (int i = num2; i <= num1; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("\n" + i);

            }
        }
    }
    Console.WriteLine("\nEnter...");
    Console.ReadLine();

    string salir = null;
    while(salir != "Q".ToLower() && salir != "S".ToLower())
    {
        Console.WriteLine("\nPreciona Q para salir, Preciona S para repetir todo.... ");
        salir = Console.ReadLine();
    }

    if (salir == "Q".ToLower())
    {
        repetir = false;
    }
    else
    {
        Console.Clear();
        
    }
    
}
Console.WriteLine("Fin del programa :) ");


