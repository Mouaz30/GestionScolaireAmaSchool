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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GestionScolaireAmaSchool.Forms.FormsGestion
{
    public partial class FormGestionClasse : Form
    {
        public FormGestionClasse()
        {
            InitializeComponent();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            using (var db = new DbContextAmaSchool())
            {
                String NomClasse = txtNomClasse.Text;

                if (string.IsNullOrEmpty(NomClasse))
                {
                    MessageBox.Show("veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Classes cl = new Classes();
                    cl.NomClasse = NomClasse;
                    db.Classe.Add(cl);
                    db.SaveChanges();
                    MessageBox.Show("Classe ajoutée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomClasse.Text = "";
                    refresh();





                }
            }

            
        }
        public void clear()
        {
            txtNomClasse.Text = "";
        }

        public void refresh()
        {
           dataGridViewClasse.DataSource = null;
          
            using (var db = new DbContextAmaSchool())
            {
                dataGridViewClasse.DataSource = db.Classe.ToList();
            }
        }

        private void FormGestionClasse_Load(object sender, EventArgs e)
        {
            
            refresh();
            dataGridViewClasse.Columns["Etudiants"].Visible = false;

        }

        private void btnEditClass_MouseClick(object sender, MouseEventArgs e)
        {
           
            using (var db = new DbContextAmaSchool())
            {
                int id = (int)dataGridViewClasse.CurrentRow.Cells["id"].Value;
                var Classe = db.Classe.Find(id);

                db.Classe.Remove(Classe);
                MessageBox.Show("Classe supprimer avec succés", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
                
            }
        
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewClasse.CurrentRow != null)
            {
                int id = (int)dataGridViewClasse.CurrentRow.Cells["id"].Value;
                using (var db = new DbContextAmaSchool())
                {
                   var Classes = db.Classe.Find(id);
                    if (Classes != null)
                    {
                        txtNomClasse.Text = Classes.NomClasse;
                    }
                    else
                    {
                        MessageBox.Show("Classe non trouvée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne valide.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeleteClasse_Click(object sender, EventArgs e)
        {

            using (var db = new DbContextAmaSchool())
            {
                int id = (int)dataGridViewClasse.CurrentRow.Cells["id"].Value;
                var classe = db.Classe.Find(id);

                if (classe != null) 
                {
                    db.Classe.Remove(classe);
                    db.SaveChanges(); 
                    MessageBox.Show("Classe supprimée avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                else
                {
                    MessageBox.Show("Classe non trouvée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnEditClass_Click(object sender, EventArgs e)
        {
            using(var db = new DbContextAmaSchool())
            {
                int id = (int)dataGridViewClasse.CurrentRow.Cells["id"].Value;
                var Classe = db.Classe.Find(id);
                Classe.NomClasse = txtNomClasse.Text;
                db.SaveChanges();
                MessageBox.Show("Classe modifiée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
        }
    }

}
