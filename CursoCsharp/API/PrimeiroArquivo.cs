using System;
using System.IO;

namespace CursoCSharp.API
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix) ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }

    class PrimeiroArquivo
    { 
        public static void Executar() {
            //utilizando o @ o vs irá ignorar as / vira tudo texto normal
            //~ pasta home
            var path = @"~/Primeiro_arquivo.txt".ParseHome();

            //crete text ira criar o arquivo
            if (!File.Exists(path)) {
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("O nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                }
            }

            //appendtext irá adicionar novas coisas no arquvio criado
            using (StreamWriter sw = File.AppendText(path)) {
                sw.WriteLine("");
                sw.WriteLine("é possivel");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto!");
                sw.WriteLine("MEU PRIU!");
            }
        }
    }
}
