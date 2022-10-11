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
using TreeStructure.Application.Nodes.Queries.FirstNode;

namespace TreeStructure.Application.Nodes
{
    public class GetFirstNodeQueryHandler : IRequestHandler<GetFirstNodeQuery, FirstNodeVm>
    {
        private readonly IDataContext _context;
        private readonly IMapper _mapper;

        public GetFirstNodeQueryHandler(IDataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<FirstNodeVm> Handle(GetFirstNodeQuery request, CancellationToken cancellationToken)
        {
            var nodesWithoutParents = await _context.Nodes.Where(x => x.ParentId == 0).FirstOrDefaultAsync(cancellationToken);
            var childrenId = nodesWithoutParents.Id;
            nodesWithoutParents.Leafs = await _context.Leafs.Where(x => x.ParentId == childrenId).ToListAsync();
            nodesWithoutParents.Nodes = await _context.Nodes.Where(x => x.ParentId == childrenId).ToListAsync();

            var nodesVm = _mapper.Map<FirstNodeVm>(nodesWithoutParents);
            return nodesVm;
            //var nodesWithoutParents = await _context.Nodes.Where(x => x.ParentId == null).Select(x => x.Id).ToListAsync();
            //return new FirstNodeVm();
        }
    }
}
