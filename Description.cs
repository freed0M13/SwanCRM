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
    public partial class Description : Form
    {
        public Description(string uname)
        {
            InitializeComponent();
            userName.Text = uname;
        }

        SqlConnection connection = new SqlConnection("");

        private void boxTemizle()
        {
            idBox.Text = string.Empty;
            cidBox.Text = string.Empty;
            descBox.Text = string.Empty;
            cidBox.Focus();
        }

        private void dbListele()
        {
            this.cALL_DESCRIPTONSTableAdapter.Fill(this.sWAN_CRM_DESC.CALL_DESCRIPTONS);
            dataGridView2.DataSource = this.sWAN_CRM_DESC.CALL_DESCRIPTONS;
        }

        private void Description_Load(object sender, EventArgs e)
        {
            dbListele();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;

            idBox.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            cidBox.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            descBox.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand insert = new SqlCommand("INSERT INTO CALL_DESCRIPTONS (C_ID, USERNAME, DESCRIPTION) VALUES (@p1, @p2, @p3)", connection);
            insert.Parameters.AddWithValue("@p1", cidBox.Text);
            insert.Parameters.AddWithValue("@p2", userName.Text);
            insert.Parameters.AddWithValue("@p3", descBox.Text);
            insert.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Açıklama başarıyla eklendi", "Swan CRM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dbListele();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            boxTemizle();
        }

        private void remBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand remove = new SqlCommand("DELETE FROM CALL_DESCRIPTONS WHERE D_ID = @p1", connection);
            remove.Parameters.AddWithValue("@p1", idBox.Text);
            remove.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Açıklama başarıyla silindi", "Swan CRM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            boxTemizle();
            dbListele();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand update = new SqlCommand("UPDATE CALL_DESCRIPTONS SET C_ID = @p1, DESCRIPTION = @p2 WHERE D_ID = @pID", connection);
            update.Parameters.AddWithValue("@pID", idBox.Text);
            update.Parameters.AddWithValue("@p1", cidBox.Text);
            update.Parameters.AddWithValue("@p2", descBox.Text);
            update.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Açıklama başarıyla güncellendi", "Swan CRM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dbListele();
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            dbListele();
        }
    }
}
