using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong4_part1_vidu
{
    public partial class FrmChaoMung : Form
    {
        public FrmChaoMung()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Ban chua nhap ten");
                txtTen.Focus();
                return;
            }
            if (txtLop.Text == "")
            {
                MessageBox.Show("Ban chua nhao lop");
                txtLop.Focus();
                return;
            }
            MessageBox.Show("chao mung ban" + txtTen.Text + "lop hoc" + txtLop.Text);
        }

        private void FrmChaoMung_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ban da bat form frmChaoMung");
        }
    }
}
