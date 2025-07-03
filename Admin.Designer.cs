namespace SwanCRM
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.returnButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSADMINDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sWAN_CRM_USERS = new SwanCRM.SWAN_CRM_USERS();
            this.uSERSTableAdapter = new SwanCRM.SWAN_CRM_USERSTableAdapters.USERSTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.veriBox = new System.Windows.Forms.GroupBox();
            this.placeholder = new System.Windows.Forms.Label();
            this.userBtn = new System.Windows.Forms.RadioButton();
            this.adminBtn = new System.Windows.Forms.RadioButton();
            this.passwdBox = new System.Windows.Forms.MaskedTextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.remBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWAN_CRM_USERS)).BeginInit();
            this.veriBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.returnButton.Location = new System.Drawing.Point(150, 156);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(135, 64);
            this.returnButton.TabIndex = 23;
            this.returnButton.Text = "Ana Panele Dön";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kIDDataGridViewTextBoxColumn,
            this.uSERNAMEDataGridViewTextBoxColumn,
            this.pASSWORDDataGridViewTextBoxColumn,
            this.mAILDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.sURNAMEDataGridViewTextBoxColumn,
            this.iSADMINDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.uSERSBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(881, 248);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // kIDDataGridViewTextBoxColumn
            // 
            this.kIDDataGridViewTextBoxColumn.DataPropertyName = "K_ID";
            this.kIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.kIDDataGridViewTextBoxColumn.Name = "kIDDataGridViewTextBoxColumn";
            this.kIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uSERNAMEDataGridViewTextBoxColumn
            // 
            this.uSERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.HeaderText = "Kullanıcı Adı";
            this.uSERNAMEDataGridViewTextBoxColumn.Name = "uSERNAMEDataGridViewTextBoxColumn";
            // 
            // pASSWORDDataGridViewTextBoxColumn
            // 
            this.pASSWORDDataGridViewTextBoxColumn.DataPropertyName = "PASSWORD";
            this.pASSWORDDataGridViewTextBoxColumn.HeaderText = "Şifre";
            this.pASSWORDDataGridViewTextBoxColumn.Name = "pASSWORDDataGridViewTextBoxColumn";
            // 
            // mAILDataGridViewTextBoxColumn
            // 
            this.mAILDataGridViewTextBoxColumn.DataPropertyName = "MAIL";
            this.mAILDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mAILDataGridViewTextBoxColumn.Name = "mAILDataGridViewTextBoxColumn";
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "İsim";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // sURNAMEDataGridViewTextBoxColumn
            // 
            this.sURNAMEDataGridViewTextBoxColumn.DataPropertyName = "SURNAME";
            this.sURNAMEDataGridViewTextBoxColumn.HeaderText = "Soyisim";
            this.sURNAMEDataGridViewTextBoxColumn.Name = "sURNAMEDataGridViewTextBoxColumn";
            // 
            // iSADMINDataGridViewCheckBoxColumn
            // 
            this.iSADMINDataGridViewCheckBoxColumn.DataPropertyName = "IS_ADMIN";
            this.iSADMINDataGridViewCheckBoxColumn.HeaderText = "Admin Yetkisi";
            this.iSADMINDataGridViewCheckBoxColumn.Name = "iSADMINDataGridViewCheckBoxColumn";
            // 
            // uSERSBindingSource
            // 
            this.uSERSBindingSource.DataMember = "USERS";
            this.uSERSBindingSource.DataSource = this.sWAN_CRM_USERS;
            // 
            // sWAN_CRM_USERS
            // 
            this.sWAN_CRM_USERS.DataSetName = "SWAN_CRM_USERS";
            this.sWAN_CRM_USERS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERSTableAdapter
            // 
            this.uSERSTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // veriBox
            // 
            this.veriBox.BackColor = System.Drawing.Color.Transparent;
            this.veriBox.Controls.Add(this.placeholder);
            this.veriBox.Controls.Add(this.userBtn);
            this.veriBox.Controls.Add(this.adminBtn);
            this.veriBox.Controls.Add(this.passwdBox);
            this.veriBox.Controls.Add(this.nameBox);
            this.veriBox.Controls.Add(this.mailBox);
            this.veriBox.Controls.Add(this.surnameBox);
            this.veriBox.Controls.Add(this.usernameBox);
            this.veriBox.Controls.Add(this.idBox);
            this.veriBox.Controls.Add(this.label7);
            this.veriBox.Controls.Add(this.label6);
            this.veriBox.Controls.Add(this.label5);
            this.veriBox.Controls.Add(this.label4);
            this.veriBox.Controls.Add(this.label3);
            this.veriBox.Controls.Add(this.label2);
            this.veriBox.Controls.Add(this.label1);
            this.veriBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.veriBox.Location = new System.Drawing.Point(12, 12);
            this.veriBox.Name = "veriBox";
            this.veriBox.Size = new System.Drawing.Size(291, 235);
            this.veriBox.TabIndex = 3;
            this.veriBox.TabStop = false;
            this.veriBox.Text = "Kullancı Verileri";
            // 
            // placeholder
            // 
            this.placeholder.AutoSize = true;
            this.placeholder.Location = new System.Drawing.Point(261, 204);
            this.placeholder.Name = "placeholder";
            this.placeholder.Size = new System.Drawing.Size(96, 21);
            this.placeholder.TabIndex = 19;
            this.placeholder.Text = "Placeholder";
            this.placeholder.Visible = false;
            this.placeholder.TextChanged += new System.EventHandler(this.placeholder_TextChanged);
            // 
            // userBtn
            // 
            this.userBtn.AutoSize = true;
            this.userBtn.Location = new System.Drawing.Point(189, 200);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(66, 25);
            this.userBtn.TabIndex = 17;
            this.userBtn.TabStop = true;
            this.userBtn.Text = "Hayır";
            this.userBtn.UseVisualStyleBackColor = true;
            this.userBtn.CheckedChanged += new System.EventHandler(this.userBtn_CheckedChanged);
            // 
            // adminBtn
            // 
            this.adminBtn.AutoSize = true;
            this.adminBtn.Location = new System.Drawing.Point(124, 200);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(59, 25);
            this.adminBtn.TabIndex = 16;
            this.adminBtn.TabStop = true;
            this.adminBtn.Text = "Evet";
            this.adminBtn.UseVisualStyleBackColor = true;
            this.adminBtn.CheckedChanged += new System.EventHandler(this.adminBtn_CheckedChanged);
            // 
            // passwdBox
            // 
            this.passwdBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.passwdBox.Location = new System.Drawing.Point(115, 82);
            this.passwdBox.Name = "passwdBox";
            this.passwdBox.Size = new System.Drawing.Size(164, 23);
            this.passwdBox.TabIndex = 12;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.nameBox.Location = new System.Drawing.Point(115, 140);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(164, 23);
            this.nameBox.TabIndex = 14;
            // 
            // mailBox
            // 
            this.mailBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.mailBox.Location = new System.Drawing.Point(115, 111);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(164, 23);
            this.mailBox.TabIndex = 13;
            // 
            // surnameBox
            // 
            this.surnameBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.surnameBox.Location = new System.Drawing.Point(115, 169);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(164, 23);
            this.surnameBox.TabIndex = 15;
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.usernameBox.Location = new System.Drawing.Point(115, 53);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(164, 23);
            this.usernameBox.TabIndex = 11;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Admin Yetkisi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Soyisim:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "İsim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.listBtn);
            this.groupBox1.Controls.Add(this.updateBtn);
            this.groupBox1.Controls.Add(this.remBtn);
            this.groupBox1.Controls.Add(this.clearBtn);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.returnButton);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(319, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 235);
            this.groupBox1.TabIndex = 4;
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SwanCRM.Properties.Resources.SwanCRM;
            this.pictureBox1.Location = new System.Drawing.Point(616, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(684, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Hoşgeldin,";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.Color.Transparent;
            this.userName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.userName.Location = new System.Drawing.Point(768, 12);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(46, 21);
            this.userName.TabIndex = 7;
            this.userName.Text = "------";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SwanCRM.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 514);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.veriBox);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swan CRM - Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWAN_CRM_USERS)).EndInit();
            this.veriBox.ResumeLayout(false);
            this.veriBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SWAN_CRM_USERS sWAN_CRM_USERS;
        private System.Windows.Forms.BindingSource uSERSBindingSource;
        private SWAN_CRM_USERSTableAdapters.USERSTableAdapter uSERSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn iSADMINDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox veriBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.MaskedTextBox passwdBox;
        private System.Windows.Forms.RadioButton userBtn;
        private System.Windows.Forms.RadioButton adminBtn;
        private System.Windows.Forms.Label placeholder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button listBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button remBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label userName;
    }
}