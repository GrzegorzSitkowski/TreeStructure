using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeStructure.Domain;

namespace TreeStructure.Application.Nodes.Queries.GetNodes
{
    public class GetNodesQuery : IRequest<TreeNodeDto>
    {
    }
}
