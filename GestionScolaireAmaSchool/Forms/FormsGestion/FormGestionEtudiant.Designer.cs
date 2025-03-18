namespace GestionScolaireAmaSchool.Forms.FormsGestion
{
    partial class FormGestionEtudiant
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDeleteEtu = new System.Windows.Forms.Button();
            this.btnEditEtu = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddEtu = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddresse = new System.Windows.Forms.TextBox();
            this.txtPrenomEtu = new System.Windows.Forms.TextBox();
            this.txtNomEtu = new System.Windows.Forms.TextBox();
            this.txtMatEtu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbSexe = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMat = new System.Windows.Forms.Label();
            this.txtDateNaiss = new System.Windows.Forms.DateTimePicker();
            this.rbFemme = new System.Windows.Forms.RadioButton();
            this.rbMasculin = new System.Windows.Forms.RadioButton();
            this.entityCommand2 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.txtClasses = new System.Windows.Forms.Label();
            this.cmbClasses = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Gestion Etudiants";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(353, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 26);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(350, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(524, 330);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // btnDeleteEtu
            // 
            this.btnDeleteEtu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEtu.Location = new System.Drawing.Point(520, 443);
            this.btnDeleteEtu.Name = "btnDeleteEtu";
            this.btnDeleteEtu.Size = new System.Drawing.Size(114, 30);
            this.btnDeleteEtu.TabIndex = 44;
            this.btnDeleteEtu.Text = "Supprimer";
            this.btnDeleteEtu.UseVisualStyleBackColor = true;
            this.btnDeleteEtu.Click += new System.EventHandler(this.btnDeleteEtu_Click);
            // 
            // btnEditEtu
            // 
            this.btnEditEtu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEtu.Location = new System.Drawing.Point(316, 442);
            this.btnEditEtu.Name = "btnEditEtu";
            this.btnEditEtu.Size = new System.Drawing.Size(116, 30);
            this.btnEditEtu.TabIndex = 43;
            this.btnEditEtu.Text = "Modifier";
            this.btnEditEtu.UseVisualStyleBackColor = true;
            this.btnEditEtu.Click += new System.EventHandler(this.btnEditEtu_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(495, 46);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(335, 24);
            this.txtSearch.TabIndex = 47;
            // 
            // btnAddEtu
            // 
            this.btnAddEtu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEtu.Location = new System.Drawing.Point(126, 441);
            this.btnAddEtu.Name = "btnAddEtu";
            this.btnAddEtu.Size = new System.Drawing.Size(110, 30);
            this.btnAddEtu.TabIndex = 42;
            this.btnAddEtu.Text = "Ajouter";
            this.btnAddEtu.UseVisualStyleBackColor = true;
            this.btnAddEtu.Click += new System.EventHandler(this.btnAddEtu_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(160, 349);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(128, 23);
            this.txtEmail.TabIndex = 39;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(158, 308);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(128, 23);
            this.txtPhone.TabIndex = 38;
            // 
            // txtAddresse
            // 
            this.txtAddresse.Location = new System.Drawing.Point(159, 268);
            this.txtAddresse.Multiline = true;
            this.txtAddresse.Name = "txtAddresse";
            this.txtAddresse.Size = new System.Drawing.Size(128, 23);
            this.txtAddresse.TabIndex = 37;
            // 
            // txtPrenomEtu
            // 
            this.txtPrenomEtu.Location = new System.Drawing.Point(164, 152);
            this.txtPrenomEtu.Multiline = true;
            this.txtPrenomEtu.Name = "txtPrenomEtu";
            this.txtPrenomEtu.Size = new System.Drawing.Size(128, 23);
            this.txtPrenomEtu.TabIndex = 35;
            // 
            // txtNomEtu
            // 
            this.txtNomEtu.Location = new System.Drawing.Point(163, 115);
            this.txtNomEtu.Multiline = true;
            this.txtNomEtu.Name = "txtNomEtu";
            this.txtNomEtu.Size = new System.Drawing.Size(128, 23);
            this.txtNomEtu.TabIndex = 34;
            // 
            // txtMatEtu
            // 
            this.txtMatEtu.Location = new System.Drawing.Point(163, 78);
            this.txtMatEtu.Multiline = true;
            this.txtMatEtu.Name = "txtMatEtu";
            this.txtMatEtu.Size = new System.Drawing.Size(128, 23);
            this.txtMatEtu.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Telephone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Addresse";
            // 
            // rbSexe
            // 
            this.rbSexe.AutoSize = true;
            this.rbSexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSexe.Location = new System.Drawing.Point(0, 232);
            this.rbSexe.Name = "rbSexe";
            this.rbSexe.Size = new System.Drawing.Size(45, 20);
            this.rbSexe.TabIndex = 29;
            this.rbSexe.Text = "Sexe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Date de Naissance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nom";
            // 
            // txtMat
            // 
            this.txtMat.AutoSize = true;
            this.txtMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMat.Location = new System.Drawing.Point(2, 80);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(73, 20);
            this.txtMat.TabIndex = 25;
            this.txtMat.Text = "Matricule";
            // 
            // txtDateNaiss
            // 
            this.txtDateNaiss.Location = new System.Drawing.Point(150, 194);
            this.txtDateNaiss.Name = "txtDateNaiss";
            this.txtDateNaiss.Size = new System.Drawing.Size(190, 20);
            this.txtDateNaiss.TabIndex = 49;
            // 
            // rbFemme
            // 
            this.rbFemme.AutoSize = true;
            this.rbFemme.Location = new System.Drawing.Point(230, 235);
            this.rbFemme.Name = "rbFemme";
            this.rbFemme.Size = new System.Drawing.Size(61, 17);
            this.rbFemme.TabIndex = 41;
            this.rbFemme.TabStop = true;
            this.rbFemme.Text = "Feminin";
            this.rbFemme.UseVisualStyleBackColor = true;
            this.rbFemme.CheckedChanged += new System.EventHandler(this.rbFemme_CheckedChanged);
            // 
            // rbMasculin
            // 
            this.rbMasculin.AutoSize = true;
            this.rbMasculin.Location = new System.Drawing.Point(158, 235);
            this.rbMasculin.Name = "rbMasculin";
            this.rbMasculin.Size = new System.Drawing.Size(67, 17);
            this.rbMasculin.TabIndex = 40;
            this.rbMasculin.TabStop = true;
            this.rbMasculin.Text = "Masculin";
            this.rbMasculin.UseVisualStyleBackColor = true;
            this.rbMasculin.CheckedChanged += new System.EventHandler(this.rbMasculin_CheckedChanged);
            // 
            // entityCommand2
            // 
            this.entityCommand2.CommandTimeout = 0;
            this.entityCommand2.CommandTree = null;
            this.entityCommand2.Connection = null;
            this.entityCommand2.EnablePlanCaching = true;
            this.entityCommand2.Transaction = null;
            // 
            // txtClasses
            // 
            this.txtClasses.AutoSize = true;
            this.txtClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClasses.Location = new System.Drawing.Point(7, 390);
            this.txtClasses.Name = "txtClasses";
            this.txtClasses.Size = new System.Drawing.Size(65, 20);
            this.txtClasses.TabIndex = 50;
            this.txtClasses.Text = "Classes";
            // 
            // cmbClasses
            // 
            this.cmbClasses.FormattingEnabled = true;
            this.cmbClasses.Location = new System.Drawing.Point(160, 390);
            this.cmbClasses.Name = "cmbClasses";
            this.cmbClasses.Size = new System.Drawing.Size(121, 21);
            this.cmbClasses.TabIndex = 51;
            // 
            // FormGestionEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 500);
            this.Controls.Add(this.cmbClasses);
            this.Controls.Add(this.txtClasses);
            this.Controls.Add(this.txtDateNaiss);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteEtu);
            this.Controls.Add(this.btnEditEtu);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddEtu);
            this.Controls.Add(this.rbFemme);
            this.Controls.Add(this.rbMasculin);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddresse);
            this.Controls.Add(this.txtPrenomEtu);
            this.Controls.Add(this.txtNomEtu);
            this.Controls.Add(this.txtMatEtu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbSexe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMat);
            this.Name = "FormGestionEtudiant";
            this.Text = "FormGestionEtudiant";
            this.Load += new System.EventHandler(this.FormGestionEtudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeleteEtu;
        private System.Windows.Forms.Button btnEditEtu;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddEtu;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddresse;
        private System.Windows.Forms.TextBox txtPrenomEtu;
        private System.Windows.Forms.TextBox txtNomEtu;
        private System.Windows.Forms.TextBox txtMatEtu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label rbSexe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtMat;
        private System.Windows.Forms.DateTimePicker txtDateNaiss;
        private System.Windows.Forms.RadioButton rbFemme;
        private System.Windows.Forms.RadioButton rbMasculin;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand2;
        private System.Windows.Forms.Label txtClasses;
        private System.Windows.Forms.ComboBox cmbClasses;
    }
}