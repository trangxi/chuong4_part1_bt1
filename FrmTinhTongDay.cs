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
    public partial class FrmTinhTongDay : Form
    {
        public FrmTinhTongDay()
        {
            InitializeComponent();
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') || (e.KeyChar == '.') ||
                   (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') || (e.KeyChar == '.') ||
                   (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else e.Handled = true;
        }

        private void btTongDay_Click(object sender, EventArgs e)
        {
            double tong = 0;
            double A = Convert.ToDouble(txtA.Text);
            double B = Convert.ToDouble(txtB.Text);

            if (A <= B)
            {
                for (double i = A; i <= B; i++) tong += i;
            }

            if (A > B)
            {
                for (double i = B; i <= A; i++) tong += i;
            }

            label1.Text = A.ToString();
            label2.Text = B.ToString();
            lbTongDay.Text = tong.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btLamLai_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            label1.Text = "";
            label2.Text = "";
            lbTongDay.Text = "";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTinhTongDay_Load(object sender, EventArgs e)
        {

        }
    }
}
