class mediaNumeros{
    public int total;
    public double suma;
    public double media;
    public void calcularMedia(){
        Console.WriteLine("Se imprimiran los numeros del 1 al 10 y luego se calculara la media aritmetica con dichos numeros");
        for (int i = 1; i < 11; i++)
        {
            total++;
            Console.Write(i+" ");
            suma=suma+i;
        }
        media=suma/total;
        Console.WriteLine("\nLa media aritmetica de los numeros impresos es: "+media);
    }
}