using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure.Application.Nodes.Commands.DeleteNode
{
    public class DeleteNodeCommand : IRequest
    {
        public int Id { get; set; }
    }
}
