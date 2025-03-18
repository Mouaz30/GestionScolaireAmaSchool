using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionScolaireAmaSchool.Entity;


namespace GestionScolaireAmaSchool.Entity
{
    internal class CoursMatieres
    {



        [Key, Column(Order = 1)]
        [Required]
        [ForeignKey("Cours")]
        public int CoursId { get; set; }
        public virtual Cours Cours { get; set; }


        [Required]
        [Key, Column(Order = 2)]
        [ForeignKey("Matieres")]
        public int MatiereId { get; set; }
        public virtual Matieres Matieres { get; set; }


    }
}

