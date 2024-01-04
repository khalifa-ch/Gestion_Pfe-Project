using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;

namespace epi_project_pfe.Models
{
    public class PFE
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public DateTime DateD { get; set; }
        public DateTime DateF { get; set; }

        public int EncadrantId { get; set; }

        public int SocieteId { get; set; }

        public virtual Enseignant? Encadrant { get; set; } = null;

        public virtual Societe? Societe { get; set; } = null;
    }
}
