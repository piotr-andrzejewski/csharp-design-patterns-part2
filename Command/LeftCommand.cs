namespace Command;

class LeftCommand : ICommand
{
    public void Invoke()
    {
        Console.Write("Left ");
        Program.x--;
    }
     
    public void Undo()
    {
        Console.Write("Right ");
        Program.x++;
    }
}