namespace GestionScolaireAmaSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class premiereMigratio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomClasse = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomCours = c.String(nullable: false, maxLength: 100),
                        Description = c.String(maxLength: 255),
                        Classes_Id = c.Int(),
                        Matieres_Id = c.Int(),
                        Professeurs_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.Classes_Id)
                .ForeignKey("dbo.Matieres", t => t.Matieres_Id)
                .ForeignKey("dbo.Professeurs", t => t.Professeurs_Id)
                .Index(t => t.Classes_Id)
                .Index(t => t.Matieres_Id)
                .Index(t => t.Professeurs_Id);
            
            CreateTable(
                "dbo.ClassesCours",
                c => new
                    {
                        IdClasse = c.Int(nullable: false),
                        IdCours = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdClasse, t.IdCours })
                .ForeignKey("dbo.Classes", t => t.IdClasse, cascadeDelete: true)
                .ForeignKey("dbo.Cours", t => t.IdCours, cascadeDelete: true)
                .Index(t => t.IdClasse)
                .Index(t => t.IdCours);
            
            CreateTable(
                "dbo.Etudiants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Matricule = c.String(nullable: false, maxLength: 50),
                        Nom = c.String(nullable: false, maxLength: 100),
                        Prenom = c.String(nullable: false, maxLength: 100),
                        DateNaissance = c.DateTime(nullable: false),
                        Sexe = c.String(nullable: false, maxLength: 10),
                        Adresse = c.String(maxLength: 200),
                        Telephone = c.String(maxLength: 15),
                        Email = c.String(maxLength: 100),
                        IdClasse = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.IdClasse, cascadeDelete: true)
                .Index(t => t.IdClasse);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdEtudiant = c.Int(nullable: false),
                        IdMatiere = c.Int(nullable: false),
                        Valeur = c.Single(nullable: false),
                        Classes_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Etudiants", t => t.IdEtudiant, cascadeDelete: true)
                .ForeignKey("dbo.Matieres", t => t.IdMatiere, cascadeDelete: true)
                .ForeignKey("dbo.Classes", t => t.Classes_Id)
                .Index(t => t.IdEtudiant)
                .Index(t => t.IdMatiere)
                .Index(t => t.Classes_Id);
            
            CreateTable(
                "dbo.Matieres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomMatiere = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Professeurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false, maxLength: 100),
                        Prenom = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        Telephone = c.String(maxLength: 15),
                        Classes_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.Classes_Id)
                .Index(t => t.Classes_Id);
            
            CreateTable(
                "dbo.CoursMatieres",
                c => new
                    {
                        CoursId = c.Int(nullable: false),
                        MatiereId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CoursId, t.MatiereId })
                .ForeignKey("dbo.Cours", t => t.CoursId, cascadeDelete: true)
                .ForeignKey("dbo.Matieres", t => t.MatiereId, cascadeDelete: true)
                .Index(t => t.CoursId)
                .Index(t => t.MatiereId);
            
            CreateTable(
                "dbo.OTPCodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUtilisateur = c.Int(nullable: false),
                        Code = c.String(nullable: false, maxLength: 10),
                        DateExpiration = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilisateurs", t => t.IdUtilisateur, cascadeDelete: true)
                .Index(t => t.IdUtilisateur);
            
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomUtilisateur = c.String(nullable: false, maxLength: 50),
                        MotDePasse = c.String(nullable: false, maxLength: 255),
                        Role = c.String(nullable: false, maxLength: 20),
                        Telephone = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProfesseursClasses",
                c => new
                    {
                        IdProfesseur = c.Int(nullable: false),
                        IdClasse = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdProfesseur, t.IdClasse })
                .ForeignKey("dbo.Classes", t => t.IdClasse, cascadeDelete: true)
                .ForeignKey("dbo.Professeurs", t => t.IdProfesseur, cascadeDelete: true)
                .Index(t => t.IdProfesseur)
                .Index(t => t.IdClasse);
            
            CreateTable(
                "dbo.ProfesseursMatieres",
                c => new
                    {
                        IdProfesseur = c.Int(nullable: false),
                        IdMatiere = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdProfesseur, t.IdMatiere })
                .ForeignKey("dbo.Matieres", t => t.IdMatiere, cascadeDelete: true)
                .ForeignKey("dbo.Professeurs", t => t.IdProfesseur, cascadeDelete: true)
                .Index(t => t.IdProfesseur)
                .Index(t => t.IdMatiere);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProfesseursMatieres", "IdProfesseur", "dbo.Professeurs");
            DropForeignKey("dbo.ProfesseursMatieres", "IdMatiere", "dbo.Matieres");
            DropForeignKey("dbo.ProfesseursClasses", "IdProfesseur", "dbo.Professeurs");
            DropForeignKey("dbo.ProfesseursClasses", "IdClasse", "dbo.Classes");
            DropForeignKey("dbo.OTPCodes", "IdUtilisateur", "dbo.Utilisateurs");
            DropForeignKey("dbo.CoursMatieres", "MatiereId", "dbo.Matieres");
            DropForeignKey("dbo.CoursMatieres", "CoursId", "dbo.Cours");
            DropForeignKey("dbo.Professeurs", "Classes_Id", "dbo.Classes");
            DropForeignKey("dbo.Cours", "Professeurs_Id", "dbo.Professeurs");
            DropForeignKey("dbo.Notes", "Classes_Id", "dbo.Classes");
            DropForeignKey("dbo.Notes", "IdMatiere", "dbo.Matieres");
            DropForeignKey("dbo.Cours", "Matieres_Id", "dbo.Matieres");
            DropForeignKey("dbo.Notes", "IdEtudiant", "dbo.Etudiants");
            DropForeignKey("dbo.Etudiants", "IdClasse", "dbo.Classes");
            DropForeignKey("dbo.Cours", "Classes_Id", "dbo.Classes");
            DropForeignKey("dbo.ClassesCours", "IdCours", "dbo.Cours");
            DropForeignKey("dbo.ClassesCours", "IdClasse", "dbo.Classes");
            DropIndex("dbo.ProfesseursMatieres", new[] { "IdMatiere" });
            DropIndex("dbo.ProfesseursMatieres", new[] { "IdProfesseur" });
            DropIndex("dbo.ProfesseursClasses", new[] { "IdClasse" });
            DropIndex("dbo.ProfesseursClasses", new[] { "IdProfesseur" });
            DropIndex("dbo.OTPCodes", new[] { "IdUtilisateur" });
            DropIndex("dbo.CoursMatieres", new[] { "MatiereId" });
            DropIndex("dbo.CoursMatieres", new[] { "CoursId" });
            DropIndex("dbo.Professeurs", new[] { "Classes_Id" });
            DropIndex("dbo.Notes", new[] { "Classes_Id" });
            DropIndex("dbo.Notes", new[] { "IdMatiere" });
            DropIndex("dbo.Notes", new[] { "IdEtudiant" });
            DropIndex("dbo.Etudiants", new[] { "IdClasse" });
            DropIndex("dbo.ClassesCours", new[] { "IdCours" });
            DropIndex("dbo.ClassesCours", new[] { "IdClasse" });
            DropIndex("dbo.Cours", new[] { "Professeurs_Id" });
            DropIndex("dbo.Cours", new[] { "Matieres_Id" });
            DropIndex("dbo.Cours", new[] { "Classes_Id" });
            DropTable("dbo.ProfesseursMatieres");
            DropTable("dbo.ProfesseursClasses");
            DropTable("dbo.Utilisateurs");
            DropTable("dbo.OTPCodes");
            DropTable("dbo.CoursMatieres");
            DropTable("dbo.Professeurs");
            DropTable("dbo.Matieres");
            DropTable("dbo.Notes");
            DropTable("dbo.Etudiants");
            DropTable("dbo.ClassesCours");
            DropTable("dbo.Cours");
            DropTable("dbo.Classes");
        }
    }
}
