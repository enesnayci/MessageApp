using System.Text;

namespace MesajlasmaProjesi
{
    public static class Encryption
    {
        public static string VigenereEncrypt(string text, string key)
        {
            StringBuilder result = new StringBuilder();
            int keyIndex = 0;

            foreach (char ch in text)
            {
                if (char.IsLetter(ch))
                {
                    char baseChar = char.IsUpper(ch) ? 'A' : 'a';
                    int offset = (ch - baseChar + key[keyIndex % key.Length] - 'A') % 26;
                    result.Append((char)(baseChar + offset));
                    keyIndex++;
                }
                else
                {
                    result.Append(ch);
                }
            }

            return result.ToString();
        }
    }
}
