class numMayor{
    double num1;
    double num2;
    public numMayor(double num1, double num2){
        this.num1=num1;
        this.num2=num2;
    }
    public void encontrarMayor(){
        if (num1>num2){
            Console.WriteLine("El numero mayor es "+num1);
        }
        else{
            Console.WriteLine("El numero mayor es "+num2);
        }
    }
}