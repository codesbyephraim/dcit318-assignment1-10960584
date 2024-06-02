internal class Program
{
    private static void Main(string[] args)
    {
        string input1;
        int a;

        Console.Write("Enter your first side: ");
        input1 = Console.ReadLine();

        bool isNumeric1 = int.TryParse(input1, out a);
        if (!isNumeric1)
        {
            Console.WriteLine("The input must be a number.");
            return;
        }

        string input2;
        int b;

        Console.Write("Enter your second side: ");
        input2 = Console.ReadLine();

        bool isNumeric2 = int.TryParse(input2, out b);
        if (!isNumeric2)
        {
            Console.WriteLine("The input must be a number.");
            return;
        }

        string input3;
        int c;

        Console.Write("Enter your third side: ");
        input3 = Console.ReadLine();

        bool isNumeric3 = int.TryParse(input3, out c);
        if (!isNumeric3)
        {
            Console.WriteLine("The input must be a number.");
            return;
        }

        if (a == b && b == c && a == c)
        {
            Console.WriteLine("It is an Equaliteral Triangle!!!");
            return;
        }
        if (a != b && b != c && a != c)
        {
            Console.WriteLine("It is a Scalene Triangle!!!");
        }
        if (a == b || b == c || a == c)
        {
            Console.WriteLine("It is an Isosceles Triangle!!");
        }

    }
}