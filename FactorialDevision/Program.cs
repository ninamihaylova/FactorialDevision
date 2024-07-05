class FactorialDivision
{
    static void Main()
    {
        
        int number1 = int.Parse(Console.ReadLine());

        
        int number2 = int.Parse(Console.ReadLine());

        int factorial1 = CalculateFactorial(number1);
        int factorial2 = CalculateFactorial(number2);

        int result = factorial1 / factorial2;

        Console.WriteLine($"{result}");
    }

    static int CalculateFactorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * CalculateFactorial(n - 1);
    }
}