class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int triple;
        Calculator.TripleBad(a);
        Console.WriteLine(a);
        Calculator.TripleRef(ref a);
        Console.WriteLine(a);
        Calculator.TripleOut(a, out triple);
        Console.WriteLine(triple);
    }
}