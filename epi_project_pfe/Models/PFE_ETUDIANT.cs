namespace epi_project_pfe.Models
{
    public class PFE_ETUDIANT
    {
        public int Id { get; set; }
        public int PfeId { get; set; }

        public int EtudiantId { get; set; }

        public virtual Etudiant? Etudiant { get; set; } 

        public virtual PFE? Pfe { get; set; }
    }
}
