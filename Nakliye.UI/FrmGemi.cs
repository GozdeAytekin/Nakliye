using Nakliye.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nakliye.UI
{
    public partial class FrmGemi : Form
    {
        public FrmGemi()
        {
            InitializeComponent();
        }
        List<Gemi> gemiler = new List<Gemi>();
        private void btnEkle_Click(object sender, EventArgs e)
        {

            gemiler.Add(new Gemi() { 
            GemiAdi=txtGemiAdi.Text,
            Tonaj= double.Parse(txtTonaj.Text)
            });
            MessageBox.Show("eklendi.");

        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            FrmRota frm = new FrmRota(gemiler);
            frm.Show();
        }
    }
}
