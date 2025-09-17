namespace Calculator
{

    internal class Program
    {

        public static int ValitseLaskutoimitus()
        {
            while (true)
            {
                Console.WriteLine("Valitse laskutoimitus (1: Yhteenlasku, 2: Vähennyslasku, 3: Kertolasku, 4: Jakolasku):");

                if (int.TryParse(Console.ReadLine()!, out int i))
                {
                    if (i > 0 && i < 5)
                        return i;
                    else
                        Console.WriteLine("Select valid operation.");

                }
                else
                {
                    Console.WriteLine("Please enter a positive integer.");
                }
            }
        }

        public static (int, int) KysyLuvut()
        {
            int first, second;

            while (true)
            {
                Console.Write("Syötä ensimmäinen luku: ");
                if (int.TryParse(Console.ReadLine(), out first))
                    break;
                else
                    Console.WriteLine("Please enter an integer.");
            }

            while (true)
            {
                Console.Write("Syötä toinen luku: ");
                if (int.TryParse(Console.ReadLine(), out second))
                    break;
                else
                    Console.WriteLine("Please enter an integer.");
            }

            return (first, second);
        }


        public static int Calculations(int x, int y, int operation)
        {
            int Addition(int x, int y)
            {
                return x + y;
            }

            int subsctraction(int x, int y)
            {
                return x - y;
            }

            int multiplication(int x, int y)
            {
                return x * y;
            }

            int division(int x, int y)
            {
                return x / y;
            }

            switch (operation)
            {
                case 1:
                    return Addition(x, y);
                case 2:
                    return subsctraction(x, y);
                case 3:
                    return multiplication(x, y);
                case 4:
                    return division(x, y);
                default:
                    return 0;
            }
        }

        public static void TulostaTulos(int x, int y, int result, int operation)
        {
            string op = operation == 1 ? "+" : operation == 2 ? "-" : operation == 3 ? "*" : operation == 4 ? "/" : null;
            Console.WriteLine($"Tulos: {x} {op} {y} = {result}");
        }

        static void Main(string[] args)
        {
            int operation = ValitseLaskutoimitus();
            (int x, int y) = KysyLuvut();
            int result = Calculations(x, y, operation);
            TulostaTulos(x, y, result, operation);
        }
    }
}