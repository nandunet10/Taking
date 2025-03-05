namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.CreateCart;

/// <summary>
/// API response model for CreateCart operation.
/// </summary>
public class CreateCartResponse
{
    /// <summary>
    /// The unique identifier of the created cart.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The user's unique identifier who owns the cart.
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// The date when the cart was created or last updated.
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// The list of products in the cart.
    /// </summary>
    public List<CartItemResponse> Items { get; set; } = [];
}

public class CartItemResponse
{
    /// <summary>
    /// The product's unique identifier.
    /// </summary>
    public Guid ProductId { get; set; }

    /// <summary>
    /// The quantity of the product in the cart.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// The price of the product.
    /// </summary>
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// The total value of the product in the cart.
    /// </summary>
    public decimal TotalValue { get; set; }
}
