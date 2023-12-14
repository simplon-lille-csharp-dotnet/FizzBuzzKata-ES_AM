
namespace FizzBuzz;

public class FizzBuzz
{
    public static string PrintFizzBuzz(int entierAffiche)
    {
        int fizz = entierAffiche % 3;
        int buzz = entierAffiche % 5;

        if (fizz == 0 && buzz == 0)
        {
            return "FizzBuzz";
        }
        if (fizz == 0)
        {
             return "Fizz";
        }
        if (buzz == 0)
        {
            return "Buzz";
        }
        else
        {
             return entierAffiche.ToString();  
        }

    }
}