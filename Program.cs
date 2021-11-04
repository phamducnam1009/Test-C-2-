using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalASM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            VnVaccineService vnvc = new VnVaccineService();
            while (true)
            {
                Console.WriteLine("Chương trình quản lý Vaccine");
                Console.WriteLine("1.Fake 10 loại Vaccine");
                Console.WriteLine("2.Thêm Vaccine");
                Console.WriteLine("3.Sửa Vaccine");
                Console.WriteLine("4.Xóa Vaccine");
                Console.WriteLine("5.In Vaccine");
                Console.WriteLine("6.Lọc Vaccine");
                Console.WriteLine("7.Tìm kiếm Vaccine");
                Console.WriteLine("8.Lưu file");
                Console.WriteLine("9.Đọc file");
                Console.WriteLine("0.Thoát");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        vnvc.Fake10VC();
                        break;
                    case "2":
                        vnvc.addVC();
                        break;
                    case "3":
                        Console.WriteLine("Mời bạn nhập mã Vaccine cần sửa: ");
                        input = Console.ReadLine();
                        VnVaccine vcCanSua = vnvc.inputDataVC();
                        vcCanSua.MaVCC1 = input;
                        Console.WriteLine(vnvc.editVC(vcCanSua));
                        break;
                    case "4":
                        Console.WriteLine("Mời bạn nhập mã Vaccine cần xóa: ");
                        input = Console.ReadLine();
                        Console.WriteLine(vnvc.removeVC(input));
                        break;
                    case "5":
                        vnvc.getLstVC();
                        break;
                    case "6":
                        vnvc.filterVC();
                        break;
                    case "7":
                        Console.WriteLine("Mời bạn nhập tên Vaccine: ");
                        input = Console.ReadLine();
                        vnvc.findVC(input);
                        break;
                    case "8":
                        vnvc.SaveFile();
                        break;
                    case "9":
                        vnvc.OpenFile();
                        break;
                    case "0":                       
                        if (vnvc._exit == true)
                        {
                            System.Environment.Exit(0);
                        }    
                        else
                        {
                            Console.WriteLine("Bạn chưa lưu file , có chắc chắn thoát?(c/k)");
                            string input1 = Console.ReadLine();
                            if(input1 == "c" || input1 == "C")
                            {
                                System.Environment.Exit(0);
                            }
                            else
                            {
                                vnvc.SaveFile();
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Bạn nhập sai chức năng, chọn lại: ");
                        break;
                }
            }                
        }
    }
}
