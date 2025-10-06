namespace Command;

class UpCommand : ICommand
{
    public void Invoke()
    {
        Console.Write("Up ");
        Program.y++;
    }
}