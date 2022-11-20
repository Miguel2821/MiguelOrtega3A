class personalServicio:individuo,IcambioEstado{
    public string seccion;
    public personalServicio(string nombres, string apellidos, string nui, string statusCivil, string seccion):base(nombres,apellidos,nui,statusCivil){
        this.seccion=seccion;
    }
    public void mostrarDatos(){
        Console.WriteLine("Los datos son: \nNombre: "+nombres+"\nApellidos: "+apellidos+"\nNUI: "+nui+"\nEstado Civil: "+statusCivil+"\nSección: "+seccion);
    }
    public void cambioEstado(){
        string nuevoEstado;
        Console.WriteLine("Ingrese el nuevo estado civil del personal de servicio: ");
        nuevoEstado=Console.ReadLine();
        statusCivil=nuevoEstado;
    }
    public void cambioImportante(){
        string nuevoPuesto;
        Console.WriteLine("Ingrese el nuevo curso del personal de servicio: ");
        nuevoPuesto=Console.ReadLine();
        seccion=nuevoPuesto;
    }
}