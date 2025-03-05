namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.UpdateCart
{
    /// <summary>
    /// API response model for UpdateCart operation
    /// </summary>
    public class UpdateCartResponse
    {
        /// <summary>
        /// The unique identifier of the updated cart
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The user's unique identifier who owns the cart
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// The date when the cart was created or last updated
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// The list of products in the cart after update
        /// </summary>
        public List<CartItemResponse> Items { get; set; } = [];
    }

    public class CartItemResponse
    {
        /// <summary>
        /// The product's unique identifier
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// The quantity of the product in the cart
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// The price of the product
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// The total value of the product in the cart
        /// </summary>
        public decimal TotalValue { get; set; }
    }
}
