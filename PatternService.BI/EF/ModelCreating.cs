using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FormGenerator.Data.Entity;
using FormGenerator.Data.Attributes;
using FormGenerator.General.Expansions;
using System.ComponentModel;

namespace FormGenerator.EF
{
    public partial class ServiceDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
