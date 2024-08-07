using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad10
{
    public class Ordenador : ProductosElectronicos
    {
        public string PotenciaProcesador { get; set; }
        public Ordenador(int id, string tipopantalla, string memoriaram, string sistemaoperativo, string almacenamiento, string poteciaprocesador) : base(id, tipopantalla, memoriaram, sistemaoperativo, almacenamiento)
        {
            this.PotenciaProcesador = poteciaprocesador;
        }
        public void Encender() 
        {
            Console.WriteLine("Encendiendo computador.....");
        }
    }
}
