using Iteration_Exercises;

namespace IterationExercises.Test;

public class LambdaTests
{
    [Test]
    public void LambdaGreetsName()
    {
        Assert.That(Lambda.Greet("Alex"), Is.EqualTo("Hi Alex"));
    }

    [Test]
    public void LambdaGivesTitle()
    {
        Assert.That(Lambda.Title("Mx", "Addison"), Is.EqualTo("Mx Addison"));
    }

    [Test]
    public void LambdaStartsWithA()
    {
        Assert.That(Lambda.StartsWithA("Alex"), Is.True);
    }

    [Test]
    public void LambdaNameLength()
    {
        Assert.That(Lambda.NameLength("Alex"), Is.EqualTo(4));
    }

    [Test]
    public void LambdaAreNamesSameTest()
    {
        string name1 = "Alice";
        string name2 = "Bob";
        bool expected = false;
        Assert.That(Lambda.AreNamesSame(name1, name2), Is.EqualTo(expected));
    }

    [Test]
    public void GreetsAll()
    {
        var names = new List<string> { "Alice", "Bob", "Carol" };
        IEnumerable<string> expected = new List<string> { "Hi Alice", "Hi Bob", "Hi Carol" };
        Assert.That(Lambda.GreetAll(names), Is.EquivalentTo(expected));
    }

    [Test]
    public void GetsNamesStartingWithA()
    {
        var names = new List<string> { "Alice", "Bob", "Carol" };
        IEnumerable<string> expected = new List<string> { "Alice" };
        Assert.That(Lambda.GetNamesStartingWithA(names), Is.EquivalentTo(expected));
    }

    [Test]
    public void GetsNameLengths()
    {
        var names = new List<string> { "Alice", "Bob", "Carol" };
        IEnumerable<int> expected = new List<int> { 5, 3, 5 };
        Assert.That(Lambda.GetNameLengths(names), Is.EquivalentTo(expected));
    }

    [Test]
    public void GetsUniqueNames()
    {
        var names = new List<string> { "Alice", "Alice", "Bob", "Carol" };
        IEnumerable<string> expected = new List<string> { "Alice", "Bob", "Carol" };
        Assert.That(Lambda.GetUniqueNames(names), Is.EquivalentTo(expected));
    }

    [Test]
    public void MapsToGreetings()
    {
        List<string> names = new List<string> { "Alice", "Bob", "Carol" };
        IEnumerable<string> expectedGreetings = new List<string> { "Hi Alice", "Hi Bob", "Hi Carol" };
        IEnumerable<string> greetings = names.MapToGreetings();

        CollectionAssert.AreEqual(expectedGreetings, greetings);
    }

    [Test]
    public void FiltersNamesStartingWithA()
    {
        var names = new List<string> { "Alice", "Bob", "Carol", "Darren" };

        var filteredNames = names.FilterNamesStartingWithA();

        CollectionAssert.AreEqual(new[] { "Alice" }, filteredNames);
    }

    [Test]
    public void ReduceNameLengthCount()
    {
        List<string> names = new List<string> { "Alice", "Bob", "Carol" };
        int expectedResult = 13;

        int result = names.ReduceNameLengthCount();

        Assert.AreEqual(expectedResult, result);
    }
}
