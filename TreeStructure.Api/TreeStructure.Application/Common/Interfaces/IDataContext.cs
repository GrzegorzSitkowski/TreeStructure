using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TreeStructure.Domain;
using TreeStructure.Domain.Entities;

namespace TreeStructure.Application.Common.Interfaces
{
    public interface IDataContext
    {
        DbSet<Leaf> Leafs { get; set; }
        DbSet<TreeNode> Nodes { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
