using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakout_Game
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string playerName = txtPlayerName.Text;
            if (string.IsNullOrEmpty(playerName))
            {
                MessageBox.Show("Por favor, ingrese su nombre.");
                return;
            }

            Form1 gameForm = new Form1(playerName);
            gameForm.Show();
            this.Hide(); // Ocultar el formulario de inicio
        }
    }
}