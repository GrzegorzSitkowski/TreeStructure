using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TreeStructure.Application.Common.Interfaces;
using TreeStructure.Application.Nodes.Commands.CreateNode;
using TreeStructure.Domain;
using TreeStructure.Persistance;

namespace TreeStructure.Application.Nodes
{
    public class CreateCommandHandler : IRequestHandler<CreateNodeCommand, int>
    {
        private readonly IDataContext _context;
        public CreateCommandHandler(IDataContext context)
        {
            _context = context;
        }
            public async Task<int> Handle(CreateNodeCommand request, CancellationToken cancellationToken)
            {

                var newNode = new TreeNode
                {
                    Name = request.Name,
                    ParentId = request.ParentId

                };

                if (newNode.ParentId is { })
                {
                    var parent = await _context.Nodes.FindAsync(request.ParentId);
                    parent.Children.Add(newNode);
                }

                _context.Nodes.Add(newNode);

                await _context.SaveChangesAsync(cancellationToken);

            return newNode.Id;
            }
    }
}
