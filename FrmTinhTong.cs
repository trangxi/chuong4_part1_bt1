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
    public partial class FrmTinhTong : Form
    {
        public FrmTinhTong()
        {
            InitializeComponent();
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(((e.KeyChar>='0') &&(e.KeyChar<='9'))|| (e.KeyChar=='-')|| (e.KeyChar=='.') ||
                    (Convert.ToInt32(e.KeyChar)==8)||(Convert.ToInt32(e.KeyChar)==13))
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

        private void btlTinhTong_Click(object sender, EventArgs e)
        {
            double tong;
            double A = Convert.ToDouble(txtA.Text);
            double B = Convert.ToDouble(txtB.Text);
            tong = A + B;

            lbTong.Text = tong.ToString();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmTinhTong_Load(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
