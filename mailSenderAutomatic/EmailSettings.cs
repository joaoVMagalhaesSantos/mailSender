using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EmailSettings
{
    public string Usuario { get; set; }
    public string Senha { get; set; }
    public string ServidorSMTP { get; set; }
    public int Porta { get; set; }
    public string Destinatario { get; set; }
    public string Copia { get; set; }
    public string Assunto { get; set; }
    public string Mensagem { get; set; }
    public string Anexo { get; set; }

}

public class EmailConfigurationReader
{
    public static EmailSettings ReadConfiguration(string filePath)
    {
        try
        {
            var lines = File.ReadAllLines(filePath);

            if (lines.Length < 8)
            {
                throw new Exception("O arquivo de configuração está incompleto");
            }

            var settings = new EmailSettings
            {
                Usuario = lines[0],
                Senha = lines[1],
                ServidorSMTP = lines[2],
                Porta = int.Parse(lines[3]),
                Destinatario = lines[4],
                Copia = lines[5],
                Assunto = lines[6],
                Mensagem = lines[7],
                Anexo = lines[8]
            };

            return settings;

        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao ler o Arquivo de configuração " + ex.Message);
        }
    }
}