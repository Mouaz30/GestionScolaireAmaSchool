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
    public partial class FormGestionMatiere : Form
    {
        public FormGestionMatiere()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouterMatiere_Click(object sender, EventArgs e)
        {
            using (var db = new DbContextAmaSchool())
            {
                string NomMatiere = txtMatiere.Text;
                if (string.IsNullOrEmpty(NomMatiere))
                {
                    MessageBox.Show("veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Matieres mat = new Matieres();
                    mat.NomMatiere = NomMatiere;
                    db.Matiere.Add(mat);
                    db.SaveChanges();
                    MessageBox.Show("Matière ajoutée avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refresh();
                    txtMatiere.Text = "";

                }
            }
        }

        public void Refresh()
        {
            dataGridView1.DataSource = null;
            using (var db = new DbContextAmaSchool())
            {
                dataGridView1.DataSource = db.Matiere.ToList();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormGestionMatiere_Load(object sender, EventArgs e)
        {
             Refresh();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
                using (var db = new DbContextAmaSchool())
                {
                    var Matiere = db.Matiere.Find(id);
                    if (Matiere != null)
                    {
                        txtMatiere.Text = Matiere.NomMatiere;
                        
                    }
                    else
                    {
                        MessageBox.Show("Matiere non trouvée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnEditMat_Click(object sender, EventArgs e)
        {
            using (var db = new DbContextAmaSchool())
            {
                int id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
                var Matiere = db.Matiere.Find(id);
                Matiere.NomMatiere = txtMatiere.Text;
             
               


                db.SaveChanges();
                MessageBox.Show("Info Matiere modifiée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refresh();
            }
        }

        private void btnSupprimerMatiere_Click(object sender, EventArgs e)
        {
            using (var db = new DbContextAmaSchool())
            {
                int id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
                var Matiere = db.Matiere.Find(id);


                if (Matiere != null)
                {
                    db.Matiere.Remove(Matiere);
                    db.SaveChanges();
                    MessageBox.Show("Matière supprimée avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refresh();
                }
                else
                {
                    MessageBox.Show("Matière non trouvée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    
}

