using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure.Application.Nodes.Commands.CreateNode
{
    public class CreateNodeCommandValidator : AbstractValidator<CreateNodeCommand>
    {
        public CreateNodeCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(30);
        }
    }
}
