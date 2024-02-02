namespace mod2_les7_task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature: ");

            int temp = int.Parse(Console.ReadLine());

            if (temp < 0)
            {
                Console.WriteLine("Damn it's cold today");
            }
            else if (temp > 0 && temp <= 10)
            {
                Console.WriteLine("It's cold");
            }

            else if (temp > 10 && temp <= 20)
            {
                Console.WriteLine("It's coldly");
            }

            else if (temp > 20 && temp <= 30)
            {
                Console.WriteLine("Temperature just right ");
            }

            else if (temp > 30 && temp <= 40)
            {
                Console.WriteLine("It's starting be poorly becasue it's hot");
            }

            else if (temp >= 40)
            {
                Console.WriteLine("Come on ! i'm moving to Alaska !");
            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
}

