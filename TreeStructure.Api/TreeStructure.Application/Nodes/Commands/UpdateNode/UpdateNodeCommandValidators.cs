using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure.Application.Nodes.Commands.UpdateNode
{
    public class UpdateNodeCommandValidators : AbstractValidator<UpdateNodeCommand>
    {
        public UpdateNodeCommandValidators()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(30);
            RuleFor(x => x.Id).NotNull();
        }
    }
}
