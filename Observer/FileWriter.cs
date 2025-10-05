namespace Observer;

public class FileWriter
{
    public string filename = DateTime.Now.ToFileTime().ToString();

    public void WriteToFile(string line) =>
        File.AppendAllText(filename, line + Environment.NewLine);
}