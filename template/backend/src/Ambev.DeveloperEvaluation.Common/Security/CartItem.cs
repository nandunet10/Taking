namespace Ambev.DeveloperEvaluation.Common.Security
{
    /// <summary>
    /// Representa um item no carrinho (produto e quantidade).
    /// </summary>
    public class CartItem
    {
        /// <summary>
        /// Identificador do produto.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Quantidade do produto no carrinho.
        /// </summary>
        public int Quantity { get; set; }
    }
}
