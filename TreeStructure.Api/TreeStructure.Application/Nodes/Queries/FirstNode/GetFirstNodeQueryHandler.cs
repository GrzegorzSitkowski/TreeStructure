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
using TreeStructure.Persistance;

namespace TreeStructure.Application.Nodes
{
    public class GetFirstNodeQueryHandler : IRequestHandler<GetFirstNodeQuery, FirstNodeDto>
    {
        private readonly IDataContext _context;

        public GetFirstNodeQueryHandler(IDataContext context)
        {
            _context = context;
        }

        public async Task<FirstNodeDto> Handle(GetFirstNodeQuery request, CancellationToken none)
        {
            var nodesWithoutParents = await _context.Nodes.Where(x => x.ParentId == null).Select(x => x.Id).ToListAsync();
            return new FirstNodeDto();
        }
    }
}
