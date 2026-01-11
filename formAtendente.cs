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

namespace Livraria
{
    public partial class formAtendente : UserControl
    {
        public formAtendente()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security= SSPI;Initial Catalog = db_livraria");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dr;

        private void desabilitarCampos()
        {
            btnNovoFunc.Enabled = true;
            txtNomeFunc.Enabled = false;
            txtLoginFunc.Enabled = false;
            txtSenhaFunc.Enabled = false;
            btnSalvarFunc.Enabled = false;
            btnAlterarFunc.Enabled = false;
            btnExcluirFunc.Enabled = false;
            btnCancelarFunc.Enabled = false;
        }
        private void habilitarCampos()
        {
            txtNomeFunc.Enabled = true;
            txtLoginFunc.Enabled = true;
            txtSenhaFunc.Enabled = true;
            btnSalvarFunc.Enabled = true;
            btnCancelarFunc.Enabled = true;
            txtNomeFunc.Focus();
            btnNovoFunc.Enabled = false;
        }

        private void limparCampos ()
        {
            txtNomeFunc.Clear();
            txtLoginFunc.Clear();
            txtSenhaFunc.Clear();
        }
        private void lbl_codigo_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void formAtendente_Load(object sender, EventArgs e)
        {
            desabilitarCampos();
        }

        private void btnNovoFunc_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void btnCancelarFunc_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitarCampos();
        }

        private void btnSalvarFunc_Click(object sender, EventArgs e)
        {
            if (txtNomeFunc.Text == "")
            {
                MessageBox.Show("O campo NOME é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeFunc.Focus();
                return;
            }
            else if (txtLoginFunc.Text == "")
            {
                MessageBox.Show("O campo LOGIN é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLoginFunc.Focus();
                return;
            }
            else if (txtSenhaFunc.Text == "")
            {
                MessageBox.Show("O campo SENHA é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenhaFunc.Focus();
                return;
            }
            else if (txtSenhaFunc.Text.Length < 8)
            {
                MessageBox.Show("A SENHA deve conter no mínimo 8 caracteres!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenhaFunc.Focus();
                return;
            }
            else
            {
                try
                {
                    string nome = txtNomeFunc.Text;
                    string login = txtLoginFunc.Text;
                    string senha = txtSenhaFunc.Text;

                    string strSql = "INSERT INTO tbl_Atendente (nm_Atendente, ds_Login, ds_Senha) VALUES (@nome, @login, @senha)";

                    cm.CommandText = strSql;

                    cm.Connection = cn;

                    cm.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                    cm.Parameters.Add("@senha", SqlDbType.Char).Value = senha;
                    cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;

                    cn.Open();

                    cm.ExecuteNonQuery();

                    MessageBox.Show("Funcionario Atendente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                    desabilitarCampos();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro");
                    cn.Close();
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void txtBuscaFunc_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscaFunc.Text != "")
            {
                try {

                    cn.Open();
                    
                    cm.CommandText = "SELECT * FROM tbl_Atendente WHERE nm_Atendente LIKE ('" + txtBuscaFunc.Text + "%')";

                    cm.Connection = cn;

                    SqlDataAdapter da = new SqlDataAdapter();

                    DataTable dt = new DataTable();

                    da.SelectCommand = cm;
                    da.Fill(dt);

                    gridSearchFuncio.DataSource = dt;

                    cn.Close();

                }
                catch (Exception err) {
                    MessageBox.Show(err.Message, "Erro");
                }
                finally {                     
                    cn.Close(); 
                }
            }
            else
            {
                gridSearchFuncio.DataSource = null;
            }
        }
    }
}
