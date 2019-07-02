using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAHamburgerci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Menu> menuler = new List<Menu>() {
            new Menu { MenuAdi = "Steakhouse", Fiyati = 18.25m },
            new Menu { MenuAdi = "McFish", Fiyati = 8 },
            new Menu { MenuAdi = "Whooper", Fiyati = 12 },
            new Menu { MenuAdi = "BigKing", Fiyati = 13.75m },
            new Menu { MenuAdi = "Chicken Royal", Fiyati = 17 },
            new Menu { MenuAdi = "King Chicken", Fiyati = 11 }
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            //cbMenuler.Items.AddRange(menuler.ToArray());
            foreach (Menu item in menuler)
                cbMenuler.Items.Add(item);

            cbMenuler.SelectedIndex = 0;
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SeciliMenusu = (Menu)cbMenuler.SelectedItem;

            #region Boyut Seçimi
            if (rbKucuk.Checked)
                yeniSiparis.Boyutu = Boyut.Kucuk;
            else if (rbOrta.Checked)
                yeniSiparis.Boyutu = Boyut.Orta;
            else
                yeniSiparis.Boyutu = Boyut.Buyuk; 
            #endregion

            #region Extra Seçimi
            yeniSiparis.ExtraMalzemesi = new List<Extra>();
            foreach (CheckBox item in grpExtralar.Controls)
            {
                if (item.Checked)
                {
                    Extra ex = new Extra();
                    ex.ExtraAdi = item.Text;
                    ex.Fiyati = Convert.ToDecimal(item.Tag);
                    yeniSiparis.ExtraMalzemesi.Add(ex);
                }
            } 
            #endregion

            yeniSiparis.Adet = Convert.ToInt32(nmrAdet.Value);
            yeniSiparis.Hesapla();
            lstSiparisler.Items.Add(yeniSiparis);

            lblToplamTutar.Text = TutarHesapla().ToString() + "TL";

            Temizle(this.Controls);
        }

        private void btmSiparisTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipariş Ücreti : " + TutarHesapla().ToString() + " Satın almayı tamamlamak istermisiniz?", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                lstSiparisler.Items.Clear();
                MessageBox.Show("Sipariş Tamamlandı!");
            }
            else
            {
                MessageBox.Show("İptal Edildi!");
            }
        }

        private decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < lstSiparisler.Items.Count; i++)
            {
                Siparis gelen = (Siparis)lstSiparisler.Items[i];
                toplamTutar += gelen.ToplamTutar;
            }

            return toplamTutar;
        }


        void Temizle(Control.ControlCollection koleksiyon)
        {
            foreach (Control item in koleksiyon)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
                else if (item is CheckBox)
                {
                    CheckBox chk = (CheckBox)item;
                    chk.Checked = false;
                }
                else if (item is RadioButton)
                {
                    RadioButton rb = (RadioButton)item;
                    if (rb.Name == "rbKucuk")
                        rb.Checked = true;
                    else
                        rb.Checked = false;
                    
                }
                else if (item is NumericUpDown)
                {
                    NumericUpDown nmr = (NumericUpDown)item;
                    nmr.Value = 1;
                }
                else if (item is GroupBox)
                {
                    GroupBox gb = (GroupBox)item;
                    Temizle(gb.Controls);
                }
                else if (item is ComboBox)
                {
                    ComboBox cb = (ComboBox)item;
                    cb.SelectedIndex = 0;
                }
            }
        }
      
    }
}
