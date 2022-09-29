using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TreeStructure.Application.Common.Interfaces;
using TreeStructure.Application.Nodes.Queries.GetNodeDetail;
using TreeStructure.Domain;
using TreeStructure.Persistance;

namespace TreeStructure.Application.Nodes
{
    public class GetNodeDetailQueryHandler
    {
        private readonly IDataContext _context;
        private readonly IMapper _mapper;

        public GetNodeDetailQueryHandler(IDataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<NodeDetailVm> Handle(GetNodeDetailQuery request, CancellationToken cancellationToken)
        {
            var node = await _context.Nodes.FindAsync(request.Id);

            var nodeVm = _mapper.Map<NodeDetailVm>(node);
            return nodeVm;
        }
    }
}
