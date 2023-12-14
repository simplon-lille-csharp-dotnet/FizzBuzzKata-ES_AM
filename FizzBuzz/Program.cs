namespace FizzBuzz;

internal class Program
{
    FizzBuzz fizzBuzz = new FizzBuzz();


    static void Main(string[] args)
    {
        int number = 100;

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(FizzBuzz.PrintFizzBuzz(i));
        }
    }
}
