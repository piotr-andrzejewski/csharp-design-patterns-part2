namespace Command;

class DownCommand : ICommand
{
    public void Invoke()
    {
        Console.Write("Down ");
        Program.y--;
    }

    public void Undo()
    {
        Console.Write("Up ");
        Program.y++;
    }
}