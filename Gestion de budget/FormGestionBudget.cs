using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Gestion_de_budget
{
    public partial class FormGestionBudget : Form
    {

        public static string stringProvider = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 9) + "budget1.mdb";
        DataSet dsGlobal = new DataSet();
        int indexActuel = 1;//le code de la transaction actuellement visualisée
        public FormGestionBudget()
        {
            InitializeComponent();
            //fillDsGlobal();
            //genNomAjoutTransaction();
            //ajoutTransaction();
            //remplirTypeAjoutTransaction();
        }
        private void FormGestionBudget_Load(object sender, EventArgs e)//AU CHARGEMENT DU FORMULAIRE
        {
            fillDsGlobal();
            Refresh1a1(indexActuel);
        }
        public void fillDsGlobal()//récupère l'ensemble de la base de données dans dsGlobal
        {
            OleDbConnection connect = new OleDbConnection(stringProvider);
            try
            {
                dsGlobal.Clear();
                connect.Open();
                DataTable schema = connect.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new Object[] { null, null, null, "Table" });
                string nomTable;
                string request;
                foreach (DataRow ligne in schema.Rows)
                {
                    nomTable = ligne[2].ToString();
                    request = "Select * from `" + nomTable + "`";
                    OleDbCommand cmd = new OleDbCommand(request, connect);
                    OleDbDataAdapter da = new OleDbDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(dsGlobal, nomTable);
                }
            }
            catch (InvalidOperationException)
            { MessageBox.Show("Problème co"); }
            catch (OleDbException)
            { MessageBox.Show("Problème requète"); }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }
        public void genNomAjoutTransaction()//génère les checkbox de personne pour l'ajout de transaction
        {
            int k = 0;// nombre de cbx généré permet le décalage
            foreach (DataRow ligne in dsGlobal.Tables["Personne"].Rows)
            {
                CheckBox checkBoxPersonne = new CheckBox();
                checkBoxPersonne.AutoSize = true;
                checkBoxPersonne.Location = new System.Drawing.Point(10, 15 + k * 25);
                checkBoxPersonne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                checkBoxPersonne.Name = "checkBoxDynamic";
                checkBoxPersonne.Size = new System.Drawing.Size(312, 21);
                checkBoxPersonne.TabIndex = 16;
                checkBoxPersonne.Text = ligne[1].ToString() + " " + ligne[2].ToString();
                grpBxUtilisateursGeneres.Controls.Add(checkBoxPersonne);
                k++;
            }
        }
        public void ajoutTransaction()//ajoute la transaction dans la base de données
        {
            int codeTransac = 0;
            string descriptionTrans;
            string dateTrans;
            int typeTrans;
            double montantTrans;
            bool recetteTrans;
            bool percuTrans;
            List<int> listeCodePersonne = new List<int>();
            OleDbConnection connect = new OleDbConnection(stringProvider);
            OleDbTransaction transac = null;
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                connect.Open();

                //start transaction
                transac = connect.BeginTransaction();

                //init la commande à la co et transac
                cmd.Connection = connect;
                cmd.Transaction = transac;

                //envoi des requètes

                //requète pour le code Transaction
                cmd.CommandText = "Select max(codeTransaction) from `Transaction`";
                codeTransac = (int)cmd.ExecuteScalar();
                codeTransac++;

                //requètes pour recup les codes personnes
                foreach (CheckBox cbx in grpBxUtilisateursGeneres.Controls)
                {
                    if (cbx.Checked)//si la checkbox est coché 
                    {
                        string[] personne = cbx.Text.Split(' ');//on découpe pour recup 0:nom et 1:prénom
                        listeCodePersonne.Add(recupCodePersonne(personne[0], personne[1], ref cmd));//on ajoute le code de la personne dans la liste
                    }
                }
                //initialisation des valeurs
                montantTrans = double.Parse(txtBxMontant.Text);
                dateTrans = dateTimePickerDateDepense.Value.ToShortDateString();
                descriptionTrans = txtBxDescription.Text;
                typeTrans = int.Parse(comboBxType.SelectedValue.ToString());
                recetteTrans = checkBxRecette.Checked;
                percuTrans = checkBxPercu.Checked;

                //requète d'inserttion de transaction
                cmd.CommandText = "Insert into `Transaction`  Values(" + codeTransac + ",'" + dateTrans + "','" + descriptionTrans + "','" + montantTrans + "'," + recetteTrans.ToString().ToUpper() + "," + percuTrans.ToString().ToUpper() + "," + typeTrans + ")";
                cmd.ExecuteNonQuery();

                //requète d'ajout dans table beneficiaires
                foreach (int codePers in listeCodePersonne)
                {
                    cmd.CommandText = "Insert into `Beneficiaires` Values(" + codeTransac + "," + codePers + ")";
                    cmd.ExecuteNonQuery();
                }
                //commit si tout va bien
                transac.Commit();


            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Problème co la transaction a été RollBack");
                transac.Rollback();
            }
            /* catch (OleDbException)
             {
                 MessageBox.Show("Problème requète la transaction a été RollBack");
                 transac.Rollback();
             }*/
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }
        public static void remplirTypeAjoutTransaction(ComboBox cb)//remplit la combobox cb de ajout Transac dysplay=lib value=codeType
        {
            OleDbConnection connect = new OleDbConnection(stringProvider);
            DataTable dtTypeTransaction = new DataTable();
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                connect.Open();//ouverture co recup de la table TypeTransac
                cmd.Connection = connect;
                cmd.CommandText = ("Select * from `TypeTransaction`");

                OleDbDataReader drTypeTransaction = cmd.ExecuteReader();//on recup dans DataReader puis charge dans DataTable
                dtTypeTransaction.Load(drTypeTransaction);

                cb.DataSource = dtTypeTransaction;//on définit source, display et value
                cb.DisplayMember = "libType";
                cb.ValueMember = "codeType";

                drTypeTransaction.Close();//fermeture dataReader
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Problème de co ");
            }
            catch (OleDbException)
            {
                MessageBox.Show("Problème requète");
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }
        public int recupCodePersonne(string nom, string prenom, ref OleDbCommand cmd)//renvoi le codePersonne correspondant a une personne
        {
            cmd.CommandText = "Select codePersonne from Personne where nomPersonne='" + nom + "' and pnPersonne='" + prenom + "'";
            return (int)cmd.ExecuteScalar();
        }
        public static void testDigit(object sender, KeyPressEventArgs e)//verif la saisie autorise digit et une virgule
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        public static void testCarac(object sender, KeyPressEventArgs e)//verif la saisie autorise les lettres 
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static void fillDataGridView(DataGridView dgv, string table)
        {
            OleDbConnection connection = new OleDbConnection(stringProvider);
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM `" + table + "`");
            try
            {
                connection.Open();
                cmd.Connection = connection;
                DataTable datas = new DataTable();
                OleDbDataAdapter adapt = new OleDbDataAdapter(cmd);
                adapt.Fill(datas);
                dgv.DataSource = datas;
                adapt.Dispose();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Problème de connection");
            }
            catch (OleDbException)
            {
                MessageBox.Show("Problème requète");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }//Remplit n'importe quel DataGridView avec la table donnée en paramètre

        //ONGLET 1a1 (nico)
        private void ongletAffichage1a1_Enter(object sender, EventArgs e)//à l'entrée dans l'onglet Affichage 1a1, charge les labels avec par défaut les attributs de la transaction 1
        {
            fillDsGlobal();
            lstBxPersonnesConcernees.Items.Clear();
            Refresh1a1(indexActuel);
        }
        private void Refresh1a1(int indexActuel)
        {
            DataRow[] ligneTrans;
            DataRow[] ligneType;
            DataRow[] lignePers;
            DataRow[] ligneBenef;
            try
            {
                labelNumTransaction.Text = "Transaction numéro " + indexActuel;
                ligneTrans = dsGlobal.Tables["Transaction"].Select("codeTransaction = " + indexActuel);//récupère un tableau avec les données de la table Transaction qui ont pour code l'index actuel
                dateTimePicker1a1.Value = (System.DateTime)ligneTrans[0][1];//et remplit les labels avec
                labelDescription1a1.Text = "Description : " + ligneTrans[0][2];
                labelMontant1a1.Text = "Montant : " + ligneTrans[0][3];
                checkBxRecette1a1.Checked = (bool)ligneTrans[0][4];
                checkBxPercu1a1.Checked = (bool)ligneTrans[0][5];
                ligneType = dsGlobal.Tables["TypeTransaction"].Select("codeType = " + ligneTrans[0][6]);//récupère la catégorie de la transaction courante

                labelType1a1.Text = "Catégorie : " + ligneType[0][1];
                ligneBenef = dsGlobal.Tables["Beneficiaires"].Select("codeTransaction = " + ligneTrans[0][0]);
                //récupère les personnes concernées par la transaction courante
                for (int i = 0; i < ligneBenef.Length; i++)//pour chaque personne concernée, on ajoute son Nom Prénom à la listbox
                {
                    lignePers = dsGlobal.Tables["Personne"].Select("codePersonne = " + ligneBenef[i][1]);
                    string nomPrenom = lignePers[0][1] + " " + lignePers[0][2];
                    lstBxPersonnesConcernees.Items.Add(nomPrenom);
                }
            }
            catch (IndexOutOfRangeException)
            {
                labelDescription1a1.Text = "Description :";
                labelNumTransaction.Text = "Transaction numéro " + indexActuel;
                dateTimePicker1a1.Value = DateTime.Today;
                labelMontant1a1.Text = "Montant : ";
                checkBxRecette1a1.Checked = false;
                checkBxPercu1a1.Checked = false;
                labelType1a1.Text = "Catégorie : ";

            }
        }//met à jour les infos de l'onglet 1a1 avec les infos de la transaction de code indexActuel
        private void btnSuivant_Click(object sender, EventArgs e)//au clic, passe à la transaction suivante
        {
            if(indexActuel < (int) dsGlobal.Tables["Transaction"].Rows[dsGlobal.Tables["Transaction"].Rows.Count-1][0])//vérifie d'abord si on est pas déjà à la dernière transaction
            {
                lstBxPersonnesConcernees.Items.Clear();
                indexActuel++;
                Refresh1a1(indexActuel);
            }
        }
        private void btnPrecedent_Click(object sender, EventArgs e)//au clic, passe à la transaction précédente
        {
            if (indexActuel > 1)
            {
                lstBxPersonnesConcernees.Items.Clear();
                indexActuel--;
                Refresh1a1(indexActuel);
            }
        }
        private void btnFin_Click(object sender, EventArgs e)//au clic, passe à la dernière transaction
        {
            lstBxPersonnesConcernees.Items.Clear();
            indexActuel = (int)dsGlobal.Tables["Transaction"].Rows[dsGlobal.Tables["Transaction"].Rows.Count - 1][0];
            Refresh1a1(indexActuel);
        }
        private void btnDebut_Click(object sender, EventArgs e)//au clic, passe à la première transaction
        {
            lstBxPersonnesConcernees.Items.Clear();
            indexActuel = 1;
            Refresh1a1(indexActuel);
        }
        private void ongletAffichage1a1_Leave(object sender, EventArgs e)//à la sortie de l'onglet, vide la listbox des personnes concernées
        {
            lstBxPersonnesConcernees.Items.Clear();
        }

        //AJOUT TRANSACTION (alex)
        private void ongletSuppressionTransaction_Enter(object sender, EventArgs e)
        {
            fillDataGridView(dataGridViewSuppression, "Transaction");
        }
        private void btnSupprimerTransaction_Click(object sender, EventArgs e)
        {
            if (dataGridViewSuppression.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une transaction", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // On s'apprête a supprimer les lignes sélectionnée par l'utilisateur par le biais d'une transaction
                OleDbConnection connect = new OleDbConnection(stringProvider);
                OleDbTransaction transac = null;
                OleDbCommand cmd = new OleDbCommand();
                int c = 0;
                int d = 0;
                try
                {
                    connect.Open();
                    transac = connect.BeginTransaction();
                    cmd.Connection = connect;
                    cmd.Transaction = transac;
                    // Pour toute les lignes sélectionnée , on fait une transaction avec une commande suppression sur Transaction et sur Beneficiaire
                    for (int i = 0; i < dataGridViewSuppression.SelectedRows.Count; i++)
                    {
                        cmd.CommandText = "DELETE Beneficiaires.* FROM `Beneficiaires` WHERE codeTransaction=" + dataGridViewSuppression.SelectedRows[i].Cells["codeTransaction"].Value;
                        d += cmd.ExecuteNonQuery();
                        cmd.CommandText = "DELETE Transaction.* FROM `Transaction` WHERE codeTransaction=" + dataGridViewSuppression.SelectedRows[i].Cells["codeTransaction"].Value;
                        c += cmd.ExecuteNonQuery();
                    }
                    transac.Commit();
                    MessageBox.Show(c + " lignes supprimées dans Transaction\n" + d + " lignes supprimées dans Beneficiaires", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillDataGridView(dataGridViewSuppression, "Transaction"); // Mise a jour du datagridview
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Problème de connection", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (OleDbException)
                {
                    MessageBox.Show("Problème requète", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            }
        }
        private void ongletModifTransaction_Enter(object sender, EventArgs e)
        {
            fillDataGridView(dataGridViewModification, "Transaction");
        }
        private void btnAjoutType_Click(object sender, EventArgs e)//ouvre la fenêtre ajout Type
        {
            FormAjoutType frm = new FormAjoutType();
            frm.ShowDialog();
            remplirTypeAjoutTransaction(comboBxType);
        }
        private void btnFinalAjouter_Click(object sender, EventArgs e)//verifie si les paramètres de la transac sont ok et valide
        {
            bool ok = true;

            if (txtBxDescription.Text.Equals(""))
            {
                ok = false;
                errorGestionBudget.SetError(txtBxDescription, "Veuillez saisir une description");
            }
            else errorGestionBudget.SetError(txtBxDescription, "");

            if (ok) ajoutTransaction();
        }
        private void ongletAjoutTransaction_Enter(object sender, EventArgs e)
        {
            remplirTypeAjoutTransaction(comboBxType);
            genNomAjoutTransaction();
        }
        private void btnAjoutPersonne_Click(object sender, EventArgs e)
        {
            FormAjoutPersonne frm = new FormAjoutPersonne();
            frm.ShowDialog();
            genNomAjoutTransaction();
        }

        //RECAP (nico)
        private void checkBxCritereDate_CheckedChanged(object sender, EventArgs e)//quand la case est cochée, permet à l'utilisateur de rechercher par date
        {
            if (checkBxCritereDate.Checked)
            {
                checkBxPlage.Enabled = true;
                dateTimePickerRecapAu.Enabled = true;
                dateTimePickerRecapDu.Enabled = true;
                btnRechercher.Enabled = true;
            }
            else
            {
                checkBxPlage.Enabled = false;
                dateTimePickerRecapAu.Enabled = false;
                dateTimePickerRecapDu.Enabled = false;
                VerificationRecherche();
            }
        }
        private void checkBxPlage_CheckedChanged(object sender, EventArgs e)//Quand la case est cochée, permet de rechercher par plage de dates
        {
            if(checkBxPlage.Checked)
            {
                dateTimePickerRecapAu.Visible = true;
                labelAu.Visible = true;
                labelLeDu.Text = "du";
            }
            else
            {
                dateTimePickerRecapAu.Visible = false;
                labelAu.Visible = false;
                labelLeDu.Text = "le";
            }
        }
        private void checkBxCritereType_CheckedChanged(object sender, EventArgs e)//Quand la case est cochée, permet de rechercher par critère et remplit la combobox critère
        {
            if(checkBxCritereType.Checked)
            {
                remplirTypeAjoutTransaction(comboBxTypeRecap);
                comboBxTypeRecap.Enabled = true;
                btnRechercher.Enabled = true;
            }
            else
            {
                comboBxTypeRecap.Enabled = false;
                VerificationRecherche();
            }
        }
        private void ongletRecapitulatif_Enter(object sender, EventArgs e)
        {
            fillDsGlobal();
        }//à l'entrée dans l'onglet de recherche, met à jour le dataset global
        private void checkBxCriterePrix_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBxCriterePrix.Checked)
            {
                txtBxMontantRecap.Enabled = true;
                radioBtnInferieurEgal.Enabled = true;
                radioBtnStrictementEgal.Enabled = true;
                radioBtnSuperieurEgal.Enabled = true;
                btnRechercher.Enabled = true;
            }
            else
            {
                txtBxMontantRecap.Enabled = false;
                radioBtnInferieurEgal.Enabled = false;
                radioBtnStrictementEgal.Enabled = false;
                radioBtnSuperieurEgal.Enabled = false;
                VerificationRecherche();
            }
        }
        private void VerificationRecherche()
        {
            bool LeBoutonRechercherEstActif = false;
            foreach(CheckBox chkbx in grpBxCriteres.Controls)
            {
                if(chkbx.Checked)
                {
                    LeBoutonRechercherEstActif = true;
                }
            }
            if(LeBoutonRechercherEstActif)
            {
                btnRechercher.Enabled = true;
            }
            else
            {
                btnRechercher.Enabled = false;
            }
        }//si une case au moins est cochée, on peut faire la recherche, sinon, non
        private void checkBxCritereEncaisse_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBxCritereEncaisse.Checked)
            {
                checkBxEncaisse.Enabled = true;
                btnRechercher.Enabled = true;
            }
            else
            {
                checkBxEncaisse.Enabled = false;
                VerificationRecherche();
            }
        }//si la case Encaisse ou non est cochée, on peut faire une recherche par Encaisse
        private void checkBxCritereRecette_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBxCritereRecette.Checked)
            {
                checkBxRecetteRecap.Enabled = true;
                btnRechercher.Enabled = true;
            }
            else
            {
                checkBxRecetteRecap.Enabled = false;
                VerificationRecherche();
            }
        }//si la case Recette ou Depense est cochée, on peut faire une recherche par Recette
        private void btnRechercher_Click(object sender, EventArgs e)
        {

        }//recherche locale ou en ligne ???

        private void btnModification_Click(object sender, EventArgs e)
        {
            try {
                int codeTransac = (int)dataGridViewModification.SelectedRows[0].Cells["codeTransaction"].Value;
                DateTime date = (DateTime)dataGridViewModification.SelectedRows[0].Cells["dateTransaction"].Value;
                string desc = (string)dataGridViewModification.SelectedRows[0].Cells["description"].Value;
                double montant = Double.Parse(dataGridViewModification.SelectedRows[0].Cells["montant"].Value.ToString());
                bool recette = (bool)dataGridViewModification.SelectedRows[0].Cells["recetteON"].Value;
                bool percu = (bool)dataGridViewModification.SelectedRows[0].Cells["percuON"].Value;
                int indiceType = (int)dataGridViewModification.SelectedRows[0].Cells["type"].Value;
                FormModifierTransaction modif = new FormModifierTransaction(codeTransac, date, desc, montant, recette, percu, indiceType);
                modif.ShowDialog();
                if(modif.DialogResult == DialogResult.OK)
                {
                    fillDataGridView(dataGridViewSuppression, "Transaction");
                }
            }
            catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Sélectionnez une ligne a modifier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
    }
}