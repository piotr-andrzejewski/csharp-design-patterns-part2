namespace ChainOfResponsibility;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Type an int to divide Max Int by");
        try
        {
            LineReader.Readlines();
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Quit trying to divide by zero, you might break something");
        }
    }
}