internal class Program
{
    private static void Main(string[] args)
    {
        string variable = "welcome to class";
        string variable2 = "Our Class about C#";

        //length
        Console.WriteLine(variable.Length);

        // Toupper ToLower
        Console.WriteLine(variable.ToUpper());
        Console.WriteLine(variable.ToLower());

        //Concat
        Console.WriteLine(string.Concat(variable, " Hello"));

        // Compare , CompareTo
        Console.WriteLine(variable.CompareTo(variable2)); //0,1,-1
        Console.WriteLine(string.Compare(variable, variable2, true));
        Console.WriteLine(string.Compare(variable, variable2, false));

        //Contains
        Console.WriteLine(variable.Contains(variable2));
        Console.WriteLine(variable.EndsWith("welcome"));
        Console.WriteLine(variable.StartsWith("Hello"));

        //IndexOf
        Console.WriteLine(variable.IndexOf("CS"));
        Console.WriteLine(variable.IndexOf("Erkan"));
        Console.WriteLine(variable.LastIndexOf("u"));

        //Insert
        Console.WriteLine(variable.Insert(0, "Hello"));

        //PadLeft, RightLeft
        Console.WriteLine(variable + variable2.PadLeft(30));
        Console.WriteLine(variable + variable2.PadLeft(30, '*'));
        Console.WriteLine(variable.PadRight(50) + variable2);
        Console.WriteLine(variable.PadRight(50, '-') + variable2);

        //Remove
        Console.WriteLine(variable.Remove(10));
        Console.WriteLine(variable.Remove(5, 3));
        Console.WriteLine(variable.Remove(0, 1));

        //Replace
        Console.WriteLine(variable.Replace("class", "lesson"));
        Console.WriteLine(variable.Replace(" ", "*"));

        //Split
        Console.WriteLine(variable.Split(' ')[1]);

        //Substring
        Console.WriteLine(variable.Substring(4));
        Console.WriteLine(variable.Substring(4, 6));


    }
}