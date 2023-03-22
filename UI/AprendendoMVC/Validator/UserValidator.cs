using AprendendoMVC.Models;
using FluentValidation;

namespace AprendendoMVC.Validator
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator()
        {
            RuleFor(user => user.Email).NotEmpty().WithMessage("E-mail vazio");
            RuleFor(user => user.Email).EmailAddress().WithMessage("E-mail inválido") ;
            RuleFor(user => user.Password).NotNull().WithMessage("Digite a senha");
        }
    }
}
