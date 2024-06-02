internal class Program
{
    private static void Main(string[] args)
    {
        string input;
        int age;
        int ticket = 10;

        Console.Write("Enter your Age: ");
        input = Console.ReadLine();

        bool isNumeric = int.TryParse(input, out age);
        if (!isNumeric)
        {
            Console.WriteLine("The input must be a number.");
            return;
        }

        if (age >= 65 || age <= 12)
        {
            ticket -= 7;
            Console.WriteLine("Your ticket costs GHC{0}.00", ticket);
        }
        else
        {
            Console.WriteLine("Your ticket costs GHC{0}.00", ticket);
        }
        
    }
}