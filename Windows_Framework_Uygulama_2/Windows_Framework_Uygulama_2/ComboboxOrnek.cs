using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders3
{
    public partial class ComboboxOrnek : Form
    {
        public ComboboxOrnek()
        {
            InitializeComponent();
        }
        List<string> sehirler=new List<string>()
        {
            "İstanbul","İzmir","Antalya","Manisa","Çanakkale","Bursa","Sakarya","Kocaeli"
        };

        private void ComboboxOrnek_Load(object sender, EventArgs e)
        {
            //foreach (string s in sehirler) 
            //{
            //    comboBox1.Items.Add(s);
            //}

            sehirler.ForEach(s=> comboBox1.Items.Add(s));
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==-1)
            {
                lblBilgi.Text = "Herhangi bir şehir bilgisi seçmediniz";
            }
            else
            {
                lblBilgi.Text = string.Format("Seçilen Öğe {0} - {1}",comboBox1.SelectedIndex,comboBox1.Text);
                comboBox1.SelectedIndex = -1;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int seciliIndex=comboBox1.SelectedIndex;
            if (seciliIndex==-1) 
            {
                lblBilgi.Text = "Herhangi bir şehir bilgisi seçmediniz";
            }
            else
            {
                string sehir = comboBox1.Items[seciliIndex].ToString();
                comboBox1.Items.RemoveAt(seciliIndex);
                lblBilgi.Text = string.Format("{0} şehri listenizden çıkarıldı",sehir);
            }
        }

        private void btnHepsiniSil_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            lblBilgi.Text = "Tüm Şehirler Kaldırıldı";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string metin = txtEkle.Text;
            if (string.IsNullOrEmpty(metin))
            {
                lblBilgi.Text = "Metin Alanı Boş Bırakılamaz";
            }
            else
            {
                comboBox1.Items.Add(metin);
                txtEkle.Clear();
                lblBilgi.Text = metin + " Şehri Listeye Eklendi";
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            string sehir = txtDegistir.Text;
            if (comboBox1.SelectedIndex==-1)
            {
                lblBilgi.Text = "Değiştirelecek şehri seçiniz";
            }
            else
            {
                if (string.IsNullOrEmpty(sehir))
                {
                    lblBilgi.Text = "Yazı Alanı Boş Bırakılamaz";
                    txtDegistir.Focus();
                }
                else
                {
                    comboBox1.Items[comboBox1.SelectedIndex] = sehir;
                    comboBox1.SelectedIndex = -1;
                    txtDegistir.Clear();
                    lblBilgi.Text=string.Empty;
                }
            }
        }
    }
}
