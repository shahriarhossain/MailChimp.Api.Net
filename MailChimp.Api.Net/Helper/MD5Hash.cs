using System.Linq;
using System.Security.Cryptography;
using System.Text;

// =====================================================
// AUTHOR      : Keith Fimreite, Enkode
// PURPOSE     : MD5 Hash string Helper
// =====================================================

namespace MailChimp.Api.Net.Helper
{
  class MD5Hash
  {
    public static string GetMD5HashString(string yourString)
    {
      return string.Join("", MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(yourString)).Select(s => s.ToString("x2")));
    }
  }
}
