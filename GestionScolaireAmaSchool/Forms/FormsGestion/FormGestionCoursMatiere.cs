using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionScolaireAmaSchool.Data;
using GestionScolaireAmaSchool.Entity;

namespace GestionScolaireAmaSchool.Forms.FormsGestion
{
    public partial class FormGestionCoursMatiere : Form
    {
        private DbContextAmaSchool db;
        public FormGestionCoursMatiere()
        {
            InitializeComponent();
            db = new DbContextAmaSchool();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAjouterCours_Click(object sender, EventArgs e)
        {
           
            string NomCours = txtCours.Text;
            string description = txtDescriptionCours.Text;
            string nomMatiere = cmbMatiere.Text;
            int idMatiere = db.Matiere.Where(m => m.NomMatiere == nomMatiere).Select(m => m.Id).FirstOrDefault();

            if (string.IsNullOrEmpty(NomCours) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            Cours c = new Cours();
            c.NomCours = NomCours;
            c.Description = description;
            db.Cour.Add(c);
            CoursMatieres coursMatieres = new CoursMatieres();
            coursMatieres.IdCours = c.Id;
            coursMatieres.IdMatiere = idMatiere;
            db.coursMatiere.Add(coursMatieres);
            db.SaveChanges();
    
            MessageBox.Show("Cours ajouté avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
           refresh();

           
        }


        public void refresh()
        {
            dataGridView1.DataSource = null;


            var cours =  db.coursMatiere.Select(c => new {c.Cours.Id,c.Cours.NomCours,c.Cours.Description,c.Matieres.NomMatiere}).ToList();
            dataGridView1.DataSource = cours;
          
        }


        private void FormGestionCoursMatiere_Load(object sender, EventArgs e)
        {
           
             var matiere = db.Matiere.ToList();
             cmbMatiere.DataSource = null;
             cmbMatiere.DataSource = matiere;
             cmbMatiere.DisplayMember = "NomMatiere";
             cmbMatiere.ValueMember = "Id";
            refresh();

        }

        private void btnModifierCours_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                
                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;

                using (var db = new DbContextAmaSchool())
                {
                   
                    var personne = db.Cour.Find(id);

                    if (personne != null)
                    {
                       
                        txtCours.Text = personne.NomCours;
                        txtDescriptionCours.Text = personne.Description;
                        cmbMatiere.Text = db.Matiere.Where(m => m.Id == db.coursMatiere.Where(c => c.IdCours == id).Select(c => c.IdMatiere).FirstOrDefault()).Select(m => m.NomMatiere).FirstOrDefault();



                    }
                    else
                    {
                        MessageBox.Show("cour non trouvée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne valide.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                var cours = db.Cour.Find(id);
                if (cours != null)
                {
                    cours.NomCours = txtCours.Text;
                    cours.Description = txtDescriptionCours.Text;
                    cours.Id = db.coursMatiere.Where(c => c.IdCours == id).Select(c => c.IdCours).FirstOrDefault();
                    db.SaveChanges();
                    MessageBox.Show("Cours modifié avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                else
                {
                    MessageBox.Show("Cours non trouvée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSupprimerCours_Click(object sender, EventArgs e)
        {

            using (var db = new DbContextAmaSchool())
            {
                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                var personne = db.Cour.Find(id);

                db.Cour.Remove(personne);
                db.SaveChanges();
                MessageBox.Show("Cours supprimer avec succés", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
                clear();

            }

           

        }

        public void clear()
        {
            txtCours.Text = string.Empty;
            txtDescriptionCours.Text = string.Empty;
            cmbMatiere.Text = string.Empty;
           
        }

       
    }
}
    

