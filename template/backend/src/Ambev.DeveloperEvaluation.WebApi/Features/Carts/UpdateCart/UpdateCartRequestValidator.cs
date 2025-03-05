using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.UpdateCart
{
    /// <summary>
    /// Validator for UpdateCartRequest that defines validation rules for cart update.
    /// </summary>
    public class UpdateCartRequestValidator : AbstractValidator<UpdateCartRequest>
    {
        /// <summary>
        /// Initializes a new instance of the UpdateCartRequestValidator with defined validation rules.
        /// </summary>
        public UpdateCartRequestValidator()
        {
            RuleFor(cart => cart.CartId).NotEmpty();
            RuleFor(cart => cart.UserId).GreaterThan(0);
            RuleFor(cart => cart.Date).NotEmpty();
            RuleForEach(cart => cart.Items).SetValidator(new CartItemRequestValidator());
        }
    }

    public class CartItemRequestValidator : AbstractValidator<CartItemRequest>
    {
        public CartItemRequestValidator()
        {
            RuleFor(item => item.ProductId).NotEmpty();
            RuleFor(item => item.Quantity).GreaterThan(0);
        }
    }
}
