namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProduct
{
    /// <summary>
    /// API response model for GetProduct operation
    /// </summary>
    public class GetProductResponse
    {
        /// <summary>
        /// The unique identifier of the product
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The name of the product
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The product's description
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// The product's price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// The product's category
        /// </summary>
        public string Category { get; set; } = string.Empty;
    }
}
