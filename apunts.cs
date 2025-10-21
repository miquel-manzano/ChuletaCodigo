using System;

public class Program
{
    public static void Main()
    {
        // / -> cociente 6 / 2 -> 3
        // % -> resto 6 % 2 -> 0
        
        int r = 6;
        Console.WriteLine("valor r: " + r++);
        Console.WriteLine("valor r despues: " + r);

        int s = 2;
        Console.WriteLine("Valor de s: " + ++s);
        Console.WriteLine("Valor de s despues: " + s);

        int num = 4;
        num++; // num <- num + 1
        //->

        num = num / 5;
        num /= 5;

        num = num + 3;
        num += 3; // num = num + 3;

        bool isCorrect = (4 > 5 && 10 != 2);

        Console.WriteLine(3 > 5);
        Console.WriteLine((4 > 5 && 10 != 2) || (num <= 2));

        // Salida or pantalla
        Console.WriteLine("Hola!");
        Console.WriteLine($"Tu num {num} i el bool {isCorrect}");
        Console.WriteLine("Tu num {0} i bool {1}", num, isCorrect);
        Console.WriteLine("Tu num: " + num + "is bool: " + isCorrect);

        // Casting implicito
        char letter = 'A';
        int numASCII = letter;

        Console.WriteLine($"Valor decimal {numASCII} i letra {letter}");
        
        double valor = 10.00;
        int valorS = (int) valor;

        Console.WriteLine($"Valor double: {valor} - valor int {valorS}");

        int numerito = Convert.ToInt32(Console.ReadLine());

        int numerazo = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Dame un num");
        int luckyNumber;

        if(Int32.TryParse(Console.ReadLine(), out luckyNumber))
        {
            Console.WriteLine($"Tu num es: {luckyNumber}");
        }
        else
        {
            Console.WriteLine("Error");
        }
        
        int number = (4 > 5) ? 4 : 2;
        int numerio = ((4 > 5) ? (2 < 2) ? 2 : 1 : 4)

        if (4 > 5)
        {
            numerio = 2;
        }
        else
        {
            numerio = 1;
        }
        else
        {
            numerio = 4;
        }

        string pokemon = "Charizard";

        switch (pokemon)
        {
            case "Charizard":
                Console.WriteLine("Selecciona attaque: ");
                Console.WriteLine("1 - Lanzallamas");
                Console.WriteLine("2 - Placaje");
                attack = Console.ReadLine();
                switch(attack)
                {
                    case "1":
                        Console.WriteLine("Charizard lanza Lanzallamas");
                        break;
                    case "2":
                        Console.WriteLine("Charizard lanza Placaje");
                        break;
                }
                break;
            case "Bulbasaur":
                Console.WriteLine("Selecciona attaque: ");
                Console.WriteLine("1 - Latigo cepa");
                Console.WriteLine("2 - Placaje");
                attack = Console.ReadLine();
                switch(attack)
                {
                    case "1":
                        Console.WriteLine("Bulbasaur lanza Latigo cepa");
                        break;
                    case "2":
                        Console.WriteLine("Bulbasaur lanza Placaje");
                        break;
                }
                break;
            default:
                Console.WriteLine("No pokemon");
                break;
        }
    }
}