using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuDe3_BaiTap_2312756_NguyenHungThinh
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }
        

        public event Action<List<SinhVien>> SinhVienTimKiem;

        private QuanLySinhVien QLSV = new QuanLySinhVien();
        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            Form2_Load(this, EventArgs.Empty);
            
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form2_Load(this, EventArgs.Empty);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dgvSinhVien.DataSource = TimKiemSinhVien(QLSV.DocSVtxt("students.txt"));
           
        }
        public  List<SinhVien> TimKiemSinhVien(List<SinhVien> danhSach)
        {
           List<SinhVien> ketqua = new List<SinhVien>();
            foreach(var sv in danhSach)
            {
                if(
                   sv.Ten.ToLower().Contains(txtTen.Text.ToLower()) &&
                   sv.MSSV.ToLower().Contains(mtxtMSSV.Text.ToLower()) &&
                   sv.Lop.ToLower().Contains(cbLop.Text.ToLower()))
                { ketqua.Add(sv); }
            }
            return ketqua;
        }

        private void mtxtMSSV_TextChanged(object sender, EventArgs e)
        {
            Form2_Load(this, EventArgs.Empty);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            List<SinhVien> ketQua = dgvSinhVien.DataSource as List<SinhVien>;
            SinhVienTimKiem?.Invoke(ketQua);
            this.Close();
        }
    }
}
