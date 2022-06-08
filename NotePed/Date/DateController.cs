using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePed_0._1.Date
{
    internal static  class DateController
    {
        internal static void write(string path, string text)
        {
            try
            {
                File.WriteAllText(path, text);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show($"Houve um erro ao escrever o arquivo{path}","Erro",System.Windows.Forms.MessageBoxButtons.OK);
            }
        }

        internal static string Read(string path)
        {
            if (!File.Exists(path))
                return null;
            else
                return File.ReadAllText(path);
        }

        internal static string extrairNome( string path)
        {
            var parts = path.Split('\\');

            var nome = parts[parts.Length - 1].Split('.');

            return nome[0];
        }
    }
}
