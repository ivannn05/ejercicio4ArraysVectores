namespace ejercicio4ArraysVectores;

class Program
{
    public static void Main(string[] args)
    {
        int numeroUsu;
        Console.WriteLine("Escriba eltamaño del vector ");
        numeroUsu = Convert.ToInt32(Console.ReadLine());
    
        double[] matriz = new double[numeroUsu];
       

        Random numero = new Random();

        for (int i = 0; i < matriz.Length; i++)
        {
            matriz[i] = numero.Next();

            Console.WriteLine(matriz[i]);
        }
        
    }
}