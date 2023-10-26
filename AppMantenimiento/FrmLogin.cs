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
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Diagnostics;

namespace AppMantenimiento
{
    public partial class FrmLogin : Form
    {
        
        public FrmLogin()
        {
            InitializeComponent();
            WebClient webClient = new WebClient();
            var client = new WebClient();

            //if (!webClient.DownloadString("https://www.dropbox.com/scl/fi/0vgb2fg4pyqaxc9b6onw0/Update.txt?rlkey=5kwu1omstj2qu5bm34p7grv8z&dl=0").Contains("1.0.0.0"))
            //{
            //    if(MessageBox.Show("Nueva versión, desea actualizar el programa","Mensaje", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        try
            //        {
            //            if (File.Exists(@".\MyAppSetup.msi"))
            //                File.Delete(@".\MyAppSetup.msi");
            //            client.DownloadFile("https://www.dropbox.com/scl/fi/d9bcaw9l22r6v9q33plws/MyAppSetup.rar?rlkey=nqap4mlpip493htfb8fraj49p&dl=0", @"MyAppSetup.zip");
            //            string zipApp = @"\MyAppSetup.zip";
            //            string extractPath = @".\";
            //            ZipFile.ExtractToDirectory(zipApp, extractPath);

            //            Process process = new Process();
            //            process.StartInfo.FileName = "msiexec";
            //            process.StartInfo.Arguments = String.Format("/i MyAppSetup.msi");

            //            this.Close();
            //            process.Start();
            //        }
            //        catch (Exception)
            //        {

            //            throw;
            //        }
            //    }
            //}
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
