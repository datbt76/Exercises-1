internal class Ex01
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so luong phan tu trong mang:");
        int i = Convert.ToInt32(Console.ReadLine());
        int[] Mang = new int[i];
        Random rnd = new Random();
        for (int j = 0; j < i; j++)
        {
            Mang[j] = rnd.Next(1, 100);
            Console.Write($"{Mang[j]} ");
        }
        Console.WriteLine("\n");

        //1. Tính trung bình cộng
        float tb = trungbinh(Mang);
        Console.WriteLine($"Gia tri trung binh cua mang la {tb}");

        //2. Kiểm tra mảng có chứa giá trị cụ thể không
        Console.Write("Nhap so can kiem tra:");
        int sokiemtra = Convert.ToInt32(Console.ReadLine());
        bool dungsai = kiemtra(Mang, sokiemtra);
        if (dungsai == true)
            Console.WriteLine($"{sokiemtra} co trong Mang \n");
        else
            Console.WriteLine($"{sokiemtra} khong co trong Mang \n");

        //3. Tìm index của phần tử
        Console.Write("Nhap so can tim index:");
        int SocantimIndex = Convert.ToInt32(Console.ReadLine());
        int index = FindIndex(Mang, SocantimIndex);
        if (index != -1)
            Console.WriteLine($"Index cua {SocantimIndex} la {index} \n");
        else
            Console.WriteLine($"{SocantimIndex} khong co trong Mang \n");

        //4. Xóa phần tử cụ thể
        Console.Write("Nhap so can xoa:");
        int Socanxoa = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Mang sau khi xoa:");
        int[] Mangsaukhixoa = RemoveElement(Mang, Socanxoa);
        for (int a = 0; a < i-1; a++)
        {
            Console.Write($"{Mangsaukhixoa[a]} ");
        }
        Console.WriteLine("\n");

        //5. Tìm min & max
        FindMinMax(Mang, out int min, out int max);
        Console.WriteLine($"Min trong mang la: {min}, Max trong mang la: {max} \n");

        //6. Đảo ngược mảng
        ReverseArray(Mang);
        Console.WriteLine("Mang sau khi dao nguoc:");
        foreach (int j in Mang)
            Console.Write($"{j} ");
        Console.WriteLine("\n");

        //7. Tìm phần tử trùng
        FindDuplicates(Mang);

        //8. Xóa phần tử trùng
        Mang = RemoveDuplicates(Mang);
        Console.WriteLine("Mang sau khi xoa phan tu trung:");
        foreach (int j in Mang)
            Console.Write($"{j} ");
        Console.WriteLine("\n");
        FindDuplicates(Mang);
        Mang = RemoveDuplicates(Mang);
      
    }
    // 1. Tính trung bình cộng
    static float trungbinh(int[] Mang)
    {
        if (Mang.Length == 0) return 0;
        int sum = 0;
        foreach (int j in Mang)
        { sum += j; }
        return sum / Mang.Length;
    }
    // 2. Kiểm tra mảng có chứa giá trị cụ thể không
    static bool kiemtra(int[] Mang, int sokiemtra)
    {
        foreach (int j in Mang)
            if (j == sokiemtra) return true;
        return false;
    }
    // 3. Tìm index của phần tử
    static int FindIndex(int[] Mang, int SocantimIndex)
    {
        for (int i = 0; i < Mang.Length; i++)
            if (Mang[i] == SocantimIndex) return i;
        return -1;
    }
    // 4. Xóa phần tử cụ thể
    static int[] RemoveElement(int[] Mang, int Socanxoa)
    {
        return Mang.Where(x => x != Socanxoa).ToArray();
    }

    // 5. Tìm min & max
    static void FindMinMax(int[] Mang, out int min, out int max)
    {
        min = Mang[0];
        max = Mang[0];
        foreach (int num in Mang)
        {
            if (num < min) min = num;
            if (num > max) max = num;
        }
    }

    // 6. Đảo ngược mảng
    static void ReverseArray(int[] Mang)
    {
        Array.Reverse(Mang);
    }

    // 7. Tìm phần tử trùng
    static void FindDuplicates(int[] Mang)
    {
        var duplicates = Mang.GroupBy(x => x)
                            .Where(g => g.Count() > 1)
                            .Select(g => g.Key);
        Console.WriteLine("Phan tu trung la: " + (duplicates.Any() ? string.Join(", ", duplicates) : "Khong co phan tu trung"));
    }

    // 8. Xóa phần tử trùng
    static int[] RemoveDuplicates(int[] Mang)
    {
        return Mang.Distinct().ToArray();
    }
}


