public class Ford: CarroBase{
    //se implementa el metodo para clonar
    public override CarroBase Clonar()
    {
        return (Ford)this.MemberwiseClone();
    }
   //se implementa el metodo para mostrar los datos
    public override string mostrarAuto()
    {
        return "Ford "+modelo+" Color "+color;
    }
}