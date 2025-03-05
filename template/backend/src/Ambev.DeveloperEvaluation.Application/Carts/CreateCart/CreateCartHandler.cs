using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Carts.CreateCart
{
    /// <summary>
    /// Handler for processing CreateCartCommand requests
    /// </summary>
    public class CreateCartHandler : IRequestHandler<CreateCartCommand, CreateCartResult>
    {
        private readonly ICartRepository _cartRepository;

        /// <summary>
        /// Initializes a new instance of CreateCartHandler
        /// </summary>
        /// <param name="cartRepository">The cart repository</param>
        public CreateCartHandler(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        /// <summary>
        /// Handles the CreateCartCommand request
        /// </summary>
        /// <param name="request">The CreateCart command</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The result of the create operation</returns>
        public async Task<CreateCartResult> Handle(CreateCartCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateCartValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            // Create the Cart entity
            var cart = new Cart
            {
                Id = Guid.NewGuid(),
                UserId = request.UserId,
                Date = DateTime.UtcNow,
                Products = request.Products.Select(p => new CartItem
                {
                    ProductId = p.ProductId,
                    Quantity = p.Quantity,
                    //Price = 0m 
                }).ToList()
            };

            // Save to repository
            await _cartRepository.CreateAsync(cart, cancellationToken);

            return new CreateCartResult
            {
                Success = true,
                CartId = cart.Id
            };
        }
    }
}
