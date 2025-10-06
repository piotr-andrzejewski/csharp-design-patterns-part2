namespace Command;

class LeftCommand : ICommand
{
    public void Invoke()
    {
        Console.Write("Left ");
        Program.x--;
    }
}