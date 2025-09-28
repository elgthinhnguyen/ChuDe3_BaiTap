using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuDe3_BaiTap_2312756_NguyenHungThinh
{
    public class SinhVien
    {
        public string HoVaTenLot { get; set; }
        public string Ten { get;set; }
        public string Lop { get; set; } 
        public DateTime NgaySinh { get; set; }
        public string DiaChi {  get; set; }
        public string GioiTinh { get; set; }
        public string SoCMND { get;set; }
        public string MSSV { get; set; }    
        public string SoDT { get; set; }
        public string[] MonHoc { get; set; }
        public override string ToString()
        {
            return $"{HoVaTenLot} {Ten} {Lop} " +
                   $"{NgaySinh:yyyy-MM-dd} {DiaChi} {GioiTinh} " +
                   $"{SoCMND} {MSSV} {SoDT} " +
                   $"{MonHoc[0]},{MonHoc[1]},{MonHoc[2]}";
        }
        public static SinhVien FromString(string line)
        {
            var parts = line.Split(' ');
            return new SinhVien
            {
                HoVaTenLot = parts[0] + " " + parts[1],   // VD: Nguyen Hung
                Ten = parts[2],                           // VD: Thinh
                Lop = parts[3],                           // CNTT1
                NgaySinh = DateTime.Parse(parts[4]),      // 02-11-2002
                DiaChi = parts[5],                        // Quan1_TPHCM
                GioiTinh = parts[6],                      // Nam/Nu
                SoCMND = parts[7],
                MSSV = parts[8],
                SoDT = parts[9]

            };
        }
    }

}
