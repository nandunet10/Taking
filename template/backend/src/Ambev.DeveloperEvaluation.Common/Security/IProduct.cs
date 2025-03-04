namespace Ambev.DeveloperEvaluation.Common.Security
{
    /// <summary>
    /// Defines the contract for representing a product in the system.
    /// </summary>
    public interface IProduct
    {
        /// <summary>
        /// Gets the unique identifier of the product.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Gets the name of the product.
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Gets the price of the product.
        /// </summary>
        decimal Price { get; }

        /// <summary>
        /// Gets the description of the product.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Gets the category of the product.
        /// </summary>
        string Category { get; }

        /// <summary>
        /// Gets the URL of the product image.
        /// </summary>
        string Image { get; }

        /// <summary>
        /// Gets the rating of the product.
        /// </summary>
        Rating Rating { get; }
    }
}
