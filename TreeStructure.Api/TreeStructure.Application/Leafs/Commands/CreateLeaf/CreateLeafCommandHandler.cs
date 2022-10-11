using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TreeStructure.Application.Common.Interfaces;
using TreeStructure.Application.Leafs.Commands.CreateLeaf;
using TreeStructure.Domain;
using TreeStructure.Domain.Entities;

namespace TreeStructure.Application.Leafs
{
    public class CreateLeafCommandHandler : IRequestHandler<CreateLeafCommand, int>
    {
        private readonly IDataContext _context;
        public CreateLeafCommandHandler(IDataContext context)
        {
            _context = context;
        }
            public async Task<int> Handle(CreateLeafCommand request, CancellationToken cancellationToken)
            {
            Leaf leaf = new()
            {
                Name = request.Name,
                ParentId = request.ParentId,
                //Parent = request.Parent,
                LeafParentId =  request.LeafParentId
            };

                _context.Leafs.Add(leaf);
                await _context.SaveChangesAsync(cancellationToken);

                return leaf.Id;
            }
    }
}
