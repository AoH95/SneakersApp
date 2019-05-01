using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SneakersApp.Data;
using SneakersApp.Models;

namespace SneakersApp.Class.Validator
{
    public class MaxWeightAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            if (value != null)
            {
                int fileSize = (int)value;

                if (fileSize < 4000)
                {
                    return ValidationResult.Success;
                }

            }
                return new ValidationResult("la taille du fichier dépasse 4mo");


        }
    }
}
