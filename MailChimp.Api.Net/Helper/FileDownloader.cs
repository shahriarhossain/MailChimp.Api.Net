using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Helper
{
    // ======================================================
    // AUTHOR      : Shahriar Hossain, Microsoft Azure MVP
    // PURPOSE     : Download file
    // ======================================================

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
