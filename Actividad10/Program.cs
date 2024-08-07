
using Actividad10;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Mostrando productos");

        Telefono NuevoCelular = new Telefono(314, "LCD", "8 ram", "IMUI", "200GB");

        NuevoCelular.mostrarInfo();

        Tablet NuevaTable = new Tablet(3116, "LCD", "12 ram", "Android", "250GB");
        NuevaTable.mostrarInfo();
        NuevaTable.llamar();
        NuevaTable.CuadernoDigital();

        Ordenador NuevoOrdenador = new Ordenador(213, "IPS", "16 Ram","Windows","1g","Intel Core i9-13900K");
        NuevoOrdenador.mostrarInfo();
        NuevoOrdenador.Encender();

        Console.WriteLine("Quieres realizar una llamada con el telefono S/N");
        var respuesta = Console.ReadLine().ToLower();

        try
        {
            if (respuesta == "s")
            {
                NuevoCelular.llamar();
                Console.WriteLine("gracias por usar el programa");
            }
            else
            {
                Console.WriteLine("Bien, gracias por usar el programa....");
            }
        } catch (Exception ex) {
            Console.WriteLine(ex.Message + "Error....");
        }
    }
}