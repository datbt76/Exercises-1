using System;

class ChuongTrinh
{
    // khoi tao mang jagged
    static object[][][] nhom = new object[3][][];

    static void KhoiTao()
    {
        nhom[0] = new object[5][];
        nhom[1] = new object[3][];
        nhom[2] = new object[6][];

        nhom[0][0] = new object[] { 101, "Nguyen Van A", 12 };
        nhom[0][1] = new object[] { 102, "Tran Van B", 9 };
        nhom[0][2] = new object[] { 103, "Le Thi C", 15 };
        nhom[0][3] = new object[] { 104, "Pham Van D", 7 };
        nhom[0][4] = new object[] { 105, "Vo Thi E", 10 };

        nhom[1][0] = new object[] { 201, "Hoang Van F", 14 };
        nhom[1][1] = new object[] { 202, "Nguyen Thi G", 11 };
        nhom[1][2] = new object[] { 203, "Tran Van H", 8 };

        nhom[2][0] = new object[] { 301, "Pham Van I", 13 };
        nhom[2][1] = new object[] { 302, "Nguyen Van J", 16 };
        nhom[2][2] = new object[] { 303, "Tran Thi K", 6 };
        nhom[2][3] = new object[] { 304, "Le Van L", 18 };
        nhom[2][4] = new object[] { 305, "Nguyen Thi M", 5 };
        nhom[2][5] = new object[] { 306, "Vo Van N", 20 };
    }

    static void InTatCa()
    {
        for (int i = 0; i < nhom.Length; i++)
        {
            Console.WriteLine("Nhom " + (i + 1));
            for (int j = 0; j < nhom[i].Length; j++)
            {
                Console.WriteLine("ID: " + nhom[i][j][0] +
                                  " Ten: " + nhom[i][j][1] +
                                  " So cong viec: " + nhom[i][j][2]);
            }
        }
    }

    static void TimTheoID(int id)
    {
        for (int i = 0; i < nhom.Length; i++)
        {
            for (int j = 0; j < nhom[i].Length; j++)
            {
                if ((int)nhom[i][j][0] == id)
                {
                    Console.WriteLine("Tim thay: ID " + nhom[i][j][0] +
                                      " Ten: " + nhom[i][j][1] +
                                      " So cong viec: " + nhom[i][j][2]);
                    return;
                }
            }
        }
        Console.WriteLine("Khong tim thay thanh vien co ID " + id);
    }

    static void TimNhieuNhat()
    {
        object[] max = null;
        for (int i = 0; i < nhom.Length; i++)
        {
            for (int j = 0; j < nhom[i].Length; j++)
            {
                if (max == null || (int)nhom[i][j][2] > (int)max[2])
                {
                    max = nhom[i][j];
                }
            }
        }
        Console.WriteLine("Thanh vien lam nhieu nhat: ID " + max[0] +
                          " Ten: " + max[1] +
                          " So cong viec: " + max[2]);
    }

    static void Main()
    {
        KhoiTao();
        int chon;
        do
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1. In tat ca thanh vien");
            Console.WriteLine("2. Tim thanh vien theo ID");
            Console.WriteLine("3. Tim nguoi lam nhieu nhat");
            Console.WriteLine("0. Thoat");
            Console.Write("Nhap lua chon: ");
            chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1: InTatCa(); break;
                case 2:
                    Console.Write("Nhap ID: ");
                    int id = int.Parse(Console.ReadLine());
                    TimTheoID(id);
                    break;
                case 3: TimNhieuNhat(); break;
                case 0: Console.WriteLine("Thoat chuong trinh"); break;
                default: Console.WriteLine("Lua chon sai"); break;
            }
        } while (chon != 0);
    }
}
