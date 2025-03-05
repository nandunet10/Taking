using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.UpdateProduct
{
    /// <summary>
    /// Validator for UpdateProductRequest that defines validation rules for product update.
    /// </summary>
    public class UpdateProductRequestValidator : AbstractValidator<UpdateProductRequest>
    {
        /// <summary>
        /// Initializes a new instance of the UpdateProductRequestValidator with defined validation rules.
        /// </summary>
        public UpdateProductRequestValidator()
        {
            RuleFor(product => product.ProductId).NotEmpty();
            RuleFor(product => product.Title).NotEmpty().Length(2, 255);
            RuleFor(product => product.Price).GreaterThan(0);
            RuleFor(product => product.Description).NotEmpty();
            RuleFor(product => product.Category).NotEmpty();
            RuleFor(product => product.Image).NotEmpty();
        }
    }
}
