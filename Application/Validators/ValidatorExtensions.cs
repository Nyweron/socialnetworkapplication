using FluentValidation;

namespace Application.Validators
{
  public static class ValidatorExtensions
  {
    public static IRuleBuilder<T, string> Password<T>(this IRuleBuilder<T, string> ruleBuilder)
    {
      var options = ruleBuilder
        .NotEmpty()
        .MinimumLength(6).WithMessage("Password must be 6 characters")
        .Matches("[A-Z]").WithMessage("Password must contain 1 upper letter")
        .Matches("[a-z]").WithMessage("Password must have at least 1 lowercase character")
        .Matches("[0-9]").WithMessage("Password must constain a number")
        .Matches("[^a-zA-Z0-9]").WithMessage("Password must constain non alpha numeric");

      return options;
    }
  }
}