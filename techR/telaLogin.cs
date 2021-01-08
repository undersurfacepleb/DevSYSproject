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
    public partial class telaLogin : Form
    {

       

        public telaLogin()
        {
            InitializeComponent();
          
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            criaLogin();
        }

        private void telaLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                criaLogin();
            }
        }

        private void criaLogin()
        {
            if (tb1.Text == "")
            {
                MessageBox.Show("Preencha o campo Usuário!");
                tb1.Focus();
                return;
            }

            if (tb2.Text == "")
            {
                MessageBox.Show("Preencha o campo senha!");
                tb2.Focus();
                return;
            }


            frTelaprinc telaPrinc = new frTelaprinc();
            limpar();
            telaPrinc.ShowDialog();

        }

        private void limpar()

        {
            tb1.Text = "";
            tb2.Text = "";
            tb1.Focus();


        }
    }

    
}
