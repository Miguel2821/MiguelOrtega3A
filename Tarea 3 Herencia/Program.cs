internal class Program
{
    private static void Main(string[] args)
    {
        estudiante est1 = new estudiante("Miguel", "Ortega", "0918423674", "Soltero", "A");
        est1.mostrarDatos();
        Console.WriteLine("====================");
        //primera muestra de datos
        est1.cambioEstado();
        est1.cambioImportante();
        //se cambia el estado civil
        est1.mostrarDatos();
        //Se muestran los datos de nuevo para mostrar los cambios realizados
        //lo mismo para cada tipo de individuo
        Console.WriteLine("==================================");
        empleado empleado1 = new empleado("fruncio", "lopez", "0918423674", "Soltero", "2015", "Limpieza");
        empleado1.mostrarDatos();
        Console.WriteLine("====================");
        empleado1.cambioEstado();
        empleado1.cambioImportante();        
        empleado1.mostrarDatos();
        Console.WriteLine("==================================");
        personalServicio servicio1 = new personalServicio("Jose", "Perez", "0947236955", "Casado", "Secretaria");
        servicio1.mostrarDatos();
        Console.WriteLine("====================");
        servicio1.cambioEstado();
        servicio1.cambioImportante();
        servicio1.mostrarDatos();
        Console.WriteLine("==================================");
        profesor profesor1 = new profesor("Gabriel","Cuenca", "1318482590", "Soltero", "Fisica");
        profesor1.mostrarDatos();
        Console.WriteLine("====================");
        profesor1.cambioEstado();
        profesor1.cambioImportante();
        profesor1.mostrarDatos();



    }
}