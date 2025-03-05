namespace Ambev.DeveloperEvaluation.Application.Carts.GetCart
{
    /// <summary>
    /// Response model for GetCart operation
    /// </summary>
    public class GetCartResult
    {
        /// <summary>
        /// The unique identifier of the cart
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The ID of the user who owns the cart
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Date when the cart was created or updated
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// List of products in the cart
        /// </summary>
        public List<CartItemResult> Products { get; set; } = [];
    }

    /// <summary>
    /// Helper class for each product in the cart
    /// </summary>
    public class CartItemResult
    {
        /// <summary>
        /// The unique identifier of the product in the cart
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// The quantity of the product in the cart
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// The price of the product
        /// </summary>
        public decimal Price { get; set; }
    }
}
