using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad10
{
    public class ProductosElectronicos
    {
        public int ID { get; set; }
        public string TipoPantalla { get; set; }
        public string MemoriaRam { get; set; }
        public string SistemaOperativo { get; set; }
        public string Almacenamiento { get; set; }

        public ProductosElectronicos(int id, string tipopantalla, string memoriaram, string sistemaoperativo, string almacenamiento)
        {
            this.ID = id;
            this.TipoPantalla = tipopantalla;
            this.MemoriaRam = memoriaram;
            this.SistemaOperativo = sistemaoperativo;
            this.Almacenamiento = almacenamiento;
        }
        public void mostrarInfo() 
        {
            Console.WriteLine($"El ID del producto es: {ID}");
            Console.WriteLine($"El tipo de pantalla es: {TipoPantalla}");
            Console.WriteLine($"La memoria ram es de: {MemoriaRam}");
            Console.WriteLine($"El tipo de sistema operativo es: {SistemaOperativo}");
            Console.WriteLine($"La capacidad de almacenamiento es: {Almacenamiento}");
        }

    }
}
