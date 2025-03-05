using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.UpdateUser
{
    /// <summary>
    /// Represents a request to update an existing user in the system.
    /// </summary>
    public class UpdateUserRequest
    {
        /// <summary>
        /// The user's full name.
        /// </summary>
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// The user's email address.
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// The user's phone number.
        /// </summary>
        public string Phone { get; set; } = string.Empty;

        /// <summary>
        /// The user's role in the system.
        /// </summary>
        public UserRole Role { get; set; }

        /// <summary>
        /// The user's status in the system.
        /// </summary>
        public UserStatus Status { get; set; }
    }
}
