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
            lbl_codigo.Visible = false;
            codigolbl.Visible = false;
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
            txtBuscaFunc.Clear();
            gridSearchFuncio.DataSource = null;
        }

        private void limparCampos ()
        {
            txtNomeFunc.Clear();
            txtLoginFunc.Clear();
            txtSenhaFunc.Clear();
            txtBuscaFunc.Clear();
            gridSearchFuncio.DataSource = null;
      
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
            else if (radioInativo.Checked)
            {
                MessageBox.Show("Impossivel cadastrar usuário com status INATIVO!", "Erro na operação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    string nome = txtNomeFunc.Text;
                    string login = txtLoginFunc.Text;
                    string senha = txtSenhaFunc.Text;

                    string strSql = "INSERT INTO tbl_Atendente (nm_Atendente, ds_Login, ds_Senha, ds_Status) VALUES (@nome, @login, @senha, 1)";

                    cm.CommandText = strSql;

                    cm.Connection = cn;

                    cm.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                    cm.Parameters.Add("@senha", SqlDbType.Char).Value = senha;
                    cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;

                    cn.Open();

                    cm.ExecuteNonQuery();

                    cm.Parameters.Clear();

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

        private void gridSearchFuncio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void manipularDados()
        {

            lbl_codigo.Visible = true;
            codigolbl.Visible = true;
            btnAlterarFunc.Enabled = true;
            btnExcluirFunc.Enabled = true;
            btnCancelarFunc.Enabled = true;
            btnSalvarFunc.Enabled = false;
            txtNomeFunc.Enabled = true;
            txtLoginFunc.Enabled = true;
            txtSenhaFunc.Enabled = true;
            btnNovoFunc.Enabled = false;
        }

        private void carregaAtendente()
        {
            lbl_codigo.Text = gridSearchFuncio.CurrentRow.Cells[0].Value.ToString();
            txtNomeFunc.Text = gridSearchFuncio.CurrentRow.Cells[3].Value.ToString();
            txtLoginFunc.Text = gridSearchFuncio.CurrentRow.Cells[1].Value.ToString();
            txtSenhaFunc.Text = gridSearchFuncio.CurrentRow.Cells[2].Value.ToString();
            bool ativo = Convert.ToBoolean(gridSearchFuncio.CurrentRow.Cells[4].Value);

            if (ativo) { 
                radioAtivo.Checked = true;
            }
            else
            {
                radioInativo.Checked = true;
            }

            manipularDados();
        }

        private void gridSearchFuncio_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregaAtendente();
            if (radioAtivo.Checked)
            {
                btnExcluirFunc.Enabled = true;
            }
            else
            {
                btnExcluirFunc.Enabled = false;
            }
        }

        private void btnAlterarFunc_Click(object sender, EventArgs e)
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
            else if (radioInativo.Checked)
            {
                MessageBox.Show("Para inativar um funcionário, é preciso clicar no botão remover!", "Erro na operação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    string nome = txtNomeFunc.Text;
                    string login = txtLoginFunc.Text;
                    string senha = txtSenhaFunc.Text;
                    int cd = Convert.ToInt32(lbl_codigo.Text);

                    string strSql = "UPDATE tbl_Atendente SET ds_Login = @login, ds_Senha = @senha, nm_Atendente = @nome, ds_Status = 1 where cd_Atendente = @cd";

                    cm.CommandText = strSql;

                    cm.Connection = cn;

                    cm.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                    cm.Parameters.Add("@senha", SqlDbType.Char).Value = senha;
                    cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                    cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd;

                    cn.Open();

                    cm.ExecuteNonQuery();

                    cm.Parameters.Clear();

                    MessageBox.Show("Funcionario alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void radioInativo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluirFunc_Click(object sender, EventArgs e)
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
            else if (radioAtivo.Checked)
            {
                MessageBox.Show("Só é possível excluir um usuário que esteja inativo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenhaFunc.Focus();
                return;
            }
            else
            {
                DialogResult exclusao = MessageBox.Show("Tem certeza que deseja excluir este funcionário?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (exclusao == DialogResult.No)
                {
                    return;
                }
                else
                {
                    try
                    {
                        cn.Open();

                        string sqlStr = "UPDATE tbl_Atendente SET ds_status = 0 WHERE cd_Atendente = @cd";

                        cm.CommandText = sqlStr;

                        cm.Connection = cn;

                        cm.Parameters.Add("@cd", SqlDbType.Int).Value = Convert.ToInt32(lbl_codigo.Text);

                        cm.ExecuteNonQuery();

                        cm.Parameters.Clear();

                        MessageBox.Show("Dados Excluídos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
    }
}
