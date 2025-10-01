public class Solution
{
    //Задание 1.
    public double Fraction(double x) // 1
    {
        return x - (int)x;
    }

    public int CharToNum(char x) => x - '0'; // 2

    public bool Is2Digits(int x) // 3
    {
        return Abs(x).ToString().Length == 2;
    }

    public bool IsInRange(int a, int b, int num) // 4
    {
        return (num >= a) && (num <= b);
    } 

    public bool IsEqual(int a, int b, int c) // 5
    {
        return a == b && b == c;
    } 

    //Задание 2.
    public int Abs(int x) // 6
    {
        return x < 0 ? -x : x;
    }

    public bool Is35(int x)  // 7
    {
        return (x % 3 == 0) ^ (x % 5 == 0);
    }

    public int Max3(int x, int y, int z) // 8
    {
        if (y > x) x = y;
        if (z > x) x = z;
        return x;
    }

    public int Sum2(int x, int y )//9
    {
        int sum = x + y;
        if (IsInRange(10, 19, sum)) return 20;
        return sum;
    }

    public string Day(int x) // 10
    {
        return x switch
        {
            1 => "Понедельник",
            2 => "Вторник",
            3 => "Среда",
            4 => "Четверг",
            5 => "Пятница",
            6 => "Суббота",
            7 => "Воскресенье",
            _ => "это не день недели"
        };
    }

    //задание 3
    public string ListNums(int x) // 11
    {
        string result = "";

        for (int i = 0; i <= x; i++) result += $"{i} ";
        return result;
    }

    public string Chet(int x) // 12
    {
        string result = "";

        for (int i = 0; i <= x; i += 2) result += $"{i} "; 
        return result;

    }

    public int NumLen(long x) // 13
    {
        int count = 0;

        do
        {
            x /= 10;
            count++;
        } while (x > 0);

        return count;
    }

    public void Square(int x) // 14
    {
        for (int i = 0; i < x; i++) Console.WriteLine(new string('*', x));
    }

    public void RightTriangle(int x) // 15
    {
        for (int i = 1; i <= x; i++) Console.WriteLine(new string(' ', x - i) + new string('*', i));
    }

    //Задание 4
    public int FindFirst(int[] arr, int x) // 16
    {
        for (int i = 0; i < arr.Length; i++) if (arr[i] == x) return i;
        return -1;
    }

    public int MaxAbs(int[] arr) // 17
    {
        int max = 0;
        foreach (int num in arr) if (Abs(num) > Abs(max)) max = num;
        return max;
    }

    public int[] Add(int[] arr, int[] ins, int pos) // 18
    {
        int lenght = arr.Length + ins.Length;
        int[] newArr = new int[lenght];

        for (int i = 0; i < lenght; i++)
        {
            if (IsInRange(pos, ins.Length + pos - 1, i)) newArr[i] = ins[i - pos];
            else if (i < pos) newArr[i] = arr[i];
            else newArr[i] = arr[i - ins.Length];
        }

        return newArr;
    }
    public int[] ReverseBack(int[] arr) // 19
    {
        int[] newArr = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++) newArr[i] = arr[arr.Length - 1 - i];
        return newArr;
    }

    public int[] FindAll(int[] arr, int x) // 20
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++) if (arr[i] == x) count++;

        int[] found = new int[count];
        int j = 0;

        for (int i = 0; i < arr.Length; i++)
            if (arr[i] == x)
            {
                found[j] = i;
                j++;
            }
        return found;
    }
}