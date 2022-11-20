class par{
    public int num;
    public par(int num){
        this.num=num;
    }
    public void calcularPar(){
        if (num%2 == 0){
            Console.WriteLine("El numero "+num+" si es par");
        }
        else{
            Console.WriteLine("El numero "+num+" no es par");
        }
    }
}