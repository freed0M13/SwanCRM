using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwanCRM
{
    public partial class mBox : Form
    {

        public string value { get; private set; }

        public mBox()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            value = textBox1.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
