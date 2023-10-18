using System.Drawing.Imaging;
using System.Net;
using System.Net.Mail;

namespace mailSender
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public void BtnEnviar_Click(object sender, EventArgs e)
        {
            string arquivoConfiguracao = "C:\\tolsistemas\\email\\configuracao.txt";

            try
            {
                string para = txtPara.Text;
                string cc = txtCC.Text;
                string assunto = txtAssunto.Text;
                string mensagem = lbMensagem.Text;

                EmailSettings settings = EmailConfigurationReader.ReadConfiguration(arquivoConfiguracao);

                using (SmtpClient cliente = new SmtpClient(settings.ServidorSMTP, settings.Porta))
                {
                    cliente.EnableSsl = false;
                    cliente.Credentials = new NetworkCredential(settings.Usuario, settings.Senha);

                    MailMessage message = new MailMessage();
                    message.Headers.Add("Disposition-Notification-To", settings.Usuario);
                    message.From = new MailAddress(settings.Usuario);

                    message.To.Add(para);
                    
                    if (cc.Length > 0)
                    {
                        message.CC.Add(cc);
                    }
                    message.Subject = settings.Assunto;
                    message.IsBodyHtml = true;

                    message.Body = $@"
                        <html>
                        <body>
                            <p>{mensagem}</p>
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAssunto.Text = "";
            txtCC.Text = "";
            lbMensagem.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}