using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Carts.GetCart
{
    /// <summary>
    /// Command for retrieving a cart by its UserId
    /// </summary>
    public record GetCartCommand : IRequest<GetCartResult>
    {
        /// <summary>
        /// The unique identifier of the user who owns the cart
        /// </summary>
        public Guid UserId { get; }

        /// <summary>
        /// Initializes a new instance of GetCartCommand
        /// </summary>
        /// <param name="userId">The ID of the user who owns the cart</param>
        public GetCartCommand(Guid userId)
        {
            UserId = userId;
        }
    }
}
