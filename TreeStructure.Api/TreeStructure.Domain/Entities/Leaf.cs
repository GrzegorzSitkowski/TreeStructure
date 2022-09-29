using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure.Domain
{
    public class Leaf
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TreeNode Parent { get; set; }
        public int ParentId { get; set; }
    }
}
