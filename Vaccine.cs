using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalASM
{
    [Serializable]
    class Vaccine
    {
        private string MaVCC;
        private string TenVCC;
        private string NhaSX;
        private int NamSX;
        private string ThoiGianTacDung;

        public Vaccine()
        {

        }

        public Vaccine(string maVCC, string tenVCC, string nhaSX, int namSX, string thoiGianTacDung)
        {
            MaVCC1 = maVCC;
            TenVCC1 = tenVCC;
            NhaSX1 = nhaSX;
            NamSX1 = namSX;
            ThoiGianTacDung1 = thoiGianTacDung;
        }

        public string MaVCC1 { get => MaVCC; set => MaVCC = value; }
        public string TenVCC1 { get => TenVCC; set => TenVCC = value; }
        public string NhaSX1 { get => NhaSX; set => NhaSX = value; }
        public int NamSX1 { get => NamSX; set => NamSX = value; }
        public string ThoiGianTacDung1 { get => ThoiGianTacDung; set => ThoiGianTacDung = value; }

        public virtual void inRaManHinh()
        {
            Console.WriteLine("Phương thức của lớp cha inRaManHinh()");
        }
    }
}
