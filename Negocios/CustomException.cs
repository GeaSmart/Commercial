using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentValidation.Results;

namespace Negocios
{
    [Serializable]
    public class CustomException:Exception
    {
        public List<ExceptionPair> tupla { get; set; }
        
        public CustomException(List<ExceptionPair> tupla)
            : base() {
            this.tupla = tupla;
        }

        public CustomException(string message)
            : base(message) { }

        public static List<ExceptionPair> getMensajeList(ValidationResult result)
        {
            List<ExceptionPair> listita = new List<ExceptionPair>();
            foreach (var aviso in result.Errors)
            {
                ExceptionPair o = new ExceptionPair();
                o.name = aviso.PropertyName;
                o.message = aviso.ErrorMessage;
                listita.Add(o);
            }
            return listita;
        }
    }

    public class ExceptionPair
    {
        public string name { get; set; }
        public string message { get; set; }
    }
}
