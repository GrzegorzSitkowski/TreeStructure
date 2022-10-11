using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TreeStructure.Application.Common.Interfaces;
using TreeStructure.Application.Nodes.Commands.DeleteNode;
namespace TreeStructure.Application.Nodes
{
    public class DeleteNodeCommandHandler : IRequestHandler<DeleteNodeCommand>
    {
        private readonly IDataContext _context;
        public DeleteNodeCommandHandler(IDataContext context)
        {
            _context = context;
        }

            public async Task<Unit> Handle(DeleteNodeCommand request, CancellationToken cancellationToken)
            {
                var node = await _context.Nodes.FindAsync(request.Id);

            if (node == null)
                return Unit.Value;

                _context.Nodes.Remove(node);

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
    }
}
