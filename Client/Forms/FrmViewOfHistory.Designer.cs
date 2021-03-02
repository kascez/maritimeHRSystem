
namespace Client.Forms
{
    partial class FrmViewOfHistory
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
            this.dgvViewOfHistory = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindSailors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnSailors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewOfHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseSailor
            // 
            this.btnChooseSailor.BackColor = System.Drawing.Color.LightSalmon;
            this.btnChooseSailor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChooseSailor.Location = new System.Drawing.Point(433, 303);
            this.btnChooseSailor.Name = "btnChooseSailor";
            this.btnChooseSailor.Size = new System.Drawing.Size(175, 21);
            this.btnChooseSailor.TabIndex = 23;
            this.btnChooseSailor.Text = "Izaberi pomorca";
            this.btnChooseSailor.UseVisualStyleBackColor = false;
            this.btnChooseSailor.Click += new System.EventHandler(this.btnChooseSailor_Click);
            // 
            // dgvFindSailors
            // 
            this.dgvFindSailors.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvFindSailors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindSailors.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvFindSailors.Location = new System.Drawing.Point(14, 182);
            this.dgvFindSailors.MultiSelect = false;
            this.dgvFindSailors.Name = "dgvFindSailors";
            this.dgvFindSailors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFindSailors.Size = new System.Drawing.Size(594, 115);
            this.dgvFindSailors.TabIndex = 22;
            this.dgvFindSailors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFindSailors_CellContentClick);
            // 
            // txtCriteria
            // 
            this.txtCriteria.Location = new System.Drawing.Point(153, 157);
            this.txtCriteria.Name = "txtCriteria";
            this.txtCriteria.Size = new System.Drawing.Size(174, 20);
            this.txtCriteria.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "Unesi prezime pomorca";
            // 
            // btnFindSailors
            // 
            this.btnFindSailors.BackColor = System.Drawing.Color.LightSalmon;
            this.btnFindSailors.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFindSailors.Location = new System.Drawing.Point(433, 155);
            this.btnFindSailors.Name = "btnFindSailors";
            this.btnFindSailors.Size = new System.Drawing.Size(175, 21);
            this.btnFindSailors.TabIndex = 19;
            this.btnFindSailors.Text = "Pretrazi pomorce";
            this.btnFindSailors.UseVisualStyleBackColor = false;
            this.btnFindSailors.Click += new System.EventHandler(this.btnFindSailors_Click);
            // 
            // dgvReturnSailors
            // 
            this.dgvReturnSailors.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvReturnSailors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnSailors.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvReturnSailors.Location = new System.Drawing.Point(14, 36);
            this.dgvReturnSailors.MultiSelect = false;
            this.dgvReturnSailors.Name = "dgvReturnSailors";
            this.dgvReturnSailors.ReadOnly = true;
            this.dgvReturnSailors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnSailors.Size = new System.Drawing.Size(594, 115);
            this.dgvReturnSailors.TabIndex = 18;
            this.dgvReturnSailors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReturnSailors_CellContentClick);
            // 
            // btnReturnSailors
            // 
            this.btnReturnSailors.BackColor = System.Drawing.Color.LightSalmon;
            this.btnReturnSailors.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturnSailors.Location = new System.Drawing.Point(433, 9);
            this.btnReturnSailors.Name = "btnReturnSailors";
            this.btnReturnSailors.Size = new System.Drawing.Size(175, 21);
            this.btnReturnSailors.TabIndex = 17;
            this.btnReturnSailors.Text = "Vrati sve pomorce";
            this.btnReturnSailors.UseVisualStyleBackColor = false;
            this.btnReturnSailors.Click += new System.EventHandler(this.btnReturnSailors_Click);
            // 
            // dgvViewOfHistory
            // 
            this.dgvViewOfHistory.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvViewOfHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewOfHistory.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvViewOfHistory.Location = new System.Drawing.Point(14, 337);
            this.dgvViewOfHistory.MultiSelect = false;
            this.dgvViewOfHistory.Name = "dgvViewOfHistory";
            this.dgvViewOfHistory.ReadOnly = true;
            this.dgvViewOfHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewOfHistory.Size = new System.Drawing.Size(594, 138);
            this.dgvViewOfHistory.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "PREGLED ISTORIJE ZAPOSLENOG";
            // 
            // FrmViewOfHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(618, 486);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvViewOfHistory);
            this.Controls.Add(this.btnChooseSailor);
            this.Controls.Add(this.dgvFindSailors);
            this.Controls.Add(this.txtCriteria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFindSailors);
            this.Controls.Add(this.dgvReturnSailors);
            this.Controls.Add(this.btnReturnSailors);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmViewOfHistory";
            this.Text = "FrmViewOfHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindSailors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnSailors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewOfHistory)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvViewOfHistory;
        private System.Windows.Forms.Label label2;
    }
}