namespace GestionScolaireAmaSchool.Forms.FormsGestion
{
    partial class FormGestionCoursMatiere
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSupprimerCours = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAjouterCours = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbMatiere = new System.Windows.Forms.ComboBox();
            this.txtNomCours = new System.Windows.Forms.Label();
            this.txtDescriptionCours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCours = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom Cours";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSupprimerCours);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAjouterCours);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.cmbMatiere);
            this.panel1.Controls.Add(this.txtNomCours);
            this.panel1.Controls.Add(this.txtDescriptionCours);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCours);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(53, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 382);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gestion Cours Matieres";
            // 
            // btnSupprimerCours
            // 
            this.btnSupprimerCours.Location = new System.Drawing.Point(422, 344);
            this.btnSupprimerCours.Name = "btnSupprimerCours";
            this.btnSupprimerCours.Size = new System.Drawing.Size(121, 24);
            this.btnSupprimerCours.TabIndex = 10;
            this.btnSupprimerCours.Text = "Supprimer";
            this.btnSupprimerCours.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 24);
            this.button1.TabIndex = 9;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAjouterCours
            // 
            this.btnAjouterCours.Location = new System.Drawing.Point(96, 344);
            this.btnAjouterCours.Name = "btnAjouterCours";
            this.btnAjouterCours.Size = new System.Drawing.Size(121, 24);
            this.btnAjouterCours.TabIndex = 8;
            this.btnAjouterCours.Text = "Ajouter ";
            this.btnAjouterCours.UseVisualStyleBackColor = true;
            this.btnAjouterCours.Click += new System.EventHandler(this.btnAjouterCours_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(321, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(351, 216);
            this.dataGridView1.TabIndex = 7;
            // 
            // cmbMatiere
            // 
            this.cmbMatiere.FormattingEnabled = true;
            this.cmbMatiere.Location = new System.Drawing.Point(157, 278);
            this.cmbMatiere.Name = "cmbMatiere";
            this.cmbMatiere.Size = new System.Drawing.Size(136, 21);
            this.cmbMatiere.TabIndex = 6;
            // 
            // txtNomCours
            // 
            this.txtNomCours.AutoSize = true;
            this.txtNomCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomCours.Location = new System.Drawing.Point(31, 274);
            this.txtNomCours.Name = "txtNomCours";
            this.txtNomCours.Size = new System.Drawing.Size(70, 20);
            this.txtNomCours.TabIndex = 5;
            this.txtNomCours.Text = "Matières";
            // 
            // txtDescriptionCours
            // 
            this.txtDescriptionCours.Location = new System.Drawing.Point(157, 181);
            this.txtDescriptionCours.Multiline = true;
            this.txtDescriptionCours.Name = "txtDescriptionCours";
            this.txtDescriptionCours.Size = new System.Drawing.Size(136, 64);
            this.txtDescriptionCours.TabIndex = 4;
            this.txtDescriptionCours.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Description";
            // 
            // txtCours
            // 
            this.txtCours.Location = new System.Drawing.Point(158, 126);
            this.txtCours.Multiline = true;
            this.txtCours.Name = "txtCours";
            this.txtCours.Size = new System.Drawing.Size(136, 21);
            this.txtCours.TabIndex = 2;
            // 
            // FormGestionCoursMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormGestionCoursMatiere";
            this.Text = "FormGestionCoursMatiere";
            this.Load += new System.EventHandler(this.FormGestionCoursMatiere_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDescriptionCours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCours;
        private System.Windows.Forms.Label txtNomCours;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbMatiere;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAjouterCours;
        private System.Windows.Forms.Button btnSupprimerCours;
        private System.Windows.Forms.Label label3;
    }
}