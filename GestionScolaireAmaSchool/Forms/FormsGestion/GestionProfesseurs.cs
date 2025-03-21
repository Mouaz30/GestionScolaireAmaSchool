using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionScolaireAmaSchool.Data;
using GestionScolaireAmaSchool.Entity;

namespace GestionScolaireAmaSchool.Forms.FormsGestion
{
    public partial class GestionProfesseurs : Form
    {
        private DbContextAmaSchool db;
        public GestionProfesseurs()
        {
            db = new DbContextAmaSchool();
            InitializeComponent();
        }

        private void GestionProfesseurs_Load(object sender, EventArgs e)
        {
            var utlisateur = db.Utilisateur.ToList();
            cmbUser.DataSource = null;

            cmbUser.DataSource = utlisateur;
            cmbUser.DisplayMember = "NomUtilisateur";
            cmbUser.ValueMember = "Id";

           refresh();
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new DbContextAmaSchool())
            {
                String NomProf = txtnomProf.Text;
                String PrenomProf = txtprenomProf.Text;
                String EmailProf = txtemailProf.Text;
                String Telephone = txtPhoneProf.Text;
                string NomUser = cmbUser.Text;
                Utilisateurs utilisateurs = db.Utilisateur.Where(C => C.NomUtilisateur == NomUser).FirstOrDefault();

                try
                {
                    Professeurs pr = new Professeurs();
                    pr.Nom = NomProf;
                    pr.Prenom = PrenomProf;
                    pr.Email = EmailProf;
                    pr.Telephone = Telephone;
                    pr.Utilisateur = utilisateurs;

                    db.Professeur.Add(pr);
                    db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Console.WriteLine($"Propriété: {validationError.PropertyName} Erreur: {validationError.ErrorMessage}");
                        }
                    }
                }


                Refresh();
                MessageBox.Show("prof ajouter aavec succes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
                
                if (string.IsNullOrEmpty(NomProf) || string.IsNullOrEmpty(PrenomProf) || string.IsNullOrEmpty(EmailProf) || string.IsNullOrEmpty(Telephone))
                {
                    MessageBox.Show("veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
                else
                {
                    if (!Telephone.All(char.IsDigit) || Telephone.Length < 9)
                    {
                        MessageBox.Show("Veuillez entrer un numéro de téléphone valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                   
                   
                }
            }
        }

        


        public void refresh()
        {
            using (var db = new DbContextAmaSchool())
            {

                dataGridView1.DataSource = null;
                var proflist = db.Professeur.ToList();
                dataGridView1.DataSource = proflist;
            }
        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                
                int id = (int)dataGridView1.CurrentRow.Cells["id"].Value;

                using (var db = new DbContextAmaSchool())
                { 
                    var personne = db.Professeur.Find(id);

                    if (personne != null)
                    {
                        txtprenomProf.Text = personne.Prenom;
                        txtnomProf.Text = personne.Nom;
                        txtemailProf.Text = personne.Email;
                        txtPhoneProf.Text = personne.Telephone;
                    }
                    else
                    {
                        MessageBox.Show("Personne non trouvée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne valide.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using(var db = new DbContextAmaSchool())
            {
                int id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
                var professeur = db.Professeur.Find(id);
                professeur.Nom = txtnomProf.Text;
                professeur.Prenom = txtprenomProf.Text;
                professeur.Email = txtemailProf.Text;
                professeur.Telephone = txtPhoneProf.Text;

                db.SaveChanges();
                refresh();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          
            if (dataGridView1.CurrentRow != null)
            {
               
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce professeur ?", "Confirmation de Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (var db = new DbContextAmaSchool())
                    {
                        int id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
                        var professeur = db.Professeur.Find(id);
                        if (professeur != null)
                        {
                            db.Professeur.Remove(professeur);
                            db.SaveChanges();

                            MessageBox.Show("Professeur supprimé avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refresh(); 
                        }
                        else
                        {
                            MessageBox.Show("Professeur non trouvé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne valide.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}


