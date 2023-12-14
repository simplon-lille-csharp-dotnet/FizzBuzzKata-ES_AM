namespace FizzBuzzTest;

[TestFixture]
public class FizzBuzzTest
{
    [Test]
    public void PrintFizzBuzz_Input1_Return1()
    {
        // un simple exemple pour démarrer
        Assert.That(FizzBuzz.FizzBuzz.PrintFizzBuzz(1), Is.EqualTo("1"));
    }

    [Test]
    public void PrintFizzBuzz_Input2_Return2()
    {
        // un simple exemple pour démarrer
        Assert.That(FizzBuzz.FizzBuzz.PrintFizzBuzz(2), Is.EqualTo("2"));
    }

    [Test]
    public void PrintFizzBuzz_Input3_ReturnFizz()
    {
        // un simple exemple pour démarrer
        Assert.That(FizzBuzz.FizzBuzz.PrintFizzBuzz(3), Is.EqualTo("Fizz"));
    }

    [Test]

    public void PrintFizzBuzz_Input6_ReturnFizz()
    {
        Assert.That(FizzBuzz.FizzBuzz.PrintFizzBuzz(6), Is.EqualTo("Fizz"));
    }

    [Test]

    public void PrintFizzBuzz_Input5_ReturnFizz()
    {
        Assert.That(FizzBuzz.FizzBuzz.PrintFizzBuzz(5), Is.EqualTo("Buzz"));
    }

    [Test]

    public void PrintFizzBuzz_Input10_ReturnFizz()
    {
        Assert.That(FizzBuzz.FizzBuzz.PrintFizzBuzz(10), Is.EqualTo("Buzz"));
    }

    [Test]
    public void PrintFizzBuzz_Input15_ReturnFizz()
    {
        Assert.That(FizzBuzz.FizzBuzz.PrintFizzBuzz(15), Is.EqualTo("FizzBuzz"));
    }
}