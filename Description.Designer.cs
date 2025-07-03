namespace SwanCRM
{
    partial class Description
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Description));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.remBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.cidBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.descBox = new System.Windows.Forms.RichTextBox();
            this.swaN_CRM_CUSTOMERS1 = new SwanCRM.SWAN_CRM_CUSTOMERS();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cALLDESCRIPTONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sWAN_CRM_DESC = new SwanCRM.SWAN_CRM_DESC();
            this.cALL_DESCRIPTONSTableAdapter = new SwanCRM.SWAN_CRM_DESCTableAdapters.CALL_DESCRIPTONSTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swaN_CRM_CUSTOMERS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cALLDESCRIPTONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWAN_CRM_DESC)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.listBtn);
            this.groupBox1.Controls.Add(this.updateBtn);
            this.groupBox1.Controls.Add(this.remBtn);
            this.groupBox1.Controls.Add(this.clearBtn);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(646, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 235);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Paneli";
            // 
            // listBtn
            // 
            this.listBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.listBtn.Location = new System.Drawing.Point(150, 28);
            this.listBtn.Name = "listBtn";
            this.listBtn.Size = new System.Drawing.Size(135, 64);
            this.listBtn.TabIndex = 21;
            this.listBtn.Text = "Listele";
            this.listBtn.UseVisualStyleBackColor = true;
            this.listBtn.Click += new System.EventHandler(this.listBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.updateBtn.Location = new System.Drawing.Point(6, 92);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(135, 64);
            this.updateBtn.TabIndex = 19;
            this.updateBtn.Text = "Güncelle";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // remBtn
            // 
            this.remBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.remBtn.Location = new System.Drawing.Point(6, 156);
            this.remBtn.Name = "remBtn";
            this.remBtn.Size = new System.Drawing.Size(135, 64);
            this.remBtn.TabIndex = 20;
            this.remBtn.Text = "Sil";
            this.remBtn.UseVisualStyleBackColor = true;
            this.remBtn.Click += new System.EventHandler(this.remBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.clearBtn.Location = new System.Drawing.Point(150, 92);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(135, 64);
            this.clearBtn.TabIndex = 22;
            this.clearBtn.Text = "Temizle";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.addBtn.Location = new System.Drawing.Point(6, 28);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(135, 64);
            this.addBtn.TabIndex = 18;
            this.addBtn.Text = "Ekle";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.Color.Transparent;
            this.userName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.userName.Location = new System.Drawing.Point(169, 84);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(46, 21);
            this.userName.TabIndex = 9;
            this.userName.Text = "------";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(76, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "İşlem Yapan:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "Müşteri ID:";
            // 
            // idBox
            // 
            this.idBox.Enabled = false;
            this.idBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.idBox.Location = new System.Drawing.Point(115, 24);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(164, 23);
            this.idBox.TabIndex = 10;
            // 
            // cidBox
            // 
            this.cidBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.cidBox.Location = new System.Drawing.Point(115, 53);
            this.cidBox.Name = "cidBox";
            this.cidBox.Size = new System.Drawing.Size(164, 23);
            this.cidBox.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.userName);
            this.groupBox2.Controls.Add(this.cidBox);
            this.groupBox2.Controls.Add(this.idBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(646, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 116);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullancı Verileri";
            // 
            // descBox
            // 
            this.descBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.descBox.Location = new System.Drawing.Point(12, 375);
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(925, 541);
            this.descBox.TabIndex = 12;
            this.descBox.Text = "";
            // 
            // swaN_CRM_CUSTOMERS1
            // 
            this.swaN_CRM_CUSTOMERS1.DataSetName = "SWAN_CRM_CUSTOMERS";
            this.swaN_CRM_CUSTOMERS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.DataSource = this.cALLDESCRIPTONSBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(628, 357);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // cALLDESCRIPTONSBindingSource
            // 
            this.cALLDESCRIPTONSBindingSource.DataMember = "CALL_DESCRIPTONS";
            this.cALLDESCRIPTONSBindingSource.DataSource = this.sWAN_CRM_DESC;
            // 
            // sWAN_CRM_DESC
            // 
            this.sWAN_CRM_DESC.DataSetName = "SWAN_CRM_DESC";
            this.sWAN_CRM_DESC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cALL_DESCRIPTONSTableAdapter
            // 
            this.cALL_DESCRIPTONSTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "D_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "C_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Müşteri ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "USERNAME";
            this.dataGridViewTextBoxColumn3.HeaderText = "Açıklama Ekleyen";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DESCRIPTION";
            this.dataGridViewTextBoxColumn4.HeaderText = "Açıklama";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Description
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SwanCRM.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 928);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Description";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swan CRM";
            this.Load += new System.EventHandler(this.Description_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swaN_CRM_CUSTOMERS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cALLDESCRIPTONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWAN_CRM_DESC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button listBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button remBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox cidBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cALLRECORDSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.RichTextBox descBox;
        private SWAN_CRM_CUSTOMERS swaN_CRM_CUSTOMERS1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private SWAN_CRM_DESC sWAN_CRM_DESC;
        private System.Windows.Forms.BindingSource cALLDESCRIPTONSBindingSource;
        private SWAN_CRM_DESCTableAdapters.CALL_DESCRIPTONSTableAdapter cALL_DESCRIPTONSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}