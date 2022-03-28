using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.BookOperations.GetBookDetails
{
    public class GetBookDetailValidator : AbstractValidator<GetBookDetail>
    {
        public GetBookDetailValidator()
        {
            RuleFor(query => query.BookId).GreaterThan(0);
        }
    }
}
