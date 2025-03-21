using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionScolaireAmaSchool.Forms.FormsGestion;
using GestionScolaireAmaSchool.Forms.FormsListe;

namespace GestionScolaireAmaSchool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void etudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionEtudiant formGestionEtudiant = new FormGestionEtudiant();
            formGestionEtudiant.Show();
        }

        private void classeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionClasse formGestionClasse = new FormGestionClasse();
            formGestionClasse.Show();
        }

        private void professeursToolStripMenuItem_Click(object sender, EventArgs e)
        {

            GestionProfesseurs gestionProfesseurs = new GestionProfesseurs();
            gestionProfesseurs.Show();
        }

        private void gestionMatieresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionMatiere gestionMatiere  = new FormGestionMatiere();
            gestionMatiere.Show();
        }

        private void formGestionCoursMatireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionCoursMatiere formGestionCoursMatiere = new FormGestionCoursMatiere();
            formGestionCoursMatiere.Show();
        }

        private void listeClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListeClasses formListeClasse = new FormListeClasses();
            formListeClasse.Show();
        }

        private void listeEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListeEtudiants formListeEtudiant = new FormListeEtudiants();
            formListeEtudiant.Show();
        }

        private void listeProfesseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListeProfesseur formListeProfesseur = new FormListeProfesseur();
            formListeProfesseur.Show();
        }

        private void listeMatiereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListeMatieres formListeMatieres = new FormListeMatieres();
            formListeMatieres.Show();
        }

        private void listeCoursMatieresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListeCours formListeCoursMatieres = new FormListeCours();
            formListeCoursMatieres.Show();
        }

    }
}
