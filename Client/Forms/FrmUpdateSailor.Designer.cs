
namespace Client.Forms
{
    partial class FrmUpdateSailor
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
            this.btnChooseSailor = new System.Windows.Forms.Button();
            this.dgvFindSailors = new System.Windows.Forms.DataGridView();
            this.txtCriteria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindSailors = new System.Windows.Forms.Button();
            this.dgvReturnSailors = new System.Windows.Forms.DataGridView();
            this.btnReturnSailors = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtLicence = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.cbRank = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindSailors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnSailors)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseSailor
            // 
            this.btnChooseSailor.BackColor = System.Drawing.Color.LightSalmon;
            this.btnChooseSailor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChooseSailor.Location = new System.Drawing.Point(429, 305);
            this.btnChooseSailor.Name = "btnChooseSailor";
            this.btnChooseSailor.Size = new System.Drawing.Size(175, 21);
            this.btnChooseSailor.TabIndex = 16;
            this.btnChooseSailor.Text = "Izaberi pomorca";
            this.btnChooseSailor.UseVisualStyleBackColor = false;
            this.btnChooseSailor.Click += new System.EventHandler(this.btnChooseSailor_Click);
            // 
            // dgvFindSailors
            // 
            this.dgvFindSailors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindSailors.Location = new System.Drawing.Point(10, 184);
            this.dgvFindSailors.MultiSelect = false;
            this.dgvFindSailors.Name = "dgvFindSailors";
            this.dgvFindSailors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFindSailors.Size = new System.Drawing.Size(594, 115);
            this.dgvFindSailors.TabIndex = 15;
            // 
            // txtCriteria
            // 
            this.txtCriteria.Location = new System.Drawing.Point(149, 159);
            this.txtCriteria.Name = "txtCriteria";
            this.txtCriteria.Size = new System.Drawing.Size(174, 20);
            this.txtCriteria.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "Unesi prezime pomorca";
            // 
            // btnFindSailors
            // 
            this.btnFindSailors.BackColor = System.Drawing.Color.LightSalmon;
            this.btnFindSailors.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFindSailors.Location = new System.Drawing.Point(429, 157);
            this.btnFindSailors.Name = "btnFindSailors";
            this.btnFindSailors.Size = new System.Drawing.Size(175, 21);
            this.btnFindSailors.TabIndex = 12;
            this.btnFindSailors.Text = "Pretrazi pomorce";
            this.btnFindSailors.UseVisualStyleBackColor = false;
            this.btnFindSailors.Click += new System.EventHandler(this.btnFindSailors_Click);
            // 
            // dgvReturnSailors
            // 
            this.dgvReturnSailors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnSailors.Location = new System.Drawing.Point(10, 38);
            this.dgvReturnSailors.MultiSelect = false;
            this.dgvReturnSailors.Name = "dgvReturnSailors";
            this.dgvReturnSailors.ReadOnly = true;
            this.dgvReturnSailors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnSailors.Size = new System.Drawing.Size(594, 115);
            this.dgvReturnSailors.TabIndex = 11;
            // 
            // btnReturnSailors
            // 
            this.btnReturnSailors.BackColor = System.Drawing.Color.LightSalmon;
            this.btnReturnSailors.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturnSailors.Location = new System.Drawing.Point(429, 11);
            this.btnReturnSailors.Name = "btnReturnSailors";
            this.btnReturnSailors.Size = new System.Drawing.Size(175, 21);
            this.btnReturnSailors.TabIndex = 10;
            this.btnReturnSailors.Text = "Vrati sve pomorce";
            this.btnReturnSailors.UseVisualStyleBackColor = false;
            this.btnReturnSailors.Click += new System.EventHandler(this.btnReturnSailors_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSaveChanges.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveChanges.Location = new System.Drawing.Point(429, 459);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(175, 21);
            this.btnSaveChanges.TabIndex = 17;
            this.btnSaveChanges.Text = "Sacuvaj promjene";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "Prezime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "Licenca";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "Drzava";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "Cin";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(99, 327);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(116, 20);
            this.txtUsername.TabIndex = 26;
            // 
            // txtLicence
            // 
            this.txtLicence.Location = new System.Drawing.Point(325, 354);
            this.txtLicence.Name = "txtLicence";
            this.txtLicence.Size = new System.Drawing.Size(116, 20);
            this.txtLicence.TabIndex = 29;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(325, 327);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(116, 20);
            this.txtEmail.TabIndex = 30;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(99, 403);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(116, 20);
            this.txtSurname.TabIndex = 31;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 378);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(116, 20);
            this.txtName.TabIndex = 32;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(99, 354);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(116, 20);
            this.txtPassword.TabIndex = 33;
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(325, 378);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(140, 20);
            this.cbCountry.TabIndex = 34;
            // 
            // cbRank
            // 
            this.cbRank.FormattingEnabled = true;
            this.cbRank.Location = new System.Drawing.Point(325, 403);
            this.cbRank.Name = "cbRank";
            this.cbRank.Size = new System.Drawing.Size(140, 20);
            this.cbRank.TabIndex = 35;
            // 
            // FrmUpdateSailor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(618, 491);
            this.Controls.Add(this.cbRank);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLicence);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnChooseSailor);
            this.Controls.Add(this.dgvFindSailors);
            this.Controls.Add(this.txtCriteria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFindSailors);
            this.Controls.Add(this.dgvReturnSailors);
            this.Controls.Add(this.btnReturnSailors);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmUpdateSailor";
            this.Text = "FrmUpdateSailor";
            this.Load += new System.EventHandler(this.FrmUpdateSailor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindSailors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnSailors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseSailor;
        private System.Windows.Forms.DataGridView dgvFindSailors;
        private System.Windows.Forms.TextBox txtCriteria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindSailors;
        private System.Windows.Forms.DataGridView dgvReturnSailors;
        private System.Windows.Forms.Button btnReturnSailors;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtLicence;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.ComboBox cbRank;
    }
}