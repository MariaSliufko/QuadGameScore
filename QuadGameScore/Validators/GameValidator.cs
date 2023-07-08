using System;
using FluentValidation;
using QuadGameScore.Models;

namespace QuadGameScore.Validators
{
	public class GameValidator : AbstractValidator<Game>
    {
        public GameValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Namnet är obligatoriskt.")
                .MinimumLength(3).WithMessage("Namnet måste vara minst 3 tecken långt.");
        }

    }
}

