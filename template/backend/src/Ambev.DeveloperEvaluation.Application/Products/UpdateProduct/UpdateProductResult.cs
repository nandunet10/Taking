namespace Ambev.DeveloperEvaluation.Application.Products.UpdateProduct
{
    /// <summary>
    /// API response model for UpdateProduct operation
    /// </summary>
    public class UpdateProductResult
    {
        /// <summary>
        /// The unique identifier of the updated product
        /// </summary>
        public Guid Id { get; set; }

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

        /// <summary>
        /// The creation date of the product
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The update date of the product
        /// </summary>
        public DateTime? UpdatedAt { get; set; }
    }
}
