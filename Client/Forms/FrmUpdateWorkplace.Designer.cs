
namespace Client.Forms
{
    partial class FrmUpdateWorkplace
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
            this.btnReturnWorplaces = new System.Windows.Forms.Button();
            this.dgvReturnWorkplaces = new System.Windows.Forms.DataGridView();
            this.txtCriteria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindWorkplaces = new System.Windows.Forms.Button();
            this.dgvFindWorkplaces = new System.Windows.Forms.DataGridView();
            this.btnChooseWorkplace = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumberOfPlaces = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnWorkplaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindWorkplaces)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturnWorplaces
            // 
            this.btnReturnWorplaces.BackColor = System.Drawing.Color.LightSalmon;
            this.btnReturnWorplaces.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturnWorplaces.Location = new System.Drawing.Point(343, 11);
            this.btnReturnWorplaces.Name = "btnReturnWorplaces";
            this.btnReturnWorplaces.Size = new System.Drawing.Size(175, 21);
            this.btnReturnWorplaces.TabIndex = 3;
            this.btnReturnWorplaces.Text = "Vrati sva radna mjesta";
            this.btnReturnWorplaces.UseVisualStyleBackColor = false;
            this.btnReturnWorplaces.Click += new System.EventHandler(this.btnReturnWorplaces_Click);
            // 
            // dgvReturnWorkplaces
            // 
            this.dgvReturnWorkplaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnWorkplaces.Location = new System.Drawing.Point(14, 38);
            this.dgvReturnWorkplaces.MultiSelect = false;
            this.dgvReturnWorkplaces.Name = "dgvReturnWorkplaces";
            this.dgvReturnWorkplaces.ReadOnly = true;
            this.dgvReturnWorkplaces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnWorkplaces.Size = new System.Drawing.Size(504, 115);
            this.dgvReturnWorkplaces.TabIndex = 4;
            // 
            // txtCriteria
            // 
            this.txtCriteria.Location = new System.Drawing.Point(153, 159);
            this.txtCriteria.Name = "txtCriteria";
            this.txtCriteria.Size = new System.Drawing.Size(174, 20);
            this.txtCriteria.TabIndex = 7;
            this.txtCriteria.TextChanged += new System.EventHandler(this.txtCriteria_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unesi ime radnog mjesta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnFindWorkplaces
            // 
            this.btnFindWorkplaces.BackColor = System.Drawing.Color.LightSalmon;
            this.btnFindWorkplaces.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFindWorkplaces.Location = new System.Drawing.Point(335, 157);
            this.btnFindWorkplaces.Name = "btnFindWorkplaces";
            this.btnFindWorkplaces.Size = new System.Drawing.Size(175, 21);
            this.btnFindWorkplaces.TabIndex = 5;
            this.btnFindWorkplaces.Text = "Pretrazi radna mjesta";
            this.btnFindWorkplaces.UseVisualStyleBackColor = false;
            this.btnFindWorkplaces.Click += new System.EventHandler(this.btnFindCompanies_Click);
            // 
            // dgvFindWorkplaces
            // 
            this.dgvFindWorkplaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindWorkplaces.Location = new System.Drawing.Point(14, 184);
            this.dgvFindWorkplaces.MultiSelect = false;
            this.dgvFindWorkplaces.Name = "dgvFindWorkplaces";
            this.dgvFindWorkplaces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFindWorkplaces.Size = new System.Drawing.Size(504, 115);
            this.dgvFindWorkplaces.TabIndex = 8;
            // 
            // btnChooseWorkplace
            // 
            this.btnChooseWorkplace.BackColor = System.Drawing.Color.LightSalmon;
            this.btnChooseWorkplace.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChooseWorkplace.Location = new System.Drawing.Point(335, 305);
            this.btnChooseWorkplace.Name = "btnChooseWorkplace";
            this.btnChooseWorkplace.Size = new System.Drawing.Size(175, 21);
            this.btnChooseWorkplace.TabIndex = 9;
            this.btnChooseWorkplace.Text = "Izaberi radno mjesto";
            this.btnChooseWorkplace.UseVisualStyleBackColor = false;
            this.btnChooseWorkplace.Click += new System.EventHandler(this.btnChooseWorkplace_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "Broj slobodnih mjesta";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(153, 356);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(116, 20);
            this.txtName.TabIndex = 12;
            // 
            // txtNumberOfPlaces
            // 
            this.txtNumberOfPlaces.Location = new System.Drawing.Point(153, 383);
            this.txtNumberOfPlaces.Name = "txtNumberOfPlaces";
            this.txtNumberOfPlaces.Size = new System.Drawing.Size(116, 20);
            this.txtNumberOfPlaces.TabIndex = 13;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSaveChanges.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveChanges.Location = new System.Drawing.Point(335, 420);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(175, 21);
            this.btnSaveChanges.TabIndex = 15;
            this.btnSaveChanges.Text = "Sacuvaj promjene";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // FrmUpdateWorkplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(532, 454);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.txtNumberOfPlaces);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChooseWorkplace);
            this.Controls.Add(this.dgvFindWorkplaces);
            this.Controls.Add(this.txtCriteria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFindWorkplaces);
            this.Controls.Add(this.dgvReturnWorkplaces);
            this.Controls.Add(this.btnReturnWorplaces);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmUpdateWorkplace";
            this.Text = "UpdateWorkplace";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnWorkplaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindWorkplaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnWorplaces;
        private System.Windows.Forms.DataGridView dgvReturnWorkplaces;
        private System.Windows.Forms.TextBox txtCriteria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindWorkplaces;
        private System.Windows.Forms.DataGridView dgvFindWorkplaces;
        private System.Windows.Forms.Button btnChooseWorkplace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumberOfPlaces;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}