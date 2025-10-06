namespace Command;

class RightCommand : ICommand
{
    public void Invoke()
    {
        Console.Write("Right ");
        Program.x++;
    }

    public void Undo()
    {
        Console.Write("Left ");
        Program.x--;
    }
}