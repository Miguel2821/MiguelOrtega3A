class empleado:individuo,ImostrarDatos,IcambioEstado, IcambioImportante{
    public string añoIncorporacion;
    public string despacho;
    public empleado (string nombres, string apellidos, string nui, string statusCivil, string añoIncorporacion, string despacho):base(nombres,apellidos,nui,statusCivil){
        this.añoIncorporacion=añoIncorporacion;
        this.despacho=despacho;
    }
    public void mostrarDatos(){
        Console.WriteLine("Los datos son: \nNombre: "+nombres+"\nApellidos: "+apellidos+"\nNUI: "+nui+"\nEstado Civil: "+statusCivil+"\nAño de Incorporación: "+añoIncorporacion+"\nDespacho: "+despacho);
    }
    public void cambioEstado(){
        string nuevoEstado;
        Console.WriteLine("Ingrese el nuevo estado civil del empleado: ");
        nuevoEstado=Console.ReadLine();
        statusCivil=nuevoEstado;
    }
    public void cambioImportante(){
        string nuevoPuesto;
        Console.WriteLine("Ingrese el nuevo curso del empleado: ");
        nuevoPuesto=Console.ReadLine();
        despacho=nuevoPuesto;
    }

}