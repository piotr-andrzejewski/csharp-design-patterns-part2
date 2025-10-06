namespace Command;

class RightCommand : ICommand
{
    public void Invoke()
    {
        Console.Write("Right ");
        Program.x++;
    }
}