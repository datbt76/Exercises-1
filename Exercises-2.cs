using System;

internal class Exercises_2
{
    static void Main(string[] args)
    {
        Doinhietdo();
        Tinhhinhcau();
        Congtrunhanchia();
        Hamso();
        Vantoc();
        Kiemtrakytu();
    }
    static void Doinhietdo() // Bài toán: Nhập nhiệt độ Celsius và chuyển đổi sang Kelvin và Fahrenheit
    { 
        Console.Write("Nhap nhiet do Celsius: ");
        string input = Console.ReadLine();
        int c = 0;
    while (!int.TryParse(input, out c))
        {
        Console.Write("Vui long nhap nhap nhiet do Celsius: ");
        input = Console.ReadLine();
        }
        // Công thức chuyển đổi
        double k = c + 273;
        double f = (c * 18 / 10) + 32;
        // Xuất kết quả
        Console.WriteLine($"{c} do Celsius = " + k +" Kelvin");
        Console.WriteLine($"{c} do Celsius = " + f +" Fahrenheit");

    }
    static void Tinhhinhcau() // Bài toán: Nhập bán kính hình cầu và tính diện tích bề mặt và thể tích
    {
        Console.Write("Hay nhap Radius: ");
        string input = Console.ReadLine();
        float radius = 0;

        // Lặp đến khi nhập đúng số
        while (!float.TryParse(input, out radius) || radius <= 0)
        {
            Console.Write("Hay nhap dung Radius: ");
            input = Console.ReadLine();
        }

        // Công thức tính
        double surface = 4 * Math.PI * Math.Pow(radius,2);
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius,3);

        // Xuất kết quả
        Console.WriteLine($"Radius = {radius}");
        Console.WriteLine($"Surface area = {surface}");
        Console.WriteLine($"Volume = {volume}");
    } 
    static void Congtrunhanchia() // Bài toán: Nhập hai số và thực hiện các phép tính cộng, trừ, nhân, chia, chia lấy dư
    {
        Console.Write("Hay nhap so thu nhat: ");
        string input1 = Console.ReadLine();
        float num1 = 0;
        // Lặp đến khi nhập đúng số
        while (!float.TryParse(input1, out num1))
        {
            Console.Write("Hay nhap lai so thu nhat: ");
            input1 = Console.ReadLine();
        }
        Console.Write("Hay nhap so thu hai (#0 de thuc hien phep chia): ");
        string input2 = Console.ReadLine();   
        float num2 = 1;
        // Lặp đến khi nhập đúng số
        while (!float.TryParse(input2, out num2) )
        {
            Console.Write("Hay nhap lai so thu hai: ");
            input2 = Console.ReadLine();
        }
        // Thực hiện các phép tính
        float tong = num1 + num2;
        float hieu = num1 - num2;
        float tich = num1 * num2;
        float thuong = num1/num2;
        float sodu = num1 % num2;
        // Xuất kết quả
        Console.WriteLine($"{num1} + {num2} = {tong}");
        Console.WriteLine($"{num1} - {num2} = {hieu}");
        Console.WriteLine($"{num1} x {num2} = {tich}");
        Console.WriteLine($"{num1} / {num2} = {thuong}");
        Console.WriteLine($"{num1} mod {num2} = {sodu}");
    }
    static void Hamso() // Bài toán: Với mỗi giá trị nguyên y từ -5 đến 5, tính giá trị hàm số x = y^2 + 2y + 1 và in kết quả
    {
        Console.WriteLine("Voi moi gia tri nguyen y tu -5 den 5 thi ham so x = y^2 + 2y + 1 co gia tri lan luot nhu sau");
        int y = -5; // bắt đầu từ -5
        while (y <= 5) // lặp đến 5
        {
            int x = (y * y) + (2 * y) + 1;
            Console.WriteLine($"Voi y= {y} thi x= {x}");
            y++; // tăng y lên 1
        }
    }
    static void Vantoc() // Bài toán: Nhập quãng đường (km) và thời gian (giờ, phút, giây), tính vận tốc (km/h và miles/h)
        {
            double distance; // quãng đường (km)
            int hours, minutes, seconds;

            // Nhập quãng đường
            Console.Write("Hay nhap khoang cach km: ");
            string khoangcach = Console.ReadLine();
            while (!double.TryParse(khoangcach, out distance) || distance < 0)
            {
                Console.Write("Hay nhap khoang cach hop le. Khoang cach km la: ");
                khoangcach = Console.ReadLine();
            }
            // Nhập giờ
            Console.Write("Hay nhap so gio: ");
            string gio = Console.ReadLine();
            while (!int.TryParse(gio, out hours) || hours < 0)
            {
                Console.Write("Hay nhap gio hop le. So gio la: ");
                gio = Console.ReadLine();
            }
            // Nhập phút
            Console.Write("Hay nhap so phut (0-59): ");
            string phut = Console.ReadLine();
            while (!int.TryParse(phut, out minutes) || minutes < 0 || minutes >= 60)
            {
                Console.Write("Hay nhap so phut hop le. So phut (0-59) la: ");
                phut = Console.ReadLine();
            }
            // Nhập giây
            Console.Write("Hay nhap so giay (0-59): ");
            string giay = Console.ReadLine();
            while (!int.TryParse(giay, out seconds) || seconds < 0 || seconds >= 60)
            {
                Console.Write("Hay nhap so giay hop le. So giay (0-59) la: ");
                giay = Console.ReadLine();
            }

            // Tính tổng thời gian tính bằng giờ
            double time = hours + (minutes / 60.0) + (seconds / 3600.0);

            if (time == 0)
            {
                Console.WriteLine("Thoi gian khong the = 0");
            }
            else
            {
                double speedKmh = distance / time;     // km/h
                double speedMph = speedKmh / 1.609;    // miles/h

                Console.WriteLine($"Voi khoang cach {distance} km va thoi gian {time} gio thi van toc la {speedKmh} km/h");
                Console.WriteLine($"Voi khoang cach {distance} km va thoi gian {time} gio thi van toc la {speedMph} miles/h");
            }
        }
    static void Kiemtrakytu() // Bài toán: Nhập một ký tự và kiểm tra xem đó là nguyên âm, chữ số hay ký hiệu khác
    {
        Console.Write("Nhap mot ky tu: ");
        string input = Console.ReadLine();

        // Kiểm tra nhập đúng 1 ký tự
        while (string.IsNullOrEmpty(input) || input.Length != 1)
        {
            Console.Write("Vui long nhap lai mot ky tu duy nhat: ");
            input = Console.ReadLine();
        }

        char ch = input[0]; // lấy ký tự đầu tiên

        // Kiểm tra nguyên âm (a, e, i, o, u)
        if ("aeiouAEIOU".Contains(ch))
        {
            Console.WriteLine($"{ch} la mot nguyen am.");
        }
        // Kiểm tra chữ số
        else if (char.IsDigit(ch))
        {
            Console.WriteLine($"{ch} la mot chu so.");
        }
        // Ngược lại là ký hiệu khác
        else
        {
            Console.WriteLine($"{ch} la mot ky hieu khac.");
        }

    }
}