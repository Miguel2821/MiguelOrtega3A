class calcFactorial{
    public int fact;
    public int num;
    public void calcularFactorial(){
        Console.WriteLine("Ingrese el numero para calcular su factorial:");
        num = int.Parse(Console.ReadLine());
        if (num==0){
            Console.WriteLine("El factorial de 0 es 1");
        }
        else{
            fact=num;
            for (int i = num; i > 1; i--)
            {
                fact=fact*(i-1);
            }
            Console.WriteLine("El factorial de "+num+" es "+fact);
            
        }
        //
    }
}