using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TreeStructure.Application.Common.Interfaces;
using TreeStructure.Application.Nodes.Queries.GetNodes;
using TreeStructure.Domain;

namespace TreeStructure.Application.Nodes
{
    public class GetNodesQueryHandler : IRequestHandler<GetNodesQuery, TreeNodeVm>
    {
        private readonly IDataContext _context;
        private readonly IMapper _mapper;

        public GetNodesQueryHandler(IDataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<TreeNodeVm> Handle(GetNodesQuery request, CancellationToken cancellationToken)
        {
            var nodes = await _context.Nodes.AsNoTracking().ProjectTo<TreeNodeVm>(_mapper.ConfigurationProvider).ToListAsync();
            return new TreeNodeVm();
        }
    }
}
