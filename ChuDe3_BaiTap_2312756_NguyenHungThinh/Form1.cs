using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

namespace ChuDe3_BaiTap_2312756_NguyenHungThinh
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();
            frm.ShowDialog();
        }

        public List<SinhVien> DocSVtxt(string path)
        {
            List<SinhVien> DSSV = new List<SinhVien> { };
            
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                SinhVien sv = new SinhVien();
                string[] parts = line.Split(' ');
                sv.HoVaTenLot = parts[0] + ' ' +parts[1];
                sv.Ten = parts[2];
                sv.Lop = parts[3];
                sv.NgaySinh = DateTime.Parse(parts[4]);
                sv.DiaChi = parts[5];
                sv.GioiTinh = parts[6];
                sv.SoCMND = parts[7];
                sv.MSSV = parts[8];
                sv.SoDT = parts[9];
                sv.MonHoc = parts[10].Split(',');
                DSSV.Add(sv);

            }
           return DSSV;
        }

        public bool KiemTraMSSVTrung(string filePath, string mssv)
        {
            if (!File.Exists(filePath)) return false;
            foreach (var line in File.ReadAllLines(filePath))
            {
                if (line.StartsWith("HoVaTenLot")) continue;
                string[] parts = line.Split(' ');
                if (parts.Contains(mssv)) return true;
                
            }
            return false;
        }

        public bool ThemSinhVienVaoFile(string filePath, SinhVien sv)
        {
            if (KiemTraMSSVTrung(filePath, sv.MSSV)) return false;
            string line = $"{sv.HoVaTenLot} {sv.Ten} {sv.Lop} {sv.NgaySinh:dd/MM/yyyy} " +
                          $"{sv.DiaChi} {sv.GioiTinh} {sv.SoCMND} {sv.MSSV} {sv.SoDT}";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(line);
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<SinhVien> DSSV = DocSVtxt("students.txt");
            dgvSinhVien.DataSource = DSSV;


        }
        private bool KiemTraTxtTrong()
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text) ||
                string.IsNullOrWhiteSpace(mtxtSoDT.Text) ||
                string.IsNullOrWhiteSpace(mtxtMSSV.Text) ||
                string.IsNullOrWhiteSpace(mtxtSoCMND.Text) ||
                string.IsNullOrWhiteSpace(txtHoLot.Text) ||
                string.IsNullOrWhiteSpace(dtpNgaySinh.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(cbLop.Text)
                )
                return true;
            else return false;

        }

        private void dgvSinhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mtxtSoDT.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtxtMSSV.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtxtSoCMND.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            for (int i = 0; i < clbMonHoc.Items.Count; i++)
            {
                
                    clbMonHoc.SetItemChecked(i, false);
            }

            DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
            txtHoLot.Text = row.Cells["HoVaTenLot"].Value.ToString();
            txtTen.Text = row.Cells["Ten"].Value.ToString();
            cbLop.Text = row.Cells["Lop"].Value.ToString();
            dtpNgaySinh.Text = Convert.ToDateTime(row.Cells["NgaySinh"].Value).ToString("MM/dd/yyyy");
            txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            mtxtSoCMND.Text = row.Cells["SoCMND"].Value.ToString();
            mtxtMSSV.Text = row.Cells["MSSV"].Value.ToString();           
            mtxtSoDT.Text = row.Cells["SoDT"].Value.ToString();
            if (row.Cells["GioiTinh"].Value.ToString()== "Nam")
            {
                rbNam.Checked = true;
            }
            else
                rbNu.Checked = true;

            List<SinhVien> ds = (List<SinhVien>)dgvSinhVien.DataSource;
            foreach(var sv in ds)
            {

                if(row.Cells["MSSV"].Value.ToString()== sv.MSSV)
                    foreach(var c in sv.MonHoc)
                    {
                        for(int i=0; i < clbMonHoc.Items.Count;i++)
                        {
                            if (c.CompareTo(clbMonHoc.Items[i]) == 0)
                                clbMonHoc.SetItemChecked(i, true);
                        }
                    }
            }


        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            mtxtSoDT.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtxtMSSV.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtxtSoCMND.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (KiemTraTxtTrong() == false)
            {
                SinhVien sv = new SinhVien();
                sv.MSSV = mtxtMSSV.Text.ToString();
                sv.Ten = txtTen.Text.ToString();
                sv.HoVaTenLot = txtHoLot.Text.ToString();
                sv.DiaChi = txtDiaChi.Text.ToString();
                sv.SoDT = mtxtSoDT.Text.ToString();
                sv.SoCMND = mtxtSoCMND.Text.ToString();
                sv.NgaySinh = dtpNgaySinh.Value;
                sv.Lop = cbLop.Text.ToString();

                if (ThemSinhVienVaoFile("students.txt", sv))
                    MessageBox.Show("Đã Nhập thành công sinh viên!");
                else
                    MessageBox.Show("Trùng MSSV!");



                Form1_Load(this, EventArgs.Empty);
            }
            else
                MessageBox.Show("Không được để trống thông tin!");

        }
        public void CapNhatSinhVien(SinhVien svCapNhat, string filePath)
        {
            List<SinhVien> DSSV = DocSVtxt(filePath);
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
            }
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                foreach (var s in DSSV)
                {
                    sw.WriteLine(s.ToString());
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTraTxtTrong())
                MessageBox.Show("Không được để trống thông tin!");
            else
            {
                SinhVien sv = new SinhVien()
                {
                    HoVaTenLot = txtHoLot.Text,
                    Ten = txtTen.Text,
                    Lop = cbLop.Text,
                    NgaySinh = DateTime.Parse(dtpNgaySinh.Text),
                    DiaChi = txtDiaChi.Text,
                    SoCMND = mtxtSoCMND.Text,
                    MSSV = mtxtMSSV.Text,
                    SoDT = mtxtSoDT.Text,
                    GioiTinh =  rbNam.Checked == true ? "Nam" : "Nu" 
                };
                CapNhatSinhVien(sv, "students.txt");
                MessageBox.Show("Cập nhật thành công!");
                Form1_Load(this, EventArgs.Empty);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Bạn có chắc chắn muốn thoát không?",
        "Xác nhận thoát",
        MessageBoxButtons.OKCancel,
        MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void xóaTheoSelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa các sinh viên đã chọn?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No) return;

            List<SinhVien> list = (List<SinhVien>)dgvSinhVien.DataSource;

            for (int i = dgvSinhVien.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dgvSinhVien.Rows[i];
                bool isChecked = row.Cells["chkChon"].Value != null &&
                                 (bool)row.Cells["chkChon"].Value;

                if (isChecked)
                {
                    list.RemoveAt(i);
                }
            }

            dgvSinhVien.DataSource = null;
            dgvSinhVien.DataSource = list;
            using (StreamWriter sw = new StreamWriter("students.txt", false))
            {
                foreach (var s in list)
                {
                    sw.WriteLine(s.ToString());
                }
            }

        }

       
    }
}
