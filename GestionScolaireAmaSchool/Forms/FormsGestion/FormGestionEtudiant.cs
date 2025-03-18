using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionScolaireAmaSchool.Data;
using GestionScolaireAmaSchool.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionScolaireAmaSchool.Forms.FormsGestion
{
    public partial class FormGestionEtudiant : Form
    {
        public FormGestionEtudiant()
        {
            InitializeComponent();
            refresh();
        }

        private void btnAddEtu_Click(object sender, EventArgs e)
        {
            using (var db = new DbContextAmaSchool())
            {
               
                    string Matricule = txtMatEtu.Text;
                    string Nom = txtNomEtu.Text;
                    string Prenom = txtPrenomEtu.Text;
                    DateTime DateNaissance = DateTime.Parse(txtDateNaiss.Text); 
                    string Sexe = rbSexe.Text;
                    string Adresse = txtAddresse.Text;
                    string Telephone = txtPhone.Text;
                    string Email = txtEmail.Text;


                if (string.IsNullOrEmpty(Matricule) || string.IsNullOrEmpty(Nom) || string.IsNullOrEmpty(Prenom) || string.IsNullOrEmpty(Sexe) || string.IsNullOrEmpty(Adresse) || string.IsNullOrEmpty(Telephone) || string.IsNullOrEmpty(Email))
                {
                    MessageBox.Show("veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    Etudiants et = new Etudiants(); 
                    et.Matricule = Matricule;
                    et.Nom = Nom;
                    et.Prenom = Prenom;
                    et.DateNaissance = DateNaissance;
                   
                    if (rbFemme.Checked)
                    {
                        et.Sexe = "Femme";
                    }
                    else
                    {
                        et.Sexe = "Homme";
                    }
                    et.Adresse = Adresse;
                    et.Telephone = Telephone;
                    et.Email = Email;
                    et.Telephone = Telephone;
                    et.IdClasse = (int)cmbClasses.SelectedValue;
                    Classes cl = db.Classe.Find(et.IdClasse);// pour gerer la recuperation des classes  sur le combobox
                    et.Classes = cl;   // pour gerer la recuperation des classes sur le combobox




                    db.Etudiant.Add(et);
                    db.SaveChanges();
                    MessageBox.Show("Etudiant Enregistrer avec succes", "succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                   // clear();


                }






            }
        }

        public void refresh()
        {
            dataGridView1.DataSource = null;
            cmbClasses.DataSource = null;
            using (var db = new DbContextAmaSchool())
            {
                var Etudiant = db.Etudiant.Select(c => new { c.Id, c.Nom, c.Prenom, c.Matricule,c.DateNaissance,c.Email,c.Sexe,c.Telephone, c.Adresse, Classes=c.Classes.NomClasse });
                dataGridView1.DataSource = Etudiant.ToList();
                
                cmbClasses.DataSource = db.Classe.ToList();
                cmbClasses.DisplayMember = "NomClasse"; 
                cmbClasses.ValueMember = "Id"; // pour gerer la recuperation des classes
                
            }

        }

        private void FormGestionEtudiant_Load(object sender, EventArgs e)
        {
           
            refresh();
        }

        private void rbMasculin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbFemme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEditEtu_Click(object sender, EventArgs e)
        {
            using (var db = new DbContextAmaSchool())
            {
                int id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
                var Etudiant = db.Etudiant.Find(id);
                Etudiant.Matricule = txtMatEtu.Text;
                Etudiant.Nom = txtNomEtu.Text;
                Etudiant.Prenom = txtPrenomEtu.Text;
                Etudiant.DateNaissance = DateTime.Parse(txtDateNaiss.Text);
                Etudiant.Sexe = rbSexe.Text;
                Etudiant.Adresse = txtAddresse.Text;
                Etudiant.Telephone = txtPhone.Text;
                Etudiant.Email = txtEmail.Text;
                Etudiant.IdClasse = (int)cmbClasses.SelectedValue;

      
                db.SaveChanges();
                MessageBox.Show("Info Etudiant modifiée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
        }

        private void btnDeleteEtu_Click(object sender, EventArgs e)
        {

            using (var db = new DbContextAmaSchool())
            {
                int id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
                var Etudiant = db.Etudiant.Find(id);

                if (Etudiant != null)
                {
                    db.Etudiant.Remove(Etudiant);
                    db.SaveChanges();
                    MessageBox.Show("Etudiant supprimée avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                else
                {
                    MessageBox.Show("Etudiant non trouvée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
                using (var db = new DbContextAmaSchool())
                {
                    var Etudiant = db.Etudiant.Find(id);
                    if (Etudiant != null)
                    {
                       
                        txtMatEtu.Text = Etudiant.Matricule;
                        txtNomEtu.Text = Etudiant.Nom;
                        txtPrenomEtu.Text = Etudiant.Prenom;
                        txtDateNaiss.Text = Etudiant.DateNaissance.ToString();
                        txtAddresse.Text = Etudiant.Adresse;
                        txtPhone.Text = Etudiant.Telephone;
                        txtEmail.Text = Etudiant.Email;
                        rbSexe.Text = Etudiant.Sexe;
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("Classe non trouvée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            using (var db = new DbContextAmaSchool())
            {
                string searchValue = txtSearch.Text.Trim();

                
                if (string.IsNullOrEmpty(searchValue))
                {
                    MessageBox.Show("Veuillez entrer un critère de recherche.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                var results = db.Etudiant
                    .Where(p => p.Matricule.ToLower().Contains(searchValue.ToLower()) ||
                                 p.Nom.ToLower().Contains(searchValue.ToLower()))
                    .ToList();

               
                dataGridView1.DataSource = null; 
                dataGridView1.DataSource = results;

                
                if (results.Count == 0)
                {
                    MessageBox.Show("Aucun résultat trouvé pour la recherche.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    
    }
}