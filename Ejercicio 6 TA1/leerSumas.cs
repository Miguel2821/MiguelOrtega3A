class leerSumas{

    int suma;
    int numInicial;
    public leerSumas(int numInicial){
        this.numInicial=numInicial;
    }
    public void leerSum(){
        for (int i = numInicial; i > 0; i--)
        {
            Console.Write(i+" ");
            suma=i+suma;
        }
        Console.WriteLine("");
        Console.WriteLine("La suma de todos los numeros leidos es "+suma);
    }
}