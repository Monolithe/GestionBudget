namespace Gestion_de_budget
{
    partial class FormModifierPostes
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
            this.dataGridViewPostesFixes = new System.Windows.Forms.DataGridView();
            this.dataGridViewRevenus = new System.Windows.Forms.DataGridView();
            this.dataGridViewPostesPonctuels = new System.Windows.Forms.DataGridView();
            this.labelPostesFixes = new System.Windows.Forms.Label();
            this.labelRevenus = new System.Windows.Forms.Label();
            this.labelPostesPonctuels = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostesFixes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevenus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostesPonctuels)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPostesFixes
            // 
            this.dataGridViewPostesFixes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPostesFixes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPostesFixes.Location = new System.Drawing.Point(12, 257);
            this.dataGridViewPostesFixes.Name = "dataGridViewPostesFixes";
            this.dataGridViewPostesFixes.Size = new System.Drawing.Size(413, 213);
            this.dataGridViewPostesFixes.TabIndex = 0;
            // 
            // dataGridViewRevenus
            // 
            this.dataGridViewRevenus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRevenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRevenus.Location = new System.Drawing.Point(431, 257);
            this.dataGridViewRevenus.Name = "dataGridViewRevenus";
            this.dataGridViewRevenus.Size = new System.Drawing.Size(399, 213);
            this.dataGridViewRevenus.TabIndex = 1;
            // 
            // dataGridViewPostesPonctuels
            // 
            this.dataGridViewPostesPonctuels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPostesPonctuels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPostesPonctuels.Location = new System.Drawing.Point(223, 26);
            this.dataGridViewPostesPonctuels.Name = "dataGridViewPostesPonctuels";
            this.dataGridViewPostesPonctuels.Size = new System.Drawing.Size(413, 213);
            this.dataGridViewPostesPonctuels.TabIndex = 2;
            // 
            // labelPostesFixes
            // 
            this.labelPostesFixes.AutoSize = true;
            this.labelPostesFixes.Location = new System.Drawing.Point(9, 241);
            this.labelPostesFixes.Name = "labelPostesFixes";
            this.labelPostesFixes.Size = new System.Drawing.Size(118, 13);
            this.labelPostesFixes.TabIndex = 3;
            this.labelPostesFixes.Text = "Postes à périodicité fixe";
            // 
            // labelRevenus
            // 
            this.labelRevenus.AutoSize = true;
            this.labelRevenus.Location = new System.Drawing.Point(780, 241);
            this.labelRevenus.Name = "labelRevenus";
            this.labelRevenus.Size = new System.Drawing.Size(50, 13);
            this.labelRevenus.TabIndex = 4;
            this.labelRevenus.Text = "Revenus";
            // 
            // labelPostesPonctuels
            // 
            this.labelPostesPonctuels.AutoSize = true;
            this.labelPostesPonctuels.Location = new System.Drawing.Point(344, 9);
            this.labelPostesPonctuels.Name = "labelPostesPonctuels";
            this.labelPostesPonctuels.Size = new System.Drawing.Size(151, 13);
            this.labelPostesPonctuels.TabIndex = 5;
            this.labelPostesPonctuels.Text = "Postes à périodicité ponctuelle";
            // 
            // FormModifierPostes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 482);
            this.Controls.Add(this.labelPostesPonctuels);
            this.Controls.Add(this.labelRevenus);
            this.Controls.Add(this.labelPostesFixes);
            this.Controls.Add(this.dataGridViewPostesPonctuels);
            this.Controls.Add(this.dataGridViewRevenus);
            this.Controls.Add(this.dataGridViewPostesFixes);
            this.Name = "FormModifierPostes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier les postes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostesFixes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevenus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostesPonctuels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPostesFixes;
        private System.Windows.Forms.DataGridView dataGridViewRevenus;
        private System.Windows.Forms.DataGridView dataGridViewPostesPonctuels;
        private System.Windows.Forms.Label labelPostesFixes;
        private System.Windows.Forms.Label labelRevenus;
        private System.Windows.Forms.Label labelPostesPonctuels;
    }
}