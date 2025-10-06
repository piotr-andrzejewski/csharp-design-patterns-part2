namespace Command;

interface ICommand
{
    void Invoke();
    void Undo();
}