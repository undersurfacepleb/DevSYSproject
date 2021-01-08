using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace techR
{
    public partial class frTelaprinc : Form
    {
        public frTelaprinc()
        {
            InitializeComponent();
        }


        private void finadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frFinado finado = new frFinado();
            finado.ShowDialog();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
