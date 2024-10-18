using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace GoSys
{
    class Envio
    {
        public static bool erro;
        public object Enviar(bool arq, string email, string senha, string para, string Cc, string Cco, string assunto, string mensagem)

        {
            SmtpClient smtp = new SmtpClient();
            MailMessage mail = new MailMessage();

            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential(email, senha);

            mail.From = new MailAddress(email);

            if (string.IsNullOrWhiteSpace(para))
            {
                return erro = true;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(Cc))
                {
                    mail.CC.Add(new MailAddress(Cc));
                }
                if (!string.IsNullOrWhiteSpace(Cco))
                {
                    mail.Bcc.Add(new MailAddress(Cco));
                }

                if (arq == true)
                {
                    foreach (var a in frmEmail.anexo.Items) 
                    {
                        mail.Attachments.Add(new Attachment(a.ToString()));
                    }
                }
                mail.To.Add(new MailAddress(para));
                mail.Subject = assunto;
                mail.Body = mensagem;
                smtp.Send(mail);
            }
            return erro = false;
        }
    }
}
