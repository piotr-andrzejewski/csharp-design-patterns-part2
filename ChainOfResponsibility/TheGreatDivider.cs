namespace ChainOfResponsibility;

static class TheGreatDivider
{
    public static void MaxIntDividedBy(string number)
    {
        if (string.IsNullOrEmpty(number))
        {
            throw new ArgumentException("Nothing entered", nameof(number));
        }
        Console.WriteLine(int.MaxValue / int.Parse(number));
    }
}