using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.CreateProduct
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(product => product.Title).NotEmpty().Length(3, 100);
            RuleFor(product => product.Price).GreaterThan(0);
            RuleFor(product => product.Description).NotEmpty().Length(10, 500);
            RuleFor(product => product.Category).NotEmpty().Length(3, 50);
            RuleFor(product => product.Image).Matches(@"^https?://[^\s]+$");
            RuleFor(product => product.Rating).NotNull();
        }
    }
}
