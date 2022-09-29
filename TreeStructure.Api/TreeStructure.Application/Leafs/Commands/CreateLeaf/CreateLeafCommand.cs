﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeStructure.Domain;

namespace TreeStructure.Application.Leafs.Commands.CreateLeaf
{
    public class CreateLeafCommand : IRequest<int>
    {
        public string Name { get; set; }
        public TreeNode Parent { get; set; }
        public int ParentId { get; set; }
    }
}
