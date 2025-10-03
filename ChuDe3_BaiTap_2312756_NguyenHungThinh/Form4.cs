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
    public partial class Form4 : Form
    {
        public event Action<string> DinhDang;
        public Form4()
        {
            InitializeComponent();
        }

        private void btnTXT_Click(object sender, EventArgs e)
        {
            DinhDang?.Invoke("TXT");
            this.Close();
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            DinhDang?.Invoke("XML");
            this.Close();
        }

        private void btnJSON_Click(object sender, EventArgs e)
        {
            DinhDang?.Invoke("JSON");
            this.Close();
        }
    }
}
