using EntityLayer.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PersonValidator : AbstractValidator<PersonModel>
    {
        public PersonValidator()
        {
            RuleFor(x => x.Person.Name).NotEmpty().WithMessage("Çalışan adını boş geçemezsiniz!");
            //RuleFor(x => x.LastName).NotEmpty().WithMessage("Çalışan soyadını boş geçemezsiniz!");
            //RuleFor(x => x.FirstName).MinimumLength(2).WithMessage("Çalışan adı 2 karakterden kısa olamaz!");
            //RuleFor(x => x.FirstName).MaximumLength(20).WithMessage("Çalışan adı 20 karakterden uzun olamaz!");
            //RuleFor(x => x.LastName).MinimumLength(2).WithMessage("Çalışan adı 2 karakterden kısa olamaz!");
            //RuleFor(x => x.LastName).MaximumLength(20).WithMessage("Çalışan adı 20 karakterden uzun olamaz!");
        }
    }
}
