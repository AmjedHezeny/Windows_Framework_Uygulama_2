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
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }
        #region
        //Timer , belirli zaman dilimi içerisinde çalıştırılmak istenilen komut satırlarını devreye almak için kullanılan bir windows form elementidir

        //Timer içerisinde kullanılan Property ve Metodlar

        //Interval => Timer ' ın ne kadar sürede bir devreye gireceğinin belirtildiği alandır.İçerisinde Milisaniye cinsinden değer yazılır . Yani 1 saniye için 1000 değerinin yazılması gerekmektedir

        //Start()=Start() fonksiyonu timer ı başlatmak için kullanılır

        //Stop()=Stop() fonksiyonu timer ı durdurmak için kullanılır

        //Timer elementinin basit bir kullanımı olduğundan dolayı çok fazla özelliği bulunmamaktadır . Aynı şekilde diğer for elementlerinde olduğu gibi birden fazla event i bulunmamaktadır . Timer elementinin sadece Tick event i bulunmaktadır . Belirtilen süre zarfında tick eventinin içerisine girip bu alandaki komut satırlarını işler
        #endregion
        int saniye = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label1.Text=saniye.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            saniye = 0;
            label1.Text= saniye.ToString();

        }
    }
}
