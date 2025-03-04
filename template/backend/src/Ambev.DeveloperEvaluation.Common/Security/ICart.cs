namespace Ambev.DeveloperEvaluation.Common.Security
{
    /// <summary>
    /// Defines the contract for representing a cart in the system.
    /// </summary>
    public interface ICart
    {
        /// <summary>
        /// Gets the unique identifier of the cart.
        /// </summary>
        /// <returns>The cart ID as a string.</returns>
        public string Id { get; }

        /// <summary>
        /// Gets the identifier of the user associated with the cart.
        /// </summary>
        /// <returns>The user ID as a string.</returns>
        public string UserId { get; }

        /// <summary>
        /// Gets the date of creation or update of the cart.
        /// </summary>
        /// <returns>The creation or update date.</returns>
        public string Date { get; }

        /// <summary>
        /// Gets the items in the cart.
        /// </summary>
        /// <returns>The items in the cart.</returns>
        public IEnumerable<CartItem> Products { get; }
    }
}
