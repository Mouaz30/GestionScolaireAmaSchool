namespace GestionScolaireAmaSchool.Forms.FormsGestion
{
    partial class FormGestionMatiere
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSupprimerMatiere = new System.Windows.Forms.Button();
            this.btnEditMat = new System.Windows.Forms.Button();
            this.btnAjouterMatiere = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMatiere = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSupprimerMatiere);
            this.panel1.Controls.Add(this.btnEditMat);
            this.panel1.Controls.Add(this.btnAjouterMatiere);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.txtMatiere);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(57, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 382);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gestion Matieres";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSupprimerMatiere
            // 
            this.btnSupprimerMatiere.Location = new System.Drawing.Point(422, 344);
            this.btnSupprimerMatiere.Name = "btnSupprimerMatiere";
            this.btnSupprimerMatiere.Size = new System.Drawing.Size(121, 24);
            this.btnSupprimerMatiere.TabIndex = 10;
            this.btnSupprimerMatiere.Text = "Supprimer";
            this.btnSupprimerMatiere.UseVisualStyleBackColor = true;
            this.btnSupprimerMatiere.Click += new System.EventHandler(this.btnSupprimerMatiere_Click);
            // 
            // btnEditMat
            // 
            this.btnEditMat.Location = new System.Drawing.Point(264, 344);
            this.btnEditMat.Name = "btnEditMat";
            this.btnEditMat.Size = new System.Drawing.Size(121, 24);
            this.btnEditMat.TabIndex = 9;
            this.btnEditMat.Text = "Modifier";
            this.btnEditMat.UseVisualStyleBackColor = true;
            this.btnEditMat.Click += new System.EventHandler(this.btnEditMat_Click);
            // 
            // btnAjouterMatiere
            // 
            this.btnAjouterMatiere.Location = new System.Drawing.Point(96, 344);
            this.btnAjouterMatiere.Name = "btnAjouterMatiere";
            this.btnAjouterMatiere.Size = new System.Drawing.Size(121, 24);
            this.btnAjouterMatiere.TabIndex = 8;
            this.btnAjouterMatiere.Text = "Ajouter ";
            this.btnAjouterMatiere.UseVisualStyleBackColor = true;
            this.btnAjouterMatiere.Click += new System.EventHandler(this.btnAjouterMatiere_Click);
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
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // txtMatiere
            // 
            this.txtMatiere.Location = new System.Drawing.Point(158, 126);
            this.txtMatiere.Multiline = true;
            this.txtMatiere.Name = "txtMatiere";
            this.txtMatiere.Size = new System.Drawing.Size(136, 21);
            this.txtMatiere.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom Matiere";
            // 
            // FormGestionMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormGestionMatiere";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormGestionMatiere_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSupprimerMatiere;
        private System.Windows.Forms.Button btnEditMat;
        private System.Windows.Forms.Button btnAjouterMatiere;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMatiere;
        private System.Windows.Forms.Label label2;
    }
}