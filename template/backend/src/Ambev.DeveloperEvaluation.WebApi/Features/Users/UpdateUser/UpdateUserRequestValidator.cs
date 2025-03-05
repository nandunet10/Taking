using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.UpdateUser
{
    /// <summary>
    /// Validator for UpdateUserRequest that defines validation rules for updating a user.
    /// </summary>
    public class UpdateUserRequestValidator : AbstractValidator<UpdateUserRequest>
    {
        public UpdateUserRequestValidator()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("Username is required");
            RuleFor(x => x.Email).NotEmpty().EmailAddress().WithMessage("Valid email is required");
            RuleFor(x => x.Phone).NotEmpty().Matches(@"^\(\d{2}\) \d{5}-\d{4}$").WithMessage("Phone number must be in the format (XX) XXXXX-XXXX");
            RuleFor(x => x.Role).IsInEnum().WithMessage("Valid role is required");
            RuleFor(x => x.Status).IsInEnum().WithMessage("Valid status is required");
        }
    }
}
