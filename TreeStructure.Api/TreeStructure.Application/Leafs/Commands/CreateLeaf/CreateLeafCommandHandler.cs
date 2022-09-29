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
using TreeStructure.Persistance;

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
                var parentId = request.ParentId;

                var parent = await _context.Nodes.FindAsync(parentId);

            Leaf leaf = new()
            {
                Name = request.Name,
                Title = request.Title,
                Text = request.Text,
                Parent = request.Parent,
                ParentId = request.ParentId
            };

                _context.Leafs.Add(leaf);

                parent.Leafs.Add(leaf);

                await _context.SaveChangesAsync(cancellationToken);

                //if (!result) return Result<Unit>.Failure("Failed to create leaf");

                return leaf.Id;
            }
    }
}
