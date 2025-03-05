using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Carts.UpdateCart
{
    /// <summary>
    /// Validator for CreateCartCommand
    /// </summary>
    public class UpdateCartValidator : AbstractValidator<UpdateCartCommand>
    {
        /// <summary>
        /// Initializes validation rules for CreateCartCommand
        /// </summary>
        public UpdateCartValidator()
        {
            RuleFor(x => x.CartId)
                .NotEmpty()
                .WithMessage("User ID is required");

        }
    }
}
