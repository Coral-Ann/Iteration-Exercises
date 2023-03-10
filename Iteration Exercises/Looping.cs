namespace Iteration_Exercises;
public static class Looping
{
    public static IEnumerable<string> WhileLoop(IList<string> names)
    {
        int i = 0;
        while (i < names.Count)
        {
            yield return $"Hello {names[i]}";
            i++;
        }
    }

    public static IEnumerable<string> ForLoop(IList<string> names)
    {
        for (int i = 0; i < names.Count; i++)
        {
            yield return $"Hello {names[i]}";
        }
    }

    public static IEnumerable<string> ForEachLoop(IList<string> names)
    {
        foreach (var name in names)
        {
            yield return $"Hello {name}";
        }
    }

    public static IEnumerable<string> WithSelect(IList<string> names)
    {
        return names.Select(name => "Hello " + name);
    }

    public static IEnumerable<string> WithAggregate(IList<string> names)
    {
        return names.Aggregate(new List<string>(), (acc, name) =>
        {
            acc.Add("Hello " + name);
            return acc;
        });
    }

    public static IEnumerable<string> WhileLoopExtension(this List<string> names)
    {
        return Looping.WhileLoop(names);
    }

    /* NOTES ON YIELD RETURN:
     
     - 'yield return' is used when you want to generate a sequence of values as a result of an iteration, 
        without creating a temporary collection to store the result in memory.
     - When using 'yield return', the code execution is paused each time a value is returned, 
        and resumes when the next value is requested.
     - Cleaner and easier to read.
     - Useful in situations where the result is too large to fit in memory, or where you want to start
        processing the result before the entire iteration is complete.
     */
}

