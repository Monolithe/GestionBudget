namespace Gestion_de_budget
{
    partial class FormAjoutType
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
            this.labelNomType = new System.Windows.Forms.Label();
            this.txtBxNouveauType = new System.Windows.Forms.TextBox();
            this.btnAjoutType = new System.Windows.Forms.Button();
            this.errorAjoutType = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorAjoutType)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNomType
            // 
            this.labelNomType.AutoSize = true;
            this.labelNomType.Location = new System.Drawing.Point(13, 13);
            this.labelNomType.Name = "labelNomType";
            this.labelNomType.Size = new System.Drawing.Size(154, 13);
            this.labelNomType.TabIndex = 0;
            this.labelNomType.Text = "Nom de la nouvelle catégorie : ";
            // 
            // txtBxNouveauType
            // 
            this.txtBxNouveauType.Location = new System.Drawing.Point(174, 10);
            this.txtBxNouveauType.MaxLength = 20;
            this.txtBxNouveauType.Name = "txtBxNouveauType";
            this.txtBxNouveauType.Size = new System.Drawing.Size(216, 20);
            this.txtBxNouveauType.TabIndex = 1;
            this.txtBxNouveauType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxNouveauType_KeyPress);
            // 
            // btnAjoutType
            // 
            this.btnAjoutType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjoutType.Location = new System.Drawing.Point(281, 36);
            this.btnAjoutType.Name = "btnAjoutType";
            this.btnAjoutType.Size = new System.Drawing.Size(109, 35);
            this.btnAjoutType.TabIndex = 2;
            this.btnAjoutType.Text = "Ajouter";
            this.btnAjoutType.UseVisualStyleBackColor = true;
            this.btnAjoutType.Click += new System.EventHandler(this.btnAjoutType_Click);
            // 
            // errorAjoutType
            // 
            this.errorAjoutType.ContainerControl = this;
            // 
            // FormAjoutType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 83);
            this.Controls.Add(this.btnAjoutType);
            this.Controls.Add(this.txtBxNouveauType);
            this.Controls.Add(this.labelNomType);
            this.Name = "FormAjoutType";
            this.Text = "Ajout d\'une catégorie";
            ((System.ComponentModel.ISupportInitialize)(this.errorAjoutType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomType;
        private System.Windows.Forms.TextBox txtBxNouveauType;
        private System.Windows.Forms.Button btnAjoutType;
        private System.Windows.Forms.ErrorProvider errorAjoutType;
    }
}