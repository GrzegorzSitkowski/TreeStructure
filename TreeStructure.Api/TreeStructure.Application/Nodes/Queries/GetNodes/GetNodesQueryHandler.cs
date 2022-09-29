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
using TreeStructure.Application.Nodes.Queries.GetNodes;
using TreeStructure.Domain;
using TreeStructure.Persistance;

namespace TreeStructure.Application.Nodes
{
    public class GetNodesQueryHandler : IRequestHandler<GetNodesQuery, TreeNodeDto>
    {
        private readonly IDataContext _context;
        private readonly IMapper _mapper;

        public GetNodesQueryHandler(IDataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<TreeNodeDto> Handle(TreeNodeDto request, CancellationToken cancellationToken)
        {

            TreeNode node = await _context.Nodes
                .Include(x => x.Children)
                .Include(x => x.Leafs)
                .Where(x => x.Id == request.Id)
                .FirstOrDefaultAsync();

            return(
                new TreeNodeDto
                  {
                    Id = node.Id,
                    Name = node.Name,
                    ParentId = node.ParentId,
                    ChildrenIds = node.Children.Select(x => x.Id).ToList(),
                    Leafs = node.Leafs.Select(l => new LeafsDto { Id = l.Id, Name = l.Name, ParentId = l.ParentId, Text = l.Text, Title = l.Title }).ToList()
                  }
                  );
        }
    }
}
