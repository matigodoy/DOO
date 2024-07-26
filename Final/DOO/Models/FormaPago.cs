using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOO.Models
{
    public abstract class FormaPago
    {
        public int FormaPagoId { get; set; }
        public double Monto { get; set; }
    }
}
