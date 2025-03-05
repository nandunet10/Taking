using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.UpdateProduct
{
    /// <summary>
    /// Handler for processing UpdateProductCommand requests
    /// </summary>
    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, UpdateProductResult>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of UpdateProductHandler
        /// </summary>
        public UpdateProductHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the UpdateProductCommand request
        /// </summary>
        public async Task<UpdateProductResult> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            // Fetch the product by its ID
            var product = await _productRepository.GetByIdAsync(request.ProductId, cancellationToken)
                ?? throw new KeyNotFoundException($"Product with ID {request.ProductId} not found");

            // Update product fields
            product.Title = request.Title;
            product.Price = request.Price;
            product.Description = request.Description;
            product.Category = request.Category;
            product.Image = request.Image;
            product.UpdatedAt = DateTime.UtcNow;  // Set update time

            // Save the updated product
            await _productRepository.UpdateAsync(product, cancellationToken);

            return new UpdateProductResult
            {
                Id = product.Id,
                Title = product.Title,
                Price = product.Price,
                Description = product.Description,
                Category = product.Category,
                Image = product.Image,
                CreatedAt = product.CreatedAt,
                UpdatedAt = product.UpdatedAt
            };
        }
    }
}
