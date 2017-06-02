namespace Gestion_de_budget
{
    partial class FormGestionBudget
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pageOnglets = new System.Windows.Forms.TabControl();
            this.ongletAffichage1a1 = new System.Windows.Forms.TabPage();
            this.lstBxPersonnesConcernees = new System.Windows.Forms.ListBox();
            this.btnFin = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnDebut = new System.Windows.Forms.Button();
            this.checkBxPercu1a1 = new System.Windows.Forms.CheckBox();
            this.checkBxRecette1a1 = new System.Windows.Forms.CheckBox();
            this.labelMontant1a1 = new System.Windows.Forms.Label();
            this.labelDescription1a1 = new System.Windows.Forms.Label();
            this.labelType1a1 = new System.Windows.Forms.Label();
            this.labelNumTransaction = new System.Windows.Forms.Label();
            this.dateTimePicker1a1 = new System.Windows.Forms.DateTimePicker();
            this.ongletAjoutTransaction = new System.Windows.Forms.TabPage();
            this.grpBxUtilisateursGeneres = new System.Windows.Forms.GroupBox();
            this.checkBxPercu = new System.Windows.Forms.CheckBox();
            this.checkBxRecette = new System.Windows.Forms.CheckBox();
            this.btnAjoutPersonne = new System.Windows.Forms.Button();
            this.txtBxMontant = new System.Windows.Forms.TextBox();
            this.txtBxDescription = new System.Windows.Forms.TextBox();
            this.btnFinalAjouter = new System.Windows.Forms.Button();
            this.btnAjoutType = new System.Windows.Forms.Button();
            this.comboBxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.dateTimePickerDateDepense = new System.Windows.Forms.DateTimePicker();
            this.labelMontant = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDateDepense = new System.Windows.Forms.Label();
            this.ongletSuppressionTransaction = new System.Windows.Forms.TabPage();
            this.btnSupprimerTransaction = new System.Windows.Forms.Button();
            this.dataGridViewSuppression = new System.Windows.Forms.DataGridView();
            this.ongletModifTransaction = new System.Windows.Forms.TabPage();
            this.btnModification = new System.Windows.Forms.Button();
            this.dataGridViewModification = new System.Windows.Forms.DataGridView();
            this.ongletRecapitulatif = new System.Windows.Forms.TabPage();
            this.grpBxCriteres = new System.Windows.Forms.GroupBox();
            this.checkBxCritereRecette = new System.Windows.Forms.CheckBox();
            this.checkBxCritereEncaisse = new System.Windows.Forms.CheckBox();
            this.checkBxCriterePrix = new System.Windows.Forms.CheckBox();
            this.checkBxCritereType = new System.Windows.Forms.CheckBox();
            this.checkBxCritereDate = new System.Windows.Forms.CheckBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnGenererPdf = new System.Windows.Forms.Button();
            this.dataGridViewResultatsRecherche = new System.Windows.Forms.DataGridView();
            this.grpBxRecherche = new System.Windows.Forms.GroupBox();
            this.checkBxRecetteRecap = new System.Windows.Forms.CheckBox();
            this.checkBxEncaisse = new System.Windows.Forms.CheckBox();
            this.txtBxMontantRecap = new System.Windows.Forms.TextBox();
            this.radioBtnInferieurEgal = new System.Windows.Forms.RadioButton();
            this.radioBtnSuperieurEgal = new System.Windows.Forms.RadioButton();
            this.radioBtnStrictementEgal = new System.Windows.Forms.RadioButton();
            this.labelMontantRecap = new System.Windows.Forms.Label();
            this.labelTypeRecap = new System.Windows.Forms.Label();
            this.comboBxTypeRecap = new System.Windows.Forms.ComboBox();
            this.labelAu = new System.Windows.Forms.Label();
            this.labelLeDu = new System.Windows.Forms.Label();
            this.dateTimePickerRecapAu = new System.Windows.Forms.DateTimePicker();
            this.checkBxPlage = new System.Windows.Forms.CheckBox();
            this.dateTimePickerRecapDu = new System.Windows.Forms.DateTimePicker();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budget1DataSet = new Gestion_de_budget.budget1DataSet();
            this.transactionTableAdapter = new Gestion_de_budget.budget1DataSetTableAdapters.TransactionTableAdapter();
            this.tabControlVolets = new System.Windows.Forms.TabControl();
            this.tabVolet1 = new System.Windows.Forms.TabPage();
            this.tabVolet2 = new System.Windows.Forms.TabPage();
            this.BudgetOnglets = new System.Windows.Forms.TabControl();
            this.PagePosteFixe = new System.Windows.Forms.TabPage();
            this.btnCalendrier = new System.Windows.Forms.Button();
            this.btnModifierPostes = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtBxMontantPosteFixe = new System.Windows.Forms.TextBox();
            this.labelMontantPosteFixe = new System.Windows.Forms.Label();
            this.labelJourDuMois = new System.Windows.Forms.Label();
            this.txtBxJourDuMois = new System.Windows.Forms.TextBox();
            this.comboBxPeriodicite = new System.Windows.Forms.ComboBox();
            this.labelPeriodicite = new System.Windows.Forms.Label();
            this.btnAutrePoste = new System.Windows.Forms.Button();
            this.comboBxLibellePoste = new System.Windows.Forms.ComboBox();
            this.labelPoste = new System.Windows.Forms.Label();
            this.PagePostePonctuel = new System.Windows.Forms.TabPage();
            this.btnCalendrier2 = new System.Windows.Forms.Button();
            this.btnModifierPostes2 = new System.Windows.Forms.Button();
            this.BtnValiderPonctuel = new System.Windows.Forms.Button();
            this.grpBxEcheances = new System.Windows.Forms.GroupBox();
            this.txtBxMontantEcheance = new System.Windows.Forms.TextBox();
            this.dateTimePickerEcheance = new System.Windows.Forms.DateTimePicker();
            this.labelEcheance1 = new System.Windows.Forms.Label();
            this.txtBxNombrePrelevements = new System.Windows.Forms.TextBox();
            this.labelNombrePrelevements = new System.Windows.Forms.Label();
            this.labelCommentaire = new System.Windows.Forms.Label();
            this.txtBxCommentaire = new System.Windows.Forms.TextBox();
            this.txtBxIntitule = new System.Windows.Forms.TextBox();
            this.labelIntitulePoste = new System.Windows.Forms.Label();
            this.PageRevenu = new System.Windows.Forms.TabPage();
            this.btnCalendrier3 = new System.Windows.Forms.Button();
            this.btnValiderRevenu = new System.Windows.Forms.Button();
            this.labelJourDuMoisRevenu = new System.Windows.Forms.Label();
            this.txtBxJourDuMoisRevenu = new System.Windows.Forms.TextBox();
            this.txtBxMontantRevenu = new System.Windows.Forms.TextBox();
            this.labelMontantRevenu = new System.Windows.Forms.Label();
            this.comboBxBeneficiaire = new System.Windows.Forms.ComboBox();
            this.labelBeneficiaire = new System.Windows.Forms.Label();
            this.txtBxNomRevenu = new System.Windows.Forms.TextBox();
            this.labelNomDuRevenu = new System.Windows.Forms.Label();
            this.errorGestionBudget = new System.Windows.Forms.ErrorProvider(this.components);
            this.pageOnglets.SuspendLayout();
            this.ongletAffichage1a1.SuspendLayout();
            this.ongletAjoutTransaction.SuspendLayout();
            this.ongletSuppressionTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppression)).BeginInit();
            this.ongletModifTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModification)).BeginInit();
            this.ongletRecapitulatif.SuspendLayout();
            this.grpBxCriteres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultatsRecherche)).BeginInit();
            this.grpBxRecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budget1DataSet)).BeginInit();
            this.tabControlVolets.SuspendLayout();
            this.tabVolet1.SuspendLayout();
            this.tabVolet2.SuspendLayout();
            this.BudgetOnglets.SuspendLayout();
            this.PagePosteFixe.SuspendLayout();
            this.PagePostePonctuel.SuspendLayout();
            this.grpBxEcheances.SuspendLayout();
            this.PageRevenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorGestionBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // pageOnglets
            // 
            this.pageOnglets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageOnglets.Controls.Add(this.ongletAffichage1a1);
            this.pageOnglets.Controls.Add(this.ongletAjoutTransaction);
            this.pageOnglets.Controls.Add(this.ongletSuppressionTransaction);
            this.pageOnglets.Controls.Add(this.ongletModifTransaction);
            this.pageOnglets.Controls.Add(this.ongletRecapitulatif);
            this.pageOnglets.Location = new System.Drawing.Point(0, 1);
            this.pageOnglets.Name = "pageOnglets";
            this.pageOnglets.SelectedIndex = 0;
            this.pageOnglets.Size = new System.Drawing.Size(667, 480);
            this.pageOnglets.TabIndex = 0;
            // 
            // ongletAffichage1a1
            // 
            this.ongletAffichage1a1.Controls.Add(this.lstBxPersonnesConcernees);
            this.ongletAffichage1a1.Controls.Add(this.btnFin);
            this.ongletAffichage1a1.Controls.Add(this.btnSuivant);
            this.ongletAffichage1a1.Controls.Add(this.btnPrecedent);
            this.ongletAffichage1a1.Controls.Add(this.btnDebut);
            this.ongletAffichage1a1.Controls.Add(this.checkBxPercu1a1);
            this.ongletAffichage1a1.Controls.Add(this.checkBxRecette1a1);
            this.ongletAffichage1a1.Controls.Add(this.labelMontant1a1);
            this.ongletAffichage1a1.Controls.Add(this.labelDescription1a1);
            this.ongletAffichage1a1.Controls.Add(this.labelType1a1);
            this.ongletAffichage1a1.Controls.Add(this.labelNumTransaction);
            this.ongletAffichage1a1.Controls.Add(this.dateTimePicker1a1);
            this.ongletAffichage1a1.Location = new System.Drawing.Point(4, 22);
            this.ongletAffichage1a1.Name = "ongletAffichage1a1";
            this.ongletAffichage1a1.Padding = new System.Windows.Forms.Padding(3);
            this.ongletAffichage1a1.Size = new System.Drawing.Size(659, 454);
            this.ongletAffichage1a1.TabIndex = 0;
            this.ongletAffichage1a1.Text = "Affichage 1 à 1";
            this.ongletAffichage1a1.UseVisualStyleBackColor = true;
            this.ongletAffichage1a1.Enter += new System.EventHandler(this.ongletAffichage1a1_Enter);
            this.ongletAffichage1a1.Leave += new System.EventHandler(this.ongletAffichage1a1_Leave);
            // 
            // lstBxPersonnesConcernees
            // 
            this.lstBxPersonnesConcernees.FormattingEnabled = true;
            this.lstBxPersonnesConcernees.Location = new System.Drawing.Point(14, 170);
            this.lstBxPersonnesConcernees.Name = "lstBxPersonnesConcernees";
            this.lstBxPersonnesConcernees.Size = new System.Drawing.Size(630, 225);
            this.lstBxPersonnesConcernees.TabIndex = 12;
            // 
            // btnFin
            // 
            this.btnFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFin.Location = new System.Drawing.Point(259, 420);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(75, 23);
            this.btnFin.TabIndex = 11;
            this.btnFin.Text = ">>";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSuivant.Location = new System.Drawing.Point(178, 420);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(75, 23);
            this.btnSuivant.TabIndex = 10;
            this.btnSuivant.Text = ">";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrecedent.Location = new System.Drawing.Point(95, 420);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(75, 23);
            this.btnPrecedent.TabIndex = 9;
            this.btnPrecedent.Text = "<";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnDebut
            // 
            this.btnDebut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDebut.Location = new System.Drawing.Point(14, 420);
            this.btnDebut.Name = "btnDebut";
            this.btnDebut.Size = new System.Drawing.Size(75, 23);
            this.btnDebut.TabIndex = 8;
            this.btnDebut.Text = "<<";
            this.btnDebut.UseVisualStyleBackColor = true;
            this.btnDebut.Click += new System.EventHandler(this.btnDebut_Click);
            // 
            // checkBxPercu1a1
            // 
            this.checkBxPercu1a1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBxPercu1a1.AutoSize = true;
            this.checkBxPercu1a1.Enabled = false;
            this.checkBxPercu1a1.Location = new System.Drawing.Point(487, 109);
            this.checkBxPercu1a1.Name = "checkBxPercu1a1";
            this.checkBxPercu1a1.Size = new System.Drawing.Size(54, 17);
            this.checkBxPercu1a1.TabIndex = 6;
            this.checkBxPercu1a1.Text = "Perçu";
            this.checkBxPercu1a1.UseVisualStyleBackColor = true;
            // 
            // checkBxRecette1a1
            // 
            this.checkBxRecette1a1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBxRecette1a1.AutoSize = true;
            this.checkBxRecette1a1.Enabled = false;
            this.checkBxRecette1a1.Location = new System.Drawing.Point(487, 86);
            this.checkBxRecette1a1.Name = "checkBxRecette1a1";
            this.checkBxRecette1a1.Size = new System.Drawing.Size(64, 17);
            this.checkBxRecette1a1.TabIndex = 5;
            this.checkBxRecette1a1.Text = "Recette";
            this.checkBxRecette1a1.UseVisualStyleBackColor = true;
            // 
            // labelMontant1a1
            // 
            this.labelMontant1a1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMontant1a1.AutoSize = true;
            this.labelMontant1a1.Location = new System.Drawing.Point(484, 55);
            this.labelMontant1a1.Name = "labelMontant1a1";
            this.labelMontant1a1.Size = new System.Drawing.Size(55, 13);
            this.labelMontant1a1.TabIndex = 4;
            this.labelMontant1a1.Text = "Montant : ";
            // 
            // labelDescription1a1
            // 
            this.labelDescription1a1.Location = new System.Drawing.Point(11, 73);
            this.labelDescription1a1.Name = "labelDescription1a1";
            this.labelDescription1a1.Size = new System.Drawing.Size(430, 75);
            this.labelDescription1a1.TabIndex = 3;
            this.labelDescription1a1.Text = "Description de la transaction courante...";
            // 
            // labelType1a1
            // 
            this.labelType1a1.AutoSize = true;
            this.labelType1a1.Location = new System.Drawing.Point(11, 46);
            this.labelType1a1.Name = "labelType1a1";
            this.labelType1a1.Size = new System.Drawing.Size(61, 13);
            this.labelType1a1.TabIndex = 2;
            this.labelType1a1.Text = "Catégorie : ";
            // 
            // labelNumTransaction
            // 
            this.labelNumTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumTransaction.AutoSize = true;
            this.labelNumTransaction.Location = new System.Drawing.Point(484, 13);
            this.labelNumTransaction.Name = "labelNumTransaction";
            this.labelNumTransaction.Size = new System.Drawing.Size(104, 13);
            this.labelNumTransaction.TabIndex = 1;
            this.labelNumTransaction.Text = "Transaction numéro ";
            // 
            // dateTimePicker1a1
            // 
            this.dateTimePicker1a1.Enabled = false;
            this.dateTimePicker1a1.Location = new System.Drawing.Point(14, 13);
            this.dateTimePicker1a1.Name = "dateTimePicker1a1";
            this.dateTimePicker1a1.Size = new System.Drawing.Size(176, 20);
            this.dateTimePicker1a1.TabIndex = 0;
            // 
            // ongletAjoutTransaction
            // 
            this.ongletAjoutTransaction.Controls.Add(this.grpBxUtilisateursGeneres);
            this.ongletAjoutTransaction.Controls.Add(this.checkBxPercu);
            this.ongletAjoutTransaction.Controls.Add(this.checkBxRecette);
            this.ongletAjoutTransaction.Controls.Add(this.btnAjoutPersonne);
            this.ongletAjoutTransaction.Controls.Add(this.txtBxMontant);
            this.ongletAjoutTransaction.Controls.Add(this.txtBxDescription);
            this.ongletAjoutTransaction.Controls.Add(this.btnFinalAjouter);
            this.ongletAjoutTransaction.Controls.Add(this.btnAjoutType);
            this.ongletAjoutTransaction.Controls.Add(this.comboBxType);
            this.ongletAjoutTransaction.Controls.Add(this.labelType);
            this.ongletAjoutTransaction.Controls.Add(this.dateTimePickerDateDepense);
            this.ongletAjoutTransaction.Controls.Add(this.labelMontant);
            this.ongletAjoutTransaction.Controls.Add(this.labelDescription);
            this.ongletAjoutTransaction.Controls.Add(this.labelDateDepense);
            this.ongletAjoutTransaction.Location = new System.Drawing.Point(4, 22);
            this.ongletAjoutTransaction.Name = "ongletAjoutTransaction";
            this.ongletAjoutTransaction.Padding = new System.Windows.Forms.Padding(3);
            this.ongletAjoutTransaction.Size = new System.Drawing.Size(659, 454);
            this.ongletAjoutTransaction.TabIndex = 1;
            this.ongletAjoutTransaction.Text = "Ajout d\'une transaction";
            this.ongletAjoutTransaction.UseVisualStyleBackColor = true;
            this.ongletAjoutTransaction.Enter += new System.EventHandler(this.ongletAjoutTransaction_Enter);
            // 
            // grpBxUtilisateursGeneres
            // 
            this.grpBxUtilisateursGeneres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxUtilisateursGeneres.Location = new System.Drawing.Point(361, 28);
            this.grpBxUtilisateursGeneres.Name = "grpBxUtilisateursGeneres";
            this.grpBxUtilisateursGeneres.Size = new System.Drawing.Size(286, 353);
            this.grpBxUtilisateursGeneres.TabIndex = 20;
            this.grpBxUtilisateursGeneres.TabStop = false;
            this.grpBxUtilisateursGeneres.Text = "Utilisateurs concernés";
            // 
            // checkBxPercu
            // 
            this.checkBxPercu.AutoSize = true;
            this.checkBxPercu.Location = new System.Drawing.Point(126, 122);
            this.checkBxPercu.Name = "checkBxPercu";
            this.checkBxPercu.Size = new System.Drawing.Size(54, 17);
            this.checkBxPercu.TabIndex = 19;
            this.checkBxPercu.Text = "Perçu";
            this.checkBxPercu.UseVisualStyleBackColor = true;
            // 
            // checkBxRecette
            // 
            this.checkBxRecette.AutoSize = true;
            this.checkBxRecette.Location = new System.Drawing.Point(14, 122);
            this.checkBxRecette.Name = "checkBxRecette";
            this.checkBxRecette.Size = new System.Drawing.Size(64, 17);
            this.checkBxRecette.TabIndex = 18;
            this.checkBxRecette.Text = "Recette";
            this.checkBxRecette.UseVisualStyleBackColor = true;
            // 
            // btnAjoutPersonne
            // 
            this.btnAjoutPersonne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjoutPersonne.Location = new System.Drawing.Point(549, 394);
            this.btnAjoutPersonne.Name = "btnAjoutPersonne";
            this.btnAjoutPersonne.Size = new System.Drawing.Size(99, 49);
            this.btnAjoutPersonne.TabIndex = 17;
            this.btnAjoutPersonne.Text = "Ajout d\'une personne";
            this.btnAjoutPersonne.UseVisualStyleBackColor = true;
            this.btnAjoutPersonne.Click += new System.EventHandler(this.btnAjoutPersonne_Click);
            // 
            // txtBxMontant
            // 
            this.txtBxMontant.Location = new System.Drawing.Point(73, 87);
            this.txtBxMontant.Name = "txtBxMontant";
            this.txtBxMontant.Size = new System.Drawing.Size(64, 20);
            this.txtBxMontant.TabIndex = 13;
            // 
            // txtBxDescription
            // 
            this.txtBxDescription.Location = new System.Drawing.Point(87, 51);
            this.txtBxDescription.MaxLength = 30;
            this.txtBxDescription.Name = "txtBxDescription";
            this.txtBxDescription.Size = new System.Drawing.Size(249, 20);
            this.txtBxDescription.TabIndex = 12;
            // 
            // btnFinalAjouter
            // 
            this.btnFinalAjouter.Location = new System.Drawing.Point(63, 244);
            this.btnFinalAjouter.Name = "btnFinalAjouter";
            this.btnFinalAjouter.Size = new System.Drawing.Size(251, 79);
            this.btnFinalAjouter.TabIndex = 11;
            this.btnFinalAjouter.Text = "Ajouter";
            this.btnFinalAjouter.UseVisualStyleBackColor = true;
            this.btnFinalAjouter.Click += new System.EventHandler(this.btnFinalAjouter_Click);
            // 
            // btnAjoutType
            // 
            this.btnAjoutType.Location = new System.Drawing.Point(259, 170);
            this.btnAjoutType.Name = "btnAjoutType";
            this.btnAjoutType.Size = new System.Drawing.Size(27, 23);
            this.btnAjoutType.TabIndex = 10;
            this.btnAjoutType.Text = "...";
            this.btnAjoutType.UseVisualStyleBackColor = true;
            this.btnAjoutType.Click += new System.EventHandler(this.btnAjoutType_Click);
            // 
            // comboBxType
            // 
            this.comboBxType.FormattingEnabled = true;
            this.comboBxType.Location = new System.Drawing.Point(78, 172);
            this.comboBxType.Name = "comboBxType";
            this.comboBxType.Size = new System.Drawing.Size(175, 21);
            this.comboBxType.TabIndex = 9;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(11, 175);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(61, 13);
            this.labelType.TabIndex = 8;
            this.labelType.Text = "Catégorie : ";
            // 
            // dateTimePickerDateDepense
            // 
            this.dateTimePickerDateDepense.Location = new System.Drawing.Point(126, 14);
            this.dateTimePickerDateDepense.Name = "dateTimePickerDateDepense";
            this.dateTimePickerDateDepense.Size = new System.Drawing.Size(163, 20);
            this.dateTimePickerDateDepense.TabIndex = 5;
            // 
            // labelMontant
            // 
            this.labelMontant.AutoSize = true;
            this.labelMontant.Location = new System.Drawing.Point(11, 87);
            this.labelMontant.Name = "labelMontant";
            this.labelMontant.Size = new System.Drawing.Size(55, 13);
            this.labelMontant.TabIndex = 2;
            this.labelMontant.Text = "Montant : ";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(11, 51);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(69, 13);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Description : ";
            // 
            // labelDateDepense
            // 
            this.labelDateDepense.AutoSize = true;
            this.labelDateDepense.Location = new System.Drawing.Point(11, 20);
            this.labelDateDepense.Name = "labelDateDepense";
            this.labelDateDepense.Size = new System.Drawing.Size(109, 13);
            this.labelDateDepense.TabIndex = 0;
            this.labelDateDepense.Text = "Date de la dépense : ";
            // 
            // ongletSuppressionTransaction
            // 
            this.ongletSuppressionTransaction.Controls.Add(this.btnSupprimerTransaction);
            this.ongletSuppressionTransaction.Controls.Add(this.dataGridViewSuppression);
            this.ongletSuppressionTransaction.Location = new System.Drawing.Point(4, 22);
            this.ongletSuppressionTransaction.Name = "ongletSuppressionTransaction";
            this.ongletSuppressionTransaction.Padding = new System.Windows.Forms.Padding(3);
            this.ongletSuppressionTransaction.Size = new System.Drawing.Size(659, 454);
            this.ongletSuppressionTransaction.TabIndex = 2;
            this.ongletSuppressionTransaction.Text = "Suppression d\'une transaction";
            this.ongletSuppressionTransaction.UseVisualStyleBackColor = true;
            this.ongletSuppressionTransaction.Enter += new System.EventHandler(this.ongletSuppressionTransaction_Enter);
            // 
            // btnSupprimerTransaction
            // 
            this.btnSupprimerTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimerTransaction.Location = new System.Drawing.Point(546, 408);
            this.btnSupprimerTransaction.Name = "btnSupprimerTransaction";
            this.btnSupprimerTransaction.Size = new System.Drawing.Size(105, 40);
            this.btnSupprimerTransaction.TabIndex = 1;
            this.btnSupprimerTransaction.Text = "Supprimer la transaction";
            this.btnSupprimerTransaction.UseVisualStyleBackColor = true;
            this.btnSupprimerTransaction.Click += new System.EventHandler(this.btnSupprimerTransaction_Click);
            // 
            // dataGridViewSuppression
            // 
            this.dataGridViewSuppression.AllowUserToAddRows = false;
            this.dataGridViewSuppression.AllowUserToDeleteRows = false;
            this.dataGridViewSuppression.AllowUserToResizeRows = false;
            this.dataGridViewSuppression.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSuppression.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSuppression.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuppression.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewSuppression.Name = "dataGridViewSuppression";
            this.dataGridViewSuppression.ReadOnly = true;
            this.dataGridViewSuppression.Size = new System.Drawing.Size(641, 395);
            this.dataGridViewSuppression.TabIndex = 0;
            // 
            // ongletModifTransaction
            // 
            this.ongletModifTransaction.Controls.Add(this.btnModification);
            this.ongletModifTransaction.Controls.Add(this.dataGridViewModification);
            this.ongletModifTransaction.Location = new System.Drawing.Point(4, 22);
            this.ongletModifTransaction.Name = "ongletModifTransaction";
            this.ongletModifTransaction.Padding = new System.Windows.Forms.Padding(3);
            this.ongletModifTransaction.Size = new System.Drawing.Size(659, 454);
            this.ongletModifTransaction.TabIndex = 3;
            this.ongletModifTransaction.Text = "Modification d\'une transaction";
            this.ongletModifTransaction.UseVisualStyleBackColor = true;
            this.ongletModifTransaction.Enter += new System.EventHandler(this.ongletModifTransaction_Enter);
            // 
            // btnModification
            // 
            this.btnModification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModification.Location = new System.Drawing.Point(546, 408);
            this.btnModification.Name = "btnModification";
            this.btnModification.Size = new System.Drawing.Size(105, 40);
            this.btnModification.TabIndex = 13;
            this.btnModification.Text = "Modifier la ligne...";
            this.btnModification.UseVisualStyleBackColor = true;
            this.btnModification.Click += new System.EventHandler(this.btnModification_Click);
            // 
            // dataGridViewModification
            // 
            this.dataGridViewModification.AllowUserToAddRows = false;
            this.dataGridViewModification.AllowUserToDeleteRows = false;
            this.dataGridViewModification.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewModification.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewModification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModification.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewModification.Name = "dataGridViewModification";
            this.dataGridViewModification.ReadOnly = true;
            this.dataGridViewModification.Size = new System.Drawing.Size(641, 395);
            this.dataGridViewModification.TabIndex = 0;
            // 
            // ongletRecapitulatif
            // 
            this.ongletRecapitulatif.Controls.Add(this.grpBxCriteres);
            this.ongletRecapitulatif.Controls.Add(this.btnRechercher);
            this.ongletRecapitulatif.Controls.Add(this.btnGenererPdf);
            this.ongletRecapitulatif.Controls.Add(this.dataGridViewResultatsRecherche);
            this.ongletRecapitulatif.Controls.Add(this.grpBxRecherche);
            this.ongletRecapitulatif.Location = new System.Drawing.Point(4, 22);
            this.ongletRecapitulatif.Name = "ongletRecapitulatif";
            this.ongletRecapitulatif.Padding = new System.Windows.Forms.Padding(3);
            this.ongletRecapitulatif.Size = new System.Drawing.Size(659, 454);
            this.ongletRecapitulatif.TabIndex = 4;
            this.ongletRecapitulatif.Text = "Récapitulatif";
            this.ongletRecapitulatif.UseVisualStyleBackColor = true;
            this.ongletRecapitulatif.Enter += new System.EventHandler(this.ongletRecapitulatif_Enter);
            // 
            // grpBxCriteres
            // 
            this.grpBxCriteres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxCriteres.Controls.Add(this.checkBxCritereRecette);
            this.grpBxCriteres.Controls.Add(this.checkBxCritereEncaisse);
            this.grpBxCriteres.Controls.Add(this.checkBxCriterePrix);
            this.grpBxCriteres.Controls.Add(this.checkBxCritereType);
            this.grpBxCriteres.Controls.Add(this.checkBxCritereDate);
            this.grpBxCriteres.Location = new System.Drawing.Point(460, 6);
            this.grpBxCriteres.Name = "grpBxCriteres";
            this.grpBxCriteres.Size = new System.Drawing.Size(188, 137);
            this.grpBxCriteres.TabIndex = 15;
            this.grpBxCriteres.TabStop = false;
            this.grpBxCriteres.Text = "Critères de recherche";
            // 
            // checkBxCritereRecette
            // 
            this.checkBxCritereRecette.AutoSize = true;
            this.checkBxCritereRecette.Location = new System.Drawing.Point(7, 116);
            this.checkBxCritereRecette.Name = "checkBxCritereRecette";
            this.checkBxCritereRecette.Size = new System.Drawing.Size(137, 17);
            this.checkBxCritereRecette.TabIndex = 4;
            this.checkBxCritereRecette.Text = "Par recette ou dépense";
            this.checkBxCritereRecette.UseVisualStyleBackColor = true;
            this.checkBxCritereRecette.CheckedChanged += new System.EventHandler(this.checkBxCritereRecette_CheckedChanged);
            // 
            // checkBxCritereEncaisse
            // 
            this.checkBxCritereEncaisse.AutoSize = true;
            this.checkBxCritereEncaisse.Location = new System.Drawing.Point(7, 92);
            this.checkBxCritereEncaisse.Name = "checkBxCritereEncaisse";
            this.checkBxCritereEncaisse.Size = new System.Drawing.Size(123, 17);
            this.checkBxCritereEncaisse.TabIndex = 3;
            this.checkBxCritereEncaisse.Text = "Par encaissé ou non";
            this.checkBxCritereEncaisse.UseVisualStyleBackColor = true;
            this.checkBxCritereEncaisse.CheckedChanged += new System.EventHandler(this.checkBxCritereEncaisse_CheckedChanged);
            // 
            // checkBxCriterePrix
            // 
            this.checkBxCriterePrix.AutoSize = true;
            this.checkBxCriterePrix.Location = new System.Drawing.Point(7, 68);
            this.checkBxCriterePrix.Name = "checkBxCriterePrix";
            this.checkBxCriterePrix.Size = new System.Drawing.Size(61, 17);
            this.checkBxCriterePrix.TabIndex = 2;
            this.checkBxCriterePrix.Text = "Par prix";
            this.checkBxCriterePrix.UseVisualStyleBackColor = true;
            this.checkBxCriterePrix.CheckedChanged += new System.EventHandler(this.checkBxCriterePrix_CheckedChanged);
            // 
            // checkBxCritereType
            // 
            this.checkBxCritereType.AutoSize = true;
            this.checkBxCritereType.Location = new System.Drawing.Point(7, 44);
            this.checkBxCritereType.Name = "checkBxCritereType";
            this.checkBxCritereType.Size = new System.Drawing.Size(71, 17);
            this.checkBxCritereType.TabIndex = 1;
            this.checkBxCritereType.Text = "Par libellé";
            this.checkBxCritereType.UseVisualStyleBackColor = true;
            this.checkBxCritereType.CheckedChanged += new System.EventHandler(this.checkBxCritereType_CheckedChanged);
            // 
            // checkBxCritereDate
            // 
            this.checkBxCritereDate.AutoSize = true;
            this.checkBxCritereDate.Location = new System.Drawing.Point(7, 20);
            this.checkBxCritereDate.Name = "checkBxCritereDate";
            this.checkBxCritereDate.Size = new System.Drawing.Size(66, 17);
            this.checkBxCritereDate.TabIndex = 0;
            this.checkBxCritereDate.Text = "Par date";
            this.checkBxCritereDate.UseVisualStyleBackColor = true;
            this.checkBxCritereDate.CheckedChanged += new System.EventHandler(this.checkBxCritereDate_CheckedChanged);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRechercher.Enabled = false;
            this.btnRechercher.Location = new System.Drawing.Point(529, 176);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(118, 26);
            this.btnRechercher.TabIndex = 0;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnGenererPdf
            // 
            this.btnGenererPdf.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGenererPdf.Location = new System.Drawing.Point(283, 425);
            this.btnGenererPdf.Name = "btnGenererPdf";
            this.btnGenererPdf.Size = new System.Drawing.Size(96, 23);
            this.btnGenererPdf.TabIndex = 3;
            this.btnGenererPdf.Text = "Générer le PDF";
            this.btnGenererPdf.UseVisualStyleBackColor = true;
            // 
            // dataGridViewResultatsRecherche
            // 
            this.dataGridViewResultatsRecherche.AllowUserToAddRows = false;
            this.dataGridViewResultatsRecherche.AllowUserToDeleteRows = false;
            this.dataGridViewResultatsRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResultatsRecherche.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResultatsRecherche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultatsRecherche.Location = new System.Drawing.Point(10, 208);
            this.dataGridViewResultatsRecherche.Name = "dataGridViewResultatsRecherche";
            this.dataGridViewResultatsRecherche.ReadOnly = true;
            this.dataGridViewResultatsRecherche.Size = new System.Drawing.Size(637, 211);
            this.dataGridViewResultatsRecherche.TabIndex = 2;
            // 
            // grpBxRecherche
            // 
            this.grpBxRecherche.Controls.Add(this.checkBxRecetteRecap);
            this.grpBxRecherche.Controls.Add(this.checkBxEncaisse);
            this.grpBxRecherche.Controls.Add(this.txtBxMontantRecap);
            this.grpBxRecherche.Controls.Add(this.radioBtnInferieurEgal);
            this.grpBxRecherche.Controls.Add(this.radioBtnSuperieurEgal);
            this.grpBxRecherche.Controls.Add(this.radioBtnStrictementEgal);
            this.grpBxRecherche.Controls.Add(this.labelMontantRecap);
            this.grpBxRecherche.Controls.Add(this.labelTypeRecap);
            this.grpBxRecherche.Controls.Add(this.comboBxTypeRecap);
            this.grpBxRecherche.Controls.Add(this.labelAu);
            this.grpBxRecherche.Controls.Add(this.labelLeDu);
            this.grpBxRecherche.Controls.Add(this.dateTimePickerRecapAu);
            this.grpBxRecherche.Controls.Add(this.checkBxPlage);
            this.grpBxRecherche.Controls.Add(this.dateTimePickerRecapDu);
            this.grpBxRecherche.Location = new System.Drawing.Point(13, 7);
            this.grpBxRecherche.Name = "grpBxRecherche";
            this.grpBxRecherche.Size = new System.Drawing.Size(444, 195);
            this.grpBxRecherche.TabIndex = 1;
            this.grpBxRecherche.TabStop = false;
            this.grpBxRecherche.Text = "Recherche";
            // 
            // checkBxRecetteRecap
            // 
            this.checkBxRecetteRecap.AutoSize = true;
            this.checkBxRecetteRecap.Enabled = false;
            this.checkBxRecetteRecap.Location = new System.Drawing.Point(12, 145);
            this.checkBxRecetteRecap.Name = "checkBxRecetteRecap";
            this.checkBxRecetteRecap.Size = new System.Drawing.Size(73, 17);
            this.checkBxRecetteRecap.TabIndex = 14;
            this.checkBxRecetteRecap.Text = "Recette ?";
            this.checkBxRecetteRecap.UseVisualStyleBackColor = true;
            // 
            // checkBxEncaisse
            // 
            this.checkBxEncaisse.AutoSize = true;
            this.checkBxEncaisse.Enabled = false;
            this.checkBxEncaisse.Location = new System.Drawing.Point(12, 121);
            this.checkBxEncaisse.Name = "checkBxEncaisse";
            this.checkBxEncaisse.Size = new System.Drawing.Size(78, 17);
            this.checkBxEncaisse.TabIndex = 13;
            this.checkBxEncaisse.Text = "Encaissé ?";
            this.checkBxEncaisse.UseVisualStyleBackColor = true;
            // 
            // txtBxMontantRecap
            // 
            this.txtBxMontantRecap.Enabled = false;
            this.txtBxMontantRecap.Location = new System.Drawing.Point(39, 95);
            this.txtBxMontantRecap.Name = "txtBxMontantRecap";
            this.txtBxMontantRecap.Size = new System.Drawing.Size(59, 20);
            this.txtBxMontantRecap.TabIndex = 12;
            // 
            // radioBtnInferieurEgal
            // 
            this.radioBtnInferieurEgal.AutoSize = true;
            this.radioBtnInferieurEgal.Enabled = false;
            this.radioBtnInferieurEgal.Location = new System.Drawing.Point(273, 98);
            this.radioBtnInferieurEgal.Name = "radioBtnInferieurEgal";
            this.radioBtnInferieurEgal.Size = new System.Drawing.Size(100, 17);
            this.radioBtnInferieurEgal.TabIndex = 11;
            this.radioBtnInferieurEgal.TabStop = true;
            this.radioBtnInferieurEgal.Text = "inférieur ou égal";
            this.radioBtnInferieurEgal.UseVisualStyleBackColor = true;
            // 
            // radioBtnSuperieurEgal
            // 
            this.radioBtnSuperieurEgal.AutoSize = true;
            this.radioBtnSuperieurEgal.Enabled = false;
            this.radioBtnSuperieurEgal.Location = new System.Drawing.Point(161, 98);
            this.radioBtnSuperieurEgal.Name = "radioBtnSuperieurEgal";
            this.radioBtnSuperieurEgal.Size = new System.Drawing.Size(106, 17);
            this.radioBtnSuperieurEgal.TabIndex = 10;
            this.radioBtnSuperieurEgal.TabStop = true;
            this.radioBtnSuperieurEgal.Text = "supérieur ou égal";
            this.radioBtnSuperieurEgal.UseVisualStyleBackColor = true;
            // 
            // radioBtnStrictementEgal
            // 
            this.radioBtnStrictementEgal.AutoSize = true;
            this.radioBtnStrictementEgal.Enabled = false;
            this.radioBtnStrictementEgal.Location = new System.Drawing.Point(104, 98);
            this.radioBtnStrictementEgal.Name = "radioBtnStrictementEgal";
            this.radioBtnStrictementEgal.Size = new System.Drawing.Size(54, 17);
            this.radioBtnStrictementEgal.TabIndex = 9;
            this.radioBtnStrictementEgal.TabStop = true;
            this.radioBtnStrictementEgal.Text = "égal à";
            this.radioBtnStrictementEgal.UseVisualStyleBackColor = true;
            // 
            // labelMontantRecap
            // 
            this.labelMontantRecap.AutoSize = true;
            this.labelMontantRecap.Location = new System.Drawing.Point(9, 98);
            this.labelMontantRecap.Name = "labelMontantRecap";
            this.labelMontantRecap.Size = new System.Drawing.Size(24, 13);
            this.labelMontantRecap.TabIndex = 8;
            this.labelMontantRecap.Text = "Prix";
            // 
            // labelTypeRecap
            // 
            this.labelTypeRecap.AutoSize = true;
            this.labelTypeRecap.Location = new System.Drawing.Point(9, 71);
            this.labelTypeRecap.Name = "labelTypeRecap";
            this.labelTypeRecap.Size = new System.Drawing.Size(37, 13);
            this.labelTypeRecap.TabIndex = 7;
            this.labelTypeRecap.Text = "Libellé";
            // 
            // comboBxTypeRecap
            // 
            this.comboBxTypeRecap.Enabled = false;
            this.comboBxTypeRecap.FormattingEnabled = true;
            this.comboBxTypeRecap.Location = new System.Drawing.Point(52, 68);
            this.comboBxTypeRecap.Name = "comboBxTypeRecap";
            this.comboBxTypeRecap.Size = new System.Drawing.Size(217, 21);
            this.comboBxTypeRecap.TabIndex = 6;
            // 
            // labelAu
            // 
            this.labelAu.AutoSize = true;
            this.labelAu.Location = new System.Drawing.Point(214, 45);
            this.labelAu.Name = "labelAu";
            this.labelAu.Size = new System.Drawing.Size(19, 13);
            this.labelAu.TabIndex = 5;
            this.labelAu.Text = "au";
            this.labelAu.Visible = false;
            // 
            // labelLeDu
            // 
            this.labelLeDu.AutoSize = true;
            this.labelLeDu.Location = new System.Drawing.Point(9, 46);
            this.labelLeDu.Name = "labelLeDu";
            this.labelLeDu.Size = new System.Drawing.Size(15, 13);
            this.labelLeDu.TabIndex = 4;
            this.labelLeDu.Text = "le";
            // 
            // dateTimePickerRecapAu
            // 
            this.dateTimePickerRecapAu.Enabled = false;
            this.dateTimePickerRecapAu.Location = new System.Drawing.Point(237, 42);
            this.dateTimePickerRecapAu.Name = "dateTimePickerRecapAu";
            this.dateTimePickerRecapAu.Size = new System.Drawing.Size(176, 20);
            this.dateTimePickerRecapAu.TabIndex = 3;
            this.dateTimePickerRecapAu.Visible = false;
            // 
            // checkBxPlage
            // 
            this.checkBxPlage.AutoSize = true;
            this.checkBxPlage.Enabled = false;
            this.checkBxPlage.Location = new System.Drawing.Point(12, 19);
            this.checkBxPlage.Name = "checkBxPlage";
            this.checkBxPlage.Size = new System.Drawing.Size(97, 17);
            this.checkBxPlage.TabIndex = 2;
            this.checkBxPlage.Text = "Plage de dates";
            this.checkBxPlage.UseVisualStyleBackColor = true;
            this.checkBxPlage.CheckedChanged += new System.EventHandler(this.checkBxPlage_CheckedChanged);
            // 
            // dateTimePickerRecapDu
            // 
            this.dateTimePickerRecapDu.Enabled = false;
            this.dateTimePickerRecapDu.Location = new System.Drawing.Point(34, 42);
            this.dateTimePickerRecapDu.Name = "dateTimePickerRecapDu";
            this.dateTimePickerRecapDu.Size = new System.Drawing.Size(176, 20);
            this.dateTimePickerRecapDu.TabIndex = 1;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataMember = "Transaction";
            this.transactionBindingSource.DataSource = this.budget1DataSet;
            // 
            // budget1DataSet
            // 
            this.budget1DataSet.DataSetName = "budget1DataSet";
            this.budget1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionTableAdapter
            // 
            this.transactionTableAdapter.ClearBeforeFill = true;
            // 
            // tabControlVolets
            // 
            this.tabControlVolets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlVolets.Controls.Add(this.tabVolet1);
            this.tabControlVolets.Controls.Add(this.tabVolet2);
            this.tabControlVolets.Location = new System.Drawing.Point(5, 2);
            this.tabControlVolets.Name = "tabControlVolets";
            this.tabControlVolets.SelectedIndex = 0;
            this.tabControlVolets.Size = new System.Drawing.Size(668, 500);
            this.tabControlVolets.TabIndex = 12;
            // 
            // tabVolet1
            // 
            this.tabVolet1.Controls.Add(this.pageOnglets);
            this.tabVolet1.Location = new System.Drawing.Point(4, 22);
            this.tabVolet1.Name = "tabVolet1";
            this.tabVolet1.Padding = new System.Windows.Forms.Padding(3);
            this.tabVolet1.Size = new System.Drawing.Size(660, 474);
            this.tabVolet1.TabIndex = 0;
            this.tabVolet1.Text = "Budget du mois";
            this.tabVolet1.UseVisualStyleBackColor = true;
            // 
            // tabVolet2
            // 
            this.tabVolet2.Controls.Add(this.BudgetOnglets);
            this.tabVolet2.Location = new System.Drawing.Point(4, 22);
            this.tabVolet2.Name = "tabVolet2";
            this.tabVolet2.Padding = new System.Windows.Forms.Padding(3);
            this.tabVolet2.Size = new System.Drawing.Size(660, 474);
            this.tabVolet2.TabIndex = 1;
            this.tabVolet2.Text = "Budget prévisionnel";
            this.tabVolet2.UseVisualStyleBackColor = true;
            // 
            // BudgetOnglets
            // 
            this.BudgetOnglets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BudgetOnglets.Controls.Add(this.PagePosteFixe);
            this.BudgetOnglets.Controls.Add(this.PagePostePonctuel);
            this.BudgetOnglets.Controls.Add(this.PageRevenu);
            this.BudgetOnglets.Location = new System.Drawing.Point(0, 2);
            this.BudgetOnglets.Name = "BudgetOnglets";
            this.BudgetOnglets.SelectedIndex = 0;
            this.BudgetOnglets.Size = new System.Drawing.Size(658, 476);
            this.BudgetOnglets.TabIndex = 1;
            // 
            // PagePosteFixe
            // 
            this.PagePosteFixe.Controls.Add(this.btnCalendrier);
            this.PagePosteFixe.Controls.Add(this.btnModifierPostes);
            this.PagePosteFixe.Controls.Add(this.btnValider);
            this.PagePosteFixe.Controls.Add(this.txtBxMontantPosteFixe);
            this.PagePosteFixe.Controls.Add(this.labelMontantPosteFixe);
            this.PagePosteFixe.Controls.Add(this.labelJourDuMois);
            this.PagePosteFixe.Controls.Add(this.txtBxJourDuMois);
            this.PagePosteFixe.Controls.Add(this.comboBxPeriodicite);
            this.PagePosteFixe.Controls.Add(this.labelPeriodicite);
            this.PagePosteFixe.Controls.Add(this.btnAutrePoste);
            this.PagePosteFixe.Controls.Add(this.comboBxLibellePoste);
            this.PagePosteFixe.Controls.Add(this.labelPoste);
            this.PagePosteFixe.Location = new System.Drawing.Point(4, 22);
            this.PagePosteFixe.Name = "PagePosteFixe";
            this.PagePosteFixe.Padding = new System.Windows.Forms.Padding(3);
            this.PagePosteFixe.Size = new System.Drawing.Size(650, 450);
            this.PagePosteFixe.TabIndex = 0;
            this.PagePosteFixe.Text = "Poste fixe";
            this.PagePosteFixe.UseVisualStyleBackColor = true;
            // 
            // btnCalendrier
            // 
            this.btnCalendrier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalendrier.BackgroundImage = global::Gestion_de_budget.Properties.Resources.calendrierProbablementPasLibreDeDroit;
            this.btnCalendrier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalendrier.Location = new System.Drawing.Point(601, 6);
            this.btnCalendrier.Name = "btnCalendrier";
            this.btnCalendrier.Size = new System.Drawing.Size(46, 46);
            this.btnCalendrier.TabIndex = 12;
            this.btnCalendrier.UseVisualStyleBackColor = true;
            // 
            // btnModifierPostes
            // 
            this.btnModifierPostes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifierPostes.Location = new System.Drawing.Point(532, 369);
            this.btnModifierPostes.Name = "btnModifierPostes";
            this.btnModifierPostes.Size = new System.Drawing.Size(115, 28);
            this.btnModifierPostes.TabIndex = 11;
            this.btnModifierPostes.Text = "Modifier les postes...";
            this.btnModifierPostes.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValider.Location = new System.Drawing.Point(532, 403);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(115, 44);
            this.btnValider.TabIndex = 10;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // txtBxMontantPosteFixe
            // 
            this.txtBxMontantPosteFixe.Location = new System.Drawing.Point(104, 142);
            this.txtBxMontantPosteFixe.Name = "txtBxMontantPosteFixe";
            this.txtBxMontantPosteFixe.Size = new System.Drawing.Size(50, 20);
            this.txtBxMontantPosteFixe.TabIndex = 9;
            // 
            // labelMontantPosteFixe
            // 
            this.labelMontantPosteFixe.AutoSize = true;
            this.labelMontantPosteFixe.Location = new System.Drawing.Point(8, 145);
            this.labelMontantPosteFixe.Name = "labelMontantPosteFixe";
            this.labelMontantPosteFixe.Size = new System.Drawing.Size(55, 13);
            this.labelMontantPosteFixe.TabIndex = 8;
            this.labelMontantPosteFixe.Text = "Montant : ";
            // 
            // labelJourDuMois
            // 
            this.labelJourDuMois.AutoSize = true;
            this.labelJourDuMois.Location = new System.Drawing.Point(8, 103);
            this.labelJourDuMois.Name = "labelJourDuMois";
            this.labelJourDuMois.Size = new System.Drawing.Size(75, 13);
            this.labelJourDuMois.TabIndex = 7;
            this.labelJourDuMois.Text = "Jour du mois : ";
            // 
            // txtBxJourDuMois
            // 
            this.txtBxJourDuMois.Location = new System.Drawing.Point(104, 100);
            this.txtBxJourDuMois.Name = "txtBxJourDuMois";
            this.txtBxJourDuMois.Size = new System.Drawing.Size(33, 20);
            this.txtBxJourDuMois.TabIndex = 6;
            // 
            // comboBxPeriodicite
            // 
            this.comboBxPeriodicite.FormattingEnabled = true;
            this.comboBxPeriodicite.Location = new System.Drawing.Point(104, 59);
            this.comboBxPeriodicite.Name = "comboBxPeriodicite";
            this.comboBxPeriodicite.Size = new System.Drawing.Size(162, 21);
            this.comboBxPeriodicite.TabIndex = 4;
            // 
            // labelPeriodicite
            // 
            this.labelPeriodicite.AutoSize = true;
            this.labelPeriodicite.Location = new System.Drawing.Point(8, 62);
            this.labelPeriodicite.Name = "labelPeriodicite";
            this.labelPeriodicite.Size = new System.Drawing.Size(65, 13);
            this.labelPeriodicite.TabIndex = 3;
            this.labelPeriodicite.Text = "Périodicité : ";
            // 
            // btnAutrePoste
            // 
            this.btnAutrePoste.Location = new System.Drawing.Point(308, 12);
            this.btnAutrePoste.Name = "btnAutrePoste";
            this.btnAutrePoste.Size = new System.Drawing.Size(75, 23);
            this.btnAutrePoste.TabIndex = 2;
            this.btnAutrePoste.Text = "Autre";
            this.btnAutrePoste.UseVisualStyleBackColor = true;
            // 
            // comboBxLibellePoste
            // 
            this.comboBxLibellePoste.FormattingEnabled = true;
            this.comboBxLibellePoste.Location = new System.Drawing.Point(104, 13);
            this.comboBxLibellePoste.Name = "comboBxLibellePoste";
            this.comboBxLibellePoste.Size = new System.Drawing.Size(198, 21);
            this.comboBxLibellePoste.TabIndex = 1;
            // 
            // labelPoste
            // 
            this.labelPoste.AutoSize = true;
            this.labelPoste.Location = new System.Drawing.Point(8, 16);
            this.labelPoste.Name = "labelPoste";
            this.labelPoste.Size = new System.Drawing.Size(90, 13);
            this.labelPoste.TabIndex = 0;
            this.labelPoste.Text = "Libellé du poste : ";
            // 
            // PagePostePonctuel
            // 
            this.PagePostePonctuel.Controls.Add(this.btnCalendrier2);
            this.PagePostePonctuel.Controls.Add(this.btnModifierPostes2);
            this.PagePostePonctuel.Controls.Add(this.BtnValiderPonctuel);
            this.PagePostePonctuel.Controls.Add(this.grpBxEcheances);
            this.PagePostePonctuel.Controls.Add(this.txtBxNombrePrelevements);
            this.PagePostePonctuel.Controls.Add(this.labelNombrePrelevements);
            this.PagePostePonctuel.Controls.Add(this.labelCommentaire);
            this.PagePostePonctuel.Controls.Add(this.txtBxCommentaire);
            this.PagePostePonctuel.Controls.Add(this.txtBxIntitule);
            this.PagePostePonctuel.Controls.Add(this.labelIntitulePoste);
            this.PagePostePonctuel.Location = new System.Drawing.Point(4, 22);
            this.PagePostePonctuel.Name = "PagePostePonctuel";
            this.PagePostePonctuel.Padding = new System.Windows.Forms.Padding(3);
            this.PagePostePonctuel.Size = new System.Drawing.Size(650, 450);
            this.PagePostePonctuel.TabIndex = 1;
            this.PagePostePonctuel.Text = "Poste ponctuel";
            this.PagePostePonctuel.UseVisualStyleBackColor = true;
            // 
            // btnCalendrier2
            // 
            this.btnCalendrier2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalendrier2.BackgroundImage = global::Gestion_de_budget.Properties.Resources.calendrierProbablementPasLibreDeDroit;
            this.btnCalendrier2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalendrier2.Location = new System.Drawing.Point(601, 6);
            this.btnCalendrier2.Name = "btnCalendrier2";
            this.btnCalendrier2.Size = new System.Drawing.Size(46, 46);
            this.btnCalendrier2.TabIndex = 13;
            this.btnCalendrier2.UseVisualStyleBackColor = true;
            // 
            // btnModifierPostes2
            // 
            this.btnModifierPostes2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifierPostes2.Location = new System.Drawing.Point(532, 369);
            this.btnModifierPostes2.Name = "btnModifierPostes2";
            this.btnModifierPostes2.Size = new System.Drawing.Size(115, 28);
            this.btnModifierPostes2.TabIndex = 12;
            this.btnModifierPostes2.Text = "Modifier les postes...";
            this.btnModifierPostes2.UseVisualStyleBackColor = true;
            // 
            // BtnValiderPonctuel
            // 
            this.BtnValiderPonctuel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnValiderPonctuel.Location = new System.Drawing.Point(532, 403);
            this.BtnValiderPonctuel.Name = "BtnValiderPonctuel";
            this.BtnValiderPonctuel.Size = new System.Drawing.Size(115, 44);
            this.BtnValiderPonctuel.TabIndex = 7;
            this.BtnValiderPonctuel.Text = "Valider\r\n";
            this.BtnValiderPonctuel.UseVisualStyleBackColor = true;
            // 
            // grpBxEcheances
            // 
            this.grpBxEcheances.Controls.Add(this.txtBxMontantEcheance);
            this.grpBxEcheances.Controls.Add(this.dateTimePickerEcheance);
            this.grpBxEcheances.Controls.Add(this.labelEcheance1);
            this.grpBxEcheances.Location = new System.Drawing.Point(7, 107);
            this.grpBxEcheances.Name = "grpBxEcheances";
            this.grpBxEcheances.Size = new System.Drawing.Size(412, 229);
            this.grpBxEcheances.TabIndex = 6;
            this.grpBxEcheances.TabStop = false;
            this.grpBxEcheances.Text = "Échéances prévues";
            // 
            // txtBxMontantEcheance
            // 
            this.txtBxMontantEcheance.Location = new System.Drawing.Point(328, 13);
            this.txtBxMontantEcheance.Name = "txtBxMontantEcheance";
            this.txtBxMontantEcheance.Size = new System.Drawing.Size(53, 20);
            this.txtBxMontantEcheance.TabIndex = 2;
            // 
            // dateTimePickerEcheance
            // 
            this.dateTimePickerEcheance.CustomFormat = "";
            this.dateTimePickerEcheance.Location = new System.Drawing.Point(141, 13);
            this.dateTimePickerEcheance.Name = "dateTimePickerEcheance";
            this.dateTimePickerEcheance.Size = new System.Drawing.Size(181, 20);
            this.dateTimePickerEcheance.TabIndex = 1;
            // 
            // labelEcheance1
            // 
            this.labelEcheance1.AutoSize = true;
            this.labelEcheance1.Location = new System.Drawing.Point(12, 16);
            this.labelEcheance1.Name = "labelEcheance1";
            this.labelEcheance1.Size = new System.Drawing.Size(123, 13);
            this.labelEcheance1.TabIndex = 0;
            this.labelEcheance1.Text = "Échéance n°( à générer)";
            // 
            // txtBxNombrePrelevements
            // 
            this.txtBxNombrePrelevements.Location = new System.Drawing.Point(148, 81);
            this.txtBxNombrePrelevements.Name = "txtBxNombrePrelevements";
            this.txtBxNombrePrelevements.Size = new System.Drawing.Size(44, 20);
            this.txtBxNombrePrelevements.TabIndex = 5;
            // 
            // labelNombrePrelevements
            // 
            this.labelNombrePrelevements.AutoSize = true;
            this.labelNombrePrelevements.Location = new System.Drawing.Point(8, 84);
            this.labelNombrePrelevements.Name = "labelNombrePrelevements";
            this.labelNombrePrelevements.Size = new System.Drawing.Size(134, 13);
            this.labelNombrePrelevements.TabIndex = 4;
            this.labelNombrePrelevements.Text = "Nombre de prélèvements : ";
            // 
            // labelCommentaire
            // 
            this.labelCommentaire.AutoSize = true;
            this.labelCommentaire.Location = new System.Drawing.Point(8, 46);
            this.labelCommentaire.Name = "labelCommentaire";
            this.labelCommentaire.Size = new System.Drawing.Size(77, 13);
            this.labelCommentaire.TabIndex = 3;
            this.labelCommentaire.Text = "Commentaire : ";
            // 
            // txtBxCommentaire
            // 
            this.txtBxCommentaire.Location = new System.Drawing.Point(148, 43);
            this.txtBxCommentaire.Name = "txtBxCommentaire";
            this.txtBxCommentaire.Size = new System.Drawing.Size(288, 20);
            this.txtBxCommentaire.TabIndex = 2;
            // 
            // txtBxIntitule
            // 
            this.txtBxIntitule.Location = new System.Drawing.Point(148, 4);
            this.txtBxIntitule.Name = "txtBxIntitule";
            this.txtBxIntitule.Size = new System.Drawing.Size(158, 20);
            this.txtBxIntitule.TabIndex = 1;
            // 
            // labelIntitulePoste
            // 
            this.labelIntitulePoste.AutoSize = true;
            this.labelIntitulePoste.Location = new System.Drawing.Point(8, 7);
            this.labelIntitulePoste.Name = "labelIntitulePoste";
            this.labelIntitulePoste.Size = new System.Drawing.Size(47, 13);
            this.labelIntitulePoste.TabIndex = 0;
            this.labelIntitulePoste.Text = "Intitulé : ";
            // 
            // PageRevenu
            // 
            this.PageRevenu.Controls.Add(this.btnCalendrier3);
            this.PageRevenu.Controls.Add(this.btnValiderRevenu);
            this.PageRevenu.Controls.Add(this.labelJourDuMoisRevenu);
            this.PageRevenu.Controls.Add(this.txtBxJourDuMoisRevenu);
            this.PageRevenu.Controls.Add(this.txtBxMontantRevenu);
            this.PageRevenu.Controls.Add(this.labelMontantRevenu);
            this.PageRevenu.Controls.Add(this.comboBxBeneficiaire);
            this.PageRevenu.Controls.Add(this.labelBeneficiaire);
            this.PageRevenu.Controls.Add(this.txtBxNomRevenu);
            this.PageRevenu.Controls.Add(this.labelNomDuRevenu);
            this.PageRevenu.Location = new System.Drawing.Point(4, 22);
            this.PageRevenu.Name = "PageRevenu";
            this.PageRevenu.Padding = new System.Windows.Forms.Padding(3);
            this.PageRevenu.Size = new System.Drawing.Size(650, 450);
            this.PageRevenu.TabIndex = 2;
            this.PageRevenu.Text = "Revenu";
            this.PageRevenu.UseVisualStyleBackColor = true;
            // 
            // btnCalendrier3
            // 
            this.btnCalendrier3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalendrier3.BackgroundImage = global::Gestion_de_budget.Properties.Resources.calendrierProbablementPasLibreDeDroit;
            this.btnCalendrier3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalendrier3.Location = new System.Drawing.Point(601, 6);
            this.btnCalendrier3.Name = "btnCalendrier3";
            this.btnCalendrier3.Size = new System.Drawing.Size(46, 46);
            this.btnCalendrier3.TabIndex = 13;
            this.btnCalendrier3.UseVisualStyleBackColor = true;
            // 
            // btnValiderRevenu
            // 
            this.btnValiderRevenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValiderRevenu.Location = new System.Drawing.Point(532, 403);
            this.btnValiderRevenu.Name = "btnValiderRevenu";
            this.btnValiderRevenu.Size = new System.Drawing.Size(115, 44);
            this.btnValiderRevenu.TabIndex = 8;
            this.btnValiderRevenu.Text = "Valider";
            this.btnValiderRevenu.UseVisualStyleBackColor = true;
            // 
            // labelJourDuMoisRevenu
            // 
            this.labelJourDuMoisRevenu.AutoSize = true;
            this.labelJourDuMoisRevenu.Location = new System.Drawing.Point(4, 124);
            this.labelJourDuMoisRevenu.Name = "labelJourDuMoisRevenu";
            this.labelJourDuMoisRevenu.Size = new System.Drawing.Size(75, 13);
            this.labelJourDuMoisRevenu.TabIndex = 7;
            this.labelJourDuMoisRevenu.Text = "Jour du mois : ";
            // 
            // txtBxJourDuMoisRevenu
            // 
            this.txtBxJourDuMoisRevenu.Location = new System.Drawing.Point(99, 121);
            this.txtBxJourDuMoisRevenu.Name = "txtBxJourDuMoisRevenu";
            this.txtBxJourDuMoisRevenu.Size = new System.Drawing.Size(39, 20);
            this.txtBxJourDuMoisRevenu.TabIndex = 6;
            // 
            // txtBxMontantRevenu
            // 
            this.txtBxMontantRevenu.Location = new System.Drawing.Point(99, 82);
            this.txtBxMontantRevenu.Name = "txtBxMontantRevenu";
            this.txtBxMontantRevenu.Size = new System.Drawing.Size(76, 20);
            this.txtBxMontantRevenu.TabIndex = 5;
            // 
            // labelMontantRevenu
            // 
            this.labelMontantRevenu.AutoSize = true;
            this.labelMontantRevenu.Location = new System.Drawing.Point(4, 85);
            this.labelMontantRevenu.Name = "labelMontantRevenu";
            this.labelMontantRevenu.Size = new System.Drawing.Size(55, 13);
            this.labelMontantRevenu.TabIndex = 4;
            this.labelMontantRevenu.Text = "Montant : ";
            // 
            // comboBxBeneficiaire
            // 
            this.comboBxBeneficiaire.FormattingEnabled = true;
            this.comboBxBeneficiaire.Location = new System.Drawing.Point(99, 43);
            this.comboBxBeneficiaire.Name = "comboBxBeneficiaire";
            this.comboBxBeneficiaire.Size = new System.Drawing.Size(193, 21);
            this.comboBxBeneficiaire.TabIndex = 3;
            // 
            // labelBeneficiaire
            // 
            this.labelBeneficiaire.AutoSize = true;
            this.labelBeneficiaire.Location = new System.Drawing.Point(4, 46);
            this.labelBeneficiaire.Name = "labelBeneficiaire";
            this.labelBeneficiaire.Size = new System.Drawing.Size(71, 13);
            this.labelBeneficiaire.TabIndex = 2;
            this.labelBeneficiaire.Text = "Bénéficiaire : ";
            // 
            // txtBxNomRevenu
            // 
            this.txtBxNomRevenu.Location = new System.Drawing.Point(99, 4);
            this.txtBxNomRevenu.Name = "txtBxNomRevenu";
            this.txtBxNomRevenu.Size = new System.Drawing.Size(193, 20);
            this.txtBxNomRevenu.TabIndex = 1;
            // 
            // labelNomDuRevenu
            // 
            this.labelNomDuRevenu.AutoSize = true;
            this.labelNomDuRevenu.Location = new System.Drawing.Point(4, 7);
            this.labelNomDuRevenu.Name = "labelNomDuRevenu";
            this.labelNomDuRevenu.Size = new System.Drawing.Size(89, 13);
            this.labelNomDuRevenu.TabIndex = 0;
            this.labelNomDuRevenu.Text = "Nom du revenu : ";
            // 
            // errorGestionBudget
            // 
            this.errorGestionBudget.ContainerControl = this;
            // 
            // FormGestionBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 506);
            this.Controls.Add(this.tabControlVolets);
            this.MinimumSize = new System.Drawing.Size(685, 545);
            this.Name = "FormGestionBudget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de budget";
            this.Load += new System.EventHandler(this.FormGestionBudget_Load);
            this.pageOnglets.ResumeLayout(false);
            this.ongletAffichage1a1.ResumeLayout(false);
            this.ongletAffichage1a1.PerformLayout();
            this.ongletAjoutTransaction.ResumeLayout(false);
            this.ongletAjoutTransaction.PerformLayout();
            this.ongletSuppressionTransaction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppression)).EndInit();
            this.ongletModifTransaction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModification)).EndInit();
            this.ongletRecapitulatif.ResumeLayout(false);
            this.grpBxCriteres.ResumeLayout(false);
            this.grpBxCriteres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultatsRecherche)).EndInit();
            this.grpBxRecherche.ResumeLayout(false);
            this.grpBxRecherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budget1DataSet)).EndInit();
            this.tabControlVolets.ResumeLayout(false);
            this.tabVolet1.ResumeLayout(false);
            this.tabVolet2.ResumeLayout(false);
            this.BudgetOnglets.ResumeLayout(false);
            this.PagePosteFixe.ResumeLayout(false);
            this.PagePosteFixe.PerformLayout();
            this.PagePostePonctuel.ResumeLayout(false);
            this.PagePostePonctuel.PerformLayout();
            this.grpBxEcheances.ResumeLayout(false);
            this.grpBxEcheances.PerformLayout();
            this.PageRevenu.ResumeLayout(false);
            this.PageRevenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorGestionBudget)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pageOnglets;
        private System.Windows.Forms.TabPage ongletAffichage1a1;
        private System.Windows.Forms.TabPage ongletAjoutTransaction;
        private System.Windows.Forms.TabPage ongletSuppressionTransaction;
        private System.Windows.Forms.TabPage ongletModifTransaction;
        private System.Windows.Forms.TabPage ongletRecapitulatif;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateDepense;
        private System.Windows.Forms.Label labelMontant;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelDateDepense;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox txtBxMontant;
        private System.Windows.Forms.TextBox txtBxDescription;
        private System.Windows.Forms.Button btnFinalAjouter;
        private System.Windows.Forms.Button btnAjoutType;
        private System.Windows.Forms.ComboBox comboBxType;
        private System.Windows.Forms.Button btnAjoutPersonne;
        private System.Windows.Forms.DataGridView dataGridViewSuppression;
        private budget1DataSet budget1DataSet;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private budget1DataSetTableAdapters.TransactionTableAdapter transactionTableAdapter;
        private System.Windows.Forms.Button btnSupprimerTransaction;
        private System.Windows.Forms.DataGridView dataGridViewModification;
        private System.Windows.Forms.CheckBox checkBxPercu;
        private System.Windows.Forms.CheckBox checkBxRecette;
        private System.Windows.Forms.DateTimePicker dateTimePicker1a1;
        private System.Windows.Forms.CheckBox checkBxPercu1a1;
        private System.Windows.Forms.CheckBox checkBxRecette1a1;
        private System.Windows.Forms.Label labelMontant1a1;
        private System.Windows.Forms.Label labelDescription1a1;
        private System.Windows.Forms.Label labelType1a1;
        private System.Windows.Forms.Label labelNumTransaction;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnDebut;
        private System.Windows.Forms.Button btnModification;
        private System.Windows.Forms.GroupBox grpBxRecherche;
        private System.Windows.Forms.Label labelAu;
        private System.Windows.Forms.Label labelLeDu;
        private System.Windows.Forms.DateTimePicker dateTimePickerRecapAu;
        private System.Windows.Forms.CheckBox checkBxPlage;
        private System.Windows.Forms.DateTimePicker dateTimePickerRecapDu;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.RadioButton radioBtnInferieurEgal;
        private System.Windows.Forms.RadioButton radioBtnSuperieurEgal;
        private System.Windows.Forms.RadioButton radioBtnStrictementEgal;
        private System.Windows.Forms.Label labelMontantRecap;
        private System.Windows.Forms.Label labelTypeRecap;
        private System.Windows.Forms.ComboBox comboBxTypeRecap;
        private System.Windows.Forms.TextBox txtBxMontantRecap;
        private System.Windows.Forms.GroupBox grpBxCriteres;
        private System.Windows.Forms.CheckBox checkBxCritereRecette;
        private System.Windows.Forms.CheckBox checkBxCritereEncaisse;
        private System.Windows.Forms.CheckBox checkBxCriterePrix;
        private System.Windows.Forms.CheckBox checkBxCritereType;
        private System.Windows.Forms.CheckBox checkBxCritereDate;
        private System.Windows.Forms.CheckBox checkBxRecetteRecap;
        private System.Windows.Forms.CheckBox checkBxEncaisse;
        private System.Windows.Forms.Button btnGenererPdf;
        private System.Windows.Forms.DataGridView dataGridViewResultatsRecherche;
        private System.Windows.Forms.GroupBox grpBxUtilisateursGeneres;
        private System.Windows.Forms.TabControl tabControlVolets;
        private System.Windows.Forms.TabPage tabVolet1;
        private System.Windows.Forms.TabPage tabVolet2;
        private System.Windows.Forms.TabControl BudgetOnglets;
        private System.Windows.Forms.TabPage PagePosteFixe;
        private System.Windows.Forms.Button btnCalendrier;
        private System.Windows.Forms.Button btnModifierPostes;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtBxMontantPosteFixe;
        private System.Windows.Forms.Label labelMontantPosteFixe;
        private System.Windows.Forms.Label labelJourDuMois;
        private System.Windows.Forms.TextBox txtBxJourDuMois;
        private System.Windows.Forms.ComboBox comboBxPeriodicite;
        private System.Windows.Forms.Label labelPeriodicite;
        private System.Windows.Forms.Button btnAutrePoste;
        private System.Windows.Forms.ComboBox comboBxLibellePoste;
        private System.Windows.Forms.Label labelPoste;
        private System.Windows.Forms.TabPage PagePostePonctuel;
        private System.Windows.Forms.Button btnCalendrier2;
        private System.Windows.Forms.Button btnModifierPostes2;
        private System.Windows.Forms.Button BtnValiderPonctuel;
        private System.Windows.Forms.GroupBox grpBxEcheances;
        private System.Windows.Forms.TextBox txtBxMontantEcheance;
        private System.Windows.Forms.DateTimePicker dateTimePickerEcheance;
        private System.Windows.Forms.Label labelEcheance1;
        private System.Windows.Forms.TextBox txtBxNombrePrelevements;
        private System.Windows.Forms.Label labelNombrePrelevements;
        private System.Windows.Forms.Label labelCommentaire;
        private System.Windows.Forms.TextBox txtBxCommentaire;
        private System.Windows.Forms.TextBox txtBxIntitule;
        private System.Windows.Forms.Label labelIntitulePoste;
        private System.Windows.Forms.TabPage PageRevenu;
        private System.Windows.Forms.Button btnCalendrier3;
        private System.Windows.Forms.Button btnValiderRevenu;
        private System.Windows.Forms.Label labelJourDuMoisRevenu;
        private System.Windows.Forms.TextBox txtBxJourDuMoisRevenu;
        private System.Windows.Forms.TextBox txtBxMontantRevenu;
        private System.Windows.Forms.Label labelMontantRevenu;
        private System.Windows.Forms.ComboBox comboBxBeneficiaire;
        private System.Windows.Forms.Label labelBeneficiaire;
        private System.Windows.Forms.TextBox txtBxNomRevenu;
        private System.Windows.Forms.Label labelNomDuRevenu;
        private System.Windows.Forms.ListBox lstBxPersonnesConcernees;
        private System.Windows.Forms.ErrorProvider errorGestionBudget;
    }
}

