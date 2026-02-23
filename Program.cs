internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("CALCULAR CUOTA DE UN PRESTAMO");
        Console.WriteLine("Cual es la cantidad del prestamo?");
        int P = int.Parse(Console.ReadLine());

        Console.WriteLine("Cual es la tasa de interes Anual?");
        Double T = double.Parse(Console.ReadLine());

        Console.WriteLine("Cual es el tiempo a pagar mensual?");
        int PT = int.Parse(Console.ReadLine());

        // Formula:

        double TF = T / 100 / 12;

      Double CP = (P*TF)/(1- Math.Pow(1 + TF, -PT));

        //Resultado:

        Console.WriteLine("Tu cuota del prestamo sera de: "+ CP);

    }
}