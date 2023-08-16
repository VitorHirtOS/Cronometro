using System;
using System.Threading;

namespace Program
{
    class Cronometro
    {

        public static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Sua acão sim ou não para preseguir no programa");
                string acao = Console.ReadLine();
                if (acao == "sim")
                {
                    Menu(0, 0, 0);
                }else if (acao == "nao")
                {
                    Console.WriteLine("Encerrando");
                    break;
                }
            }

            Thread.Sleep(2500);
            Console.WriteLine("Finalizou o software");
            
        }

        public static int Menu(int segundos, int minutos, int temp)
        {
           
            Console.WriteLine("S = Segundos");
            segundos =  int.Parse(Console.ReadLine());
            Console.WriteLine("M = Minuto");
            minutos = int.Parse(Console.ReadLine());
            Console.WriteLine("Quanto tempo deseja contar? ");
            temp = int.Parse(Console.ReadLine());
            
            // ToLower() -> transforma tudo em minúsculo
            // string texto = "Vitor";
            // string new = texto.Substring(0, texto.length) -> Pegar o primeiro valor e o final 
            // System.Enviroment.Exit() -> para sair do programa
            
            return  Start(segundos, minutos, temp); // Type Reference
        }

        private static int Start(int segundos, int minutos, int temp)
        {

            var c = 0;
            
            while (c <= temp)
            {
                
                Console.WriteLine($"{temp}:{minutos += 1}:{segundos +=1}");
                Thread.Sleep(1000);
                c++;
            }
            
            int soma = Somar();     
            Console.WriteLine($"A multiplicação é: {soma}");
            
            Console.WriteLine("Stop Finalizado");
            return soma;
       
        }

        private static int Somar()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            
            return x * y;
        }
    }
}