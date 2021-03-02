
namespace Client.Forms
{
    partial class FrmUpdateCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateCompany));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtShipsType = new System.Windows.Forms.TextBox();
            this.txtPIB = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Naziv = new System.Windows.Forms.Label();
            this.btnChooseCompany = new System.Windows.Forms.Button();
            this.dgvFindCompanies = new System.Windows.Forms.DataGridView();
            this.txtCriteria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFindCompanies = new System.Windows.Forms.Button();
            this.dgvReturnCompanies = new System.Windows.Forms.DataGridView();
            this.chbDaughter = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindCompanies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnCompanies)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.chbDaughter);
            this.panel1.Controls.Add(this.btnSaveChanges);
            this.panel1.Controls.Add(this.txtShipsType);
            this.panel1.Controls.Add(this.txtPIB);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Naziv);
            this.panel1.Controls.Add(this.btnChooseCompany);
            this.panel1.Controls.Add(this.dgvFindCompanies);
            this.panel1.Controls.Add(this.txtCriteria);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnFindCompanies);
            this.panel1.Controls.Add(this.dgvReturnCompanies);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 500);
            this.panel1.TabIndex = 0;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSaveChanges.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveChanges.Location = new System.Drawing.Point(278, 465);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(150, 23);
            this.btnSaveChanges.TabIndex = 14;
            this.btnSaveChanges.Text = "Sacuvaj promjene";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtShipsType
            // 
            this.txtShipsType.Location = new System.Drawing.Point(165, 409);
            this.txtShipsType.Name = "txtShipsType";
            this.txtShipsType.Size = new System.Drawing.Size(100, 20);
            this.txtShipsType.TabIndex = 13;
            // 
            // txtPIB
            // 
            this.txtPIB.Location = new System.Drawing.Point(165, 382);
            this.txtPIB.Name = "txtPIB";
            this.txtPIB.Size = new System.Drawing.Size(100, 20);
            this.txtPIB.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(165, 356);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipovi brodova";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "PIB";
            // 
            // Naziv
            // 
            this.Naziv.AutoSize = true;
            this.Naziv.Location = new System.Drawing.Point(15, 359);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(35, 12);
            this.Naziv.TabIndex = 7;
            this.Naziv.Text = "Naziv";
            // 
            // btnChooseCompany
            // 
            this.btnChooseCompany.BackColor = System.Drawing.Color.LightSalmon;
            this.btnChooseCompany.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChooseCompany.Location = new System.Drawing.Point(278, 327);
            this.btnChooseCompany.Name = "btnChooseCompany";
            this.btnChooseCompany.Size = new System.Drawing.Size(150, 23);
            this.btnChooseCompany.TabIndex = 6;
            this.btnChooseCompany.Text = "Izaberi kompaniju";
            this.btnChooseCompany.UseVisualStyleBackColor = false;
            this.btnChooseCompany.Click += new System.EventHandler(this.btnChooseCompany_Click);
            // 
            // dgvFindCompanies
            // 
            this.dgvFindCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindCompanies.Location = new System.Drawing.Point(12, 196);
            this.dgvFindCompanies.MultiSelect = false;
            this.dgvFindCompanies.Name = "dgvFindCompanies";
            this.dgvFindCompanies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFindCompanies.Size = new System.Drawing.Size(416, 125);
            this.dgvFindCompanies.TabIndex = 5;
            this.dgvFindCompanies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFindCompanies_CellContentClick);
            // 
            // txtCriteria
            // 
            this.txtCriteria.Location = new System.Drawing.Point(122, 169);
            this.txtCriteria.Name = "txtCriteria";
            this.txtCriteria.Size = new System.Drawing.Size(150, 20);
            this.txtCriteria.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rijec za pretragu";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(278, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Vrati sve kompanije";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFindCompanies
            // 
            this.btnFindCompanies.BackColor = System.Drawing.Color.LightSalmon;
            this.btnFindCompanies.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFindCompanies.Location = new System.Drawing.Point(278, 167);
            this.btnFindCompanies.Name = "btnFindCompanies";
            this.btnFindCompanies.Size = new System.Drawing.Size(150, 23);
            this.btnFindCompanies.TabIndex = 1;
            this.btnFindCompanies.Text = "Pretrazi kompanije";
            this.btnFindCompanies.UseVisualStyleBackColor = false;
            this.btnFindCompanies.Click += new System.EventHandler(this.btnFindCompanies_Click);
            // 
            // dgvReturnCompanies
            // 
            this.dgvReturnCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnCompanies.Location = new System.Drawing.Point(12, 36);
            this.dgvReturnCompanies.MultiSelect = false;
            this.dgvReturnCompanies.Name = "dgvReturnCompanies";
            this.dgvReturnCompanies.ReadOnly = true;
            this.dgvReturnCompanies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnCompanies.Size = new System.Drawing.Size(416, 125);
            this.dgvReturnCompanies.TabIndex = 0;
            // 
            // chbDaughter
            // 
            this.chbDaughter.AutoSize = true;
            this.chbDaughter.Location = new System.Drawing.Point(18, 439);
            this.chbDaughter.Name = "chbDaughter";
            this.chbDaughter.Size = new System.Drawing.Size(117, 16);
            this.chbDaughter.TabIndex = 15;
            this.chbDaughter.Text = "Cerka kompanija";
            this.chbDaughter.UseVisualStyleBackColor = true;
            // 
            // FrmUpdateCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(440, 500);
            this.Controls.Add(this.panel1);
            this.Name = "FrmUpdateCompany";
            this.Text = "FrmChangeCompany";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindCompanies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnCompanies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvReturnCompanies;
        private System.Windows.Forms.TextBox txtCriteria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFindCompanies;
        private System.Windows.Forms.DataGridView dgvFindCompanies;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtShipsType;
        private System.Windows.Forms.TextBox txtPIB;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Naziv;
        private System.Windows.Forms.Button btnChooseCompany;
        private System.Windows.Forms.CheckBox chbDaughter;
    }
}