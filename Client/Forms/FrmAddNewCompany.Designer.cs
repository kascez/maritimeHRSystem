
namespace Client.Forms
{
    partial class FrmAddNewCompany
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPIB = new System.Windows.Forms.TextBox();
            this.txtShipTypes = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvWorkplaces = new System.Windows.Forms.DataGridView();
            this.btnDeleteWorkplace = new System.Windows.Forms.Button();
            this.btnAddWorkplace = new System.Windows.Forms.Button();
            this.txtNumberOfPlaces = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWorkplaceName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.chbDaughter = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkplaces)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum osnivanja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "PIB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tip brodova";
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Location = new System.Drawing.Point(203, 21);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(116, 20);
            this.txtDateOfBirth.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(203, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(116, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtPIB
            // 
            this.txtPIB.Location = new System.Drawing.Point(203, 70);
            this.txtPIB.Name = "txtPIB";
            this.txtPIB.Size = new System.Drawing.Size(116, 20);
            this.txtPIB.TabIndex = 7;
            // 
            // txtShipTypes
            // 
            this.txtShipTypes.Location = new System.Drawing.Point(203, 94);
            this.txtShipTypes.Name = "txtShipTypes";
            this.txtShipTypes.Size = new System.Drawing.Size(116, 20);
            this.txtShipTypes.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvWorkplaces);
            this.groupBox1.Controls.Add(this.btnDeleteWorkplace);
            this.groupBox1.Controls.Add(this.btnAddWorkplace);
            this.groupBox1.Controls.Add(this.txtNumberOfPlaces);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtWorkplaceName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(14, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 218);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj radna mjesta";
            // 
            // dgvWorkplaces
            // 
            this.dgvWorkplaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkplaces.Location = new System.Drawing.Point(7, 74);
            this.dgvWorkplaces.MultiSelect = false;
            this.dgvWorkplaces.Name = "dgvWorkplaces";
            this.dgvWorkplaces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorkplaces.Size = new System.Drawing.Size(465, 138);
            this.dgvWorkplaces.TabIndex = 6;
            // 
            // btnDeleteWorkplace
            // 
            this.btnDeleteWorkplace.BackColor = System.Drawing.Color.LightSalmon;
            this.btnDeleteWorkplace.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteWorkplace.Location = new System.Drawing.Point(352, 46);
            this.btnDeleteWorkplace.Name = "btnDeleteWorkplace";
            this.btnDeleteWorkplace.Size = new System.Drawing.Size(87, 21);
            this.btnDeleteWorkplace.TabIndex = 5;
            this.btnDeleteWorkplace.Text = "Obrisi";
            this.btnDeleteWorkplace.UseVisualStyleBackColor = false;
            this.btnDeleteWorkplace.Click += new System.EventHandler(this.btnDeleteWorkplace_Click);
            // 
            // btnAddWorkplace
            // 
            this.btnAddWorkplace.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAddWorkplace.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddWorkplace.Location = new System.Drawing.Point(352, 22);
            this.btnAddWorkplace.Name = "btnAddWorkplace";
            this.btnAddWorkplace.Size = new System.Drawing.Size(87, 21);
            this.btnAddWorkplace.TabIndex = 4;
            this.btnAddWorkplace.Text = "Dodaj";
            this.btnAddWorkplace.UseVisualStyleBackColor = false;
            this.btnAddWorkplace.Click += new System.EventHandler(this.btnAddWorkplace_Click);
            // 
            // txtNumberOfPlaces
            // 
            this.txtNumberOfPlaces.Location = new System.Drawing.Point(189, 48);
            this.txtNumberOfPlaces.Name = "txtNumberOfPlaces";
            this.txtNumberOfPlaces.Size = new System.Drawing.Size(116, 20);
            this.txtNumberOfPlaces.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "Broj mjesta";
            // 
            // txtWorkplaceName
            // 
            this.txtWorkplaceName.Location = new System.Drawing.Point(189, 24);
            this.txtWorkplaceName.Name = "txtWorkplaceName";
            this.txtWorkplaceName.Size = new System.Drawing.Size(116, 20);
            this.txtWorkplaceName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Naziv radnog mjesta";
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAddCompany.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddCompany.Location = new System.Drawing.Point(246, 411);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(208, 21);
            this.btnAddCompany.TabIndex = 10;
            this.btnAddCompany.Text = "Sacuvaj kompaniju";
            this.btnAddCompany.UseVisualStyleBackColor = false;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // chbDaughter
            // 
            this.chbDaughter.AutoSize = true;
            this.chbDaughter.Location = new System.Drawing.Point(29, 123);
            this.chbDaughter.Name = "chbDaughter";
            this.chbDaughter.Size = new System.Drawing.Size(117, 16);
            this.chbDaughter.TabIndex = 16;
            this.chbDaughter.Text = "Cerka kompanija";
            this.chbDaughter.UseVisualStyleBackColor = true;
            // 
            // FrmAddNewCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(503, 465);
            this.Controls.Add(this.chbDaughter);
            this.Controls.Add(this.btnAddCompany);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtShipTypes);
            this.Controls.Add(this.txtPIB);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDateOfBirth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmAddNewCompany";
            this.Text = "FrmAddNewCompany";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkplaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPIB;
        private System.Windows.Forms.TextBox txtShipTypes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvWorkplaces;
        private System.Windows.Forms.Button btnDeleteWorkplace;
        private System.Windows.Forms.Button btnAddWorkplace;
        private System.Windows.Forms.TextBox txtNumberOfPlaces;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWorkplaceName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.CheckBox chbDaughter;
    }
}