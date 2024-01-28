using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppMenu.Model1;
using AppMenu.Utils;

namespace AppMenu
{
    public partial class frmProvisionnement : Form
    {

        public Produit produit;
        public BdKireneEntities db = new BdKireneEntities();

        public frmProvisionnement()
        {
            InitializeComponent();
        }
        private void frmProvisionnement_Load(object sender, EventArgs e)
        {
            
            lblProduit.Text = produit.DesignationProduit;
            dgApprovisionnement.DataSource = db.Approvisionnement.Where(a => a.CodeProduit == produit.CodeProduit && a.QteRestant > 0).ToList();
            alerte.alerteColor(dgApprovisionnement.Rows);


        }

        private void txtQte_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDatePeremption_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetForm()
        {
            txtDatePeremption.Value = DateTime.Now;
            txtQte.Text = string.Empty;
            dgApprovisionnement.DataSource = db.Approvisionnement.Where(a => a.CodeProduit == produit.CodeProduit && a.QteRestant > 0).ToList();
            txtQte.Focus();
            alerte.alerteColor(dgApprovisionnement.Rows);

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            
            if (DateTime.Now > txtDatePeremption.Value)
            {
                MessageBox.Show("la date saisie est passer, veuillez saisir une bonne date !");
            }else
            {
                Approvisionnement a = new Approvisionnement();
                a.QteAppro = int.Parse(txtQte.Text);
                a.DatePeremption = txtDatePeremption.Value;
                a.QteRestant = int.Parse(txtQte.Text);
                a.DateAppro = DateTime.Now.ToShortDateString();
                a.CodeProduit = produit.CodeProduit;
                db.Approvisionnement.Add(a);
                db.SaveChanges();
            }
            resetForm();

        }

       

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgApprovisionnement.CurrentRow.Cells[0].Value.ToString());
            Approvisionnement a = db.Approvisionnement.Find(id);
            db.Approvisionnement.Remove(a);
            db.SaveChanges();
            resetForm();    
        }
    }
}
