using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Application.Beach.CreateBeach
{
    public  class CreateBeachValidator : AbstractValidator<CreateBeachRequest>
    {
        public CreateBeachValidator()
        {
            RuleFor(x => x.BeachName).NotEmpty();
        }
    }
}
