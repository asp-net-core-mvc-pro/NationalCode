using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace NationalCodeValidation.Validations
{
    public class NationalCodeValidatorAttribute : Attribute, IModelValidator
    {
        public string ErrorMessage { get; set; }

        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
            var nationalCode = (string)context.Model;

            if (!string.IsNullOrEmpty(nationalCode) && nationalCode.Length == 10)
            {
                return Enumerable.Empty<ModelValidationResult>();
            }

            return new List<ModelValidationResult>
            {
                new ModelValidationResult(context.ModelMetadata.PropertyName, ErrorMessage)
            };
        }
    }
}
