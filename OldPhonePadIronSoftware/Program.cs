namespace OldPhonePadIronSoftware
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Test Cases
            OldPhonePad("33#"); //E

            OldPhonePad("227 *#"); //B

            OldPhonePad("4433555 555666#"); // HELLO

            OldPhonePad("8 88777444666*664#"); //TURNG

            OldPhonePad("227 **#"); // blank

            OldPhonePad("8 88477788555#"); // TUGRUL

            OldPhonePad("777729283 33 33 5577727#"); // SAWATDEEKRAP
        }

        public static string OldPhonePad(string input)
        {
            string result = "";
            char previousChar = ' ';
            int count = 0;

            Dictionary<char, string> phonePad = new Dictionary<char, string>
            {
                {'1', ""},
                {'2', "ABC"},
                {'3', "DEF"},
                {'4', "GHI"},
                {'5', "JKL"},
                {'6', "MNO"},
                {'7', "PQRS"},
                {'8', "TUV"},
                {'9', "WXYZ"},
                {'0', " "},
                {'*', "BACKSPACE"},
                {'#', "SEND"}
            };

            foreach (char c in input)
            {
                if (c == '#')
                {
                    if (count > 0 && phonePad.ContainsKey(previousChar))
                    {
                        result += phonePad[previousChar][count - 1];
                    }
                    break;
                }
                else if (c == '*')
                {
                    if (result.Length > 0)
                        result = result.Remove(result.Length - 1);
                    count = 0;
                    continue;
                }
                else if (c == ' ')
                {
                    if (count > 0 && phonePad.ContainsKey(previousChar))
                    {
                        result += phonePad[previousChar][count - 1];
                    }
                    count = 0;
                    continue;
                }

                if (c == '1')
                {
                    continue;
                }

                if (previousChar == c)
                {
                    count++;
                }
                else
                {
                    if (count > 0 && phonePad.ContainsKey(previousChar))
                    {
                        result += phonePad[previousChar][count - 1];
                    }

                    count = 1;
                    previousChar = c;
                }
            }

            Console.WriteLine(result); //print results to console
            return result;
        }
    }
}