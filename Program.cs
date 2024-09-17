
using SytemNomina.SueldoEmpleado;

class ProgramaNomina
{
    static void Main(string[] args)
    {
        
        List<Empleado> empleados = new List<Empleado>
        {
            new EmpleadoAsalariado("Angel", "Marte", "999-00-1221", 1000M),
            new EmpleadoPorHoras("Ana", "Baez", "227-20-2242", 200M, 450M),
            new EmpleadoPorComision("Ana", "Imenenez", "333-33-3333", 10000M, 0.06M),
            new EmpleadoBaseMasComision("Juan", "Perez", "404-00-5964", 5000M, 0.04M, 300M)
        };


        foreach (Empleado empleado in empleados)
        {
            Console.WriteLine(empleado);
            Console.WriteLine($"Ingresos: {empleado.Ingresos():C}\n");
        }
    }
}

