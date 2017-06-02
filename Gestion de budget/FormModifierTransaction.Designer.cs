namespace Gestion_de_budget
{
    partial class FormModifierTransaction
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
            this.labelNouvelleDate = new System.Windows.Forms.Label();
            this.labelNouvelleDescription = new System.Windows.Forms.Label();
            this.labelNouveauMontant = new System.Windows.Forms.Label();
            this.labelNouveauType = new System.Windows.Forms.Label();
            this.checkBxRecette = new System.Windows.Forms.CheckBox();
            this.checkBxPercu = new System.Windows.Forms.CheckBox();
            this.comboBxType = new System.Windows.Forms.ComboBox();
            this.txtBxNouvelleDescription = new System.Windows.Forms.TextBox();
            this.txtBxNouveauMontant = new System.Windows.Forms.TextBox();
            this.dateTimePickerNouvelleDate = new System.Windows.Forms.DateTimePicker();
            this.btnValiderModifs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNouvelleDate
            // 
            this.labelNouvelleDate.AutoSize = true;
            this.labelNouvelleDate.Location = new System.Drawing.Point(13, 13);
            this.labelNouvelleDate.Name = "labelNouvelleDate";
            this.labelNouvelleDate.Size = new System.Drawing.Size(39, 13);
            this.labelNouvelleDate.TabIndex = 0;
            this.labelNouvelleDate.Text = "Date : ";
            // 
            // labelNouvelleDescription
            // 
            this.labelNouvelleDescription.AutoSize = true;
            this.labelNouvelleDescription.Location = new System.Drawing.Point(13, 47);
            this.labelNouvelleDescription.Name = "labelNouvelleDescription";
            this.labelNouvelleDescription.Size = new System.Drawing.Size(69, 13);
            this.labelNouvelleDescription.TabIndex = 1;
            this.labelNouvelleDescription.Text = "Description : ";
            // 
            // labelNouveauMontant
            // 
            this.labelNouveauMontant.AutoSize = true;
            this.labelNouveauMontant.Location = new System.Drawing.Point(13, 78);
            this.labelNouveauMontant.Name = "labelNouveauMontant";
            this.labelNouveauMontant.Size = new System.Drawing.Size(55, 13);
            this.labelNouveauMontant.TabIndex = 2;
            this.labelNouveauMontant.Text = "Montant : ";
            // 
            // labelNouveauType
            // 
            this.labelNouveauType.AutoSize = true;
            this.labelNouveauType.Location = new System.Drawing.Point(13, 160);
            this.labelNouveauType.Name = "labelNouveauType";
            this.labelNouveauType.Size = new System.Drawing.Size(61, 13);
            this.labelNouveauType.TabIndex = 3;
            this.labelNouveauType.Text = "Catégorie : ";
            // 
            // checkBxRecette
            // 
            this.checkBxRecette.AutoSize = true;
            this.checkBxRecette.Location = new System.Drawing.Point(16, 121);
            this.checkBxRecette.Name = "checkBxRecette";
            this.checkBxRecette.Size = new System.Drawing.Size(64, 17);
            this.checkBxRecette.TabIndex = 4;
            this.checkBxRecette.Text = "Recette";
            this.checkBxRecette.UseVisualStyleBackColor = true;
            // 
            // checkBxPercu
            // 
            this.checkBxPercu.AutoSize = true;
            this.checkBxPercu.Location = new System.Drawing.Point(101, 121);
            this.checkBxPercu.Name = "checkBxPercu";
            this.checkBxPercu.Size = new System.Drawing.Size(54, 17);
            this.checkBxPercu.TabIndex = 5;
            this.checkBxPercu.Text = "Perçu";
            this.checkBxPercu.UseVisualStyleBackColor = true;
            // 
            // comboBxType
            // 
            this.comboBxType.FormattingEnabled = true;
            this.comboBxType.Location = new System.Drawing.Point(88, 157);
            this.comboBxType.Name = "comboBxType";
            this.comboBxType.Size = new System.Drawing.Size(121, 21);
            this.comboBxType.TabIndex = 6;
            // 
            // txtBxNouvelleDescription
            // 
            this.txtBxNouvelleDescription.Location = new System.Drawing.Point(88, 44);
            this.txtBxNouvelleDescription.Name = "txtBxNouvelleDescription";
            this.txtBxNouvelleDescription.Size = new System.Drawing.Size(183, 20);
            this.txtBxNouvelleDescription.TabIndex = 7;
            // 
            // txtBxNouveauMontant
            // 
            this.txtBxNouveauMontant.Location = new System.Drawing.Point(88, 75);
            this.txtBxNouveauMontant.Name = "txtBxNouveauMontant";
            this.txtBxNouveauMontant.Size = new System.Drawing.Size(100, 20);
            this.txtBxNouveauMontant.TabIndex = 8;
            this.txtBxNouveauMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxNouveauMontant_KeyPress);
            // 
            // dateTimePickerNouvelleDate
            // 
            this.dateTimePickerNouvelleDate.Location = new System.Drawing.Point(88, 7);
            this.dateTimePickerNouvelleDate.Name = "dateTimePickerNouvelleDate";
            this.dateTimePickerNouvelleDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerNouvelleDate.TabIndex = 9;
            // 
            // btnValiderModifs
            // 
            this.btnValiderModifs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValiderModifs.Location = new System.Drawing.Point(186, 232);
            this.btnValiderModifs.Name = "btnValiderModifs";
            this.btnValiderModifs.Size = new System.Drawing.Size(109, 39);
            this.btnValiderModifs.TabIndex = 10;
            this.btnValiderModifs.Text = "Valider";
            this.btnValiderModifs.UseVisualStyleBackColor = true;
            this.btnValiderModifs.Click += new System.EventHandler(this.btnValiderModifs_Click);
            // 
            // FormModifierTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 283);
            this.Controls.Add(this.btnValiderModifs);
            this.Controls.Add(this.dateTimePickerNouvelleDate);
            this.Controls.Add(this.txtBxNouveauMontant);
            this.Controls.Add(this.txtBxNouvelleDescription);
            this.Controls.Add(this.comboBxType);
            this.Controls.Add(this.checkBxPercu);
            this.Controls.Add(this.checkBxRecette);
            this.Controls.Add(this.labelNouveauType);
            this.Controls.Add(this.labelNouveauMontant);
            this.Controls.Add(this.labelNouvelleDescription);
            this.Controls.Add(this.labelNouvelleDate);
            this.MinimumSize = new System.Drawing.Size(323, 322);
            this.Name = "FormModifierTransaction";
            this.Text = "Modifier une transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNouvelleDate;
        private System.Windows.Forms.Label labelNouvelleDescription;
        private System.Windows.Forms.Label labelNouveauMontant;
        private System.Windows.Forms.Label labelNouveauType;
        private System.Windows.Forms.CheckBox checkBxRecette;
        private System.Windows.Forms.CheckBox checkBxPercu;
        private System.Windows.Forms.ComboBox comboBxType;
        private System.Windows.Forms.TextBox txtBxNouvelleDescription;
        private System.Windows.Forms.TextBox txtBxNouveauMontant;
        private System.Windows.Forms.DateTimePicker dateTimePickerNouvelleDate;
        private System.Windows.Forms.Button btnValiderModifs;
    }
}