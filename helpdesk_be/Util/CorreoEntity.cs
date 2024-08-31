using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace helpdesk_be.Util
{
    public class CorreoEntity
    {
        public string StmpServidor { get; set; }
        public string CorreoSalida { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string ContenidoCorreo { get; set; }
        public int Puerto { get; set; }
        public List<string> Adjuntos { get; set; }
        
        //Constructor (usuario es el nombre con el que se desea enviar)
        public CorreoEntity() { }
        public CorreoEntity(string stmpServidor, string correoSalida, string usuario, string password, string contenidoCorreo, int puerto/*, List<string> adjuntos */)
        {
            this.StmpServidor = stmpServidor;
            this.CorreoSalida = correoSalida;
            this.Usuario = usuario;
            this.ContenidoCorreo = contenidoCorreo;
            this.Puerto = puerto;
            this.Password = password;
            //this.Adjuntos = adjuntos;
        }
        //Constructor
        public CorreoEntity(string stmpServidor, string correoSalida, string usuario, string password, int puerto)
        {
            this.StmpServidor = stmpServidor;
            this.CorreoSalida = correoSalida;
            this.Usuario = usuario;
            this.Puerto = puerto;
            this.Password = password;
        }

    }
    public class ServidorCorreo
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="suscriptor"></param>
        /// <param name="correo"></param>
        /// <returns></returns>
        //public static Boolean RecordarContraseña(SuscriptorEntity suscriptor, CorreoEntity correo)
        //{
        //    try
        //    {
        //        //Configuración del Mensaje
        //        MailMessage mail = new MailMessage();
        //        SmtpClient SmtpServer = new SmtpClient(correo.StmpServidor);
        //        //Especificamos el correo desde el que se enviará el Email y el nombre de la persona que lo envía
        //        mail.From = new MailAddress(correo.CorreoSalida, correo.Usuario, Encoding.UTF8);
        //        //Aquí ponemos el asunto del correo
        //        mail.Subject = "Reestablecer Contraseña";
        //        //Aquí ponemos el mensaje que incluirá el correo
        //        mail.Body = correo.ContenidoCorreo;
        //        mail.IsBodyHtml = true;
        //        //Especificamos a quien enviaremos el Email, no es necesario que sea Gmail, puede ser cualquier otro proveedor
        //        mail.To.Add(suscriptor.Email);
        //        //Si queremos enviar archivos adjuntos tenemos que especificar la ruta en donde se encuentran
        //        foreach (string adjunto in correo.Adjuntos)
        //        {
        //            mail.Attachments.Add(new Attachment(@adjunto));
        //        }
        //        //Configuracion del SMTP
        //        SmtpServer.Port = correo.Puerto; //Puerto que utiliza Gmail para sus servicios
        //        //Especificamos las credenciales con las que enviaremos el mail
        //        SmtpServer.Credentials = new System.Net.NetworkCredential(correo.CorreoSalida, correo.Password);
        //        SmtpServer.EnableSsl = true;
        //        SmtpServer.Send(mail);
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}
        /// <summary>
        ///
        /// </summary>
        /// <param name="correo"></param>
        /// <param name="asunto"></param>
        /// <param name="correoDestino"></param>
        /// <returns></returns>
        public static Boolean EnviarCorreoContacto(CorreoEntity correo, string asunto, string correoDestino)//entidad solicitante y nombre solicitante
        {
            try
            {
                //Configuración del Mensaje
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(correo.StmpServidor);
                //Especificamos el correo desde el que se enviará el Email y el nombre de la persona que lo envía
                mail.From = new MailAddress(correo.CorreoSalida, correo.Usuario, Encoding.UTF8);
                //Aquí ponemos el asunto del correo
                mail.Subject = asunto;
                //Aquí ponemos el mensaje que incluirá el correo
                mail.IsBodyHtml = true;
                mail.Body = correo.ContenidoCorreo;
                //Especificamos a quien enviaremos el Email, no es necesario que sea Gmail, puede ser cualquier otro proveedor
                mail.To.Add(correoDestino);
                //Si queremos enviar archivos adjuntos tenemos que especificar la ruta en donde se encuentran
                /*foreach (string adjunto in correo.Adjuntos)
                {
                    mail.Attachments.Add(new Attachment(@adjunto));
                }*/
                //Configuracion del SMTP
                SmtpServer.Port = correo.Puerto; //Puerto que utiliza Gmail para sus servicios
                //Especificamos las credenciales con las que enviaremos el mail
                SmtpServer.Credentials = new System.Net.NetworkCredential(correo.CorreoSalida, correo.Password);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
