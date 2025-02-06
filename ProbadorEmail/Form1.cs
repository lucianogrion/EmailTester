using System;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace ProbadorEmail
{
    public partial class frmEmail : Form
    {
        public frmEmail()
        {
            InitializeComponent();
        }

        private void cmdEnviar_Click(object sender, EventArgs e)
        {

            try
            {
                MailMessage msg = new MailMessage();
                string mailRemitente = txtUser.Text.ToString();
                string nombreRemitente = "User";
                MailAddress Remitente = new MailAddress(mailRemitente, nombreRemitente);

                string NombreDestinatario = txtDest.Text.ToString();
                MailAddress Destinatario = new MailAddress(NombreDestinatario, "testingUser");

                string Asunto = "Test";
                
                msg.Sender = Remitente;
                msg.ReplyTo = Remitente;
                msg.From = Remitente;
                msg.Subject = Asunto;
                msg.IsBodyHtml = true;

                string Cuerpo = txtText.Text;
                msg.Body = Cuerpo;
                msg.To.Add(Destinatario);

                SmtpClient clienteSMTP = new SmtpClient(txtSMTP.Text.ToString(), int.Parse(txtPort.Text.ToString()));

                clienteSMTP.Credentials = new NetworkCredential(txtUser.Text, txtPassword.Text);

                clienteSMTP.Timeout = 1;
                
                clienteSMTP.EnableSsl = false;
                msg.IsBodyHtml = true;
                msg.BodyEncoding = Encoding.UTF8;

                clienteSMTP.Send(msg);

                lblError.Text = "Email Enviado Correctamente";

            }
             catch (Exception ex)
            {
                lblError.Text = ex.Message.ToString();
            }

        }

        private void cmdSendCDO_Click(object sender, EventArgs e)
        {
            try
            {
                cmdSendCDO.Enabled = false;

                CDO.Message oMsg = new CDO.Message();
                CDO.IConfiguration iConfg;
                iConfg = oMsg.Configuration;
                ADODB.Fields oFields;
                oFields = iConfg.Fields;

                //Const cdoSendUsingPickup = 1 
                //Const cdoSendUsingPort = 2
                //Const cdoAnonymous = 0
                //Const cdoBasic = 1 
                //Const cdoNTLM = 2 
	
                //oFields[CDO.CdoConfiguration.cdoSendUsingMethod].Value = 2;
                oFields[CDO.CdoConfiguration.cdoSendUsingMethod].Value = 2;
                //oFields[CDO.CdoConfiguration.cdosmtp].Value = 0;
                oFields[CDO.CdoConfiguration.cdoSMTPAuthenticate].Value = 1;
                oFields[CDO.CdoConfiguration.cdoSMTPUseSSL].Value = 0;
                
                oFields[CDO.CdoConfiguration.cdoSMTPServer].Value = txtSMTP.Text.ToString();
                oFields[CDO.CdoConfiguration.cdoSMTPServerPort].Value = int.Parse(txtPort.Text.ToString());
                oFields[CDO.CdoConfiguration.cdoSMTPAuthenticate].Value = 1;

                oFields[CDO.CdoConfiguration.cdoSendUserName].Value = txtUser.Text.ToString();
                oFields[CDO.CdoConfiguration.cdoSendEmailAddress].Value = txtUser.Text.ToString();		

                oFields[CDO.CdoConfiguration.cdoSendPassword].Value = txtPassword.Text.ToString();

                //oMsg.Configuration.Fields. = oFields;

                //oFields.Append( ["http://schemas.microsoft.com/cdo/configuration/sendusing"] = 2;
                //oMsg.Configuration.Fields("http://schemas.microsoft.com/cdo/configuration/smtpserver") = txtSMTP.Text.ToString() ;
                //oMsg.Configuration.Fields("http://schemas.microsoft.com/cdo/configuration/smtpserverport") = int.Parse(txtPort.Text.ToString());
                //oMsg.Configuration.Fields("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate") = 1;
                //oMsg.Configuration.Fields("http://schemas.microsoft.com/cdo/configuration/sendusername") = txtUser.Text;
                //oMsg.Configuration.Fields("http://schemas.microsoft.com/cdo/configuration/sendpassword") = txtPassword.Text;
                //oMsg.Configuration.Fields("http://schemas.microsoft.com/cdo/configuration/smtpconnectiontimeout") = 60;

                oMsg.Configuration.Fields.Update();

                oMsg.Subject = "Test CDO";
                oMsg.HTMLBody = txtText.Text.ToString();
                //oMsg.TextBody = strCuerpo;

                oMsg.From = txtUser.Text.ToString();
                oMsg.To = txtDest.Text.ToString();

                oMsg.Send();
                lblError.Text = "oMsg.Send() Sin errores";

                cmdSendCDO.Enabled = true;
            }
            catch (Exception ex)
            {
                cmdSendCDO.Enabled = true;
                lblError.Text = ex.Message.ToString();
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmdSendCDO.Enabled = false;

                MailMessage email = new System.Net.Mail.MailMessage("webmaster@domain.gov.ar", "nsaez@domain.gov.ar");

                email.Subject = "test subject";
                email.Body = "this is a test";

                System.Net.Mail.SmtpClient mailClient = new System.Net.Mail.SmtpClient();

                System.Net.NetworkCredential basicAuthenticationInfo = new System.Net.NetworkCredential("webmaster@domain.gov.ar", "t6aSIVzwxg");

                mailClient.Host = "exch.domain.local";
                mailClient.UseDefaultCredentials = false;
                mailClient.Credentials = basicAuthenticationInfo;
                mailClient.Send(email);


                lblError.Text = "mailClient.Send(email) - Sin errores";

                cmdSendCDO.Enabled = true;
            }
            catch (Exception ex)
            {
                cmdSendCDO.Enabled = true;
                lblError.Text = ex.Message.ToString();

            }
        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }
    }
}