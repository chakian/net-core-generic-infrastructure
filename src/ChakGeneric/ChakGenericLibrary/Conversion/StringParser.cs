using System.Text;

namespace ChakGenericLibrary.Conversion
{
    public class StringParser
    {
        /// <summary>
        /// Converts a byte array to a string with UTF8 format
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ByteArrayToString(byte[] input)
        {
            return Encoding.UTF8.GetString(input);
        }

        /// <summary>
        /// Converts a string to a byte array with UTF8 format
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] StringToByteArray(string input)
        {
            return Encoding.UTF8.GetBytes(input);
        }
    }
}
