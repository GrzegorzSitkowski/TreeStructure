using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TreeStructure.Application.Common.Interfaces;
using TreeStructure.Application.Leafs.Commands.UpdateLeaf;
using TreeStructure.Domain;
using TreeStructure.Persistance;

namespace TreeStructure.Application.Leafs
{
    public class UpdateLeafCommandHandler : IRequestHandler<UpdateLeafCommand>
    {
        private readonly IDataContext _context;
        public UpdateLeafCommandHandler(IDataContext context)
        {
            _context = context;
        }
         public async Task<Unit> Handle(UpdateLeafCommand request, CancellationToken cancellationToken)
            {
                var leaf = await _context.Leafs.FindAsync(request.Id);

                if (leaf == null) 
                    return Unit.Value;

                leaf.Name = request.Name;

                var result = await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
    }
}
