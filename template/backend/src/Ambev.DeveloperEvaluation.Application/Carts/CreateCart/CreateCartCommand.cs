using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Carts.CreateCart
{
    /// <summary>
    /// Command for creating a new cart
    /// </summary>
    public record CreateCartCommand : IRequest<CreateCartResult>
    {
        /// <summary>
        /// The unique identifier of the user who owns the cart
        /// </summary>
        public int UserId { get; }

        /// <summary>
        /// List of products in the cart
        /// </summary>
        public List<CartItemDto> Products { get; }

        /// <summary>
        /// Initializes a new instance of CreateCartCommand
        /// </summary>
        /// <param name="userId">The ID of the user who owns the cart</param>
        /// <param name="products">The products to add to the cart</param>
        public CreateCartCommand(int userId, List<CartItemDto> products)
        {
            UserId = userId;
            Products = products;
        }

        public ValidationResultDetail Validate()
        {
            var validator = new CreateCartValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }

    public class CartItemDto
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}




