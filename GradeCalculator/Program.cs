internal class Program
{
    private static void Main(string[] args)
    {
        string input;
        int grade;

        Console.Write("Enter your Grade: ");
        input = Console.ReadLine();

        bool isNumeric = int.TryParse(input, out grade);
        if (!isNumeric)
        {
            Console.WriteLine("The input must be a number.");
            return;
        }

        if (grade < 0 || grade > 100)
        {
            Console.WriteLine("You have entered an invalid grade!");
        }

        if (grade >= 90)
        {
            Console.WriteLine("You scored an A!!!");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("You scored a B!!!");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("You scored a C!!!");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("You scored a D!!!");
        }
        else if (grade < 60)
        {
            Console.WriteLine("You scored an F!!!");
        }
    }
}