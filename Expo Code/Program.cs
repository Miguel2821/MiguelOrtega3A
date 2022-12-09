internal class Program
{
    private static void Main(string[] args)
    {
        //Se crea un objeto de carro ford, se le asignan caracteristicas y se muestran
        CarroBase ford_base = new Ford();
        ford_base.color ="Rojo";
        ford_base.modelo="Explorer";
        Console.WriteLine(ford_base.mostrarAuto());
        //Se crea un objeto de tipo carrobase que va a ser clonado
        CarroBase fordclon;
        //Se ejecuta el metodo para clonar y en este caso se le asignan nuevos valores
        fordclon = ford_base.Clonar();
        fordclon.color="Blanco";
        fordclon.modelo="Onix Turbo";
        //se muestra el objeto clonado con los nuevos valores
        Console.WriteLine(fordclon.mostrarAuto());
        //Se crea un nuevo carro en este caso uno nissan y se le asignan sus caracteristicas
        CarroBase nissan_base = new Nissan();
        nissan_base.color="Rojo";
        nissan_base.modelo="X-Trail";
        //Se crea un nuevo objeto de carro para la clonacion
        CarroBase nissanclon;
        //Se muestran los datos del carro clonado
        nissanclon = nissan_base.Clonar();

    }
}