namespace Command;

static class Program
{
    public static int x = 0;
    public static int y = 0;

    static void Main(string[] args)
    {
        var commandList = new List<ICommand>();
        Console.WriteLine("Use arrows to add direction commands, and enter to run the command list");

        while (true)
        {
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.UpArrow)
            {
                commandList.Add(new UpCommand());
            }
            else if (key == ConsoleKey.DownArrow)
            {
                commandList.Add(new DownCommand());
            }
            else if (key == ConsoleKey.LeftArrow)
            {
                commandList.Add(new LeftCommand());
            }
            else if (key == ConsoleKey.RightArrow)
            {
                commandList.Add(new RightCommand());
            }
            else if (key == ConsoleKey.Enter)
            {
                Console.WriteLine();
                commandList.ForEach(c => c.Invoke());
                Console.WriteLine($": {x}, {y}");
                commandList.Clear();
            }
        }
    }
}