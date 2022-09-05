int respuesta;
int cantidad;
int total=0;
Console.WriteLine("Que producto desea comprar");
Console.WriteLine("1:Zapatos Gucii $80000");
Console.WriteLine("2:Zapatos Adidas $40000");
Console.WriteLine("3:Zapatos Nike $30000");
  respuesta=Convert.ToInt32(Console.ReadLine());

switch (respuesta)
{
    case 1: 
    Console.WriteLine("zapatos gucci");
    Console.WriteLine("Cuantos zapatos gucci?");
    cantidad=Convert.ToInt32(Console.ReadLine());
    total=cantidad*80000;
    break;
    
    case 2:
    Console.WriteLine("zapatos adidas");
     Console.WriteLine("Cuantos zapatos adidas?");
    cantidad=Convert.ToInt32(Console.ReadLine());
    total=cantidad*40000;
    break;

    case 3:
    Console.WriteLine("zapatos nike");
     Console.WriteLine("Cuantos zapatos nike?");
    cantidad=Convert.ToInt32(Console.ReadLine());
    total=cantidad*30000;
    break;


}

Console.WriteLine("Total a pagar "+total);







