using Iteration_Exercises;

namespace IterationExercises.Test;

public class LoopingTests
{

    [Test]
    public void WhileLoopReturnsOneNameWithHello()
    {
        var greetedNames = Looping.WhileLoop(new List<string> { "Alex" }).ToList();

        Assert.That(greetedNames.Count, Is.EqualTo(1));
        Assert.That(greetedNames[0], Is.EqualTo("Hello Alex"));
    }

    [Test]
    public void WhileLoopReturnsMultipleNamesWithHello()
    {
        var greetedNames = Looping.WhileLoop(new List<string> { "Dan", "Joao", "Ryan Le" }).ToList();

        Assert.That(greetedNames.Count, Is.EqualTo(3));
        Assert.That(greetedNames[0], Is.EqualTo("Hello Dan"));
        Assert.That(greetedNames[1], Is.EqualTo("Hello Joao"));
        Assert.That(greetedNames[2], Is.EqualTo("Hello Ryan Le"));
    }

    [Test]
    public void ForLoopReturnsOneNameWithHello()
    {
        var greetedNames = Looping.ForLoop(new List<string> { "Alex" }).ToList();

        Assert.That(greetedNames.Count, Is.EqualTo(1));
        Assert.That(greetedNames[0], Is.EqualTo("Hello Alex"));
    }

    [Test]
    public void ForLoopReturnsMultipleNamesWithHello()
    {
        var greetedNames = Looping.ForLoop(new List<string> { "Dan", "Joao", "Ryan Le" }).ToList();

        Assert.That(greetedNames.Count, Is.EqualTo(3));
        Assert.That(greetedNames[0], Is.EqualTo("Hello Dan"));
        Assert.That(greetedNames[1], Is.EqualTo("Hello Joao"));
        Assert.That(greetedNames[2], Is.EqualTo("Hello Ryan Le"));
    }

    [Test]
    public void ForEachLoopReturnsOneNameWithHello()
    {
        var greetedNames = Looping.ForEachLoop(new List<string> { "Alex" }).ToList();

        Assert.That(greetedNames.Count, Is.EqualTo(1));
        Assert.That(greetedNames[0], Is.EqualTo("Hello Alex"));
    }

    [Test]
    public void ForEachLoopReturnsMultipleNamesWithHello()
    {
        var greetedNames = Looping.ForEachLoop(new List<string> { "Dan", "Joao", "Ryan Le" }).ToList();

        Assert.That(greetedNames.Count, Is.EqualTo(3));
        Assert.That(greetedNames[0], Is.EqualTo("Hello Dan"));
        Assert.That(greetedNames[1], Is.EqualTo("Hello Joao"));
        Assert.That(greetedNames[2], Is.EqualTo("Hello Ryan Le"));
    }

    [Test]
    public void WithSelectReturnsOneNameWithHello()
    {
        var greetedNames = Looping.WithSelect(new List<string> { "Alex" }).ToList();

        Assert.That(greetedNames.Count, Is.EqualTo(1));
        Assert.That(greetedNames[0], Is.EqualTo("Hello Alex"));
    }

    [Test]
    public void WithSelectReturnsMultipleNamesWithHello()
    {
        var greetedNames = Looping.WithSelect(new List<string> { "Dan", "Joao", "Ryan Le" }).ToList();

        Assert.That(greetedNames.Count, Is.EqualTo(3));
        Assert.That(greetedNames[0], Is.EqualTo("Hello Dan"));
        Assert.That(greetedNames[1], Is.EqualTo("Hello Joao"));
        Assert.That(greetedNames[2], Is.EqualTo("Hello Ryan Le"));
    }

    [Test]
    public void WithAggregateReturnsOneNameWithHello()
    {
        var greetedNames = Looping.WithAggregate(new List<string> { "Alex" }).ToList();

        Assert.That(greetedNames.Count, Is.EqualTo(1));
        Assert.That(greetedNames[0], Is.EqualTo("Hello Alex"));
    }

    [Test]
    public void WithAggregateReturnsMultipleNamesWithHello()
    {
        var greetedNames = Looping.WithAggregate(new List<string> { "Dan", "Joao", "Ryan Le" }).ToList();

        Assert.That(greetedNames.Count, Is.EqualTo(3));
        Assert.That(greetedNames[0], Is.EqualTo("Hello Dan"));
        Assert.That(greetedNames[1], Is.EqualTo("Hello Joao"));
        Assert.That(greetedNames[2], Is.EqualTo("Hello Ryan Le"));
    }
}
