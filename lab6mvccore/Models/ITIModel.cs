using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab6mvccore.Models
{
    public class ITIModel :DbContext
    {
        public DbSet<Student> students  { get; set; }
        public DbSet<department> departments { get; set; }
        public ITIModel(DbContextOptions<ITIModel> options):base(options)
        {

        }
    }
}
