using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure.Application.Leafs.Commands.CreateLeaf
{
    public class CreateLeafCommandValidator : AbstractValidator<CreateLeafCommand>
    {
        public CreateLeafCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(30);
        }
    }
}
