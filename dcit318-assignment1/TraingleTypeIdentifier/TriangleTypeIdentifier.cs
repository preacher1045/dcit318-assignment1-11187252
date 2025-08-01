namespace TraingleTypeIdentifier
{
    internal class TriangleTypeIdentifier
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Error handling using try..catch block
                try
                {
                    //Input request for  length 1
                    Console.Write("Please enter a value for Lenght 1:  ");
                    String input1 = Console.ReadLine();
                    int len1 = Convert.ToInt32(input1);

                    //Input request for  length 2
                    Console.Write("Please enter a value for Lenght 2:  ");
                    String input2 = Console.ReadLine();
                    int len2 = Convert.ToInt32(input2);

                    //Input request for  length 3
                    Console.Write("Please enter a value for Lenght 3:  ");
                    String input3 = Console.ReadLine();
                    int len3 = Convert.ToInt32(input3);

                    //Check for triangle type
                    if (len1 == len2 && len2 == len3)
                    {
                        Console.WriteLine("All sides are equal so this is an equilatoral triangle...");
                    }
                    else if (len1 == len2 && len2 != len3)
                    {
                        Console.WriteLine("Two sides are equal so this is an isoceles triangle...");
                    }
                    else
                    {
                        Console.WriteLine("All sides are different so this is a scalene triangle");
                    }
                    break; //Break loop
                }
                catch (FormatException fe) 
                {
                    Console.WriteLine("Please enter a number......");
                    Console.WriteLine(fe.Message);
                    continue; // Continue loop
                }
            }
        }
    }
}
