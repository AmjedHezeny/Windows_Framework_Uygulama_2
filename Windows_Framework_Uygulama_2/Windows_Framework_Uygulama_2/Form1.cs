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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Combobox form=new Combobox();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ComboboxOrnek f=new ComboboxOrnek();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Timer timer=new Timer();
            timer.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TimerOdev to=new TimerOdev();
            to.Show();
        }
    }
}
