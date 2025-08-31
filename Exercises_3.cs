internal class Exercises3
{
    private static void Main(string[] args)
    {
        game_engine();
        dice_game();
    }
    static void game_engine()
    {
    Console.WriteLine("Chao mung ban den voi tro choi doan so");
        // [THÊM] Khởi tạo tiền quỹ và thống kê
        int tienQuy = 100;
        int soTranThang = 0;
        int soTranThua = 0;
        do
        {
            Console.WriteLine($"\nTien hien tai: {tienQuy}$");
            if (tienQuy <= 0)
            {
                Console.WriteLine("Ban da het tien! Tro choi ket thuc.");
                break;
            }
            Console.WriteLine("Level:\n\tKho: 4 lan choi\n\tTrung bình: 7 lan choi\n\tDe: 10 lan choi");
            int level = 0;
            string input;
            // Lặp cho đến khi nhập đúng 1, 2 hoặc 3
            do
            {
                Console.Write("Ban chon level nao? [1-Kho ; 2-Trung binh ; 3-De]: ");
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out level) || level < 1 || level > 3);

            // Gán số lần chơi theo level
            int solanchoi = (level == 1) ? 4 : (level == 2) ? 7 : 10;
            //Xác định tiền thưởng/thua theo level
            int tienThang = (level == 1) ? 4 : (level == 2) ? 7 : 10;
            int tienThua = tienThang;
            //máy tính nghĩ ra 1 số ngẫu nhiên từ 1-100
            Random rnd = new Random(); //công cụ nghĩ ra số ngẫu nhiên
            int comp_num = rnd.Next(0, 100) + 1; //[1,10]
            //biến nghĩ lưu trữ trạng thái thua hay thắng
            bool is_won = false;
            //yêu cầu người dùng đoán số
            for (int i = 0; i < solanchoi; i++)
                {
                    int man_num = 0;
                    do
                    {
                        Console.Write($"{i + 1}. Ban doan so may [1-100]: ");
                        string in1 = Console.ReadLine();
                    }
                    while (!int.TryParse(in1, out man_num) || man_num < 1 || man_num > 100);
                    if (man_num == comp_num)
                {
                    is_won = true;
                    break; //thoát khỏi vòng lặp
                }
                else
                {
                    //gợi ý người dùng số bạn đoán nhỏ hơn hay lớn hơn số máy tính nghĩ
                    if (man_num > comp_num)
                    {
                        Console.WriteLine("So ban doan lon hon so may tinh nghi");
                    }
                    else
                    {
                        Console.WriteLine("So ban doan nho hon so may tinh nghi");
                    }
                }
            }
            if (is_won)
            {
                Console.WriteLine($"Chuc mung! Ban da doan dung so {comp_num}");
                tienQuy += tienThang;
                soTranThang++;
            }
            else
            {
                Console.WriteLine($"May nghi ra so {comp_num}. Phuc khong!");
                tienQuy -= tienThua;
                soTranThua++;
            }

            if (tienQuy <= 0)
            {
                Console.WriteLine("Ban da het tien! Tro choi ket thuc.");
                break;
            }
            //sau mỗi ván chơi, hỏi người chơi có muốn chơi lại không? (c/k)
            Console.Write("Ban co muon choi lai khong? [c/k]: ");
            string tl = Console.ReadLine();
            if (tl.ToLower().Equals("k"))
            {
                Console.WriteLine("Cam on ban da choi tro choi!");
                break; //thoát khỏi vòng lặp do-while
            }
        } while (true); //vòng lặp vô hạn
        //In thống kê cuối
        Console.WriteLine("\n=== Thong ke ket qua ===");
        Console.WriteLine($"So tran thang: {soTranThang}");
        Console.WriteLine($"So tran thua: {soTranThua}");
        Console.WriteLine($"So tien con lai: {tienQuy}$");
    }
    static void dice_game()
    {
        int money = 100;
        int winCount = 0;
        int loseCount = 0;

        Console.WriteLine("=== TRO CHOI TAI XIU ===");
        Console.WriteLine("Ban dau ban co 100$");

        do
        {
            Console.WriteLine($"\nSo tien hien tai: {money}$");

            // Máy tính gieo xúc sắc
            Random rnd = new Random();
            int die1 = rnd.Next(6) + 1;
            int die2 = rnd.Next(6) + 1;
            int pair_of_dice = die1 + die2;

            // Hỏi người chơi đoán
            string choice;
            do
            {
                Console.Write("Ban doan gi? (tai/xiu/5): ");
                choice = Console.ReadLine().ToLower();
            } while (choice != "tai" && choice != "xiu" && choice != "5");

            string result;
            if (pair_of_dice > 5) result = "tai";
            else if (pair_of_dice < 5) result = "xiu";
            else result = "5";

            Console.WriteLine($"Xuc sac: {die1} + {die2} = {pair_of_dice} -> {result.ToUpper()}");

            // Xử lý thắng/thua
            if (choice == result)
            {
                if (result == "5")
                {
                    money += 15;
                    Console.WriteLine("Chuc mung! Ban doan dung 5. +15$");
                }
                else
                {
                    money += 5;
                    Console.WriteLine("Chuc mung! Ban doan dung. +5$");
                }
                winCount++;
            }
            else
            {
                money -= 5;
                Console.WriteLine("Rat tiec! Ban doan sai. -5$");
                loseCount++;
            }

            // Kiểm tra hết tiền
            if (money <= 0)
            {
                Console.WriteLine("\nBan da het tien! Tro choi ket thuc.");
                break;
            }

            // Hỏi có chơi tiếp không
            Console.Write("\nBan co muon choi tiep khong? (c/k): ");
            string tl = Console.ReadLine();
            if (tl.ToLower().Equals("k"))
            {
                Console.WriteLine("Bye, hen gap lai!");
                break;
            }

        } while (true);

        // Báo cáo tổng hợp
        Console.WriteLine("\n=== BAO CAO TONG HOP ===");
        Console.WriteLine($"So tran thang: {winCount}");
        Console.WriteLine($"So tran thua: {loseCount}");
        Console.WriteLine($"So tien con lai: {money}$");
    }
}
