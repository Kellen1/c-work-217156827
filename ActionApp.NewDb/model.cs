using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ActionApp.NewDb
{
    public class ActionContext : DbContext
    {
        public DbSet<Actiontbl> Actions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.ActionApp.NewDb;Trusted_Connection=True;");
        }
    }

    public class Actiontbl
    {
        [Key]
        public int ActionId { get; set; }
        public string title { get; set; }
        public string year { get; set; }
        public string category_name { get; set; }
    }


}