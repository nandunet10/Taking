using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Carts.UpdateCart
{
    /// <summary>
    /// Handler for processing UpdateCartCommand requests
    /// </summary>
    public class UpdateCartHandler : IRequestHandler<UpdateCartCommand, UpdateCartResult>
    {
        private readonly ICartRepository _cartRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of UpdateCartHandler
        /// </summary>
        public UpdateCartHandler(ICartRepository cartRepository, IMapper mapper)
        {
            _cartRepository = cartRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the UpdateCartCommand request
        /// </summary>
        public async Task<UpdateCartResult> Handle(UpdateCartCommand request, CancellationToken cancellationToken)
        {
            // Fetch existing cart by ID
            var cart = await _cartRepository.GetByIdAsync(request.CartId, cancellationToken)
                ?? throw new KeyNotFoundException($"Cart with ID {request.CartId} not found");

            // Update the cart fields
            cart.UserId = request.UserId;
            cart.Date = request.Date;

            // Update or replace items in the cart
            cart.Products = request.Items.Select(item =>
                new CartItem
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity
                }).ToList();

            // Save the updated cart
            await _cartRepository.UpdateAsync(cart, cancellationToken);

            return new UpdateCartResult
            {
                Id = cart.Id,
                UserId = cart.UserId,
                Date = cart.Date,
                Items = _mapper.Map<List<CartItemResponse>>(cart.Products)
            };
        }
    }
}
