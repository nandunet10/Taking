using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation
{
    /// <summary>
    /// Validates the properties of a product.
    /// </summary>
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Title)
                .NotEmpty().WithMessage("Title is required.")
                .MaximumLength(100).WithMessage("Title cannot be longer than 100 characters.");

            RuleFor(p => p.Description)
                .NotEmpty().WithMessage("Description is required.")
                .MaximumLength(500).WithMessage("Description cannot be longer than 500 characters.");

            RuleFor(p => p.Price)
                .GreaterThan(0).WithMessage("Price must be greater than zero.");

            RuleFor(p => p.Category)
                .NotEmpty().WithMessage("Category is required.");

            RuleFor(p => p.Image)
                .Matches(@"^(https?://)?([\w-]+(\.[\w-]+)+(/[\w- ./?%&=]*)?)?$")
                .WithMessage("Invalid image URL format.");

            RuleFor(p => p.Rating)
                .NotNull().WithMessage("Rating is required.")
                .Must(r => r.Rate >= 0 && r.Rate <= 5).WithMessage("Rating must be between 0 and 5.");
        }
    }
}
