using System;
namespace Iteration_Exercises
{
	public static class Lambda
	{

        public static Func<string, string> Greet = name => "Hi " + name;
        public static Func<string, string, string> Title = (honorific, name) => $"{honorific} {name}";
        public static Func<string, bool> StartsWithA = name => name.StartsWith("A");
        public static Func<string, int> NameLength = name => name.Length;
        public static Func<string, string, bool> AreNamesSame = (name1, name2) => name1 == name2;

        /*
         Pros of using 'name' as a string:

            - String is a commonly used data type for representing names and is easily understandable.
            - String is an efficient data type for manipulation and processing purposes (stored in memory).


        Cons of using 'name' as a string:

            - Strings are immutable, this can lead to increased memory usage when manipulating strings.
            - Using string for representing names might not be flexible enough to accommodate 
                other data types or formats that may be needed for representing names.
            - Processing large strings could affect the performance of the application.
        */

        public static IEnumerable<string> GreetAll(IEnumerable<string> names)
        {
            return names.Select(Greet);
        }

        public static IEnumerable<string> GetNamesStartingWithA(IEnumerable<string> names)
        {
            return names.Where(StartsWithA);
        }

        public static IEnumerable<int> GetNameLengths(IEnumerable<string> names)
        {
            return names.Select(NameLength);
        }

        // Could just use return names.Distinct(); for the following but wanted to try with lambda!

        public static IEnumerable<string> GetUniqueNames(IEnumerable<string> names)
        {
            List<string> uniqueNames = new List<string>();

            foreach (var name in names)
            {
                if (!uniqueNames.Any(comparedName => AreNamesSame(comparedName, name)))
                {
                    uniqueNames.Add(name);
                }
            }

            return uniqueNames;
        }

        /* ===== BONUS WORK ===== */

        /* Create your own Map, Filter and Reduce extension methods which take 
         * an IEnumerable and a lambda, and behave similarly to Ruby's map, 
         * filter and reduce (these are standard methods often used on big 
         * datasets, so it's worthwhile knowing about them)
         * 
         * Once you've created those methods, talk to Alex about how large a 
         * dataset you could use them with, and why
         */

        public static IEnumerable<string> MapToGreetings(this IEnumerable<string> names)
        {
            return names.Select(Lambda.Greet);
        }
    }
}
