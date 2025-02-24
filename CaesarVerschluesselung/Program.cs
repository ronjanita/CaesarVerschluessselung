using System;
class Caesar
{
    static string Encrypt(string text, int shift)
    {
        string result = "";
        foreach (char letter in text)
        {
            if (char.IsLetter(letter))
            {
                char baseChar = char.IsUpper(letter) ? 'A' : 'a';
                int newPosition = letter - baseChar + shift;
                if (newPosition > 25)
                {
                    newPosition -= 26;
                }
                else if (newPosition < 0)
                {
                    newPosition += 26;
                }
                result += (char)(baseChar + newPosition);
            }
            else
            {
                result += letter;
            }
        }
        return result;
    }
}

