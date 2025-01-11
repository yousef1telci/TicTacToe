using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tbPnl3_Click(object sender, EventArgs e)
        {
            Form three = new frmthree();
            three.ShowDialog();
        }

        private void tbPnl4_Click(object sender, EventArgs e)
        {
            Form four = new frmFour();
            four.ShowDialog();
        }

        private void tbPnl7_Click(object sender, EventArgs e)
        {
            Form seven = new frmSeven();
            seven.ShowDialog();
        }
    }
}
