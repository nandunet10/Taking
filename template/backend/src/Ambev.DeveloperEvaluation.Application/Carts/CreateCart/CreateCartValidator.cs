using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Carts.CreateCart
{
    /// <summary>
    /// Validator for CreateCartCommand
    /// </summary>
    public class CreateCartValidator : AbstractValidator<CreateCartCommand>
    {
        /// <summary>
        /// Initializes validation rules for CreateCartCommand
        /// </summary>
        public CreateCartValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .WithMessage("User ID is required");

            RuleFor(x => x.Products)
                .NotEmpty()
                .WithMessage("At least one product is required");

            RuleForEach(x => x.Products)
                .ChildRules(product =>
                {
                    product.RuleFor(p => p.ProductId)
                        .NotEmpty()
                        .WithMessage("Product ID is required");

                    product.RuleFor(p => p.Quantity)
                        .GreaterThan(0)
                        .WithMessage("Quantity must be greater than zero");
                });
        }
    }
}
