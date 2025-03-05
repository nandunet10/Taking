using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Users.UpdateUser
{
    /// <summary>
    /// API response model for UpdateUser operation
    /// </summary>
    public class UpdateUserResult
    {
        /// <summary>
        /// The unique identifier of the updated user
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The username of the user
        /// </summary>
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// The email of the user
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// The phone number of the user
        /// </summary>
        public string Phone { get; set; } = string.Empty;

        /// <summary>
        /// The role of the user
        /// </summary>
        public UserRole Role { get; set; }

        /// <summary>
        /// The creation date of the user
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The update date of the user
        /// </summary>
        public DateTime? UpdatedAt { get; set; }
    }
}
