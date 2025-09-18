namespace FunctionAssigmentV1
{
    internal class Program
    {


        public static T AskForSomething<T>(string prompt)
        {
            object input;

            while (true)
            {
                Console.Write(prompt);
                input = Console.ReadLine()!;

                if (typeof(T) == typeof(string) && !int.TryParse(input?.ToString(), out int _))
                {
                    if (!string.IsNullOrWhiteSpace(input?.ToString()))
                        return (T)(object)(input?.ToString() ?? string.Empty);
                    else
                        Console.WriteLine("Input cannot be empty.");
                }

                if (typeof(T) == typeof(int) && int.TryParse(input?.ToString(), out int i))
                    return (T)(object)i;
                else
                    Console.WriteLine("Please enter a positive integer.");
            }
        }

        static void TulostaNimiJaIka(string name, int age)
        {
            Console.WriteLine($"Your name is {name} and your age is {age}.");
        }

        static bool TarkistaTaysiIkainen(int age)
        {
            return age >= 18;
        }

        static void VertaaNimea(string name, string compareTo)
        {
            if (name.Equals(compareTo, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine($"Your name matches '{compareTo}' (case-insensitive).");
            if (name.Equals(compareTo))
                Console.WriteLine("Your name is exactly 'Matti' (case-sensitive).");
        }

        static void Main(string[] args)
        {
            string name = AskForSomething<string>("Enter your name: ");
            int age = AskForSomething<int>("Enter your age: ");

            TulostaNimiJaIka(name, age);

            // Check if the user is an adult
            if (TarkistaTaysiIkainen(age))
                Console.WriteLine("You are an adult.");
            else
                Console.WriteLine("You are not an adult.");

            VertaaNimea(name, "Matti");
        }
    }
}