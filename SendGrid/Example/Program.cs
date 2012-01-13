﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using SendGridMail;
using SendGridMail.Transport;

namespace Example
{
    class Program
    {
        static void Main(String[] args)
        {
            var restInstance = new REST(new NetworkCredential("cjbuchmann", "Gadget_15"));

            //create a new message object
            var message = new SendGrid(new Header());

            message.AddTo("cj.buchmann@sendgrid.com");
            message.From = new MailAddress("cj.buchmann@sendgrid.com");
            message.Html = "<div>hello world</div>";
            message.Subject = "THIS STUPID SUBJECT";
            message.AddAttachment(@"D:\att_proj\21.jpg");

            restInstance.Deliver(message);
        }

        /*static void Main(string[] args)
        {
            var username = "cjbuchmann";
            var password = "Gadget_15";
            var from = "cj.buchmann@sendgrid.com";
            var to = new List<String>
                         {
                             "cj.buchmann@sendgrid.com"
                         };

            var bcc = new List<string>
                          {
                              "eric@sendgrid.com"
                          };            
            
            var cc = new List<string>
                          {
                              "eric@sendgrid.com"
                          };

            //initialize the SMTPAPI example class
            var smtpapi = new SMTPAPI(username, password, from, to);
            var restpapi = new RESTAPI(username, password, from, to, null, null);

            //send a simple HTML encoded email.
            //smtpapi.SimpleHTMLEmail();

            //send a simple Plaintext email.
            //smtpapi.SimplePlaintextEmail();

            //send a gravatar enabled email.
            //smtpapi.EnableGravatarEmail();

            //send an open tracking enabled email.
            //smtpapi.EnableOpenTrackingEmail();

            restpapi.SimpleHTMLEmail();
        }*/
    }
}
