using Ambev.DeveloperEvaluation.Common.Security;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProduct
{
    /// <summary>
    /// Response model for GetProduct operation
    /// </summary>
    public class GetProductResult
    {
        /// <summary>
        /// The unique identifier of the product
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The title of the product
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// The description of the product
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// The price of the product
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// The category of the product
        /// </summary>
        public string Category { get; set; } = string.Empty;

        /// <summary>
        /// The image URL of the product
        /// </summary>
        public string Image { get; set; } = string.Empty;

        /// <summary>
        /// The rating of the product
        /// </summary>
        public Rating Rating { get; set; }

        /// <summary>
        /// The creation date of the product
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The last update date of the product (nullable)
        /// </summary>
        public DateTime? UpdatedAt { get; set; }
    }
}
