using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure.Application.Nodes.Commands.DeleteNode
{
    public class DeleteNodeCommandValidator : AbstractValidator<DeleteNodeCommand>
    {
        public DeleteNodeCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();
        }
    }
}
