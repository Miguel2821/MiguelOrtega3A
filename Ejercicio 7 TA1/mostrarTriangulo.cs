class mostrarTriangulo{
    int lado1;
    int lado2;
    int lado3;
    public void mostrarTriangulos(){
        string eleccion;
        do{
            Console.WriteLine("Ingrese el lado 1:");
            lado1 = int.Parse(Console.ReadLine());
            //para converitr la entrada a entero
            Console.WriteLine("Ingrese el lado 2:");
            lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el lado 3:");
            lado3 = int.Parse(Console.ReadLine());
            if (lado1==lado2 && lado1==lado3)
                {Console.WriteLine("El triangulo es Equilatero");}
            else {
                if (lado1!=lado2 && lado1!=lado3)
                    {Console.WriteLine("El triangulo es Escaleno");}
                else {
                    Console.WriteLine("El triangul es Isosceles");
                }
            }


            Console.WriteLine("==========================");
            Console.WriteLine("Desea volver a hacerlo \nEscriba 1 para intentar de nuevo, cualquier otra tecla si desea terminar");
            eleccion=Console.ReadLine();
        }while (eleccion=="1");
    }
}