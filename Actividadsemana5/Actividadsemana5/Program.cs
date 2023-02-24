// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int dato1, dato2;
Console.WriteLine("Ingresar el primer numero");
dato1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
dato2 = Convert.ToInt32(Console.ReadLine());


//Numeros pares 
Console.WriteLine($"Los numeros pares entre los datos ingresados  {dato1} y {dato2} son:");
for (int i = dato1;  i<= dato2; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
    
       

