
namespace TareaWhiile.PpromedioAritmético
{
    public class CalcularEnteros
    {
        public void CalcularNumeros()
        {
            try
            {
                int suma = 0;
                int contador = 0;
                int numero = 0; ;
                double promedio = 0;
                while (contador < 10)
                {
                    Console.Write("Ingrese un numero entero: ");
                    if (int.TryParse(Console.ReadLine(), out numero))
                    {
                        suma += numero;
                        contador++;
                    }
                    else
                    {
                        Console.WriteLine("Por favor, ingrese un número válido.");
                    }
                }

                 promedio = (double)suma / 10;

                Console.WriteLine($"La suma de los numeros es: {suma}");
                Console.WriteLine($"El promedio aritmetico es: {promedio}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio un error: {ex.Message}");
            }
        }
    }
}