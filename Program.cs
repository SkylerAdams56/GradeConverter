namespace Grade_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Letter Grade Converter");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter a numerical grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            if (grade >= 88)
            {
                Console.WriteLine("Letter Grade: A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Letter Grade: B");
            }
            else if (grade >= 67)
            {
                Console.WriteLine("Letter Grade: C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Letter Grade: D");
            }
            else
            {
                Console.WriteLine("Letter Grade: F");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Continue? (y/n): ");
            string answer = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            if (answer == "y")
            {
                Main(args);
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}