using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMailLibrary
{
    public class Email
    {
        private String from;
        private String to;
        private String subject;
        private String message;
        private String folder;

        public Email(String from, String to, String subject, String message, String folder)
        {
            this.from = from;
            this.to = to;
            this.subject = subject;
            this.message = message ;
            this.folder = folder;
        }

        public String getFrom()
        {
            return from;
        }
        public void setFrom(String from)
        {
            this.from = from;
        }
        public String getTo()
        {
            return to;
        }
        public void setTo(String to)
        {
            this.to = to;
        }
        public String getSubject()
        {
            return subject;
        }
        public void setSubject(String subject)
        {
            this.subject = subject;
        }
        public String getMessage()
        {
            return message;
        }
        public void setMessage(String message)
        {
            this.message = message;
        }
        public String getFolder()
        {
            return folder;
        }
        public void setFolder(String folder)
        {
            this.folder = folder;
        }

    }
}
