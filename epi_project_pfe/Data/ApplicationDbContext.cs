using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using epi_project_pfe.Models;

namespace epi_project_pfe.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<epi_project_pfe.Models.Etudiant>? Etudiant { get; set; }
        public DbSet<epi_project_pfe.Models.Enseignant>? Enseignant { get; set; }
        public DbSet<epi_project_pfe.Models.Societe>? Societe { get; set; }
        public DbSet<epi_project_pfe.Models.PFE>? PFE { get; set; }
        public DbSet<epi_project_pfe.Models.Soutenance>? Soutenance { get; set; }
        public DbSet<epi_project_pfe.Models.PFE_ETUDIANT>? PFE_ETUDIANT { get; set; }
    }
}