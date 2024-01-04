using System.ComponentModel.DataAnnotations.Schema;

namespace epi_project_pfe.Models
{
    public class Soutenance
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime Heure { get; set; }

        public int PfeId { get; set; }


        public int PresidentId { get; set; }

        public int RapporteurId { get; set; }


        public virtual PFE? Pfe { get; set; }

        public virtual Enseignant? President { get; set; } = null;

        public virtual Enseignant? Rapporteur { get; set; } = null;
    }
}
