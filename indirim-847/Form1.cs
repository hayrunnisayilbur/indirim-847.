using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indirim_847
{
    public partial class lblFiyat : Form
    {
        public lblFiyat()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double tutar = Convert.ToDouble(txtTutar.Text);

            if (rb5.Checked)
            {
                tutar = tutar * 0.95; //yüzde 5indirim
            }
            else if (rb10.Checked)
            {
                tutar = tutar * 0.90;
            }
            else if (rb15.Checked)
            {
                tutar = tutar * 0.85;
            }
            else if (rb25.Checked)
            {
                tutar = tutar * 0.75;

                //hesaplama bittikten sonra labal içine ekliyoruz.
                lblİndirim.Text = tutar.ToString();
                    
            }
        }  
    }
}
