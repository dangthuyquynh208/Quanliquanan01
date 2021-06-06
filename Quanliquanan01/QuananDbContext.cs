using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Quanliquanan01
{
    public partial class QuananDbContext : DbContext
    {
        public QuananDbContext()
            : base("name=QuananDbContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
