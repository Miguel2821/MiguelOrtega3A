public abstract class CarroBase{
    public string? modelo {get; set;}
    public string? color {get; set;}
    //Es el metodo que se va a usar para clonar el carro
    public abstract CarroBase Clonar();
    //Metodo para mostrar los datos del carro
    public abstract string mostrarAuto();
}