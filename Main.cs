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

namespace SwanCRM
{
    public partial class Main : Form
    {
        public Main(string uname, string adminStatus)
        {
            InitializeComponent();
            userName.Text = uname;
            if (adminStatus == "True")
            {
                returnButton.Enabled = true;
                returnButton.Visible = true;
            }
            else {
                returnButton.Enabled = false;
                returnButton.Visible = false;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        SqlConnection connection = new SqlConnection("");

        private void boxTemizle()
        {
            idBox.Text = string.Empty;
            nameBox.Text = string.Empty;
            surnameBox.Text = string.Empty;
            mailBox.Text = string.Empty;
            phoneBox.Text = string.Empty;
            fNameBox.Text = string.Empty;
            fAddrBox.Text = string.Empty;
            fJobBox.Text = string.Empty;
            yesBtn.Checked = false;
            noBtn.Checked = false;
            yes2Btn.Checked = false;
            no2Btn.Checked = false;
            nameBox.Focus();
        }

        private void dbListele()
        {
            this.cUSTOMERSTableAdapter.Fill(this.sWAN_CRM_CUSTOMERS1.CUSTOMERS);
            dataGridView1.DataSource = this.sWAN_CRM_CUSTOMERS1.CUSTOMERS;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dbListele();
        }

        private void yesBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (yesBtn.Checked)
            {
                placeholder.Text = "True";
            }
            else
            {
                placeholder.Text = "False";
            }
        }

        private void yes2Btn_CheckedChanged(object sender, EventArgs e)
        {
            if (yes2Btn.Checked)
            {
                placeholder2.Text = "True";
            }
            else
            {
                placeholder2.Text = "False";
            }
        }

        private void noBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (noBtn.Checked)
            {
                placeholder.Text = "False";
            }
        }

        private void no2Btn_CheckedChanged(object sender, EventArgs e)
        {
            if (no2Btn.Checked)
            {
                placeholder2.Text = "False";
            }
        }

        private void placeholder_TextChanged(object sender, EventArgs e)
        {
            if (placeholder.Text == "True")
            {
                yesBtn.Checked = true;
                noBtn.Checked = false;
            }
            if (placeholder.Text == "False")
            {
                yesBtn.Checked = false;
                noBtn.Checked = true;
            }
        }

        private void placeholder2_TextChanged(object sender, EventArgs e)
        {
            if (placeholder2.Text == "True")
            {
                yes2Btn.Checked = true;
                no2Btn.Checked = false;
            }
            if (placeholder2.Text == "False")
            {
                yes2Btn.Checked = false;
                no2Btn.Checked = true;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            idBox.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            nameBox.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            surnameBox.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mailBox.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            phoneBox.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            fNameBox.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fAddrBox.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fJobBox.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            placeholder.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            placeholder2.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand insert = new SqlCommand("INSERT INTO CUSTOMERS (NAME, SURNAME, MAIL, PHONE, FIRM, F_ADRESS, F_JOB, IS_LEAD, NEGOTIATION_STATUS) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)", connection);
            insert.Parameters.AddWithValue("@p1", nameBox.Text);
            insert.Parameters.AddWithValue("@p2", surnameBox.Text);
            insert.Parameters.AddWithValue("@p3", mailBox.Text);
            insert.Parameters.AddWithValue("@p4", phoneBox.Text);
            insert.Parameters.AddWithValue("@p5", fNameBox.Text);
            insert.Parameters.AddWithValue("@p6", fAddrBox.Text);
            insert.Parameters.AddWithValue("@p7", fJobBox.Text);
            insert.Parameters.AddWithValue("@p8", placeholder.Text);
            insert.Parameters.AddWithValue("@p9", placeholder2.Text);
            insert.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Müşteri başarıyla eklendi", "Swan CRM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dbListele();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand update = new SqlCommand("UPDATE CUSTOMERS SET NAME = @p1, SURNAME = @p2, MAIL = @p3, PHONE = @p4, FIRM = @p5, F_ADRESS = @p6, F_JOB = @p7, IS_LEAD = @p8, NEGOTIATION_STATUS = @p9 WHERE C_ID = @pID ", connection);
            update.Parameters.AddWithValue("@pID", idBox.Text);
            update.Parameters.AddWithValue("@p1", nameBox.Text);
            update.Parameters.AddWithValue("@p2", surnameBox.Text);
            update.Parameters.AddWithValue("@p3", mailBox.Text);
            update.Parameters.AddWithValue("@p4", phoneBox.Text);
            update.Parameters.AddWithValue("@p5", fNameBox.Text);
            update.Parameters.AddWithValue("@p6", fAddrBox.Text);
            update.Parameters.AddWithValue("@p7", fJobBox.Text);
            update.Parameters.AddWithValue("@p8", placeholder.Text);
            update.Parameters.AddWithValue("@p9", placeholder2.Text);
            update.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Müşteri başarıyla güncellendi", "Swan CRM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dbListele();
        }

        private void remBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand rem = new SqlCommand("DELETE FROM CUSTOMERS WHERE C_ID = @p1", connection);
            rem.Parameters.AddWithValue("@p1", idBox.Text);
            rem.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Müşteri başarıyla silindi", "Swan CRM", MessageBoxButtons.OK, MessageBoxIcon.  Information);
            dbListele();
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            dbListele();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            mBox mBox = new mBox();
            if (mBox.ShowDialog() == DialogResult.OK) { 
                string surname = mBox.value;
                connection.Open();
                SqlCommand search = new SqlCommand("SELECT * FROM CUSTOMERS WHERE SURNAME = @p1 ", connection);
                search.Parameters.AddWithValue("@p1", surname);
                SqlDataAdapter adapter = new SqlDataAdapter(search);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            boxTemizle();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            string uname = userName.Text;
            Admin admin = new Admin(uname);
            admin.Show();
            this.Hide();
        }

        private void descBtn_Click(object sender, EventArgs e)
        {
            Description description = new Description(userName.Text);
            description.Show();
        }

        private void rmdBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
