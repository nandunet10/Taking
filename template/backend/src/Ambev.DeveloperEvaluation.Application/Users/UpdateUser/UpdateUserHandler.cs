using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Users.UpdateUser
{
    /// <summary>
    /// Handler for processing UpdateUserCommand requests
    /// </summary>
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, UpdateUserResult>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of UpdateUserHandler
        /// </summary>
        public UpdateUserHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the UpdateUserCommand request
        /// </summary>
        public async Task<UpdateUserResult> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            // Fetch the user by its ID
            var user = await _userRepository.GetByIdAsync(request.UserId, cancellationToken)
                ?? throw new KeyNotFoundException($"User with ID {request.UserId} not found");

            // Update user fields
            user.Username = request.Username;
            user.Email = request.Email;
            user.Phone = request.Phone;
            user.Password = request.Password;
            user.Role = request.Role;
            user.UpdatedAt = DateTime.UtcNow;

            // Save the updated user
            await _userRepository.UpdateAsync(user, cancellationToken);

            return new UpdateUserResult
            {
                Id = user.Id,
                Username = user.Username,
                Email = user.Email,
                Phone = user.Phone,
                Role = user.Role,
                CreatedAt = user.CreatedAt,
                UpdatedAt = user.UpdatedAt
            };
        }
    }
}
