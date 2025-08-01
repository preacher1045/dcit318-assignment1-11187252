namespace TicketPriceCalculator
{
    internal class TicketPriceCalculator
    {
        static void Main(string[] args)
        {  
            //Variable initialization
            int ticketPrice = 10;
            int disount = 7;
            int age;
            int discountAmount;

            
            while (true) 
            {
                //Error handling using try..catch block
                try
                {
                    Console.WriteLine("Please enter age: ");
                    string input = Console.ReadLine();

                    // Convert user input to integer
                    age = Convert.ToInt32(input);

                    //Check required age for dicount
                    if (age <= 12 || age >= 65)
                    {
                        discountAmount = ticketPrice - disount;
                        Console.WriteLine("Your discounted price is Ghc" + discountAmount);
                    }
                    else
                    {
                        Console.WriteLine("Your ticket price is Ghc " + ticketPrice);
                    }

                    break; // Break loop
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Age must be a number....");
                    Console.WriteLine(fe.Message);
                    continue; // Continue loop
                }
            }
        }
    }
}
