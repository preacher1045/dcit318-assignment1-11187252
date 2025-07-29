namespace GradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade;

            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter a numerical grade between 0 and 100");
                    string input = Console.ReadLine();

                    grade = Convert.ToInt32(input);

                    if (grade < 0 || grade > 100)
                    {
                        Console.WriteLine("Please enter a number between 0 and 100....");
                        continue;
                    }

                    if (grade >= 90)
                    {
                        Console.WriteLine("Your grade is A");
                    }
                    else if (grade >= 80)
                    {
                        Console.WriteLine("Your grade is B");
                    }
                    else if (grade >= 70)
                    {
                        Console.WriteLine("Your grade is  C");
                    }
                    else if (grade >= 60)
                    {
                        Console.WriteLine("Your grade is D");
                    }
                    else
                    {
                        Console.WriteLine("Your grade is F");
                    }

                    break;

                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Please enter a number.....");
                    Console.WriteLine(fe.Message);
                }
            }
        }
    }
}
