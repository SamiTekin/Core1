using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules;

public class WriterValidator:AbstractValidator<Writer>
{
    public WriterValidator()
    {
        RuleFor(x => x.WriterName).NotEmpty().WithMessage("İsim boş geçilemez");
        RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
        RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez");
        RuleFor(x => x.WriterMail).Must(x => x != null && x.EndsWith("@giresun.edu.tr")).WithMessage("Mail adresi @giresun.edu.tr ile bitmelidir");
    }
}
