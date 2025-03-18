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
            string nomMatiere = cmbMatiere.Text;
            int idMatiere = db.Matiere.Where(m => m.NomMatiere == nomMatiere).Select(m => m.Id).FirstOrDefault();
            string NomCours = txtNomCours.Text;
            string description = txtDescriptionCours.Text;
            string matiere = cmbMatiere.Text;
            
            if (string.IsNullOrEmpty(NomCours) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            Cours c = new Cours();
            c.NomCours = NomCours;
            c.Description = description;
            db.Cour.Add(c);
            CoursMatieres coursMatieres = new CoursMatieres();
            coursMatieres.CoursId = c.Id;
            coursMatieres.MatiereId = idMatiere;
            db.coursMatiere.Add(coursMatieres);
            db.SaveChanges();
            MessageBox.Show(idMatiere.ToString());
            MessageBox.Show("Cours ajouté avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Refresh();

           
        }


        public void Refresh()
        {
            dataGridView1.DataSource = null;
           

            //  var cours = db.Cour.Select(c => new {c.Id,c.NomCours,c.Description,c.IdMatiere});
            //dataGridView1.DataSource = db..ToList();
          
        }


        private void FormGestionCoursMatiere_Load(object sender, EventArgs e)
        {
             var matiere = db.Matiere.ToList();
             cmbMatiere.DataSource = null;
             cmbMatiere.DataSource = matiere;
             cmbMatiere.DisplayMember = "NomMatiere";
             cmbMatiere.ValueMember = "Id";

        }
    }
}
    

