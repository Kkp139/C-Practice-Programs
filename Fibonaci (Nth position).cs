class CalcFibo
{
    public static int calcFibo(int n)
    {
        // Write code here
        int a = 0;
        int b = 1;
        int fib = 0;

        if (n <= 0)
            return 0;
        else if (n == 1)
            return 1;
        else
        {
            for(int i = 2; i < n; i++)
            {
                fib = a + b;
                a = b;
                b = fib;
            }
            return fib;
        }
    }

    public static void Main()
    {
        Console.WriteLine(calcFibo(9));
    }
}