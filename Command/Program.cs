namespace Command;

static class Program
{
    public static int x = 0;
    public static int y = 0;

    static void Main(string[] args)
    {
        var commandList = new List<(ICommand, bool)>();
        Console.WriteLine("Use arrows to add direction commands, and enter to run the command list");

        while (true)
        {
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.UpArrow)
            {
                commandList.Add((new UpCommand(), true));
            }
            else if (key == ConsoleKey.DownArrow)
            {
                commandList.Add((new DownCommand(), true));
            }
            else if (key == ConsoleKey.LeftArrow)
            {
                commandList.Add((new LeftCommand(), true));
            }
            else if (key == ConsoleKey.RightArrow)
            {
                commandList.Add((new RightCommand(), true));
            }
            else if (key == ConsoleKey.Backspace)
            {
                var notUndoneCommands = commandList
                    .Where(c => c.Item2)
                    .SkipLast(commandList.Count(c => !c.Item2));

                if (notUndoneCommands.Any())
                {
                    commandList.Add((notUndoneCommands.Last().Item1, false));
                }
            }
            else if (key == ConsoleKey.Enter)
            {
                Console.WriteLine();
                commandList.ForEach(c =>
                {
                    if (c.Item2)
                    {
                        c.Item1.Invoke();
                    }
                    else
                    {
                        c.Item1.Undo();
                    }
                });

                Console.WriteLine($": {x}, {y}");
                commandList.Clear();
            }
        }
    }
}