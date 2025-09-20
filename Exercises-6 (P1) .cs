using System;

class Program
{
    static void Main()
    {
        // ==== BAI 1 ====
        Console.WriteLine("===== BAI 1: JAGGED ARRAY KHOI TAO SAN =====");

        int[][] arr1 = new int[4][];
        arr1[0] = new int[] { 1, 1, 1, 1, 1 };
        arr1[1] = new int[] { 2, 2 };
        arr1[2] = new int[] { 3, 3, 3, 3 };
        arr1[3] = new int[] { 4, 4 };

        Console.WriteLine("Mang jagged array da khoi tao:");
        PrintJaggedArray(arr1);

        // ==== BAI 2 ====
        Console.WriteLine("\n===== BAI 2: JAGGED ARRAY TU NGUOI DUNG =====");

        Console.Write("Nhap so dong: ");
        int rows = int.Parse(Console.ReadLine());
        int[][] arr2 = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            Console.Write($"Nhap so cot cua dong {i + 1}: ");
            int cols = int.Parse(Console.ReadLine());
            arr2[i] = new int[cols];

            Console.WriteLine($"Nhap {cols} so cho dong {i + 1}:");
            for (int j = 0; j < cols; j++)
            {
                arr2[i][j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nMang vua nhap:");
        PrintJaggedArray(arr2);

        // 1. Tim so lon nhat moi dong va toan mang
        Console.WriteLine("\nSo lon nhat moi dong:");
        int maxAll = int.MinValue;
        for (int i = 0; i < arr2.Length; i++)
        {
            int maxRow = int.MinValue;
            foreach (int num in arr2[i])
            {
                if (num > maxRow) maxRow = num;
                if (num > maxAll) maxAll = num;
            }
            Console.WriteLine($"Dong {i + 1}: {maxRow}");
        }
        Console.WriteLine($"So lon nhat toan mang: {maxAll}");

        // 2. Sap xep tang dan moi dong
        Console.WriteLine("\nMang sau khi sap xep tung dong:");
        for (int i = 0; i < arr2.Length; i++)
        {
            Array.Sort(arr2[i]);
        }
        PrintJaggedArray(arr2);

        // 3. In cac so nguyen to
        Console.WriteLine("\nCac so nguyen to trong mang:");
        for (int i = 0; i < arr2.Length; i++)
        {
            for (int j = 0; j < arr2[i].Length; j++)
            {
                if (IsPrime(arr2[i][j]))
                {
                    Console.WriteLine($"arr[{i}][{j}] = {arr2[i][j]}");
                }
            }
        }

        // 4. Tim vi tri cua 1 so nhap tu nguoi dung
        Console.Write("\nNhap so can tim: ");
        int search = int.Parse(Console.ReadLine());
        bool found = false;
        for (int i = 0; i < arr2.Length; i++)
        {
            for (int j = 0; j < arr2[i].Length; j++)
            {
                if (arr2[i][j] == search)
                {
                    Console.WriteLine($"Tim thay tai vi tri arr[{i}][{j}]");
                    found = true;
                }
            }
        }
        if (!found) Console.WriteLine("Khong tim thay so nay trong mang.");
    }

    // Ham in jagged array
    static void PrintJaggedArray(int[][] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            foreach (int num in arr[i])
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }

    // Ham kiem tra so nguyen to
    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}
