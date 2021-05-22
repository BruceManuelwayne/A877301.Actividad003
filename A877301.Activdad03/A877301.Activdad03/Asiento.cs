using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A877301.Activdad03
{
    class Asiento
    {
        public int NumeroAsiento { get; set; }

        public int CodigoCuenta { get; set; }

        public DateTime Fecha { get; set; }

        public decimal Debe { get; set; }

        public decimal Haber { get; set; }

        public Asiento(int nroAsiento, DateTime fecha, int codigoCuenta, decimal debe, decimal haber)
        {
            NumeroAsiento = nroAsiento;
            Fecha = fecha;
            CodigoCuenta = codigoCuenta;
            Debe = debe;
            Haber = haber;
        }
        public Asiento() { }

        
    }
}
