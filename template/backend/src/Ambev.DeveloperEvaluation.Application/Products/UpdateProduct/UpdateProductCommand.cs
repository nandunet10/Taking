using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.UpdateProduct
{
    /// <summary>
    /// Command for updating an existing product
    /// </summary>
    public record UpdateProductCommand : IRequest<UpdateProductResult>
    {
        /// <summary>
        /// The unique identifier of the product
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// The name of the product
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// The price of the product
        /// </summary>
        public decimal Price { get; }

        /// <summary>
        /// The description of the product
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// The category of the product
        /// </summary>
        public string Category { get; }

        /// <summary>
        /// The image URL of the product
        /// </summary>
        public string Image { get; }

        /// <summary>
        /// Initializes a new instance of UpdateProductCommand
        /// </summary>
        public UpdateProductCommand(Guid productId, string title, decimal price, string description, string category, string image)
        {
            ProductId = productId;
            Title = title;
            Price = price;
            Description = description;
            Category = category;
            Image = image;
        }
    }
}
