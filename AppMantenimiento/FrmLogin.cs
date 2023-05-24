using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AppMantenimiento
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void Login()
        {
            if (txtUser.Text != "USUARIO")
            {
                if (txtPass.Text != "CONTRASEÑA")
                {
                    Trabajador trabajador = new Trabajador();
                    string sHA256Hash = GetSHA256Hash(txtPass.Text);
                    if (trabajador.Login(txtUser.Text, sHA256Hash))
                    {
                        FrmDashBoard frmDashBoard = new FrmDashBoard();
                        frmDashBoard.FormClosed += Logout;
                        frmDashBoard.Show();
                        Hide();
                    }
                    else
                    {
                        msgerror("Usuario o contraseña incorrecta. \n Por favor vuelva a intentralo");
                        txtPass.Text = "CONTRASEÑA";
                        txtPass.UseSystemPasswordChar = false;
                        txtUser.Clear();
                        txtUser.Focus();
                    }
                }
                else
                {
                    msgerror("Por favor ingrese su contraseña");
                }
            }
            else
            {
                msgerror("Por favor ingrese su Usuario");
            }
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtUser.Text = "USUARIO";
            txtPass.Text = "CONTRASEÑA";
            txtPass.UseSystemPasswordChar = false;
            lblError.Visible = false;
            Show();
            txtUser.Focus();
        }
        private string GetSHA256Hash(string input)
        {
            using (SHA256 sHA = SHA256.Create())
            {
                byte[] array = sHA.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder stringBuilder = new StringBuilder();

                for (int i = 0; i < array.Length; i++)
                {
                    stringBuilder.Append(array[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }
        private void msgerror(string msg)
        {
            lblError.Text = msg;
            lblError.Visible = true;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.DarkGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DarkGray;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DarkGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Login();
            }
        }
    }
}
