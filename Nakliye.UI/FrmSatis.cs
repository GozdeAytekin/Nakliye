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
    public partial class FrmSatis : Form
    {
        private List<Rota> rotas;
        private List<Gemi> gemiler;

        public FrmSatis()
        {
            InitializeComponent();
        }
        public FrmSatis(List<Rota> rotas, List<Gemi> gemiler) : this()
        {
            this.rotas = rotas;
            this.gemiler = gemiler;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            bool varMi = false;
            foreach (Rota item in rotas)
            {
                if (item.KalkisLimani == cmbKalkisLimani.SelectedItem.ToString()
                    && item.KalkisTarihi == dtTarih.Value
                    && (item.VaarisLimani == cmbVarisLimani.SelectedItem.ToString()
                    || item.UgranacakLiman == cmbVarisLimani.SelectedItem.ToString()) &&
                   TonajKontroluYap() == true)
                {
                    //todo yuklenecek miktara bak
                    //uygun gemiyi bulduk
                    cmbBulunanSeferler.Items.Add(item);
                    varMi = true;
                }
            }
            if (!varMi)
            {
                MessageBox.Show("uygun kriterde bir seferimiz bulunmamaktadır.");
            }
        }

        public bool TonajKontroluYap()
        {
            return true;
        }
        List<MusteriLojistik> musteriler = new List<MusteriLojistik>();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            musteriler.Add(new MusteriLojistik()
            {
                IslemTarihi = DateTime.Now,
                LojistikRotasi = cmbBulunanSeferler.SelectedItem as Rota,
                TasitascagiYukMiktari = double.Parse(txtYuklenecekMiktar.Text),
                Musteri = new Musteri()
                {
                    AdresBilgisi = txtAdres.Text,
                    FirmaUnvani = txtMusteriUnvan.Text,
                    //MusteriTemsilciAdSoyadBilgisi
                    VDNumarasi = txtVDNumarasi.Text
                }
            });
        }

        private void btnGeç_Click(object sender, EventArgs e)
        {
            FrmRapor frm = new FrmRapor(musteriler,gemiler);
            frm.Show();
        }
    }
}
