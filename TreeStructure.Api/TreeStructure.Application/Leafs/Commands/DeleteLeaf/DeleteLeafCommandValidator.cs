using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure.Application.Leafs.Commands.DeleteLeaf
{
    public class DeleteLeafCommandValidator :AbstractValidator<DeleteLeafCommand>
    {
        public DeleteLeafCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();
        }
    }
}
