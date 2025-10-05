namespace Observer;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your list, press ctrl-c to quit:");
        var reader = new ListReader();
        var writer = new FileWriter();
        reader.ListUpdated += (listItem) => Console.WriteLine(listItem);
        reader.ListUpdated += writer.WriteToFile;
        reader.ReadList();
    }
}