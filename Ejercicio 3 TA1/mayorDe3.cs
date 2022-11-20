class mayorDe3{
    public double num1;
    public double num2;
    public double num3;
    public mayorDe3(double num1, double num2, double num3){
        this.num1=num1;
        this.num2=num2;
        this.num3=num3;
    }
    public void calcularMayor(){
        double mayor=num1;
        if (num1>num2 && num1>num3)
            {Console.WriteLine("El numero mayor es "+num1);}
        if (num2>num1 && num2>num3)
            {Console.WriteLine("El numero mayor es "+num2);}
        if (num3>num1 && num3>num2)
            {Console.WriteLine("El numero mayor es "+num3);}
    }
}