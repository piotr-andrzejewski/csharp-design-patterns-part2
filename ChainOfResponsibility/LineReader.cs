namespace ChainOfResponsibility;

static class LineReader
{
    public static void Readlines()
    {
        while (true)
        {
            try
            {
                TheGreatDivider.MaxIntDividedBy(Console.ReadLine()!);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Caught: " + ex.Message);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Enter a number");
            }
        }
    }
}