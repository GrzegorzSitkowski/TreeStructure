using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TreeStructure.Application.Common.Interfaces;
using TreeStructure.Application.Leafs.Commands.DeleteLeaf;

namespace TreeStructure.Application.Leafs
{
    public class DeleteLeafCommandHandler : IRequestHandler<DeleteLeafCommand>
    {
        private readonly IDataContext _context;

        public DeleteLeafCommandHandler(IDataContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteLeafCommand request, CancellationToken cancellationToken)
        {
            var leaf = await _context.Leafs.Where(p => p.Id == request.Id).FirstOrDefaultAsync(cancellationToken);

            _context.Leafs.Remove(leaf);

             await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
