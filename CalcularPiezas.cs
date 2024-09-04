

namespace TareaWhiile.TareasWhile
{
    public class CalcularPiezas
    {
        public void CalcularHierro()

        {

            try
            {
                int cantidadPiezas = 0;
                int piezasAptas = 0;
                double longitud = 0;
                int contador = 0;

                Console.WriteLine("Introduzca la cantidad de piezas de hierro :");
                cantidadPiezas = int.Parse(Console.ReadLine());

                
                while (contador < cantidadPiezas)
                {
                    Console.WriteLine($"Introduzca la longitud de la pieza  de hierro{contador + 1}:");
                    longitud = double.Parse(Console.ReadLine());

                    // Verificar si la longitud esta en  rango entre 1.20 y 1.30
                    if (longitud >= 1.20 && longitud <= 1.30)
                    {
                        piezasAptas++;
                    }

                    contador++;
                }

                Console.WriteLine($"Numero de piezas aptas : {piezasAptas}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Entrada invalida, favor de ingresar numeros correctamente");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo un error inesperado:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}