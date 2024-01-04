using System.ComponentModel.DataAnnotations.Schema;

namespace epi_project_pfe.Models
{
    public class Etudiant
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaiss { get; set; }
    }
}
