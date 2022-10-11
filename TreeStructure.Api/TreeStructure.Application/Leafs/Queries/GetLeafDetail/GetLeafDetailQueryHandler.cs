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
using TreeStructure.Application.Leafs.Queries.GetLeafDetail;
using TreeStructure.Domain;

namespace TreeStructure.Application.Leafs.Queries.GetLeafDetail
{
    public class GetLeafDetailQueryHandler : IRequestHandler<GetLeafDetailQuery,LeafDetailVm>
    {
        private readonly IDataContext _context;
        private readonly IMapper _mapper;

        public GetLeafDetailQueryHandler(IDataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<LeafDetailVm> Handle(GetLeafDetailQuery request, CancellationToken cancellationToken)
        {
            var leaf = await _context.Leafs.FindAsync(request.Id);
            leaf.LeafsChildren = await _context.Leafs.Where(p => p.LeafParentId == request.Id).ToListAsync();

            var leafVm = _mapper.Map<LeafDetailVm>(leaf);

            return leafVm;
        }
    }
}
