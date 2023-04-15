using InformationPersonel.Models;
using Microsoft.EntityFrameworkCore;

namespace InformationPersonel.Context
{
    public class DbMainContext : DbContext
    {
        public DbMainContext(DbContextOptions<DbMainContext> options) : base(options) 
        {
            
        }


        public DbSet<Person> Persons { get; set; }
    }
}
