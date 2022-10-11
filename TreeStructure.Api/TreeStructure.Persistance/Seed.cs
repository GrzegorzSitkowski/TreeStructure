using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeStructure.Domain;
using TreeStructure.Domain.Entities;

namespace TreeStructure.Persistance
{
    public static class Seed
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TreeNode>().HasData(
                new TreeNode() { Id = 11, Name = "FirstNode", ParentId = 0 },
                new TreeNode() { Id = 12, Name = "SecondNode", ParentId = 11 },
                new TreeNode() { Id = 13, Name = "ThirdNode", ParentId = 11 },
                new TreeNode() { Id = 14, Name = "FourthNode", ParentId = 12 }
                );

            modelBuilder.Entity<Leaf>().HasData(
                new Leaf() { Id = 21, Name = "FirstLeaf", ParentId = 11},
                new Leaf() { Id = 22, Name = "SecondLeaf", ParentId = 11 },
                new Leaf() { Id = 23, Name = "ThirdLeaf", ParentId = 12 },
                new Leaf() { Id = 24, Name = "FourthLeaf", ParentId = 12, LeafParentId = 23 }
                );
        }
    }
}
