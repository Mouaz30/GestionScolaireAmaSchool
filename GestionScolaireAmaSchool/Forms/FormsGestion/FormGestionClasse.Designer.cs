namespace GestionScolaireAmaSchool.Forms.FormsGestion
{
    partial class FormGestionClasse
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
            this.btnDeleteClasse = new System.Windows.Forms.Button();
            this.btnEditClass = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.dataGridViewClasse = new System.Windows.Forms.DataGridView();
            this.txtNomClasse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteClasse
            // 
            this.btnDeleteClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClasse.Location = new System.Drawing.Point(531, 357);
            this.btnDeleteClasse.Name = "btnDeleteClasse";
            this.btnDeleteClasse.Size = new System.Drawing.Size(111, 27);
            this.btnDeleteClasse.TabIndex = 12;
            this.btnDeleteClasse.Text = "Supprimer";
            this.btnDeleteClasse.UseVisualStyleBackColor = true;
            this.btnDeleteClasse.Click += new System.EventHandler(this.btnDeleteClasse_Click);
            // 
            // btnEditClass
            // 
            this.btnEditClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClass.Location = new System.Drawing.Point(337, 357);
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.Size = new System.Drawing.Size(111, 27);
            this.btnEditClass.TabIndex = 11;
            this.btnEditClass.Text = "Modifier";
            this.btnEditClass.UseVisualStyleBackColor = true;
            this.btnEditClass.Click += new System.EventHandler(this.btnEditClass_Click);
            this.btnEditClass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnEditClass_MouseClick);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClass.Location = new System.Drawing.Point(157, 357);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(111, 27);
            this.btnAddClass.TabIndex = 10;
            this.btnAddClass.Text = "Ajouter";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // dataGridViewClasse
            // 
            this.dataGridViewClasse.AllowUserToAddRows = false;
            this.dataGridViewClasse.AllowUserToDeleteRows = false;
            this.dataGridViewClasse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClasse.Location = new System.Drawing.Point(421, 66);
            this.dataGridViewClasse.Name = "dataGridViewClasse";
            this.dataGridViewClasse.ReadOnly = true;
            this.dataGridViewClasse.Size = new System.Drawing.Size(319, 228);
            this.dataGridViewClasse.TabIndex = 9;
            this.dataGridViewClasse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewClasse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // txtNomClasse
            // 
            this.txtNomClasse.Location = new System.Drawing.Point(160, 115);
            this.txtNomClasse.Multiline = true;
            this.txtNomClasse.Name = "txtNomClasse";
            this.txtNomClasse.Size = new System.Drawing.Size(155, 27);
            this.txtNomClasse.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom Classe";
            // 
            // FormGestionClasse
            // 
            this.AcceptButton = this.btnEditClass;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.btnDeleteClasse);
            this.Controls.Add(this.btnEditClass);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.dataGridViewClasse);
            this.Controls.Add(this.txtNomClasse);
            this.Controls.Add(this.label2);
            this.Name = "FormGestionClasse";
            this.Text = "FormGestionClasse";
            this.Load += new System.EventHandler(this.FormGestionClasse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteClasse;
        private System.Windows.Forms.Button btnEditClass;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.DataGridView dataGridViewClasse;
        private System.Windows.Forms.TextBox txtNomClasse;
        private System.Windows.Forms.Label label2;
    }
}