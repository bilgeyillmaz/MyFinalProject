using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType) 
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir doğrulama sınıfı değildir.");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation) //methodinterception onbefore override
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType); //Reflection
            var entityType = _validatorType.BaseType.GetGenericArguments()[0]; //ProductValidator çalışma tipini bul, BaseType+ GenericÇalışmaTipi --->AbstractValidator<Product> 
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);//ilgili metodun parametreleri --> Add(Product product) gibi
            foreach (var entity in entities)// her bir parametreyi tek tek gez
            {
                ValidationTool.Validate(validator, entity);//ValidationTool kullanarak kontrol et
            }
        }
    }
}
