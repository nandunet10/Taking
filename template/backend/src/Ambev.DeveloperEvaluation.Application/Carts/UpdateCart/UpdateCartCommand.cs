using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Carts.UpdateCart
{
    /// <summary>
    /// Command for updating an existing cart
    /// </summary>
    public record UpdateCartCommand : IRequest<UpdateCartResult>
    {
        /// <summary>
        /// The unique identifier of the cart
        /// </summary>
        public Guid CartId { get; set; }

        /// <summary>
        /// The unique identifier of the user who owns the cart
        /// </summary>
        public int UserId { get; }

        /// <summary>
        /// The date when the cart was created or last updated
        /// </summary>
        public DateTime Date { get; }

        /// <summary>
        /// The list of products to be updated in the cart
        /// </summary>
        public List<CartItemRequest> Items { get; }

        /// <summary>
        /// Initializes a new instance of UpdateCartCommand
        /// </summary>
        public UpdateCartCommand(Guid cartId, DateTime date, List<CartItemRequest> items)
        {
            CartId = cartId;
            Date = date;
            Items = items;
        }
    }

    public class CartItemRequest
    {
        /// <summary>
        /// The product's unique identifier.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// The quantity of the product in the cart.
        /// </summary>
        public int Quantity { get; set; }
    }
}
