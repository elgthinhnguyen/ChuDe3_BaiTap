using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace ChuDe3_BaiTap_2312756_NguyenHungThinh
{
    public class QuanLySinhVien
    {
        public List<SinhVien> DocSV(string path)
        {
            string[] parts = path.Split('.');
            switch (parts[1])
            {
                
                case "txt":
                    return DocSVtxt(path);
                    
                case "xml":

                    return DocFileXML(path);
                    
                case "json":
                    return DocFileJSON(path);
                default:
                    MessageBox.Show("Không đúng định dạng");
                    return null;

            }

        }
        public List<SinhVien> DocSVtxt(string path)
        {
            List<SinhVien> DSSV = new List<SinhVien>();

            if (!File.Exists(path)) return DSSV;

            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] parts = line.Split(' ');
                SinhVien sv = new SinhVien
                {
                    HoVaTenLot = parts[0] + " " + parts[1],
                    Ten = parts[2],
                    Lop = parts[3],
                    NgaySinh = DateTime.Parse(parts[4]),
                    DiaChi = parts[5],
                    GioiTinh = parts[6],
                    SoCMND = parts[7],
                    MSSV = parts[8],
                    SoDT = parts[9],
                    MonHoc = parts.Length > 10 ? parts[10].Split(',') : new string[0]
                };
                DSSV.Add(sv);
            }
            return DSSV;
        }
        public List<SinhVien> DocFileXML(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Không tìm thấy file XML!", filePath);

            XmlSerializer serializer = new XmlSerializer(typeof(List<SinhVien>),
                                    new XmlRootAttribute("ListOfSinhVien"));

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                return (List<SinhVien>)serializer.Deserialize(fs);
            }
        }
        public List<SinhVien> DocFileJSON(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Không tìm thấy file JSON!", filePath);

            string jsonData = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<SinhVien>>(jsonData);
        }

        public bool KiemTraMSSVTrung(string filePath, string mssv)
        {
            if (!File.Exists(filePath)) return false;
            List<SinhVien> DSSV = DocSV(filePath);
            foreach (var sv in DSSV)
            {
                if (string.IsNullOrWhiteSpace(sv.MSSV)) continue;
                
                if (sv.MSSV == (mssv)) return true;
            }
            return false;
        }

        public bool ThemSinhVienVaoFile(string filePath, SinhVien sv)
        {
            if (KiemTraMSSVTrung(filePath, sv.MSSV)) return false;

            List<SinhVien> DSSV = DocSV(filePath);
            DSSV.Add(sv);
            GhiDanhSachSinhVien(filePath, DSSV);
            return true;
        }

        public void CapNhatSinhVien(SinhVien svCapNhat, string filePath)
        {
            List<SinhVien> DSSV = DocSV(filePath);
            SinhVien sv = DSSV.FirstOrDefault(s => s.MSSV == svCapNhat.MSSV);
            if (sv != null)
            {
                sv.HoVaTenLot = svCapNhat.HoVaTenLot;
                sv.Ten = svCapNhat.Ten;
                sv.Lop = svCapNhat.Lop;
                sv.NgaySinh = svCapNhat.NgaySinh;
                sv.DiaChi = svCapNhat.DiaChi;
                sv.GioiTinh = svCapNhat.GioiTinh;
                sv.SoCMND = svCapNhat.SoCMND;
                sv.SoDT = svCapNhat.SoDT;
                sv.MonHoc = svCapNhat.MonHoc;
            }

            GhiDanhSachSinhVien(filePath, DSSV);
        }
        public void GhiDanhSachSinhVienXML(string filePath, List<SinhVien> danhSach)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<SinhVien>));
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(fs, danhSach);
            }
        }
        public void GhiDanhSachSinhVienJSON(string filePath, List<SinhVien> danhSach)
        {
            string jsonData = JsonConvert.SerializeObject(danhSach, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }
        public void GhiDanhSachSinhVienTXT(string filePath, List<SinhVien> danhSach)
        { 
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                foreach (SinhVien sv in danhSach)
                {

                    sw.WriteLine(sv.ToString());
                }
            }
        }

        public void GhiDanhSachSinhVien(string filePath, List<SinhVien> danhSach)
        {
            string[] parts = filePath.Split('.');
            switch (parts[1])
            {

                case "txt":
                    GhiDanhSachSinhVienTXT(filePath,danhSach);
                    break;
                case "xml":
                    GhiDanhSachSinhVienXML(filePath, danhSach);
                    break;
                case "json":
                    GhiDanhSachSinhVienJSON(filePath, danhSach);
                    break;
                default:
                    MessageBox.Show("Không đúng định dạng");
                    break;

            }
        }

        public void XoaTheoMSSV(string filePath, string mssv)
        {
            List<SinhVien> DSSV = DocSVtxt(filePath);
            DSSV = DSSV.Where(s => s.MSSV != mssv).ToList();

            GhiDanhSachSinhVien(filePath, DSSV);
        }
        public void XuatFileTheoDuongDan(List<SinhVien> danhSach)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Chọn nơi lưu file";
            sfd.Filter = "Text file (*.txt)|*.txt|JSON file (*.json)|*.json|XML file (*.xml)|*.xml";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                string extension = Path.GetExtension(path).ToLower();

                // Tạo file mới (nếu có rồi thì ghi đè để đảm bảo sạch sẽ)
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                switch (extension)
                {
                    case ".txt":
                        GhiDanhSachSinhVienTXT(path, danhSach);
                        break;

                    case ".json":
                        GhiDanhSachSinhVienJSON(path, danhSach);
                        break;

                    case ".xml":
                        GhiDanhSachSinhVienXML(path, danhSach);
                        break;

                    default:
                        MessageBox.Show("Không hỗ trợ định dạng này!");
                        return;
                }

                MessageBox.Show($"Đã lưu file thành công tại:\n{path}");
            }
        }

    }
}

