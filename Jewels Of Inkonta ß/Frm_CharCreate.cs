using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jewels_Of_Inkonta_ß
{
    public partial class Frm_CharCreate : Form
    {
        public static String name;
        public Frm_CharCreate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = Txt_Name.Text;
            Frm_Gaem Gaem = new Frm_Gaem();
            Gaem.Show();
            this.Close();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
