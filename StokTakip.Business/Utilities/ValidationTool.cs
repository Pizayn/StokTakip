﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.DataAccess.Abstract;


namespace StokTakip.Business.Utilities
{
    public  static class ValidationTool
    {
        public static void Validate(IValidator validator, IEntity entity)
        {
            var result = validator.Validate(entity);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }

          
    }
}
