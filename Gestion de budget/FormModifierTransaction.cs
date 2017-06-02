using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_budget
{
    public partial class FormModifierTransaction : Form
    {
        private int codeTransac;
        public FormModifierTransaction(int codeTransac, DateTime date, string description, double montant, bool recette, bool percu, int indiceCat)
        { 
            InitializeComponent();
            this.codeTransac = codeTransac;
            dateTimePickerNouvelleDate.Value = date;
            txtBxNouvelleDescription.Text = description;
            txtBxNouveauMontant.Text = montant.ToString();
            checkBxRecette.Checked = recette;
            checkBxPercu.Checked = percu;
            FormGestionBudget.remplirTypeAjoutTransaction(comboBxType);
            comboBxType.SelectedIndex = indiceCat - 1;
        }

        private void txtBxNouveauMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnValiderModifs_Click(object sender, EventArgs e)
        {
            int recette = 0;
            int percu = 0;
            if(checkBxRecette.Checked)
            {
                recette = 1;
            }
            if(checkBxPercu.Checked)
            {
                percu = 1;
            }
            string date = dateTimePickerNouvelleDate.Value.ToString("d", CultureInfo.CreateSpecificCulture("en-US"));
            string commande = "UPDATE `Transaction` SET dateTransaction=format('" + date + "', 'mm/dd/yyyy'),description='" + txtBxNouvelleDescription.Text + "',montant=" + txtBxNouveauMontant.Text + ",recetteON=" + recette + ",percuON=" + percu + ",type=" + comboBxType.SelectedIndex + " WHERE codeTransaction = " + codeTransac;

            OleDbConnection connect = new OleDbConnection(FormGestionBudget.stringProvider);
            OleDbTransaction transac = null;
            OleDbCommand cmd = new OleDbCommand(commande);
            
            try
            {
                connect.Open();
                transac = connect.BeginTransaction();
                cmd.Connection = connect;
                cmd.Transaction = transac;
                cmd.ExecuteNonQuery();
                transac.Commit();
                MessageBox.Show("Modification effectuées avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
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
            this.Close();
        }
    }
}
 