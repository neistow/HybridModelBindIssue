using FluentValidation;
using WebApplication.Models;

namespace WebApplication.Validators
{
    public class ExampleModelValidator : AbstractValidator<ExampleModel>
    {
        public ExampleModelValidator()
        {
            RuleFor(c => c.Test).NotEmpty();
            RuleFor(c => c.Model.Value).GreaterThanOrEqualTo(1).When(c => c.Model != null);
        }
    }
}