using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
        
        public string[] MonHoc = new string[8];
        public override string ToString()
        {
            return $"{HoVaTenLot} {Ten} {Lop} " +
                   $"{NgaySinh:yyyy-MM-dd} {DiaChi} {GioiTinh} " +
                   $"{SoCMND} {MSSV} {SoDT} " +
                   $"{string.Join(",", MonHoc)}";
        }
        
    }

}
