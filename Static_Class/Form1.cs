using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Static_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double s = Cevre.Ucgen(6,12,15);

            //İnstance almadan Access Midfier uygun olan static sınıfımın içindeki static üyelerime ulaşabilir alan ve cevre hesaplamalarını yaptırabilirim.
                
            MessageBox.Show($" {s}");
        }
    }
}
