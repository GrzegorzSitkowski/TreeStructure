using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeStructure.Application.Common.Mappings;
using TreeStructure.Domain.Entities;

namespace TreeStructure.Application.Nodes.Queries.GetNodeDetail
{
    public class LeafInNode : IMapFrom<Leaf>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Leaf, LeafInNode>();
        }
    }
}
