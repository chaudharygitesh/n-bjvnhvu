using Microsoft.EntityFrameworkCore;
using SchoolManagement.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DAL.DataContext
{
    public class ApplicationDbContxt : DbContext
    {
        public ApplicationDbContxt(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Patient> Gitesh_Patients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
