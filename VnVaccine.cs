using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalASM
{
    [Serializable]
    class VnVaccine:Vaccine
    {
        private string CongNghe;
        private int TuoiDuocPhepTiem;
        private string GhiChu;

        public VnVaccine()
        {

        }

        public VnVaccine(string maVCC, string tenVCC, string nhaSX, int namSX, string thoiGianTacDung, string congNghe,
            int tuoiDuocPhepTiem, string ghiChu) : base(maVCC, tenVCC, nhaSX, namSX, thoiGianTacDung)
        {
            CongNghe1 = congNghe;
            TuoiDuocPhepTiem1 = tuoiDuocPhepTiem;
            GhiChu1 = ghiChu;
        }

        public string CongNghe1 { get => CongNghe; set => CongNghe = value; }
        public int TuoiDuocPhepTiem1 { get => TuoiDuocPhepTiem; set => TuoiDuocPhepTiem = value; }
        public string GhiChu1 { get => GhiChu; set => GhiChu = value; }

        public override void inRaManHinh()
        {
            Console.WriteLine("Mã VC: {0} | Tên VC: {1} | Nhà SX: {2} | NamSX: {3} | TGTD: {4} | " +
                "Công nghệ: {5} | Tuổi được phép: {6} | Ghi chú: {7}",MaVCC1,TenVCC1,NhaSX1,NamSX1,ThoiGianTacDung1,
                CongNghe,TuoiDuocPhepTiem,GhiChu);
        }
    }
}
