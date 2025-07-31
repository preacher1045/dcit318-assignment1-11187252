namespace TicketPriceCalculator
{
    internal class TicketPriceCalculator
    {
        static void Main(string[] args)
        {
            int ticketPrice = 10;
            int disount = 7;
            int age;
            int discountAmount;

            try
            {
                while (true)
                {
                    Console.WriteLine("Please enter age: ");
                    string input = Console.ReadLine();

                    age = Convert.ToInt32(input);

                    if (age <= 12 || age >= 65)
                    {
                        discountAmount = ticketPrice - disount;
                        Console.WriteLine("Your discounted price is Ghc" + discountAmount);
                    }
                    else
                    {
                        Console.WriteLine("Your ticket price is Ghc " + ticketPrice);
                    }

                    break;
                }



            }
            catch (FormatException fe)
            {
                Console.WriteLine("Age must be a number.....");
                Console.WriteLine(fe.Message);
            }
        }
    }
}
