using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeStructure.Domain;

namespace TreeStructure.Application.Leafs.Queries.GetLeafs
{
    public class GetLeafQuery : IRequest<LeafsDto>
    {
    }
}
