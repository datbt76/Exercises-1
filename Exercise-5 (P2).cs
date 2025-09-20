using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    // Bubble Sort
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // swap arr[j] and arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Linear Search trả về index
    static int LinearSearch(string[] words, string target)
    {
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Equals(target, StringComparison.OrdinalIgnoreCase))
                return i; // trả về vị trí tìm thấy
        }
        return -1; // không tìm thấy
    }

    static void Main()
    {
        // --- PHẦN 1: Bubble Sort ---
        int[] numbers = new int[10];
        Console.WriteLine("Hay nhap 10 so nguyen:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"So thu {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        BubbleSort(numbers);

        Console.WriteLine("\nDay so sau khi sap xep la:");
        Console.WriteLine(string.Join(", ", numbers));

        // --- PHẦN 2: Linear Search ---
        Console.WriteLine("\nHay nhap mot cau:");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Console.Write("Hay nhap tu can tim: ");
        string target = Console.ReadLine();

        int index = LinearSearch(words, target);

        if (index != -1)
            Console.WriteLine($"Tu \"{target}\" duoc tim thay o chi so thu {index}.");
        else
            Console.WriteLine($"Tu \"{target}\" khong duoc tim thay trong cau.");
    }
}
