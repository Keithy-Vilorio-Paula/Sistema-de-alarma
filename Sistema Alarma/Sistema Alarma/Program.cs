using System;

class Program
{
    // Delegado para el evento de activación de la alarma
    public delegate void AlarmEventHandler(object sender);

    // Evento de activación de la alarma
    public static event AlarmEventHandler AlarmActivated;

    static void Main(string[] args)
    {
        // Configuración del contador
        int counter = 0;
        int threshold = 5; //  se configura el Umbral para activar la alarma

        // Bucle para simular el incremento del contador
        while (true)
        {
            counter++;
            Console.WriteLine($"Contador: {counter}");

            // Comprobar si se ha alcanzado el umbral para activar la alarma
            if (counter >= threshold)
            {
                // Disparar el evento de activación de la alarma
                AlarmActivated?.Invoke(null);
                break; // Salir del bucle una vez que se activa la alarma
            }

            // Esperar medio segundo antes de la siguiente iteración
            System.Threading.Thread.Sleep(500);
        }

        Console.WriteLine("Alarma activada. Presiona cualquier tecla para salir.");
        Console.ReadKey();
    }
}
