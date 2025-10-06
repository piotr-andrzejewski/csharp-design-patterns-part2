namespace ChainOfResponsibilityGroceryList;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your list, press ctrl-c to quit:");
        var reader = new ListReader()
            .AddHandler(new ConsoleItemHandler())
            .AddHandler(new FileWritingItemHandler());

        reader.ReadList();
    }
}