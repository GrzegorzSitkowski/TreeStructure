using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure.Domain
{
    public class TreeNodeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<LeafsDto> Leafs { get; set; }
        public List<int> ChildrenIds { get; set; }
        public int? ParentId { get; set; }
    }
}
