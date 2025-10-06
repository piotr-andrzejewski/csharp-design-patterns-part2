namespace ChainOfResponsibilityGroceryList;

class FileWritingItemHandler : IItemHandler
{
    public string filename = DateTime.Now.ToFileTime().ToString();
    public IItemHandler Next { get; set; }

    public void Handle(string line)
    {
        File.AppendAllText(filename, line + Environment.NewLine);
        Next?.Handle(line);
    }
}