using System;

// mein taschenrechner projekt - luca

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("SimpleCalc - by sw4gaccino");
        Console.WriteLine("------------------------");
        Console.WriteLine();

        bool laueft = true;

        while (laueft)
        {
            Console.WriteLine("Was willst du rechnen? (+, -, *, /, exit)");
            Console.Write("> ");
            string op = Console.ReadLine();

            if (op == "exit")
            {
                Console.WriteLine("tschuess");
                laueft = false;
                continue;
            }

            if (op != "+" && op != "-" && op != "*" && op != "/")
            {
                Console.WriteLine("das kenn ich nicht, versuchs nochmal");
                continue;
            }

            Console.Write("erste zahl: ");
            string eingabe1 = Console.ReadLine();
            double zahl1;
            bool ok1 = double.TryParse(eingabe1, out zahl1);
            if (!ok1)
            {
                Console.WriteLine("das ist keine zahl");
                continue;
            }

            Console.Write("zweite zahl: ");
            string eingabe2 = Console.ReadLine();
            double zahl2;
            bool ok2 = double.TryParse(eingabe2, out zahl2);
            if (!ok2)
            {
                Console.WriteLine("das ist keine zahl");
                continue;
            }

            double ergebnis = 0;
            bool fehler = false;

            if (op == "+")
                ergebnis = zahl1 + zahl2;
            else if (op == "-")
                ergebnis = zahl1 - zahl2;
            else if (op == "*")
                ergebnis = zahl1 * zahl2;
            else if (op == "/")
            {
                if (zahl2 == 0)
                {
                    Console.WriteLine("durch 0 teilen geht nicht");
                    fehler = true;
                }
                else
                    ergebnis = zahl1 / zahl2;
            }

            if (!fehler)
                Console.WriteLine(zahl1 + " " + op + " " + zahl2 + " = " + ergebnis);

            Console.WriteLine();
        }
    }
}
