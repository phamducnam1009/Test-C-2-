using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinalASM
{
    class VnVaccineService
    {
        private List<VnVaccine> _lstvnVaccines;
        private VnVaccine _vnVaccines;
        private string _input;
        private FileStream _fs;
        private BinaryFormatter _bf;
        private string _path = @"C:\Users\Hiep\Desktop\c#\FinalASM\FinalASM\Data.bin";
        public bool _exit;

        public VnVaccineService()
        {
            _lstvnVaccines = new List<VnVaccine>();
        }

        public void Fake10VC()
        {
            _lstvnVaccines = new List<VnVaccine>();
            VnVaccine vc1 = new VnVaccine("VC1", "Vaccine 1", "Việt Nam", 2021, "2 năm", "Astra", 18, "Vaccine ok");
            VnVaccine vc2 = new VnVaccine("VC2", "Vaccine 2", "Anh", 2021, "1 năm", "Alpha", 18, "Vaccine đã test");
            VnVaccine vc3 = new VnVaccine("VC3", "Vaccine 3", "Pháp", 2020, "6 tháng", "Delta", 18, "Vaccine đạt");
            VnVaccine vc4 = new VnVaccine("VC4", "Vaccine 4", "Mỹ", 2021, "1 năm", "Mega", 18, "Vaccine ok");
            VnVaccine vc5 = new VnVaccine("VC5", "Vaccine 5", "Trung Quốc", 2020, "1 năm", "Astra", 18, "Vaccine đã test");
            VnVaccine vc6 = new VnVaccine("VC6", "Vaccine 6", "Việt Nam", 2021, "1 năm", "Norin", 18, "Vaccine ok");
            VnVaccine vc7 = new VnVaccine("VC7", "Vaccine 7", "Thái Lan", 2020, "2 năm", "Alex", 18, "Vaccine ổn");
            VnVaccine vc8 = new VnVaccine("VC8", "Vaccine 8", "Việt Nam", 2021, "6 tháng", "Astra", 18, "Vaccine ok");
            VnVaccine vc9 = new VnVaccine("VC9", "Vaccine 9", "Lào", 2020, "1 năm", "Flex", 18, "Vaccine đạt");
            VnVaccine vc10 = new VnVaccine("VC10", "Vaccine 10", "Ấn Độ", 2021, "6 tháng", "Astra", 18, "Vaccine ok");
            _lstvnVaccines.Add(vc1);
            _lstvnVaccines.Add(vc2);
            _lstvnVaccines.Add(vc3);
            _lstvnVaccines.Add(vc4);
            _lstvnVaccines.Add(vc5);
            _lstvnVaccines.Add(vc6);
            _lstvnVaccines.Add(vc7);
            _lstvnVaccines.Add(vc8);
            _lstvnVaccines.Add(vc9);
            _lstvnVaccines.Add(vc10);
        }

        public void addVC()
        {
            Console.WriteLine("Bạn muốn thêm bao nhiêu Vaccine: ");
            _input = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(_input); i++)
            {
                _vnVaccines = new VnVaccine();
                Console.WriteLine("Mời bạn nhập mã Vaccine: ");
                _vnVaccines.MaVCC1 = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập tên Vaccine: ");
                _vnVaccines.TenVCC1 = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập nhà sản xuất: ");
                _vnVaccines.NhaSX1 = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập năm sản xuất: ");
                _vnVaccines.NamSX1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập TGTD: ");
                _vnVaccines.ThoiGianTacDung1 = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập công nghệ: ");
                _vnVaccines.CongNghe1 = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập tuổi được tiêm: ");
                _vnVaccines.TuoiDuocPhepTiem1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập ghi chú: ");
                _vnVaccines.GhiChu1 = Console.ReadLine();
                _lstvnVaccines.Add(_vnVaccines);
            }
            _exit = false;
        }
        public string editVC(VnVaccine vnvaccine)
        {
            if (vnvaccine != null)
            {
                for (int i = 0; i < _lstvnVaccines.Count; i++)
                {
                    if (_lstvnVaccines[i].MaVCC1.ToLower() == vnvaccine.MaVCC1.ToLower())
                    {
                        _lstvnVaccines[i] = vnvaccine;
                    }
                }
                return "Sửa thành công";
                _exit = false;
            }
            return "Sửa không thành công";
        }
        public string removeVC(string maVC)
        {
            _vnVaccines = _lstvnVaccines.FirstOrDefault(c => c.MaVCC1.ToLower() == maVC.ToLower());
            if (_vnVaccines != null)
            {
                _lstvnVaccines.Remove(_vnVaccines);
                return "Xóa thành công";
                _exit = false;
            }
            return "Xóa không thành công";
        }
        public void findVC(string ten)
        {
            foreach (var x in _lstvnVaccines.Where(c => c.TenVCC1.ToLower().StartsWith(ten.ToLower())))
            {
                x.inRaManHinh();
            }
        }

        public void filterVC()
        {
            Console.WriteLine("Lọc Vaccine");
            Console.WriteLine("1.Theo thời gian tác dụng");
            Console.WriteLine("2.Tên theo bảng chữ cái");
            Console.WriteLine("3.Theo độ tuổi được phép tiêm");
            _input = Console.ReadLine();
            switch (_input)
            {
                case "1":
                    Console.WriteLine("Mời bạn nhập giờ cần lọc: ");
                    _input = Console.ReadLine();
                    foreach (var x in _lstvnVaccines.Where(c=>c.ThoiGianTacDung1.StartsWith(_input)))
                    {
                        x.inRaManHinh();
                    }
                    break;
                case "2":
                    Console.WriteLine("Mời bạn nhập tên theo bảng chữ cái cần lọc: ");
                    _input = Console.ReadLine();
                    foreach (var x in _lstvnVaccines.Where(c=>c.TenVCC1.ToLower().StartsWith(_input)))
                    {
                        x.inRaManHinh();
                    }
                    break;
                case "3":
                    Console.WriteLine("Mời bạn nhập tuổi được phép tiêm cần lọc: ");
                    _input = Console.ReadLine();
                    foreach (var x in _lstvnVaccines.Where(c => c.TuoiDuocPhepTiem1.ToString().StartsWith(_input)))
                    {
                        x.inRaManHinh();
                    }
                    break;
            }
        }

        public void SaveFile()
        {
            try
            {
                _fs = new FileStream(_path, FileMode.Create);
                _bf = new BinaryFormatter();
                _bf.Serialize(_fs, _lstvnVaccines);
                _fs.Close();
                Console.WriteLine("Save file thành công");
                _exit = true;
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Save thất bại");
        }

        public void OpenFile()
        {
            try
            {
                _fs = new FileStream(_path, FileMode.Open);
                _bf = new BinaryFormatter();
                var data = _bf.Deserialize(_fs);
                _lstvnVaccines = new List<VnVaccine>();
                _lstvnVaccines = (List<VnVaccine>)data;
                _fs.Close();
                Console.WriteLine("Open file thành công");
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Open file thất bại");
        }

        public void getLstVC()
        {
            var sxVC = from a in _lstvnVaccines orderby a.NhaSX1 select a;
            foreach (var x in sxVC)
            {
                x.inRaManHinh();
            }
        }
        public VnVaccine inputDataVC()
        {
            _vnVaccines = new VnVaccine();
            Console.WriteLine("Mời bạn nhập mã Vaccine: ");
            _vnVaccines.MaVCC1 = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập tên Vaccine: ");
            _vnVaccines.TenVCC1 = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập nhà sản xuất: ");
            _vnVaccines.NhaSX1 = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập năm sản xuất: ");
            _vnVaccines.NamSX1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập TGTD: ");
            _vnVaccines.ThoiGianTacDung1 = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập công nghệ: ");
            _vnVaccines.CongNghe1 = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập tuổi được tiêm: ");
            _vnVaccines.TuoiDuocPhepTiem1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập ghi chú: ");
            _vnVaccines.GhiChu1 = Console.ReadLine();
            return _vnVaccines;
        }
    }
}
