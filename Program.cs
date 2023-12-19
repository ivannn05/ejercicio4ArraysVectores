namespace ejercicio4ArraysVectores;

class Program
{
    public static void Main(string[] args)
    {
        int numeroUsu;
        Console.WriteLine("Escriba eltamaño del vector ");
        numeroUsu = Convert.ToInt32(Console.ReadLine());
    
        double[] vector = new double[numeroUsu];
       

        Random numero = new Random();

        for (int i = 0; i < vector.Length; i++)
        {
            vector[i] = numero.Next(50);
           
        }
        Array.Sort(vector);

        for (int i = 0; i < vector.Length; i++)
        {
            Console.WriteLine(vector[i]);

        }


    }
}