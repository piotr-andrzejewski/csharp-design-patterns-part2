namespace Command;

class DownCommand : ICommand
{
    public void Invoke()
    {
        Console.Write("Down ");
        Program.y--;
    }
}