using FluentValidation;
using FluentValidation.Results;

namespace BookLibraryAPI.Models.Validation
{
    public abstract class CustomValidator<T>:AbstractValidator<T>
    {
        public bool Validate(T v, out string error)
        {
            ValidationResult result = Validate(v);

            error = string.Empty;
            if (!result.IsValid)
            {
                foreach (var failure in result.Errors)
                {
                    error += failure + Environment.NewLine;
                }
            }

            return result.IsValid;
        }
    }
}
