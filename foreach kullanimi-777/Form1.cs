using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foreach_kullanimi_777
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> isimler = new List<string>() { "Hayri", "Ufuk", "Ahmet", "Recep" };

            //for 
            for (int i = 0; i < isimler.Count; i++)
            {
                string isim = isimler[i];
                MessageBox.Show(isim);
            }

            //foreach 
            foreach (string isim in isimler)
            {
                MessageBox.Show(isim);
            }
        }
    }
}
