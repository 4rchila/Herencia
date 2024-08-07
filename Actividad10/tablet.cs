using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad10
{
    public class Tablet : Telefono
    {
        public Tablet(int id, string tipopantalla, string memoriaram, string sistemaoperativo, string almacenamiento) : base(id, tipopantalla, memoriaram, sistemaoperativo, almacenamiento)
        {

        }
        public void CuadernoDigital() 
        {
            Console.WriteLine("Iniciando Cuaderno Digital....");
        }
    }

}
