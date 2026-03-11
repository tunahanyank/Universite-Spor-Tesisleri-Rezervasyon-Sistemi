using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUyeIslemleri_Click(object sender, EventArgs e)
        {
            UyeFormu frm = new UyeFormu();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelFormu frm = new PersonelFormu();
            frm.Show();
        }
    }
}
