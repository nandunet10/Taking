namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.UpdateProduct
{
    /// <summary>
    /// Represents a request to update an existing product in the system
    /// </summary>
    public class UpdateProductRequest
    {
        /// <summary>
        /// The unique identifier of the product
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// The name of the product
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// The price of the product
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// The description of the product
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// The category of the product
        /// </summary>
        public string Category { get; set; } = string.Empty;

        /// <summary>
        /// The image URL of the product
        /// </summary>
        public string Image { get; set; } = string.Empty;
    }
}
