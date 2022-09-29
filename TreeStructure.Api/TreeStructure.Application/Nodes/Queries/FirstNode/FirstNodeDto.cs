using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeStructure.Application.Common.Mappings;
using TreeStructure.Domain;

namespace TreeStructure.Application.Nodes.Queries.FirstNode
{
    public class FirstNodeDto : IMapFrom<TreeNode>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Leaf> Leafs { get; set; } = new List<Leaf>();
        public ICollection<TreeNode> Children { get; set; } = new List<TreeNode>();
        public int? ParentId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TreeNode, FirstNodeDto>();
        }
    }
}
