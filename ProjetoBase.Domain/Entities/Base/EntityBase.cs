using FluentValidation;
using FluentValidation.Results;
using System;

namespace ProjetoBase.Domain.Entities.Base
{
    public class EntityBase
    {
        protected EntityBase()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
        public ValidationResult ValidationResult { get; set; }

        public bool Validate<TModel>(TModel model, AbstractValidator<TModel> validator)
        {
            ValidationResult = validator.Validate(model);
            return ValidationResult.IsValid;
        }
    }
}
