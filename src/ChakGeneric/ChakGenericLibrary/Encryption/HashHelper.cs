using ChakGenericLibrary.Conversion;
using System.Security.Cryptography;
using System.Text;

namespace ChakGenericLibrary.Encryption
{
    public class HashHelper
    {
        public static string GetHash(string data)
        {
            SHA512 sha = SHA512.Create();

            //convert the input text to array of bytes
            byte[] hashData = sha.ComputeHash(StringParser.StringToByteArray(data));

            StringBuilder returnValue = new StringBuilder();

            //loop for each byte and add it to StringBuilder
            for (int i = 0; i < hashData.Length; i++)
            {
                returnValue.Append(hashData[i].ToString());
            }

            // return hexadecimal string
            return returnValue.ToString();
        }
    }
}
