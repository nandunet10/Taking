using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    /// <summary>
    /// Represents a shopping cart in the system.
    /// </summary>
    public class Cart : BaseEntity, ICart
    {
        /// <summary>
        /// Identifier of the user who owns the cart.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Date of creation or update of the cart.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// List of products added to the cart.
        /// </summary>
        public IEnumerable<CartItem> Products { get; set; } = [];

        /// <summary>
        /// Implementation of the ICart interface.
        /// </summary>
        string ICart.Id => Id.ToString();
        string ICart.UserId => UserId.ToString();
        string ICart.Date => Date.ToString("yyyy-MM-dd");
        IEnumerable<CartItem> ICart.Products => Products;
    }
}
