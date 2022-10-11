using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure.Domain.Entities
{
    public class TreeNode
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<TreeNode> Nodes { get; set; }
        public ICollection<Leaf> Leafs { get; set; }
        public int? ParentId { get; set; }
    }
}
