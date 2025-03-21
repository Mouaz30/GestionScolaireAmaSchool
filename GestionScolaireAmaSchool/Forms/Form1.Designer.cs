namespace GestionScolaireAmaSchool
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professeursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionMatieresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formGestionCoursMatireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeEtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeProfesseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeMatiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeCoursMatieresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etudiantToolStripMenuItem,
            this.classeToolStripMenuItem,
            this.gestionMatieresToolStripMenuItem,
            this.formGestionCoursMatireToolStripMenuItem,
            this.professeursToolStripMenuItem});
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            // 
            // etudiantToolStripMenuItem
            // 
            this.etudiantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeEtudiantToolStripMenuItem});
            this.etudiantToolStripMenuItem.Name = "etudiantToolStripMenuItem";
            this.etudiantToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.etudiantToolStripMenuItem.Text = "Etudiant";
            this.etudiantToolStripMenuItem.Click += new System.EventHandler(this.etudiantToolStripMenuItem_Click);
            // 
            // classeToolStripMenuItem
            // 
            this.classeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeClasseToolStripMenuItem});
            this.classeToolStripMenuItem.Name = "classeToolStripMenuItem";
            this.classeToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.classeToolStripMenuItem.Text = "Classe";
            this.classeToolStripMenuItem.Click += new System.EventHandler(this.classeToolStripMenuItem_Click);
            // 
            // listeClasseToolStripMenuItem
            // 
            this.listeClasseToolStripMenuItem.Name = "listeClasseToolStripMenuItem";
            this.listeClasseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listeClasseToolStripMenuItem.Text = "Liste Classe";
            this.listeClasseToolStripMenuItem.Click += new System.EventHandler(this.listeClasseToolStripMenuItem_Click);
            // 
            // professeursToolStripMenuItem
            // 
            this.professeursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeProfesseurToolStripMenuItem});
            this.professeursToolStripMenuItem.Name = "professeursToolStripMenuItem";
            this.professeursToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.professeursToolStripMenuItem.Text = "Professeurs";
            this.professeursToolStripMenuItem.Click += new System.EventHandler(this.professeursToolStripMenuItem_Click);
            // 
            // gestionMatieresToolStripMenuItem
            // 
            this.gestionMatieresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeMatiereToolStripMenuItem});
            this.gestionMatieresToolStripMenuItem.Name = "gestionMatieresToolStripMenuItem";
            this.gestionMatieresToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.gestionMatieresToolStripMenuItem.Text = "Gestion Matieres";
            this.gestionMatieresToolStripMenuItem.Click += new System.EventHandler(this.gestionMatieresToolStripMenuItem_Click);
            // 
            // formGestionCoursMatireToolStripMenuItem
            // 
            this.formGestionCoursMatireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeCoursMatieresToolStripMenuItem});
            this.formGestionCoursMatireToolStripMenuItem.Name = "formGestionCoursMatireToolStripMenuItem";
            this.formGestionCoursMatireToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.formGestionCoursMatireToolStripMenuItem.Text = "FormGestionCoursMatire";
            this.formGestionCoursMatireToolStripMenuItem.Click += new System.EventHandler(this.formGestionCoursMatireToolStripMenuItem_Click);
            // 
            // listeEtudiantToolStripMenuItem
            // 
            this.listeEtudiantToolStripMenuItem.Name = "listeEtudiantToolStripMenuItem";
            this.listeEtudiantToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listeEtudiantToolStripMenuItem.Text = "Liste Etudiant";
            this.listeEtudiantToolStripMenuItem.Click += new System.EventHandler(this.listeEtudiantToolStripMenuItem_Click);
            // 
            // listeProfesseurToolStripMenuItem
            // 
            this.listeProfesseurToolStripMenuItem.Name = "listeProfesseurToolStripMenuItem";
            this.listeProfesseurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listeProfesseurToolStripMenuItem.Text = "Liste Professeur";
            this.listeProfesseurToolStripMenuItem.Click += new System.EventHandler(this.listeProfesseurToolStripMenuItem_Click);
            // 
            // listeMatiereToolStripMenuItem
            // 
            this.listeMatiereToolStripMenuItem.Name = "listeMatiereToolStripMenuItem";
            this.listeMatiereToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listeMatiereToolStripMenuItem.Text = "Liste Matiere";
            this.listeMatiereToolStripMenuItem.Click += new System.EventHandler(this.listeMatiereToolStripMenuItem_Click);
            // 
            // listeCoursMatieresToolStripMenuItem
            // 
            this.listeCoursMatieresToolStripMenuItem.Name = "listeCoursMatieresToolStripMenuItem";
            this.listeCoursMatieresToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.listeCoursMatieresToolStripMenuItem.Text = "Liste cours & Matieres";
            this.listeCoursMatieresToolStripMenuItem.Click += new System.EventHandler(this.listeCoursMatieresToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professeursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionMatieresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formGestionCoursMatireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeEtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeProfesseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeMatiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeCoursMatieresToolStripMenuItem;
    }
}

