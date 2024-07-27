using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;
using MultiLanguageApp.Models;

namespace MultiLanguageApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }
        public DbSet<Language> Language { get; set; }
    }

}
