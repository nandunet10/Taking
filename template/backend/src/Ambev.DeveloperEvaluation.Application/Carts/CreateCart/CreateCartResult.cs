namespace Ambev.DeveloperEvaluation.Application.Carts.CreateCart
{
    /// <summary>
    /// Response model for CreateCart operation
    /// </summary>
    public class CreateCartResult
    {
        /// <summary>
        /// Indicates whether the cart creation was successful
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// The unique identifier of the created cart
        /// </summary>
        public Guid CartId { get; set; }
    }
}
