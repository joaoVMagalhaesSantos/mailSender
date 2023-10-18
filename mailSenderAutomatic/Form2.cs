using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace mailSender
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            EnviarEmail();
            InitializeComponent();
            
        }
        static void EnviarEmail()
        {
            string arquivoConfiguracao = "C:\\tolsistemas\\email\\configuracao.txt";
            try
            {
                EmailSettings settings = EmailConfigurationReader.ReadConfiguration(arquivoConfiguracao);




                using (SmtpClient cliente = new SmtpClient(settings.ServidorSMTP, settings.Porta))
                {
                    cliente.EnableSsl = false;
                    cliente.Credentials = new NetworkCredential(settings.Usuario, settings.Senha);

                    MailMessage message = new MailMessage();

                    message.Headers.Add("Disposition-Notification-To", settings.Usuario);

                    message.From = new MailAddress(settings.Usuario);
                    
                    if(settings.Destinatario != "")
                    {
                        message.To.Add(settings.Destinatario);
                    }
                    else
                    {
                        MessageBox.Show("Email de destinatario não encontrado por favor verifique", "Alerta");
                        Environment.Exit(0);
                    }

                    if (settings.Copia.Length > 0)
                    {
                        message.CC.Add(settings.Copia);
                    }
                    message.Subject = settings.Assunto;

                    message.IsBodyHtml = true;

                    message.Body = $@"
                        <html>
                        <body>
                            <p>{settings.Mensagem}</p>
                            <p><img src='C:\\tolsistemas\\email\\assinatura.png' alt='Assinatura'></p>
                        </body>
                        </html>
                    ";
                    
                    message.Attachments.Add(new Attachment(settings.Anexo));

                    cliente.Send(message);
                }
                //Console.Write("Email Enviado com sucesso");
                MessageBox.Show("Email Enviado com sucesso", "Alerta");
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Erro ao enviar o email: " + ex.Message);
                MessageBox.Show("Erro ao enviar o email: " + ex.Message);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
