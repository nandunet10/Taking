namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.UpdateCart
{
    /// <summary>
    /// Represents a request to update an existing cart in the system
    /// </summary>
    public class UpdateCartRequest
    {
        /// <summary>
        /// The unique identifier of the cart
        /// </summary>
        public Guid CartId { get; set; }

        /// <summary>
        /// The user's unique identifier who owns the cart
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// The date when the cart was created or last updated
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// The list of products to be updated in the cart
        /// </summary>
        public List<CartItemRequest> Items { get; set; } = [];
    }

    public class CartItemRequest
    {
        /// <summary>
        /// The product's unique identifier
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// The quantity of the product in the cart
        /// </summary>
        public int Quantity { get; set; }
    }
}
