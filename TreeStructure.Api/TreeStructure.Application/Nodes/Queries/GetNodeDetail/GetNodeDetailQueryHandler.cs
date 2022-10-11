using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TreeStructure.Application.Common.Interfaces;
using TreeStructure.Application.Nodes.Queries.GetNodeDetail;
using TreeStructure.Domain;

namespace TreeStructure.Application.Nodes
{
    public class GetNodeDetailQueryHandler : IRequestHandler<GetNodeDetailQuery, NodeDetailVm>
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
            var node = await _context.Nodes.Where(p => p.Id == request.Id).FirstOrDefaultAsync(cancellationToken);
            node.Leafs = await _context.Leafs.Where(p => p.ParentId == request.Id).ToListAsync();
            node.Nodes = await _context.Nodes.Where(p => p.ParentId == request.Id).ToListAsync();

            var nodeVm = _mapper.Map<NodeDetailVm>(node);
            return nodeVm;
        }
    }
}
