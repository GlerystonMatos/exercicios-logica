class URI
{
    static void Main(string[] args)
    {
        int tempoEmSegundos = 0;

        const int HORA_EM_SEGUNDOS = (60 * 60);
        const int MINUTO_EM_SEGUNDOS = 60;

        int.TryParse(Console.ReadLine(), out tempoEmSegundos);

        int horas = (int)(tempoEmSegundos / HORA_EM_SEGUNDOS);
        int horasLidasEmSegundos = (horas * HORA_EM_SEGUNDOS);
        int minutos = (int)((tempoEmSegundos - horasLidasEmSegundos) / MINUTO_EM_SEGUNDOS);
        int minutosLidosEmSegundos = (minutos * MINUTO_EM_SEGUNDOS);
        int segundos = (int)(tempoEmSegundos - horasLidasEmSegundos - minutosLidosEmSegundos);

        Console.Write("{0}:{1}:{2}\n", horas, minutos, segundos);
    }
}