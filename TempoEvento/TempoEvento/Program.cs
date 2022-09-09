using System;

namespace TempoEvento {
    class Program {
        static void Main(string[] args) {
            for (int i = 0; i < 3; i++) {

                int diainicio, diafinal, horainicio, minutoinicio, segundoinicio, horafinal, minutofinal, segundofinal, dias, horas, minutos, segundos;

                Console.Write("Digite o primeiro dia: ");
                diainicio = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Horário no formato HH:MM:SS");
                string[] vetor = Console.ReadLine().Split(':');
                horainicio = int.Parse(vetor[0]);
                minutoinicio = int.Parse(vetor[1]);
                segundoinicio = int.Parse(vetor[2]);

                Console.Write("Digite o segundo dia: ");
                diafinal = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Horário no formato HH:MM:SS");
                string[] vetor1 = Console.ReadLine().Split(':');
                horafinal = int.Parse(vetor1[0]);
                minutofinal = int.Parse(vetor1[1]);
                segundofinal = int.Parse(vetor1[2]);

                dias = (diafinal - diainicio) - 1;

                horas = 24 - (horainicio - horafinal);

                minutos = minutofinal - minutoinicio;

                segundos = segundofinal - segundoinicio;

                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Duração do evento:");
                Console.WriteLine(dias + " Dia(s)");
                Console.WriteLine(horas + " Horas(s)");
                Console.WriteLine(minutos + " Minuto(s)");
                Console.WriteLine(segundos + " Segundos(s)");
            }
        }
    }
}