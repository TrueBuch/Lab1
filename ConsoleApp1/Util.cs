public static class Util
{
    public static string Input(this string str)
    {
        Console.Write(str);
        return Console.ReadLine();
    }
    public static double GetDouble()
    {
        while (true)
        {
            var input = "Enter a number: ".Input();

            if (double.TryParse(input, out double result)) return result;

            InvalidInput();
        }
    }

    public static char GetChar()
    {
        while (true)
        {
            var input = "Enter a char: ".Input();

            if (char.TryParse(input, out char result)) return result;

            InvalidInput();
        }
    }

    public static int GetInt()
    {
        while (true)
        {
            var input = "Enter a number: ".Input();

            if (int.TryParse(input, out int result)) return result;

            InvalidInput();
        }
    }

    public static long GetLong()
    {
        while (true)
        {
            var input = "Enter a number: ".Input();

            if (long.TryParse(input, out long result)) return result;

            InvalidInput();
        }
    }

    public static (int, int, int) GetThreeNums()
    {
        while (true)
        {
            var input = "Enter 3 numbers separated by space: ".Input();

            var parts = input?.Split(' ');

            if (parts?.Length == 3 &&
                int.TryParse(parts[0], out int a) &&
                int.TryParse(parts[1], out int b) &&
                int.TryParse(parts[2], out int c))
                return (a, b, c);

            InvalidInput();
        }
    }

    public static (int, int) GetTwoNums()
    {
        while (true)
        {
            var input = "Enter 2 numbers separated by space: ".Input();

            var parts = input?.Split(' ');

            if (parts?.Length == 2 &&
                int.TryParse(parts[0], out int a) &&
                int.TryParse(parts[1], out int b))
                return (a, b);
            
            InvalidInput();
        }
    }

    public static string WithThreeNums<T>(Func<int, int, int, T> func)
    {
        var input = GetThreeNums();
        return func(input.Item1, input.Item2, input.Item3).ToString();
    }

    public static string WithTwoNums<T>(Func<int, int, T> func)
    {
        var input = GetTwoNums();
        return func(input.Item1, input.Item2).ToString();
    }

    public static int[] GetArr()
    {
        while (true)
        {
            var input = "Enter numbers separated by space: ".Input();

            var parts = input?.Split(' ');

            int[] arr = new int[parts.Length];
            
            bool valid = true;

            for (int i = 0; i < parts.Length; i++)
            {
                if (int.TryParse(parts[i], out int number))
                {
                    arr[i] = number;
                    continue;
                }
                else
                {
                    InvalidInput();
                    valid = false;
                    break;
                }
            }

            if (valid) return arr;
        }
    }

    public static void InvalidInput() => Console.WriteLine("Invalid input. Try again"); 
}
