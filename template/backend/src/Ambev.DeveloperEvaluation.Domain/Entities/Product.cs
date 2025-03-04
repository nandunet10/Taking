using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    /// <summary>
    /// Represents a product in the system.
    /// </summary>
    public class Product : BaseEntity, IProduct
    {
        /// <summary>
        /// Name of the product.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Price of the product.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Description of the product.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Category of the product.
        /// </summary>
        public string Category { get; set; } = string.Empty;

        /// <summary>
        /// URL of the product image.
        /// </summary>
        public string Image { get; set; } = string.Empty;

        /// <summary>
        /// Gets the date and time when the product was created.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets the date and time when the product information was last updated.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Product rating.
        /// </summary>
        public Rating Rating { get; set; } = new Rating();

        /// <summary>
        /// Initializes a new instance of the Product class.
        /// </summary>
        public Product()
        {
            CreatedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// Implementation of the IProduct interface.
        /// </summary>
        string IProduct.Id => Id.ToString();
        string IProduct.Title => Title;
        decimal IProduct.Price => Price;
        string IProduct.Description => Description;
        string IProduct.Category => Category;
        string IProduct.Image => Image;
        Rating IProduct.Rating => Rating;
    }
}
