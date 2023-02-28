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
    public partial class FrmRapor : Form
    {
        private List<MusteriLojistik> musteriler;
        private List<Gemi> gemiler;

        public FrmRapor()
        {
            InitializeComponent();
        }

        public FrmRapor(List<MusteriLojistik> musteriler, List<Gemi> gemiler):this()
        {
            this.musteriler = musteriler;
            this.gemiler = gemiler;
        }

        private void FrmRapor_Load(object sender, EventArgs e)
        {
            //todo musterileri listelet 
        }
    }
}
