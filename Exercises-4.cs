internal class Exercises_4
{
    // Hàm tìm số lớn nhất trong 3 số
    static int FindLargest(int a, int b, int c)
    {
        int max = a;
        if (b > max)
            max = b;
        if (c > max)
            max = c;
        return max;
    }
    // Hàm tính giai thừa
    static long GiaiThua(int n)
    {
        if (n < 0)
            throw new ArgumentException("So nay la so am.");
        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
    // Hàm kiểm tra số nguyên tố
    static bool IsPrime(int n)
    {
        if (n <= 1) return false; // Số <= 1 không phải số nguyên tố
        if (n == 2) return true;  // 2 là số nguyên tố
        if (n % 2 == 0) return false; // Số chẵn > 2 không phải số nguyên tố

        // Chỉ cần kiểm tra tới căn bậc 2 của n
        for (int i = 3; i * i <= n; i += 2)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }
    // Hàm in tất cả số nguyên tố nhỏ hơn limit
    static void PrintPrimesLessThan(int limit) // In tất cả số nguyên tố < limit
    {
        Console.WriteLine($"Cac so nguyen to nho hon {limit} la:");
        for (int i = 2; i < limit; i++)
        {
            if (IsPrime(i))
                Console.Write(i + " ");
        }
        Console.WriteLine();
    }
    // Hàm in N số nguyên tố đầu tiên
    static void PrintFirstNPrimes(int N)  // Hàm in N số nguyên tố đầu tiên
        {
            Console.WriteLine($"{N} so nguyen to dau tien:");
            int count = 0;
            int num = 2;
            while (count < N)
            {
                if (IsPrime(num))
                {
                    Console.Write(num + " ");
                    count++;
                }
                num++;
            }
            Console.WriteLine();
        }
    // Hàm kiểm tra số hoàn hảo
    static bool IsPerfect(int n)
    {
        if (n <= 1) return false;

        int sum = 0;
        for (int i = 1; i <= n / 2; i++) // chỉ cần duyệt đến n/2
        {
            if (n % i == 0)
                sum += i;
        }
        return sum == n;
    }

    // Hàm in tất cả số hoàn hảo nhỏ hơn limit
    static void PrintPerfectNumbers(int limit)
    {
        Console.WriteLine($"Cac so hoan hao nho hon {limit}:");
        for (int i = 2; i < limit; i++)
        {
            if (IsPerfect(i))
                Console.Write(i + " ");
        }
        Console.WriteLine();
    }
    // Hàm kiểm tra pangram
    static bool IsPangram(string input)
    {
        if (string.IsNullOrEmpty(input))
            return false;

        input = input.ToLower(); // chuyển về chữ thường

        for (char c = 'a'; c <= 'z'; c++)
        {
            if (!input.Contains(c))
                return false; // thiếu chữ cái nào thì không phải pangram
        }

        return true;
    }
    static void Main(string[] args)
    {
        // Tim so lon nhat trong 3 so
        int max = FindLargest(5, 8, 12);
        Console.WriteLine("Largest = " + max);

        // Tinh giai thua
        long kqGT = GiaiThua(5);
        Console.WriteLine("5! = " + kqGT);

        // Kiem tra so nguyen to
        Console.Write("Nhap so can kiem tra: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (IsPrime(num))
            Console.WriteLine($"{num} la so nguyen to.");
        else
            Console.WriteLine($"{num} không phai la so nguyen to.");

        // 4.1. In cac so nguyen to nho hon n
        Console.Write("Nhap mot so n = ");
        int limit = Convert.ToInt32(Console.ReadLine());
        PrintPrimesLessThan(limit);

        // 4.2. In N so nguyen to dau tien
        Console.Write("Nhap N (so luong so nguyen to dau tien): ");
        int N = Convert.ToInt32(Console.ReadLine());
        PrintFirstNPrimes(N);

        // Kiểm tra một số bất kỳ là số hoàn hảo hay không
        Console.Write("Nhap mot so: ");
        int numPerfect = Convert.ToInt32(Console.ReadLine());
        if (IsPerfect(numPerfect))
            Console.WriteLine($"{numPerfect} la so hoan hao.");
        else
            Console.WriteLine($"{numPerfect} khong phai so hoan hao.");

        // In tất cả số hoàn hảo nhỏ hơn 1000
        PrintPerfectNumbers(1000);
        // Kiểm tra pangram
        string str1 = "The quick brown fox jumps over the lazy dog";
        string str2 = "Hello World";
        Console.WriteLine($"\"{str1}\" la Pangram: {IsPangram(str1)}"); // True
        Console.WriteLine($"\"{str2}\" la Pangram: {IsPangram(str2)}"); // False
        Console.ReadLine();
    }
}