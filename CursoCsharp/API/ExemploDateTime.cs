using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.API
{
    class ExemploDateTime
    {
        public static void Executar() {
            var dateTime = new DateTime(year: 2030, month:2, day:6);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);


            // para pegar uma data sem hora
            //.today para pegar a data de hoje
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);


            //com hora
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine("Hora: " + diaAtual.Hour);
            Console.WriteLine("Minuto: " + diaAtual.Minute);
            Console.WriteLine("Segundos: " + diaAtual.Second);

            //para pegar o dia de amanhã, o numeral é quantos dia pra frente irá pegar
            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);

            //para a pegar a data de ontem -1
            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine(ontem);

            //APRESENTA SO O DIA EX: 01
            Console.WriteLine(diaAtual.ToString("dd"));

            //APRESENTA A DATA COMPLETA EX:01/06/2021
            Console.WriteLine(diaAtual.ToString("d"));

            //APRESNETA A DATA COMPLETA SO QUE MAIS ESPECIFICA COM O DIA DA SEMANA. EX: terça-feira, 1 de junho de 2021
            Console.WriteLine(diaAtual.ToString("D"));

            //DIA Atual com a hora sem os segundos
            Console.WriteLine(diaAtual.ToString("g"));

            //dia atual com a hora comos segundos
            Console.WriteLine(diaAtual.ToString("G"));

            //para passar no foramtdo que eu passar dia mes ano hora minuto
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));
        }
    }
}
