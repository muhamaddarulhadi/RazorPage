using Microsoft.EntityFrameworkCore;
using RazorPage.Models;

namespace RazorPage.Data
{
    public class DefaultConnection : DbContext
    {
        public DefaultConnection (
            DbContextOptions<DefaultConnection> options)    //CALL THIS CLASS NAME
            : base(options)
        {
        }

        public DbSet<Table_Razor_Page> Table_Razor_Page { get; set; }       //GET THE CLASS FROM ENTITY MODELS AND DECLARE ITS NAME

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table_Razor_Page>().ToTable("Table_Razor_Page");        //PARSE THE TABLE FROM DB INTO CERTAIN ENTITY MODELS
        }
    }
}