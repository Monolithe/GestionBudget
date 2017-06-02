namespace Gestion_de_budget
{
    partial class FormAjoutPersonne
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
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.txtBxNom = new System.Windows.Forms.TextBox();
            this.txtBxPrenom = new System.Windows.Forms.TextBox();
            this.btnAjoutPersonne = new System.Windows.Forms.Button();
            this.errorAjoutPersonne = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorAjoutPersonne)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(13, 13);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(35, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom :";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(13, 48);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(52, 13);
            this.labelPrenom.TabIndex = 1;
            this.labelPrenom.Text = "Prénom : ";
            // 
            // txtBxNom
            // 
            this.txtBxNom.Location = new System.Drawing.Point(72, 10);
            this.txtBxNom.Name = "txtBxNom";
            this.txtBxNom.Size = new System.Drawing.Size(176, 20);
            this.txtBxNom.TabIndex = 2;
            // 
            // txtBxPrenom
            // 
            this.txtBxPrenom.Location = new System.Drawing.Point(71, 45);
            this.txtBxPrenom.Name = "txtBxPrenom";
            this.txtBxPrenom.Size = new System.Drawing.Size(177, 20);
            this.txtBxPrenom.TabIndex = 3;
            // 
            // btnAjoutPersonne
            // 
            this.btnAjoutPersonne.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAjoutPersonne.Location = new System.Drawing.Point(95, 97);
            this.btnAjoutPersonne.Name = "btnAjoutPersonne";
            this.btnAjoutPersonne.Size = new System.Drawing.Size(81, 35);
            this.btnAjoutPersonne.TabIndex = 4;
            this.btnAjoutPersonne.Text = "Ajouter";
            this.btnAjoutPersonne.UseVisualStyleBackColor = true;
            // 
            // errorAjoutPersonne
            // 
            this.errorAjoutPersonne.ContainerControl = this;
            // 
            // FormAjoutPersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 144);
            this.Controls.Add(this.btnAjoutPersonne);
            this.Controls.Add(this.txtBxPrenom);
            this.Controls.Add(this.txtBxNom);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Name = "FormAjoutPersonne";
            this.Text = "Ajout d\'une personne";
            ((System.ComponentModel.ISupportInitialize)(this.errorAjoutPersonne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox txtBxNom;
        private System.Windows.Forms.TextBox txtBxPrenom;
        private System.Windows.Forms.Button btnAjoutPersonne;
        private System.Windows.Forms.ErrorProvider errorAjoutPersonne;
    }
}