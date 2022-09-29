using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure.Application.Leafs.Commands.UpdateLeaf
{
    public class UpdateLeafCommandValidator : AbstractValidator<UpdateLeafCommand>
    {
        public UpdateLeafCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(30);
            RuleFor(x => x.Id).NotNull();
        }     
    }
}
