internal class Exercises_1
{

    static void Main(string[] args)
    {
        Ex1();
        Ex2();
        Ex3();
        Ex4();
        Ex5();
        Ex6();
        Ex7();
        Ex8();
        Ex9();
        Ex10();
    }
    static void Ex1()
    {//to Add/sum two numbers
        int sodautien = 4;
        int sothuhai = 10;
        int sum = sodautien + sothuhai;
        Console.WriteLine($"tong cua hai so la: {sum}");

    }
    static void Ex2()
    {//to Swap Values of Two Variables
        int sodautien = 4;
        int sothuhai = 10;
        Console.WriteLine("Truoc khi doi");
        Console.WriteLine($"so dau tien la {sodautien}\nso thu hai la {sothuhai}");
        // swap
        int trunggian = sodautien;
        sodautien = sothuhai;
        sothuhai = trunggian;
        Console.WriteLine("Sau khi doi");
        Console.WriteLine($"so dau tien la {sodautien}\nso thu hai la {sothuhai}");
    }
    static void Ex3()
    {//to Multiply two Floating Point Numbers
        float num1, num2, result;
        // Nhập số
        Console.Write("Nhap so dau tien: ");
        num1 = float.Parse(Console.ReadLine());
        Console.Write("Nhap so thu hai: ");
        num2 = float.Parse(Console.ReadLine());
        // tính nhân
        result = num1 * num2;
        // Show kết quả
        Console.WriteLine($"Ket qua phep nhan cua so {num1} va so {num2} la: {result}");
    }
    static void Ex4()
    {//to convert feet to meter
        double feet, meters;
        //Nhập độ dài feet
        Console.Write("Nhap do dai feet: ");
        feet = double.Parse(Console.ReadLine());
        // Thực hiện đổi: 1 feet = 0.3048 meters
        meters = feet * 0.3048;
        // Show kết quả
        Console.WriteLine($"{feet} feet = {meters} meters.");
    }
    static void Ex5()
    {
        Console.WriteLine("Lua chon chuong trinh ban muon doi");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        Console.Write("Ban chon (1 hay 2): ");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Nhap nhiet do trong Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
        }
        else if (choice == 2)
        {
            Console.Write("Nhap nhiet do trong Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheit}°F = {celsius}°C");
        }
        else
        {
            Console.WriteLine("Invalid option. Please run the program again.");
        }
    }
    static void Ex6()
    {
        Console.WriteLine("Size of C# Data Types (in bytes):\n");

        Console.WriteLine($"byte: {sizeof(byte)} byte");
        Console.WriteLine($"sbyte: {sizeof(sbyte)} byte");
        Console.WriteLine($"short: {sizeof(short)} bytes");
        Console.WriteLine($"ushort: {sizeof(ushort)} bytes");
        Console.WriteLine($"int: {sizeof(int)} bytes");
        Console.WriteLine($"uint: {sizeof(uint)} bytes");
        Console.WriteLine($"long: {sizeof(long)} bytes");
        Console.WriteLine($"ulong: {sizeof(ulong)} bytes");
        Console.WriteLine($"char: {sizeof(char)} bytes");
        Console.WriteLine($"float: {sizeof(float)} bytes");
        Console.WriteLine($"double: {sizeof(double)} bytes");
        Console.WriteLine($"decimal: {sizeof(decimal)} bytes");
        Console.WriteLine($"bool: {sizeof(bool)} byte");
    }
    static void Ex7()
    {
        Console.Write("Nhap mot ky tu: ");
        char ch = Console.ReadKey().KeyChar;
        // Đọc 1 ký tự từ bàn phím, không cần nhấn Enter
        Console.WriteLine();
        int asciiValue = (int)ch; // Ép kiểu char sang int để lấy mã ASCII
        Console.WriteLine($"Ma ASCII cua'{ch}' la {asciiValue}");
    }
    static void Ex8()
    {
        // Khai báo biến
        double radius, area;

        // Nhập bán kính từ người dùng
        Console.Write("Nhap ban kinh hinh tron: ");
        radius = double.Parse(Console.ReadLine());

        // Công thức tính diện tích: π * r^2
        area = Math.PI * radius * radius;

        // Hiển thị kết quả
        Console.WriteLine($"Diện tích hình tròn với bán kính {radius} là: {area}");
    }
    static void Ex9()
    {
        double side, area;

        // Nhập độ dài cạnh
        Console.Write("Nhap do dai canh hinh vuong: ");
        side = double.Parse(Console.ReadLine());

        // Công thức tính diện tích: cạnh × cạnh
        area = side * side;

        // Hiển thị kết quả
        Console.WriteLine($"Dien tich hinh vuong voi canh {side} la: {area}");
    }
    static void Ex10()
    {
        int totalDays, years, weeks, days;

        // Nhập số ngày
        Console.Write("Nhap tong so ngay: ");
        totalDays = int.Parse(Console.ReadLine());

        // Tính số năm, tuần và ngày
        years = totalDays / 365;                 // 1 năm = 365 ngày
        int remainingDays = totalDays % 365;     // Số ngày còn lại sau khi trừ năm
        weeks = remainingDays / 7;               // 1 tuần = 7 ngày
        days = remainingDays % 7;                // Ngày lẻ

        // Hiển thị kết quả
        Console.WriteLine($"{totalDays} ngay = {years} nam, {weeks} tuan, {days} ngay");
    }
}

