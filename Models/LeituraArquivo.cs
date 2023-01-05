using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class LeituraArquivo
    {
        public (bool Success, string[] Lines, int QuantityLines) LerArquivo(string path)
        {
            try
            {
                string[] linhas = File.ReadAllLines(path);
                return (true, linhas, linhas.Count());
            }
            catch (Exception)
            {
                return (false, new string[0], 0);
            }

        }
    }
}