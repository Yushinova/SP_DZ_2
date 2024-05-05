using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Child_1
{
    public partial class Form1 : Form
    {
        public int count = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)//выводим текущее время
        {
            DateTime time = DateTime.Now;
            textTimer.Text = time.ToLongTimeString();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

    }

}
