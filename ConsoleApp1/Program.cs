public static class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Solution solution = new();

        while (true)
        {
            int number = Choice();
            switch (number)
            {
                case 1: Print(solution.Fraction(Util.GetDouble())); break;
                case 2: Print(solution.CharToNum(Util.GetChar())); break;
                case 3: Print(solution.Is2Digits(Util.GetInt())); break;
                case 4: Print(Util.WithThreeNums(solution.IsInRange)); break;
                case 5: Print(Util.WithThreeNums(solution.IsEqual)); break;
                case 6: Print(solution.Abs(Util.GetInt())); break;
                case 7: Print(solution.Is35(Util.GetInt())); break;
                case 8: Print(Util.WithThreeNums(solution.Max3)); break;
                case 9: Print(Util.WithTwoNums(solution.Sum2)); break;
                case 10: Print(solution.Day(Util.GetInt())); break;
                case 11: Print(solution.ListNums(Util.GetInt())); break;
                case 12: Print(solution.Chet(Util.GetInt())); break;
                case 13: Print(solution.NumLen(Util.GetLong())); break;
                case 14: solution.Square(Util.GetInt()); break;
                case 15: solution.RightTriangle(Util.GetInt()); break;
                case 16: Print(solution.FindFirst(Util.GetArr(), Util.GetInt())); break;
                case 17: Print(solution.MaxAbs(Util.GetArr())); break;
                case 18: Print(solution.Add(Util.GetArr(), Util.GetArr(), Util.GetInt())); break;
                case 19: Print(solution.ReverseBack(Util.GetArr())); break;
                case 20: Print(solution.FindAll(Util.GetArr(), Util.GetInt())); break;
            };
        }
    }

    public static int Choice()
    {
        while (true)
        {
            if (int.TryParse("Enter the task number: ".Input(), out int result))
            {
                if (result > 0 && result <= 20)
                {
                    return result;
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