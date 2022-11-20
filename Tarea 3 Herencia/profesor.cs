class profesor:individuo,IcambioEstado{
    public string departamento;
    public profesor(string nombres, string apellidos, string nui, string statusCivil, string departamento):base(nombres,apellidos,nui,statusCivil){
        this.departamento=departamento;
    }
    public void mostrarDatos(){
        Console.WriteLine("Los datos son: \nNombre: "+nombres+"\nApellidos: "+apellidos+"\nNUI: "+nui+"\nEstado Civil: "+statusCivil+"\nDepartamento: "+departamento);
    }
    public void cambioEstado(){
        string nuevoEstado;
        Console.WriteLine("Ingrese el nuevo estado civil del profesor: ");
        nuevoEstado=Console.ReadLine();
        statusCivil=nuevoEstado;
    }
    public void cambioImportante(){
        string nuevoPuesto;
        Console.WriteLine("Ingrese el nuevo curso del profesor: ");
        nuevoPuesto=Console.ReadLine();
        departamento=nuevoPuesto;
    }
}