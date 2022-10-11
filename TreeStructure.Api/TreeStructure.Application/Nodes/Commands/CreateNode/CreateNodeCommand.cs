using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeStructure.Domain;
using TreeStructure.Domain.Entities;

namespace TreeStructure.Application.Nodes.Commands.CreateNode
{
    public class CreateNodeCommand : IRequest<int>
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
    }
}
