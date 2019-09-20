 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace Jewels_Of_Inkonta_ß
{
    public partial class Frm_Gaem : Form
    {
        private Player _player;
        
        public Frm_Gaem()
        {
            InitializeComponent();
            this.Text = Frm_CharCreate.name;
            _player = new Player();
            _player.HP = 100;
            Pb_Health.Value = _player.HP;
            _player.Gold = 100;
            _player.Mana = 20;
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
