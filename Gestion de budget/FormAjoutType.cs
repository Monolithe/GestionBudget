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

namespace Gestion_de_budget
{
    public partial class FormAjoutType : Form
    {
        public FormAjoutType()
        {
            InitializeComponent();
        }
        private void btnAjoutType_Click(object sender, EventArgs e)//verif les conditions et lance la requète
        {
            bool ok = false;
            if (txtBxNouveauType.Text.Equals(""))
            {
                errorAjoutType.SetError(txtBxNouveauType, "Veuillez saisir une valeur");
            }
            else ok = true;
            if (ok) ajoutType();
        }
        private void ajoutType()//requète d'ajout de type
        {

            errorAjoutType.SetError(txtBxNouveauType, "");
            string nomType = txtBxNouveauType.Text;
            int codeType;
            OleDbConnection connect = new OleDbConnection(FormGestionBudget.stringProvider);
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                connect.Open();
                cmd.Connection = connect;
                cmd.CommandText = "Select max(codeType) from `TypeTransaction`";
                codeType = (int)cmd.ExecuteScalar();
                codeType++;

                cmd.CommandText = "Insert Into `TypeTransaction` Values(" + codeType + ",'" + nomType + "')";
                cmd.ExecuteNonQuery();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Problème co");
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            txtBxNouveauType.Text = "";
        }

        private void txtBxNouveauType_KeyPress(object sender, KeyPressEventArgs e)//verif les conditions et lance la requète quand on press enter
        {
            FormGestionBudget.testCarac(sender, e);
            if (e.KeyChar == 13)
            {
                bool ok = false;
                if (txtBxNouveauType.Text.Equals(""))
                {
                    errorAjoutType.SetError(txtBxNouveauType, "Veuillez saisir une valeur");
                }
                else ok = true;
                if (ok) ajoutType();
            }
        }
    }
}