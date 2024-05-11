using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_Net_2.Models
{
    public class LeituraArquivo
    {
        //metodod para retornar tuples
        public (bool sucessfullRead, string [] textInLine, int totalLines) readFile(string filePath)
        {
            try
            {
                string [] lines = File.ReadAllLines(filePath);
                return (true, lines, lines.Count());
            }
            catch (Exception)
            {
                return (false, new string [0], 0);
            }
              
            //<bool readText, string textInLine, int totalLines> FileInfo = new FileInfo(filePath);

            // foreach (string line in lines)
            // {
            //     int lineNumber = Array.IndexOf(lines, line +1);
            //     Console.WriteLine($"-{lineNumber} {line}");
            // }

          
        }
    }
}