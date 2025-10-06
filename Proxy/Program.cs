namespace Proxy;

class Program
{
    static void Main(string[] args)
    {
        Parallel.For(0, 10, i => OneFileAtATimeProxy.AppendAllText("A.txt", i + ", "));
    }
}