using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ChuDe3_BaiTap_2312756_NguyenHungThinh
{
    public partial class Form1 : Form
    {
        public QuanLySinhVien qlsv = new QuanLySinhVien();
        string filePath = "students.txt";
        public void LayDSMHtxt()
        {
            string path = "monhoc.txt";
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                clbMonHoc.Items.Clear();
                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                        clbMonHoc.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy file monhoc.txt");
            }
        }
        

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
            dgvSinhVien.DataSource = qlsv.DocSV(filePath);
            LayDSMHtxt();
        }

        private bool KiemTraTxtTrong()
        {
            
            return string.IsNullOrWhiteSpace(txtTen.Text) ||
                   string.IsNullOrWhiteSpace(mtxtSoDT.Text) ||
                   string.IsNullOrWhiteSpace(mtxtMSSV.Text) ||
                   string.IsNullOrWhiteSpace(mtxtSoCMND.Text) ||
                   string.IsNullOrWhiteSpace(txtHoLot.Text) ||
                   string.IsNullOrWhiteSpace(dtpNgaySinh.Text) ||
                   string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                   string.IsNullOrWhiteSpace(cbLop.Text);
        }
        private bool KiemTraRangBuoc()
        {
            mtxtSoDT.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtxtMSSV.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtxtSoCMND.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (mtxtMSSV.Text.Length < 7 || mtxtSoCMND.Text.Length < 9 || mtxtSoDT.Text.Length < 10)
                return false;
            else
                return true;
        }

        private void dgvSinhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mtxtSoDT.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtxtMSSV.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtxtSoCMND.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            for (int i = 0; i < clbMonHoc.Items.Count; i++)
                clbMonHoc.SetItemChecked(i, false);

            DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
            txtHoLot.Text = row.Cells["HoVaTenLot"].Value.ToString();
            txtTen.Text = row.Cells["Ten"].Value.ToString();
            cbLop.Text = row.Cells["Lop"].Value.ToString();
            dtpNgaySinh.Text = Convert.ToDateTime(row.Cells["NgaySinh"].Value).ToString("MM/dd/yyyy");
            txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            mtxtSoCMND.Text = row.Cells["SoCMND"].Value.ToString();
            mtxtMSSV.Text = row.Cells["MSSV"].Value.ToString();
            mtxtSoDT.Text = row.Cells["SoDT"].Value.ToString();

            if (row.Cells["GioiTinh"].Value.ToString() == "Nam")
                rbNam.Checked = true;
            else
                rbNu.Checked = true;

            List<SinhVien> ds = (List<SinhVien>)dgvSinhVien.DataSource;
            foreach (var sv in ds)
            {
                if (row.Cells["MSSV"].Value.ToString() == sv.MSSV)
                    foreach (var c in sv.MonHoc)
                        for (int i = 0; i < clbMonHoc.Items.Count; i++)
                            if (c.CompareTo(clbMonHoc.Items[i]) == 0)
                                clbMonHoc.SetItemChecked(i, true);
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            mtxtSoDT.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtxtMSSV.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtxtSoCMND.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (!KiemTraTxtTrong() && KiemTraRangBuoc())
            {
                string gioi = null;
                if(rbNam.Checked == true)
                {
                     gioi = "Nam";
                }
                else
                {
                     gioi = "Nu";
                }

                SinhVien sv = new SinhVien
                {
                    MSSV = mtxtMSSV.Text,
                    Ten = txtTen.Text,
                    HoVaTenLot = txtHoLot.Text,
                    DiaChi = txtDiaChi.Text,
                    SoDT = mtxtSoDT.Text,
                    GioiTinh = gioi,
                    SoCMND = mtxtSoCMND.Text,
                    NgaySinh = dtpNgaySinh.Value,
                    Lop = cbLop.Text
                };

                if (qlsv.ThemSinhVienVaoFile(filePath, sv))
                    MessageBox.Show("Đã Nhập thành công sinh viên!");
                else
                    MessageBox.Show("Trùng MSSV!");

                Form1_Load(this, EventArgs.Empty);
            }
            else
                MessageBox.Show("Không được để trống thông tin!");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTraTxtTrong() && KiemTraRangBuoc())
                MessageBox.Show("Không được để trống thông tin!");
            else
            {
                string[] Mon= new string[clbMonHoc.CheckedItems.Count];
                for (int i = 0; i< clbMonHoc.CheckedItems.Count; i++)
                {
                    Mon[i] = clbMonHoc.CheckedItems[i].ToString();
                }
                SinhVien sv = new SinhVien
                {
                    HoVaTenLot = txtHoLot.Text,
                    Ten = txtTen.Text,
                    Lop = cbLop.Text,
                    NgaySinh = DateTime.Parse(dtpNgaySinh.Text),
                    DiaChi = txtDiaChi.Text,
                    SoCMND = mtxtSoCMND.Text,
                    MSSV = mtxtMSSV.Text,
                    SoDT = mtxtSoDT.Text,
                    GioiTinh = rbNam.Checked ? "Nam" : "Nu",
                    MonHoc = Mon
                };

                qlsv.CapNhatSinhVien(sv, filePath);
                MessageBox.Show("Cập nhật thành công!");
                Form1_Load(this, EventArgs.Empty);
            }
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
                    list.RemoveAt(i);
            }

            dgvSinhVien.DataSource = null;
            dgvSinhVien.DataSource = list;
            qlsv.GhiDanhSachSinhVien(filePath, list);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không?",
                "Xác nhận thoát",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.OK)
                Application.Exit();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();

            
            frm2.SinhVienTimKiem += (listTimKiem) =>
            {
                dgvSinhVien.DataSource = null;
                dgvSinhVien.DataSource = listTimKiem;
            };

            frm2.ShowDialog();
        }

        private void btnXoaTimKiem_Click(object sender, EventArgs e)
        {
            Form1_Load(this, EventArgs.Empty);
        }

        private void xóaMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clbMonHoc.Items.Remove(clbMonHoc.SelectedItem);
            CapNhatFileMonHoc();
        }

       



        public void CapNhatFileMonHoc()
        {
            string path = "monhoc.txt";
            List<string> dsMon = new List<string>();

            foreach (var item in clbMonHoc.Items)
            {
                dsMon.Add(item.ToString());
            }

            File.WriteAllLines(path, dsMon);
        }

        private void thêmMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.tenMonHoc += (TenMH) =>
            {
                clbMonHoc.Items.Add(TenMH);
                CapNhatFileMonHoc();
            };
            frm3.ShowDialog();

        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            qlsv.XuatFileTheoDuongDan(qlsv.DocSV(filePath));
            
        }
    }
}
