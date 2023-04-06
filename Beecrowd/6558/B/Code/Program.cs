using System;

class URI
{
    static void Main(string[] args)
    {
        int tempoEmSegundos = 0;

        const int HORA_EM_SEGUNDOS = 3600;
        const int MINUTO_EM_SEGUNDOS = 60;

        int.TryParse(Console.ReadLine(), out tempoEmSegundos);

        int horas = tempoEmSegundos / HORA_EM_SEGUNDOS;
        tempoEmSegundos %= HORA_EM_SEGUNDOS;

        int minutos = tempoEmSegundos / MINUTO_EM_SEGUNDOS;
        tempoEmSegundos %= MINUTO_EM_SEGUNDOS;

        int segundos = tempoEmSegundos;

        Console.WriteLine($"{horas}:{minutos}:{segundos}");
    }
}