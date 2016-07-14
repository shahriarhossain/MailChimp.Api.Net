using System.IO;

namespace MailChimp.Api.Net.Helper
{
    public class Class1
    {
          public string CSVReader()
          {
              string dataSource = @"E:\MOCK_DATA.csv";
                var reader = new StreamReader(File.OpenRead(dataSource));
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var singleValue = line.Split(',');
                    var fName = singleValue[0];
                    var lName = singleValue[1];
                    var email = singleValue[2];

                    var values = line.Split(',');
                }
                return "Something for NOW";
          }
    }
}
