namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.GetCart
{
    /// <summary>
    /// API response model for GetCart operation
    /// </summary>
    public class GetCartResponse
    {
        /// <summary>
        /// The unique identifier of the cart
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The ID of the user who owns the cart
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// A collection of products in the cart
        /// </summary>
        public List<Guid> ProductIds { get; set; } = [];

        /// <summary>
        /// The total price of the cart
        /// </summary>
        public decimal TotalPrice { get; set; }
    }
}
