using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace A877301.Activdad03
{
     class PlanDeCuentas
    { 
        List<Cuenta> planDeCuentas = new List<Cuenta>();
        const string nombreArchivo = "PlanDeCuentas.txt";


        public  PlanDeCuentas() 
        {
            if (File.Exists(nombreArchivo))
                using (var reader = new StreamReader(nombreArchivo))
                {
                    while (!reader.EndOfStream)
                    {
                        var linea = reader.ReadLine();
                        if (linea == "Codigo|Nombre|Tipo")
                        {
                            continue;
                        }
                        else
                        {
                            var cuenta = new Cuenta(linea);
                            planDeCuentas.Add(cuenta);
                        }
                        
                    }
                }



        }
        //public void MostrarPlan() 
        //{
        //    using (var reader = new StreamReader(nombreArchivo)) 
        //    {
        //        while (!reader.EndOfStream) 
        //        {
        //            var linea = reader.ReadLine();
        //            Console.WriteLine(linea); 
        //        }
        //    }
        //}
      

        public void ListarPlan() 
        {
            Console.WriteLine("****************\nPLAN DE CUENTAS:\n****************");
            foreach (Cuenta cuenta in planDeCuentas)
            {
                Console.WriteLine($"Código = {cuenta.Codigo} - {cuenta.Nombre} - {cuenta.Tipo}");
            }

        }


    }
}
