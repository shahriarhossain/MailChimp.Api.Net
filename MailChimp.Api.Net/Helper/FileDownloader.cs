using System;
using System.Net;

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
