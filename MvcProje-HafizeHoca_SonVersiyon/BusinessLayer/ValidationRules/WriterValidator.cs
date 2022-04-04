using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar Soyadını boş geçemezsiniz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkımdayı boş geçemezsin");
            RuleFor(x => x.WriterAbout).MinimumLength(50).WithMessage("En az 50 karakter girişi yapın");
            RuleFor(x => x.WriterAbout).MaximumLength(200).WithMessage("En çok 200 karakter girişi yapın");
            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("En az 2 karakter girişi yapın");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("En çok 50 karakter girişi yapın");

       
        }


    }
}
