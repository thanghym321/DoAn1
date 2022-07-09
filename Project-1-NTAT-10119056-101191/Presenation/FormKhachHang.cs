using System;
using System.Collections.Generic;
using System.Text;
using Project_1_NTAT_10119056_101191.BusinessLayer;

namespace Project_1_NTAT_10119056_101191.Presenation
{
    class FormKhachHang
    {
        private KhachHangBLL khBLL=new KhachHangBLL();

        public void MenuKhachHang()
        {
            do
            {
                Console.Clear();
                Console.SetCursorPosition(37, 8); Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.SetCursorPosition(37, 9); Console.WriteLine("║                QUẢN LÝ KHÁCH HÀNG              ║");
                Console.SetCursorPosition(37, 10); Console.WriteLine("╠══════╦═════════════════════════════════════════╣");
                Console.SetCursorPosition(37, 11); Console.WriteLine("║  F1  ║             HIỂN THỊ KHÁCH HÀNG         ║");
                Console.SetCursorPosition(37, 12); Console.WriteLine("╠══════╬═════════════════════════════════════════╣");
                Console.SetCursorPosition(37, 13); Console.WriteLine("║  F2  ║             NHẬP KHÁCH HÀNG             ║");
                Console.SetCursorPosition(37, 14); Console.WriteLine("╠══════╬═════════════════════════════════════════╣");
                Console.SetCursorPosition(37, 15); Console.WriteLine("║  F3  ║             SỬA KHÁCH HÀNG              ║");
                Console.SetCursorPosition(37, 16); Console.WriteLine("╠══════╬═════════════════════════════════════════╣");
                Console.SetCursorPosition(37, 17); Console.WriteLine("║  F4  ║             XÓA KHÁCH HÀNG              ║");
                Console.SetCursorPosition(37, 18); Console.WriteLine("╠══════╬═════════════════════════════════════════╣");
                Console.SetCursorPosition(37, 19); Console.WriteLine("║  F5  ║             TÌM KIẾM KHÁCH HÀNG         ║");
                Console.SetCursorPosition(37, 20); Console.WriteLine("╠══════╬═════════════════════════════════════════╣");
                Console.SetCursorPosition(37, 21); Console.WriteLine("║  F6  ║             QUAY LẠI                    ║");
                Console.SetCursorPosition(37, 22); Console.WriteLine("╚══════╩═════════════════════════════════════════╝");

                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.F1:
                        {
                            Console.Clear();
                            khBLL.HienKhachHang();
                            Console.SetCursorPosition(80, 27);
                            Console.WriteLine("Nhấn một phím bất kỳ để tiếp tục...");
                            Console.ReadKey();
                            break;
                        }
                    case ConsoleKey.F2:
                        {
                            Console.Clear();
                            khBLL.ThemKhachHang();
                            Console.SetCursorPosition(80, 27);
                            Console.WriteLine("Nhấn một phím bất kỳ để tiếp tục...");
                            Console.ReadKey();
                            break;
                        }
                    case ConsoleKey.F3:
                        {
                            Console.Clear();
                            khBLL.SuaKhachHang();
                            Console.SetCursorPosition(80, 27);
                            Console.WriteLine("Nhấn một phím bất kỳ để tiếp tục...");
                            Console.ReadKey();
                            break;
                        }
                    case ConsoleKey.F4:
                        {
                            Console.Clear();
                            khBLL.XoaKhachHang();
                            Console.SetCursorPosition(80, 27);
                            Console.WriteLine("Nhấn một phím bất kỳ để tiếp tục...");
                            Console.ReadKey();
                            break;
                        }
                    case ConsoleKey.F5:
                        {
                            Console.Clear();
                            khBLL.TimKhachHang();
                            Console.SetCursorPosition(80, 27);
                            Console.WriteLine("Nhấn một phím bất kỳ để tiếp tục...");
                            Console.ReadKey();
                            break;
                        }
                    case ConsoleKey.F6:
                        {
                            Menu menu = new Menu();
                            menu.MenuChinh();
                            break;
                        }
                }
            } while (true);
        }
    }
}
