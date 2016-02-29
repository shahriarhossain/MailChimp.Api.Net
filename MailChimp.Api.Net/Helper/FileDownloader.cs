using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Helper
{
    public static class FileDownloader
    {
        public static void download(string inputFileURL, string outputDirectory)
        {
            try
            {
                using (var downloadClient = new WebClient())
                {
                    downloadClient.DownloadFile(inputFileURL, outputDirectory);
                }
            }
            catch (Exception ex )
            {
                
                throw ex;
            }
           
        }
    }
}
