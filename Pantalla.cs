using System.Drawing;
namespace git;


class Program
{
    static void Main()
    {
        
        // Creo instancia de la figura rectangulo y calculo su area
        Rectangulo rectangulo = new Rectangulo(10,10,Color.Aquamarine);
        // Mostrar información 
        Console.WriteLine(rectangulo.ToString());
        //Calculamos el area
        System.Console.WriteLine("El area del rectangulo es de "+rectangulo.GetArea());
        // Creo instancia de la figura circulo y calculo su area
        Circulo circulo = new Circulo(10,Color.AliceBlue);
        // Mostrar información 
        System.Console.WriteLine(circulo.ToString());
        //Calculamos el area
        System.Console.WriteLine("El area del circulo es de "+circulo.GetArea());
        // Creo instancia de la figura triangulo y calculo su area
        TrianguloEquilatero trianguloEquilatero = new TrianguloEquilatero(6,Color.AliceBlue);
        // Mostrar información
        System.Console.WriteLine(trianguloEquilatero);
        // Creo instancia de la figura triangulo y calculo su area
        System.Console.WriteLine("El area del triangulo es de "+trianguloEquilatero.GetArea());

        //Ahora modificaremos los valores de los elementos en triangulo
        rectangulo.SetDimensiones(5,5);
        System.Console.WriteLine(rectangulo);
        //Ahora modificaremos los valores de los elementos en circulo
        circulo.SetRadio(5);
        System.Console.WriteLine(circulo.ToString());
        //Ahora modificaremos los valores de los elementos en triangulo
        trianguloEquilatero.SetLado(3);
        System.Console.WriteLine(trianguloEquilatero.ToString());
         List<Figura> lista_figuras = new List<Figura>();
         lista_figuras.Add(new Rectangulo(20,20,Color.Aqua));
         lista_figuras.Add(new Circulo(20,Color.Beige));
         lista_figuras.Add(new TrianguloEquilatero(20,Color.Bisque));
         double areatotal=0;
         foreach (Figura ev in lista_figuras)
            {
                Console.WriteLine(ev+"   "+ev.Color.ToString());
                areatotal=ev.GetArea();

            }
            System.Console.WriteLine("El area total es de: "+areatotal);

            
    }
}

