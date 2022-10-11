using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TreeStructure.Application.Common.Interfaces;
using TreeStructure.Application.Nodes.Commands.UpdateNode;
using TreeStructure.Domain;

namespace TreeStructure.Application.Nodes
{
    public class UpdateNodeCommandHandler : IRequestHandler<UpdateNodeCommand>
    {
        private readonly IDataContext _context;

        public UpdateNodeCommandHandler(IDataContext context)
        {
            _context = context;
        }

            public async Task<Unit> Handle(UpdateNodeCommand request, CancellationToken cancellationToken)
            {
                var node = await _context.Nodes.FindAsync(request.Id);

            if (node == null)
                return Unit.Value;

                node.Name = request.Name;
                node.ParentId = request.ParentId;

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
    }
}
