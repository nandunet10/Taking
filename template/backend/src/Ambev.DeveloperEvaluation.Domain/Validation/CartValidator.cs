using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation
{
    /// <summary>
    /// Validates the properties of a shopping cart.
    /// </summary>
    public class CartValidator : AbstractValidator<Cart>
    {
        public CartValidator()
        {
            RuleFor(c => c.UserId)
                .GreaterThan(0).WithMessage("UserId must be greater than zero.");

            RuleFor(c => c.Date)
                .NotEmpty().WithMessage("Date is required.")
                .LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Date cannot be in the future.");

            RuleFor(c => c.Products)
                .NotEmpty().WithMessage("The cart must contain at least one product.")
                .Must(products => products.Any()).WithMessage("The cart cannot be empty.");

            RuleForEach(c => c.Products)
                .ChildRules(product =>
                {
                    product.RuleFor(p => p.ProductId)
                        .GreaterThan(0).WithMessage("ProductId must be greater than zero.");

                    product.RuleFor(p => p.Quantity)
                        .GreaterThan(0).WithMessage("Quantity must be greater than zero.");
                });
        }
    }
}
