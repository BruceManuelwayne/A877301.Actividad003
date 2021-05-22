using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A877301.Activdad03
{
    class Program
    {
        static void Main(string[] args)
        {
            PlanDeCuentas planDeCuentas = new PlanDeCuentas(); 
            List<Cuenta> cuentas = new List<Cuenta>();
            //lanDeCuentas.leerPlanDeCuentas();
            planDeCuentas.ListarPlan();
            //planDeCuentas.MostrarPlan();
            Console.ReadKey(); 
        }
    }
}
