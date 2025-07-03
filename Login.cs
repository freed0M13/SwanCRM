using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;

namespace SwanCRM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("");

        private void girisButton_Click(object sender, EventArgs e)
        {
            string uname = usernameBox.Text;
            string passwd = passwdBox.Text;

            if (uname.Length == 0 || passwd.Length == 0) {
                MessageBox.Show("Kullanıcı adı ve ya şifre alanı boş. Lütfen kontrol edin ve tekrar deneyin.", "Swan CRM - Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                SqlCommand loginCheck = new SqlCommand("select count(1) from USERS where USERNAME = @usrName AND PASSWORD = @passwd", connection);
                loginCheck.Parameters.AddWithValue("@usrName", uname);
                loginCheck.Parameters.AddWithValue("@passwd", passwd);
                int loginStatus = (int)loginCheck.ExecuteScalar();

                if (loginStatus > 0)
                {
                    SqlCommand adminCheck = new SqlCommand("select count(1) from USERS where USERNAME = @usrName AND PASSWORD = @passwd AND IS_ADMIN = 1", connection);
                    adminCheck.Parameters.AddWithValue("@usrName", uname);
                    adminCheck.Parameters.AddWithValue("@passwd", passwd);
                    int adminStatus = (int)adminCheck.ExecuteScalar();
                    connection.Close();
                    if (adminStatus > 0)
                    {
                        MessageBox.Show("Admin girişi başarılı.", "Swan CRM - Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                        Admin admin = new Admin(uname);
                        admin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Giriş başarılı.", "Swan CRM - Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                        Main main = new Main(uname, "False");
                        main.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Giriş başarısız lütfen bilgileri kontrol edin ve tekrardan deneyin.", "Swan CRM - Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    connection.Close();
                    passwdBox.Text = string.Empty;
                }
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
