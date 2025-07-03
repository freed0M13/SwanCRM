using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace SwanCRM
{
    public partial class Admin : Form
    {
        public Admin(string uname)
        {
            InitializeComponent();
            userName.Text = uname;
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        SqlConnection connection = new SqlConnection("");

        private void boxTemizle()
        {
            idBox.Text = string.Empty;
            usernameBox.Text = string.Empty;
            passwdBox.Text = string.Empty;
            mailBox.Text = string.Empty;
            nameBox.Text = string.Empty;
            surnameBox.Text = string.Empty;
            adminBtn.Checked = false;
            userBtn.Checked = false;
            usernameBox.Focus();
        }

        private void dbListele()
        {
            this.uSERSTableAdapter.Fill(this.sWAN_CRM_USERS.USERS);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            dbListele();
        }

        private void adminBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (adminBtn.Checked)
            {
                placeholder.Text = "True";
            }
            else
            {
                placeholder.Text = "False";
            }
        }

        private void userBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (userBtn.Checked)
            {
                placeholder.Text = "False";
            }
        }

        private void placeholder_TextChanged(object sender, EventArgs e)
        {
            if (placeholder.Text == "True")
            {
                adminBtn.Checked = true;
                userBtn.Checked = false;
            }
            if (placeholder.Text == "False")
            {
                adminBtn.Checked = false;
                userBtn.Checked = true;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            idBox.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            usernameBox.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            passwdBox.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mailBox.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            nameBox.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            surnameBox.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            placeholder.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand insert = new SqlCommand("INSERT INTO USERS (USERNAME, PASSWORD, MAIL, NAME, SURNAME, IS_ADMIN) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)", connection);
            insert.Parameters.AddWithValue("@p1", usernameBox.Text);
            insert.Parameters.AddWithValue("@p2", passwdBox.Text);
            insert.Parameters.AddWithValue("@p3", mailBox.Text);
            insert.Parameters.AddWithValue("@p4", nameBox.Text);
            insert.Parameters.AddWithValue("@p5", surnameBox.Text);
            insert.Parameters.AddWithValue("@p6", placeholder.Text);
            insert.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kullanıcı sisteme başarıyla eklendi", "Swan CRM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dbListele();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand update = new SqlCommand("UPDATE USERS SET USERNAME = @p1, PASSWORD = @p2, MAIL = @p3, NAME = @p4, SURNAME = @p5, IS_ADMIN = @p6 WHERE K_ID = @pID", connection);
            update.Parameters.AddWithValue("@pID", idBox.Text);
            update.Parameters.AddWithValue("@p1", usernameBox.Text);
            update.Parameters.AddWithValue("@p2", passwdBox.Text);
            update.Parameters.AddWithValue("@p3", mailBox.Text);
            update.Parameters.AddWithValue("@p4", nameBox.Text);
            update.Parameters.AddWithValue("@p5", surnameBox.Text);
            update.Parameters.AddWithValue("@p6", placeholder.Text);
            update.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kullanıcı başarıyla güncellendi", "Swan CRM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dbListele();
        }

        private void remBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand rem = new SqlCommand("DELETE FROM USERS WHERE K_ID = @p1", connection);
            rem.Parameters.AddWithValue("@p1", idBox.Text);
            rem.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kullanıcı sistemden başarıyla silindi", "Swan CRM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dbListele();
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            dbListele();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            boxTemizle();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            string uname = userName.Text;
            Main main = new Main(uname, "True");
            main.Show();
            this.Hide();
        }
    }
}
