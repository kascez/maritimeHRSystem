
namespace Client.Forms
{
    partial class FrmAddNewEngagement
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
            this.btnChooseWorkplace = new System.Windows.Forms.Button();
            this.dgvFindWorkplaces = new System.Windows.Forms.DataGridView();
            this.txtCriteria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindWorkplaces = new System.Windows.Forms.Button();
            this.dgvReturnWorkplaces = new System.Windows.Forms.DataGridView();
            this.btnReturnWorplaces = new System.Windows.Forms.Button();
            this.btnChooseSailor = new System.Windows.Forms.Button();
            this.dgvFindSailors = new System.Windows.Forms.DataGridView();
            this.txtCriteriaSailor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFindSailors = new System.Windows.Forms.Button();
            this.dgvReturnSailors = new System.Windows.Forms.DataGridView();
            this.btnReturnSailors = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDateFrom = new System.Windows.Forms.TextBox();
            this.txtDateTo = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblWorkplace = new System.Windows.Forms.Label();
            this.lblSailor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindWorkplaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnWorkplaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindSailors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnSailors)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseWorkplace
            // 
            this.btnChooseWorkplace.BackColor = System.Drawing.Color.LightSalmon;
            this.btnChooseWorkplace.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChooseWorkplace.Location = new System.Drawing.Point(265, 300);
            this.btnChooseWorkplace.Name = "btnChooseWorkplace";
            this.btnChooseWorkplace.Size = new System.Drawing.Size(146, 21);
            this.btnChooseWorkplace.TabIndex = 16;
            this.btnChooseWorkplace.Text = "Izaberi radno mjesto";
            this.btnChooseWorkplace.UseVisualStyleBackColor = false;
            this.btnChooseWorkplace.Click += new System.EventHandler(this.btnChooseWorkplace_Click);
            // 
            // dgvFindWorkplaces
            // 
            this.dgvFindWorkplaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindWorkplaces.Location = new System.Drawing.Point(14, 179);
            this.dgvFindWorkplaces.MultiSelect = false;
            this.dgvFindWorkplaces.Name = "dgvFindWorkplaces";
            this.dgvFindWorkplaces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFindWorkplaces.Size = new System.Drawing.Size(397, 115);
            this.dgvFindWorkplaces.TabIndex = 15;
            // 
            // txtCriteria
            // 
            this.txtCriteria.Location = new System.Drawing.Point(153, 154);
            this.txtCriteria.Name = "txtCriteria";
            this.txtCriteria.Size = new System.Drawing.Size(93, 20);
            this.txtCriteria.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "Unesi ime radnog mjesta";
            // 
            // btnFindWorkplaces
            // 
            this.btnFindWorkplaces.BackColor = System.Drawing.Color.LightSalmon;
            this.btnFindWorkplaces.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFindWorkplaces.Location = new System.Drawing.Point(265, 152);
            this.btnFindWorkplaces.Name = "btnFindWorkplaces";
            this.btnFindWorkplaces.Size = new System.Drawing.Size(146, 21);
            this.btnFindWorkplaces.TabIndex = 12;
            this.btnFindWorkplaces.Text = "Pretrazi radna mjesta";
            this.btnFindWorkplaces.UseVisualStyleBackColor = false;
            this.btnFindWorkplaces.Click += new System.EventHandler(this.btnFindWorkplaces_Click);
            // 
            // dgvReturnWorkplaces
            // 
            this.dgvReturnWorkplaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnWorkplaces.Location = new System.Drawing.Point(14, 33);
            this.dgvReturnWorkplaces.MultiSelect = false;
            this.dgvReturnWorkplaces.Name = "dgvReturnWorkplaces";
            this.dgvReturnWorkplaces.ReadOnly = true;
            this.dgvReturnWorkplaces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnWorkplaces.Size = new System.Drawing.Size(397, 115);
            this.dgvReturnWorkplaces.TabIndex = 11;
            // 
            // btnReturnWorplaces
            // 
            this.btnReturnWorplaces.BackColor = System.Drawing.Color.LightSalmon;
            this.btnReturnWorplaces.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturnWorplaces.Location = new System.Drawing.Point(265, 6);
            this.btnReturnWorplaces.Name = "btnReturnWorplaces";
            this.btnReturnWorplaces.Size = new System.Drawing.Size(146, 21);
            this.btnReturnWorplaces.TabIndex = 10;
            this.btnReturnWorplaces.Text = "Vrati sva radna mjesta";
            this.btnReturnWorplaces.UseVisualStyleBackColor = false;
            this.btnReturnWorplaces.Click += new System.EventHandler(this.btnReturnWorplaces_Click);
            // 
            // btnChooseSailor
            // 
            this.btnChooseSailor.BackColor = System.Drawing.Color.LightSalmon;
            this.btnChooseSailor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChooseSailor.Location = new System.Drawing.Point(714, 300);
            this.btnChooseSailor.Name = "btnChooseSailor";
            this.btnChooseSailor.Size = new System.Drawing.Size(145, 21);
            this.btnChooseSailor.TabIndex = 23;
            this.btnChooseSailor.Text = "Izaberi pomorca";
            this.btnChooseSailor.UseVisualStyleBackColor = false;
            this.btnChooseSailor.Click += new System.EventHandler(this.btnChooseSailor_Click);
            // 
            // dgvFindSailors
            // 
            this.dgvFindSailors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindSailors.Location = new System.Drawing.Point(435, 179);
            this.dgvFindSailors.MultiSelect = false;
            this.dgvFindSailors.Name = "dgvFindSailors";
            this.dgvFindSailors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFindSailors.Size = new System.Drawing.Size(423, 115);
            this.dgvFindSailors.TabIndex = 22;
            // 
            // txtCriteriaSailor
            // 
            this.txtCriteriaSailor.Location = new System.Drawing.Point(575, 154);
            this.txtCriteriaSailor.Name = "txtCriteriaSailor";
            this.txtCriteriaSailor.Size = new System.Drawing.Size(131, 20);
            this.txtCriteriaSailor.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "Rijec za pretragu";
            // 
            // btnFindSailors
            // 
            this.btnFindSailors.BackColor = System.Drawing.Color.LightSalmon;
            this.btnFindSailors.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFindSailors.Location = new System.Drawing.Point(714, 152);
            this.btnFindSailors.Name = "btnFindSailors";
            this.btnFindSailors.Size = new System.Drawing.Size(145, 21);
            this.btnFindSailors.TabIndex = 19;
            this.btnFindSailors.Text = "Pretrazi pomorce";
            this.btnFindSailors.UseVisualStyleBackColor = false;
            this.btnFindSailors.Click += new System.EventHandler(this.btnFindSailors_Click);
            // 
            // dgvReturnSailors
            // 
            this.dgvReturnSailors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnSailors.Location = new System.Drawing.Point(435, 33);
            this.dgvReturnSailors.MultiSelect = false;
            this.dgvReturnSailors.Name = "dgvReturnSailors";
            this.dgvReturnSailors.ReadOnly = true;
            this.dgvReturnSailors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnSailors.Size = new System.Drawing.Size(423, 115);
            this.dgvReturnSailors.TabIndex = 18;
            // 
            // btnReturnSailors
            // 
            this.btnReturnSailors.BackColor = System.Drawing.Color.LightSalmon;
            this.btnReturnSailors.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturnSailors.Location = new System.Drawing.Point(714, 6);
            this.btnReturnSailors.Name = "btnReturnSailors";
            this.btnReturnSailors.Size = new System.Drawing.Size(145, 21);
            this.btnReturnSailors.TabIndex = 17;
            this.btnReturnSailors.Text = "Vrati sve pomorce";
            this.btnReturnSailors.UseVisualStyleBackColor = false;
            this.btnReturnSailors.Click += new System.EventHandler(this.btnReturnSailors_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSaveChanges.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveChanges.Location = new System.Drawing.Point(714, 383);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(146, 21);
            this.btnSaveChanges.TabIndex = 24;
            this.btnSaveChanges.Text = "Sacuvaj zaposlenje";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "Datum od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "Datum do";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 27;
            this.label5.Text = "Plata";
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Location = new System.Drawing.Point(79, 342);
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.Size = new System.Drawing.Size(116, 20);
            this.txtDateFrom.TabIndex = 28;
            // 
            // txtDateTo
            // 
            this.txtDateTo.Location = new System.Drawing.Point(79, 370);
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.Size = new System.Drawing.Size(116, 20);
            this.txtDateTo.TabIndex = 29;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(475, 342);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(116, 20);
            this.txtSalary.TabIndex = 30;
            // 
            // lblWorkplace
            // 
            this.lblWorkplace.AutoSize = true;
            this.lblWorkplace.Location = new System.Drawing.Point(10, 309);
            this.lblWorkplace.Name = "lblWorkplace";
            this.lblWorkplace.Size = new System.Drawing.Size(57, 12);
            this.lblWorkplace.TabIndex = 31;
            this.lblWorkplace.Text = "Izabrano:";
            // 
            // lblSailor
            // 
            this.lblSailor.AutoSize = true;
            this.lblSailor.Location = new System.Drawing.Point(432, 304);
            this.lblSailor.Name = "lblSailor";
            this.lblSailor.Size = new System.Drawing.Size(50, 12);
            this.lblSailor.TabIndex = 32;
            this.lblSailor.Text = "Izabran:";
            // 
            // FrmAddNewEngagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(874, 415);
            this.Controls.Add(this.lblSailor);
            this.Controls.Add(this.lblWorkplace);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtDateTo);
            this.Controls.Add(this.txtDateFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnChooseSailor);
            this.Controls.Add(this.dgvFindSailors);
            this.Controls.Add(this.txtCriteriaSailor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFindSailors);
            this.Controls.Add(this.dgvReturnSailors);
            this.Controls.Add(this.btnReturnSailors);
            this.Controls.Add(this.btnChooseWorkplace);
            this.Controls.Add(this.dgvFindWorkplaces);
            this.Controls.Add(this.txtCriteria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFindWorkplaces);
            this.Controls.Add(this.dgvReturnWorkplaces);
            this.Controls.Add(this.btnReturnWorplaces);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmAddNewEngagement";
            this.Text = "FrmAddNewEngagement";
            this.Load += new System.EventHandler(this.FrmAddNewEngagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindWorkplaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnWorkplaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindSailors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnSailors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseWorkplace;
        private System.Windows.Forms.DataGridView dgvFindWorkplaces;
        private System.Windows.Forms.TextBox txtCriteria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindWorkplaces;
        private System.Windows.Forms.DataGridView dgvReturnWorkplaces;
        private System.Windows.Forms.Button btnReturnWorplaces;
        private System.Windows.Forms.Button btnChooseSailor;
        private System.Windows.Forms.DataGridView dgvFindSailors;
        private System.Windows.Forms.TextBox txtCriteriaSailor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFindSailors;
        private System.Windows.Forms.DataGridView dgvReturnSailors;
        private System.Windows.Forms.Button btnReturnSailors;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDateFrom;
        private System.Windows.Forms.TextBox txtDateTo;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblWorkplace;
        private System.Windows.Forms.Label lblSailor;
    }
}