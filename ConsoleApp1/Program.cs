public static class Program
{



    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Solution solution = new();

        Dictionary<int, Action> actions = new()
        {
            { 1, () => Print(solution.Fraction(Util.GetDouble())) },
            { 2, () => Print(solution.CharToNum(Util.GetChar())) },
            { 3, () => Print(solution.Is2Digits(Util.GetInt())) },
            { 4, () => Print(Util.WithThreeNums(solution.IsInRange)) },
            { 5, () => Print(Util.WithThreeNums(solution.IsEqual)) },
            { 6, () => Print(solution.Abs(Util.GetInt())) },
            { 7, () => Print(solution.Is35(Util.GetInt())) },
            { 8, () => Print(Util.WithThreeNums(solution.Max3)) },
            { 9, () => Print(Util.WithTwoNums(solution.Sum2)) },
            { 10, () => Print(solution.Day(Util.GetInt())) },
            { 11, () => Print(solution.ListNums(Util.GetInt())) },
            { 12, () => Print(solution.Chet(Util.GetInt())) },
            { 13, () => Print(solution.NumLen(Util.GetLong())) },
            { 14, () => solution.Square(Util.GetInt()) },
            { 15, () => solution.RightTriangle(Util.GetInt())},
            { 16, () => Print(solution.FindFirst(Util.GetArr(), Util.GetInt()))},
            { 17, () => Print(solution.MaxAbs(Util.GetArr()))},
            { 18, () => Print(solution.Add(Util.GetArr(), Util.GetArr(), Util.GetInt()))},
            { 19, () => Print(solution.ReverseBack(Util.GetArr()))},
            { 20, () => Print(solution.FindAll(Util.GetArr(), Util.GetInt()))}
        };

        Choice(actions);
    }

    public static void Choice(Dictionary<int, Action> actions)
    {
        while (true)
        {
            if (int.TryParse("Enter the task number: ".Input(), out int result))
            {
                if (result > 0 && result <= 20)
                {
                    actions[result].Invoke();
                    continue;
                }
            }
            Util.InvalidInput();
        }
    }

    public static void Print(object str)
    {
        if (str is double s) str = Math.Round(s, 10);
        Console.WriteLine(str);
    }

    public static void Print(int[] arr)
    {
        foreach (var i in arr)
            Console.Write($"{i} ");
        Console.WriteLine();
    }
}