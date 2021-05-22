using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace A877301.Activdad03
{
    public class Cuenta
    {

        public int Codigo { get; set; }
        public string Nombre { get; set; }

        public string Tipo { get; set; }

        List<Cuenta> cuentas = new List<Cuenta>(); 

       
        public Cuenta() { }

        public Cuenta(string linea)
        {
            var datos = linea.Split('|');
            Codigo = int.Parse(datos[0]);
            Nombre = datos[1];
            Tipo = datos[2];
        }
        //internal void leerPlanDeCuentas()
        //{
        //    string filePath = Path.Combine(Directory.GetCurrentDirectory(), "PlanDeCuentas.txt");
        //    string[] lines = File.ReadAllLines(filePath);
        //    if (File.Exists(filePath))
        //    {
        //        using (var reader = new StreamReader(filePath))
        //        {
        //            while (!reader.EndOfStream)
        //            {
        //                var linea = reader.ReadLine();
        //                if (linea == "codigo|nombre|tipo")
        //                {
        //                    continue;
        //                }
        //                else
        //                {
        //                    var cuenta = new Cuenta(linea);
        //                    cuentas.Add(cuenta);
        //                }


        //            }


        //        }
        //    }
        //}
       
    }
}