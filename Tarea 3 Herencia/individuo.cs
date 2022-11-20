class individuo{
    public string nombres;
    public string apellidos;
    public string nui;
    //nui = Número Único de Identificación (cedula)
    public string statusCivil;
    public individuo(string nombres, string apellidos, string nui, string statusCivil){
        this.nombres=nombres;
        this.apellidos=apellidos;
        this.nui=nui;
        this.statusCivil=statusCivil;
    }
}