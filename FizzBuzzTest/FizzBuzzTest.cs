namespace FizzBuzzTest;

[TestFixture]
public class FizzBuzzTest
{
    [Test]
    public void life_the_universe_and_everything()
    {
        // un simple exemple pour démarrer
        Assert.That(FizzBuzz.FizzBuzz.PrintFizzBuzz(), Is.EqualTo(42));
    }
}