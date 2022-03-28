﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.BookOperations.CreateBook
{
    public class CreateBookCommandValidator: AbstractValidator<CreateBookCommand>
    {
        public CreateBookCommandValidator()
        {
            RuleFor(command => command.Model.GenreId).GreaterThanOrEqualTo(0);
            RuleFor(command => command.Model.PageCount).GreaterThan(0);
            RuleFor(command => command.Model.PublishDate).NotEmpty().LessThan(DateTime.Now.Date);
            RuleFor(command => command.Model.Title).NotEmpty().MinimumLength(4);
        }
    }
}
