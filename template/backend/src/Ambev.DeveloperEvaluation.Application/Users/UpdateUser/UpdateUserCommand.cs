using Ambev.DeveloperEvaluation.Domain.Enums;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Users.UpdateUser
{
    /// <summary>
    /// Command for updating an existing user
    /// </summary>
    public record UpdateUserCommand : IRequest<UpdateUserResult>
    {
        /// <summary>
        /// The unique identifier of the user
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// The username of the user
        /// </summary>
        public string Username { get; }

        /// <summary>
        /// The email of the user
        /// </summary>
        public string Email { get; }

        /// <summary>
        /// The phone number of the user
        /// </summary>
        public string Phone { get; }

        /// <summary>
        /// The password of the user
        /// </summary>
        public string Password { get; }

        /// <summary>
        /// The role of the user
        /// </summary>
        public UserRole Role { get; }

        /// <summary>
        /// Initializes a new instance of UpdateUserCommand
        /// </summary>
        public UpdateUserCommand(Guid userId, string username, string email, string phone, string password, UserRole role)
        {
            UserId = userId;
            Username = username;
            Email = email;
            Phone = phone;
            Password = password;
            Role = role;
        }
    }
}
