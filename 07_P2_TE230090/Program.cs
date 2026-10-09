Console.WriteLine("SIMULADOR DE BRAZO ROBOTICO");
Console.WriteLine();

// Crear un objeto de la clase BrazoRobotico
BrazoRobotico brazo1 = new BrazoRobotico();

// Capturar los tiempos de cada etapa
Console.Write("Ingrese el tiempo para tomar la pieza (s): ");
brazo1.TiempoTomar = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el tiempo para trasladar la pieza (s): ");
brazo1.TiempoTrasladar = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el tiempo para soltar la pieza (s): ");
brazo1.TiempoSoltar = Convert.ToDouble(Console.ReadLine());

// Capturar el numero de ciclos
Console.Write("Ingrese el numero de ciclos a simular: ");
int ciclos = Convert.ToInt32(Console.ReadLine());

// Calcular y mostrar el tiempo de un ciclo
double tiempoCiclo = brazo1.CalcularTiempoCiclo();

Console.WriteLine();
Console.WriteLine($"Tiempo de un ciclo: {tiempoCiclo:F2} s");

// Simular la produccion
Console.WriteLine();
brazo1.SimularProduccion(ciclos);


// Definicion de la clase
class BrazoRobotico
{
    // Propiedades
    public double TiempoTomar { get; set; }

    public double TiempoTrasladar { get; set; }

    public double TiempoSoltar { get; set; }


    // Metodo para calcular el tiempo de un ciclo
    public double CalcularTiempoCiclo()
    {
        double tiempoCiclo;

        tiempoCiclo = TiempoTomar
                    + TiempoTrasladar
                    + TiempoSoltar;

        return tiempoCiclo;
    }


    // Metodo para simular la produccion
    public void SimularProduccion(int ciclos)
    {
        double tiempoAcumulado = 0;

        for (int i = 1; i <= ciclos; i++)
        {
            tiempoAcumulado = tiempoAcumulado
                            + CalcularTiempoCiclo();

            Console.WriteLine($"Ciclo: {i}");
            Console.WriteLine(
                $"Tiempo acumulado: {tiempoAcumulado:F2} s");
        }

        // Mostrar el tiempo total de produccion
        Console.WriteLine();
        Console.WriteLine(
            $"Tiempo total de produccion: {tiempoAcumulado:F2} s");
    }
}