using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TreeStructure.Application.Common.Interfaces;
using TreeStructure.Domain;
using TreeStructure.Domain.Entities;

namespace TreeStructure.Persistance
{
    public class DataContext : DbContext, IDataContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Leaf> Leafs { get; set; }
        public DbSet<TreeNode> Nodes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.SeedData();
 
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Leaf>()
                .HasOne(l => l.Parent)
                .WithMany(n => n.Leafs);
        }
    }
}
