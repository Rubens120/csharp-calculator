using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Eenvoudige Rekenmachine");
            Console.Write("Voer het eerste getal in: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Voer een operator in (+, -, *, /): ");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Voer het tweede getal in: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultaat = 0;

            switch (op)
            {
                case '+':
                    resultaat = num1 + num2;
                    break;
                case '-':
                    resultaat = num1 - num2;
                    break;
                case '*':
                    resultaat = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        resultaat = num1 / num2;
                    else
                        Console.WriteLine("Fout: Delen door nul is niet toegestaan.");
                    break;
                default:
                    Console.WriteLine("Ongeldige operator.");
                    continue;
            }

            Console.WriteLine($"Resultaat: {resultaat}");
            Console.Write("Druk op een toets om opnieuw te berekenen, of 'q' om te stoppen...");
            if (Console.ReadKey().KeyChar == 'q')
                break;
        }
    }
}