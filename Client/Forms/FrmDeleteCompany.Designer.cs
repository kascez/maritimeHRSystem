
namespace Client.Forms
{
    partial class FrmDeleteCompany
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
            this.btnDeleteCompany = new System.Windows.Forms.Button();
            this.dgvFindCompanies = new System.Windows.Forms.DataGridView();
            this.txtCriteria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFindCompanies = new System.Windows.Forms.Button();
            this.dgvReturnCompanies = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindCompanies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnCompanies)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteCompany
            // 
            this.btnDeleteCompany.BackColor = System.Drawing.Color.LightSalmon;
            this.btnDeleteCompany.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteCompany.Location = new System.Drawing.Point(324, 306);
            this.btnDeleteCompany.Name = "btnDeleteCompany";
            this.btnDeleteCompany.Size = new System.Drawing.Size(175, 21);
            this.btnDeleteCompany.TabIndex = 13;
            this.btnDeleteCompany.Text = "Izbrisi kompaniju";
            this.btnDeleteCompany.UseVisualStyleBackColor = false;
            this.btnDeleteCompany.Click += new System.EventHandler(this.btnDeleteCompany_Click);
            // 
            // dgvFindCompanies
            // 
            this.dgvFindCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindCompanies.Location = new System.Drawing.Point(14, 186);
            this.dgvFindCompanies.MultiSelect = false;
            this.dgvFindCompanies.Name = "dgvFindCompanies";
            this.dgvFindCompanies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFindCompanies.Size = new System.Drawing.Size(485, 115);
            this.dgvFindCompanies.TabIndex = 12;
            // 
            // txtCriteria
            // 
            this.txtCriteria.Location = new System.Drawing.Point(142, 161);
            this.txtCriteria.Name = "txtCriteria";
            this.txtCriteria.Size = new System.Drawing.Size(174, 20);
            this.txtCriteria.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rijec za pretragu";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(324, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 21);
            this.button1.TabIndex = 9;
            this.button1.Text = "Vrati sve kompanije";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFindCompanies
            // 
            this.btnFindCompanies.BackColor = System.Drawing.Color.LightSalmon;
            this.btnFindCompanies.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFindCompanies.Location = new System.Drawing.Point(324, 159);
            this.btnFindCompanies.Name = "btnFindCompanies";
            this.btnFindCompanies.Size = new System.Drawing.Size(175, 21);
            this.btnFindCompanies.TabIndex = 8;
            this.btnFindCompanies.Text = "Pretrazi kompanije";
            this.btnFindCompanies.UseVisualStyleBackColor = false;
            this.btnFindCompanies.Click += new System.EventHandler(this.btnFindCompanies_Click);
            // 
            // dgvReturnCompanies
            // 
            this.dgvReturnCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnCompanies.Location = new System.Drawing.Point(14, 38);
            this.dgvReturnCompanies.MultiSelect = false;
            this.dgvReturnCompanies.Name = "dgvReturnCompanies";
            this.dgvReturnCompanies.ReadOnly = true;
            this.dgvReturnCompanies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnCompanies.Size = new System.Drawing.Size(485, 115);
            this.dgvReturnCompanies.TabIndex = 7;
            // 
            // FrmDeleteCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(514, 337);
            this.Controls.Add(this.btnDeleteCompany);
            this.Controls.Add(this.dgvFindCompanies);
            this.Controls.Add(this.txtCriteria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFindCompanies);
            this.Controls.Add(this.dgvReturnCompanies);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmDeleteCompany";
            this.Text = "FrmDeleteCompany";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindCompanies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnCompanies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteCompany;
        private System.Windows.Forms.DataGridView dgvFindCompanies;
        private System.Windows.Forms.TextBox txtCriteria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFindCompanies;
        private System.Windows.Forms.DataGridView dgvReturnCompanies;
    }
}