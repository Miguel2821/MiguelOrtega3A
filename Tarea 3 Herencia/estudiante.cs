class estudiante:individuo, IcambioEstado, IcambioImportante{
    public string curso;
    public estudiante(string nombres, string apellidos, string nui, string statusCivil, string curso):base(nombres,apellidos,nui,statusCivil){
        this.curso=curso;
    }
    public void mostrarDatos(){
        Console.WriteLine("Los datos son: \nNombre: "+nombres+"\nApellidos: "+apellidos+"\nNUI: "+nui+"\nEstado Civil: "+statusCivil+"\nCurso: "
        +curso);
    }
    public void cambioEstado(){
        string nuevoEstado;
        Console.WriteLine("Ingrese el nuevo estado civil del estudiante ");
        nuevoEstado=Console.ReadLine();
        statusCivil=nuevoEstado;
    }
    public void cambioImportante(){;
        string nuevoPuesto;
        Console.WriteLine("Ingrese el nuevo curso del estudiante ");
        nuevoPuesto=Console.ReadLine();
        curso=nuevoPuesto;
    }

}