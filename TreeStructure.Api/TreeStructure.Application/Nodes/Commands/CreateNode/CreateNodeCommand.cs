using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeStructure.Domain;

namespace TreeStructure.Application.Nodes.Commands.CreateNode
{
    public class CreateNodeCommand : IRequest<int>
    {
        public string Name { get; set; }
        public ICollection<Leaf> Leafs { get; set; } = new List<Leaf>();
        public ICollection<TreeNode> Children { get; set; } = new List<TreeNode>();
        public int? ParentId { get; set; }
    }
}
