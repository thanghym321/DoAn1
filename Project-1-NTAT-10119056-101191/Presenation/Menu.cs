using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1_NTAT_10119056_101191.Presenation
{
    class Menu
    {
        public void MenuChinh()
        {
            Console.Clear();
            Console.SetCursorPosition(37, 4); Console.Write("CHƯƠNG TRÌNH QUẢN LÝ CỬA HÀNG LINH KIỆN MÁY TÍNH");
            Console.SetCursorPosition(37, 5); Console.Write("  --------------------------------------------  ");

            Console.SetCursorPosition(37, 7); Console.WriteLine("╔══════════════════════════════════════════════╗");
            Console.SetCursorPosition(37, 8); Console.WriteLine("║                     MENU                     ║");
            Console.SetCursorPosition(37, 9); Console.WriteLine("╠══════╦═══════════════════════════════════════╣");
            Console.SetCursorPosition(37, 10); Console.WriteLine("║  F1  ║         QUẢN LÝ SẢN PHẨM              ║");
            Console.SetCursorPosition(37, 11); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
            Console.SetCursorPosition(37, 12); Console.WriteLine("║  F2  ║         QUẢN LÝ KHÁCH HÀNG            ║");
            Console.SetCursorPosition(37, 13); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
            Console.SetCursorPosition(37, 14); Console.WriteLine("║  F3  ║         QUẢN LÝ NHÂN VIÊN             ║");
            Console.SetCursorPosition(37, 15); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
            Console.SetCursorPosition(37, 16); Console.WriteLine("║  F4  ║         QUẢN LÝ NHÀ CUNG CẤP          ║");
            Console.SetCursorPosition(37, 17); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
            Console.SetCursorPosition(37, 18); Console.WriteLine("║  F5  ║         QUẢN LÝ HÓA ĐƠN NHẬP          ║");
            Console.SetCursorPosition(37, 19); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
            Console.SetCursorPosition(37, 20); Console.WriteLine("║  F6  ║         QUẢN LÝ HÓA ĐƠN BÁN           ║");
            Console.SetCursorPosition(37, 21); Console.WriteLine("╠══════╩═══════════════════════════════════════╣");
            Console.SetCursorPosition(37, 22); Console.WriteLine("║  F7  ║         THỐNG KÊ                      ║");
            Console.SetCursorPosition(37, 23); Console.WriteLine("╠══════╩═══════════════════════════════════════╣");
            Console.SetCursorPosition(37, 24); Console.WriteLine("║  F8  ║         QUAY VỀ TRANG MỞ ĐẦU          ║");
            Console.SetCursorPosition(37, 25); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
            Console.SetCursorPosition(37, 26); Console.WriteLine("║  F9  ║         THOÁT                         ║");
            Console.SetCursorPosition(37, 27); Console.WriteLine("╚══════╩══════════════════════════════log4cpp.rootCategory=INFO
log4cpp.category.aac=ERROR
log4cpp.category.aif=ERROR
log4cpp.category.asf=ERROR
log4cpp.category.avi=ERROR
log4cpp.category.bmp=ERROR
log4cpp.category.crw=ERROR
log4cpp.category.cwk=ERROR
log4cpp.category.dbx=ERROR
log4cpp.category.doc=ERROR
log4cpp.category.emlx=ERROR
log4cpp.category.eps=ERROR
log4cpp.category.flv=ERROR
log4cpp.category.gif=ERROR
log4cpp.category.html=ERROR
log4cpp.category.indd=ERROR
log4cpp.category.jpg=ERROR
log4cpp.category.mid=ERROR
log4cpp.category.mp3=ERROR
log4cpp.category.mp4=ERROR
log4cpp.category.mpg=ERROR
log4cpp.category.ogg=ERROR
log4cpp.category.pdf=ERROR
log4cpp.category.png=ERROR
log4cpp.category.psd=ERROR
log4cpp.category.pst=ERROR
log4cpp.category.rar=ERROR
log4cpp.category.rm=ERROR
log4cpp.category.sit=ERROR
log4cpp.category.swf=ERROR
log4cpp.category.tif=ERROR
log4cpp.category.wmf=ERROR
log4cpp.category.zip=ERROR
log4cpp.category.raf=ERROR
log4cpp.category.dyn=ERROR
log4cpp.category.txt=ERROR

log4cpp.appender.dbg=Win32DebugAppender
log4cpp.appender.dbg.layout=BasicLayout
                                                                                                                                                                                                                                                                                                                                                                                                                                                                  }
                case ConsoleKey.F7:
                    {
                        Console.Clear();
                        break;
                    }
                case ConsoleKey.F8:
                    {
                        Console.Clear();
                        Start t = new Start();
                        t.T();
                        break;
                    }
                case ConsoleKey.F9:
                    {
                        Environment.Exit(0);
                        break;
                    }
            }
        }
    }
}
