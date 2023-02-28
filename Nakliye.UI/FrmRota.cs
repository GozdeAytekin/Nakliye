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
    public partial class FrmRota : Form
    {
        private List<Gemi> gemiler;
        public FrmRota(List<Gemi> gemiler)
        {
            this.gemiler = gemiler;
            InitializeComponent();

        }

        private void FrmRota_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void Doldur()
        {
            foreach (var item in gemiler)
            {
                cmbGemi.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rota r = new Rota();
            r.RotaninGemisi = cmbGemi.SelectedItem as Gemi;
            r.KalkisLimani = cmbKalkisLimani.SelectedItem.ToString();
            r.UgranacakLiman = cmbUgranacakLiman.SelectedItem.ToString();
            r.VaarisLimani = cmbVarisLimani.SelectedItem.ToString();
            r.VarisTarihi = dtVaris.Value;
            r.KalkisTarihi = dtKalkis.Value;

            lstRotalar.Items.Add(r);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSatis frm = new FrmSatis(VerileriListboxtanOku(), gemiler);
            frm.Show();
        }
        /// <summary>
        /// bu kod daha kısa nasıl yazılır ?
        /// </summary>
        private List<Rota> VerileriListboxtanOku()
        {
            List<Rota> listem = new List<Rota>();
            foreach (Rota item in lstRotalar.Items)
            {
                listem.Add(item);
            }
            //var hede = lstRotalar.Items as List<Rota>;
            //List<Rota> hede1 = (List<Rota>)lstRotalar.Items;
            //return  lstRotalar.Items.Cast<Rota>().ToList();
            //linq
            //var sonuc = from p in lstRotalar.Items
            //            select p;
            return listem;
        }

       // private List<Rota> VerileriListboxtanOku() { return lstRotalar.Items.Cast<Rota>().ToList(); }
    }
}
