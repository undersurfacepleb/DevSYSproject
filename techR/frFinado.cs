using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;

namespace techR
{
    public partial class frFinado : Form
    {
        public frFinado()
        {
            InitializeComponent();
        }

        conexao con = new conexao();
        string sql;
        SqlCommand cmd;
        string id;

        private void list()
        {
            con.OpenCon();
            sql = "SELECT * FROM tblFuncionários";
            cmd = new SqlCommand(sql, con.conec);
            SqlDataAdapter daList = new SqlDataAdapter();
            daList.SelectCommand = cmd;
            DataTable dtlist = new DataTable();
            daList.Fill(dtlist);
            dgvReadData.DataSource = dtlist;
            con.CloseCon();



        }


        private void formatarDGV()
        {
            dgvReadData.Columns[0].HeaderText = "Nome";
            dgvReadData.Columns[1].HeaderText = "CPF";
            dgvReadData.Columns[2].HeaderText = "Email";
            dgvReadData.Columns[3].HeaderText = "Endereço";
            dgvReadData.Columns[4].HeaderText = "Data Nasc";

            dgvReadData.Columns[0].Visible = false;

            dgvReadData.Columns[1].Width = 200;
        }
        private void habilitarCampos()
        {
            tbName.Enabled = true;
            tbCPF.Enabled = true;
            tbAdress.Enabled = true;
            tbDate.Enabled = true;
            tbEmail.Enabled = true;

            tbName.Focus();
        }
        private void desabilitarCampos()
        {
            tbName.Enabled = false;
            tbCPF.Enabled = false;
            tbAdress.Enabled = false;
            tbDate.Enabled = false;
            tbEmail.Enabled = false;
        }
        private void limparCampos()
        {
            tbName.Text = "";
            tbCPF.Text = "";
            tbAdress.Text = "";
            tbEmail.Text = "";
            tbDate.Text = "";
        }

        private void btSave_Click_1(object sender, EventArgs e)
        {
            if (tbName.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o Nome!", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbName.Text = "";
                tbName.Focus();
                return;
            }

            if (tbCPF.Text.Trim() == "   .   .   -")
            {
                MessageBox.Show("Preencha o CPF!", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbCPF.Text = "";
                tbCPF.Focus();
                return;
            }

            if (tbEmail.Text.Trim() == "(  )       -")
            {
                MessageBox.Show("Preencha o Email!", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbEmail.Text = "";
                tbEmail.Focus();
                return;
            }

            if (tbAdress.Text == "")
            {
                MessageBox.Show("Preencha o campo Endereço!", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbAdress.Text = "";
                tbAdress.Focus();
                return;
            }




            //COD SAVE BUTTON
            con.OpenCon();
            sql = "INSERT INTO tblFuncionários(' " + tbName.Text + " ')";
            sql = "INSERT INTO tblFuncionários(' " + tbCPF.Text + " ')";
            sql = "INSERT INTO tblFuncionários(' " + tbEmail.Text + " ')";
            sql = "INSERT INTO tblFuncionários(' " + tbAdress.Text + " ')";
            sql = "INSERT INTO tblFuncionários(' " + tbDate.Text + " ')";

            cmd = new SqlCommand(sql, con.conec);

            cmd.ExecuteNonQuery();

            con.CloseCon();


            MessageBox.Show("Registro salvo com sucesso!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btNew.Enabled = true;
            btSave.Enabled = false;

            limparCampos();
            desabilitarCampos();

        }

        private void btUpdate_Click_1(object sender, EventArgs e)
        {
            if (tbName.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o Nome!", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbName.Text = "";
                tbName.Focus();
                return;
            }

            if (tbCPF.Text.Trim() == "   .   .   -")
            {
                MessageBox.Show("Preencha o CPF!", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbCPF.Text = "";
                tbCPF.Focus();
                return;
            }

            if (tbEmail.Text.Trim() == "(  )       -")
            {
                MessageBox.Show("Preencha o Email!", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbEmail.Text = "";
                tbEmail.Focus();
                return;
            }

            if (tbAdress.Text == "")
            {
                MessageBox.Show("Preencha o campo Endereço!", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbAdress.Text = "";
                tbAdress.Focus();
                return;
            }

            MessageBox.Show("Registro atualizado com sucesso!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btSave.Enabled = true;
            btUpdate.Enabled = false;
            btDelete.Enabled = false;

            limparCampos();
            desabilitarCampos();
        }

        private void btDelete_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente deletar o registro?", "Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Registro deletado com sucesso!!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btSave.Enabled = true;
                btUpdate.Enabled = false;
                btDelete.Enabled = false;

                limparCampos();
                desabilitarCampos();
            }
        }


        private void frFunc_Load(object sender, EventArgs e)
        {
            list();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            habilitarCampos();

            btSave.Enabled = true;
            tbName.Focus();

            btNew.Enabled = false;
            btUpdate.Enabled = false;
            btDelete.Enabled = false;
        }

        private void dgvReadData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btUpdate.Enabled = true;
            btDelete.Enabled = true;
            btSave.Enabled = false;

            id = dgvReadData.CurrentRow.Cells[0].Value.ToString();

            tbName.Text = dgvReadData.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
