using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace A877301.Activdad03
{
     class LibroDiario
    {
        public string appDataPath { get; set; }
        public string path { get; set; }
        public string pathtxt { get; set; }
       
        public int NumeroAsiento { get; set;  }

        public int CodigoCuenta { get; set;  }

        public DateTime Fecha { get; set;  }

        public decimal Debe { get; set;  }

        public decimal Haber { get; set;  }
        List<LibroDiario> libroDiario = new List<LibroDiario>();

        List<Asiento> asientos = new List<Asiento>(); 

        const string nombreArchivo = "LibroDiario.txt";

     

        public LibroDiario() 
        {
        }

        public LibroDiario(int nroAsiento, DateTime fecha, int codigoCuenta, decimal debe, decimal haber) 
        {
            NumeroAsiento = nroAsiento;
            Fecha = fecha;
            CodigoCuenta = codigoCuenta;
            Debe = debe;
            Haber = haber; 
        }
        public LibroDiario(string linea)  
        {
            var datos = linea.Split('|');
            NumeroAsiento = int.Parse(datos[0]);
            Fecha = DateTime.Parse(datos[1]);
            CodigoCuenta = int.Parse(datos[2]);
            Debe = decimal.Parse(datos[3]);
            Haber = decimal.Parse(datos[4]);

        }

        public void crearLibroDiarioArchivo() 
        {
            if (File.Exists(nombreArchivo)) 
            {
                using (var reader = new StreamReader(nombreArchivo)) 
                {
                    while (!reader.EndOfStream) 
                    {
                        var linea = reader.ReadLine();
                        if (linea == "NroAsiento | Fecha | CodigoCuenta | Debe | Haber")
                        {
                            continue;
                        }
                        else
                        {
                            var diario = new LibroDiario(linea);
                            libroDiario.Add(diario); 
                        }
                    }
                }
            }
        }

        public void Iniciar() 
        {
            const string asientoDebe = "d";
            const string asientoHaber = "h"; 
            
            bool salir = false;
            do
            {

                Console.WriteLine();
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("-------------");
                Console.WriteLine("1- Ingresar Asiento Contable");
                Console.WriteLine("2-Mostrar Libro Diario");
                Console.WriteLine("3- Salir");

                Console.WriteLine("Ingrese una opcion y presione [Enter]");
                var opcion = Console.ReadLine();

                switch (opcion)
                {
                    

                }

            } while (!salir);

        }
        
    }
}
