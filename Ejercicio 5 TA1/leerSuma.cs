class leerSuma{
    int suma;
    public void leerSum(){
        for (int i = 8; i > 0; i--)
        {
            Console.Write(i+" ");
            suma=i+suma;
        }
        Console.WriteLine("");
        Console.WriteLine("La suma de todos los numeros leidos es "+suma);
    }
}