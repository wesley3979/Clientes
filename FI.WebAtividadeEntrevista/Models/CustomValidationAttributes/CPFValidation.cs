using CpfLibrary;
using System.ComponentModel.DataAnnotations;

namespace WebAtividadeEntrevista.CustomValidationAttributes
{
    public class CPFValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string cpf = value as string;
            if (cpf == null)
                return false;

            return Cpf.Check(cpf);
        }
    }
}
