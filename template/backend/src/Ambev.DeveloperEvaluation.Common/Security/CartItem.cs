namespace Ambev.DeveloperEvaluation.Common.Security
{
    /// <summary>
    /// Represents an item in the cart (product and quantity).
    /// </summary>
    public class CartItem
    {
        /// <summary>
        /// Product identifier.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Quantity of the product in the cart.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Price of the product.
        /// </summary>
        public decimal Price { get; set; }
    }
}
