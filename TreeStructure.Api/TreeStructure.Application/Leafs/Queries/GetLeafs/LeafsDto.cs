using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeStructure.Application.Common.Mappings;

namespace TreeStructure.Domain
{
    public class LeafsDto : IMapFrom<Leaf>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int ParentId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Leaf, LeafsDto>();
        }
    }
}
