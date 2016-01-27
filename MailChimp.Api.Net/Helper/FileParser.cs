using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Helper
{
    public class FileParser
    {
        public string EmailParser(string path)
        {
            string templateContent = "";

            if (File.Exists(path))
            {
                try
                {
                    StreamReader reader = new StreamReader(path);
                    templateContent = reader.ReadToEnd();
                    reader.Close();
                    
                    //templateContent = templateContent.Replace("<##FirstName##>", registeredUser.Member.FirstName);
                    return templateContent;
                }
                catch (Exception ex)
                {
                    throw ex;
                } 
            }
            return templateContent;
        }
    }
}
