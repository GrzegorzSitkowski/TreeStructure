using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure.Application.Leafs.Queries.GetLeafDetail
{
    public class GetLeafDetailQuery : IRequest<LeafDetailVm>
    {
        public int Id { get; set; }
    }
}
