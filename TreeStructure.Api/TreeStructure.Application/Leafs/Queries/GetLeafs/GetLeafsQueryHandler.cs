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
using TreeStructure.Application.Leafs.Queries.GetLeafs;
using TreeStructure.Domain;
using TreeStructure.Domain.Entities;

namespace TreeStructure.Application.Leafs.Queries.GetLeafs
{
    public class GetLeafsQueryHandler
    {
        private readonly IDataContext _context;
        private readonly IMapper _mapper;

        public GetLeafsQueryHandler(IDataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<LeafsDto> Handle(LeafsDto getLeafsQuery, CancellationToken cancellationToken)
        {
            List<Leaf> children = await _context.Leafs.Where(x => x.ParentId == getLeafsQuery.Id).ToListAsync();

            return new LeafsDto();
        }
    }
}
