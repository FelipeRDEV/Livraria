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
using System.Security.Cryptography;

namespace Livraria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //sql

        SqlConnection cn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security= SSPI;Initial Catalog = db_livraria");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dr;

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerSenha_Click(object sender, EventArgs e)
        {
        }

        private void btnVerSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
        }

        private void btnVerSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "SELECT * FROM tbl_Atendente WHERE ds_Login = ('" + txtLogin.Text + "') AND ds_Senha = ('" + txtSenha.Text + "')";
                    cm.Connection = cn;
                    dr = cm.ExecuteReader();

                    if (dr.HasRows)
                    {
                        Menu menu = new Menu();
                        menu.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Login ou senha incorretos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtLogin.Clear();
                        txtSenha.Clear();
                        txtLogin.Focus();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Erro");
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
