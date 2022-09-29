using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure.Application.Leafs.Commands.DeleteLeaf
{
    public class DeleteLeafCommand : IRequest
    {
        public int Id { get; set; }
    }
}
