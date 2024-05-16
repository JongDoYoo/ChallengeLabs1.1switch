namespace ChallengeLabs1._1switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                do
                {
                    Console.WriteLine("Enter fahrenheit: ");
                    double temp = Convert.ToDouble(Console.ReadLine());
                    switch (temp)
                    {
                        case < 10:
                            Console.WriteLine("Freezing weather");
                            Console.WriteLine();
                            break;
                        case >= 10 and <= 20:
                            Console.WriteLine("Very Cold weather");
                            Console.WriteLine();
                            break;
                        case >= 20 and <= 35:
                            Console.WriteLine("Cold weather");
                            Console.WriteLine();
                            break;
                        case >= 36 and <= 50:
                            Console.WriteLine("Normal in weather");
                            Console.WriteLine();
                            break;
                        case >= 51 and <= 65:
                            Console.WriteLine("Its hot");
                            Console.WriteLine();
                            break;
                        case >= 66 and <=80:
                            Console.WriteLine("Its very hot");
                            Console.WriteLine();
                            break;
                    }
                }
                while (true);
            }
            catch (Exception e)
            {
                Console.WriteLine("There was a error somewhere");
                Console.WriteLine(e.ToString());
                Console.WriteLine("End of program");
            }
        }
    }
}
