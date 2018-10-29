using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_MP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }
        private void btn_SetName_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text != string.Empty)
            {
                Game g = new Game(txt_Username.Text);
                this.Hide();
                g.ShowDialog();
                this.Dispose();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txt_Username;
        }
    }
}
