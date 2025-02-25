using System;
class Caesar
{
    static string Encrypt(string text, int shift)  // methode um zu verschlüsseln, nimmt einen text und einen zahlen wert (shift wertr) auf
    {
        string result = "";
        foreach (char letter in text)
        {
            if (char.IsLetter(letter))  // überprüft ob das zeichen ein buchstabe ist
            {
                char baseChar = char.IsUpper(letter) ? 'A' : 'a';  //unterscheidet zwischen gross und klei buchstaben
                int newPosition = letter - baseChar + shift;  //berecnet neu eposition von buchstaben
                if (newPosition > 25)  // falls die  neu estelle über 25 (also z) geht, springt sie wider zu 8 zurück
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
    static string Decrypt(string text, int shift)  //entschlüssel7ung methode, durch das negative shift wird einfachder shift rückgängig gemacht.
    {
        return Encrypt(text, -shift);
    }

    static void Main()    // hauptspi8elteil mi tkonsolen ausgabe
    {
        Console.WriteLine("Welcome to the Caesar Cipher!");
        Console.Write("Please enter the text: ");
        string input = Console.ReadLine();

        Console.Write("Please enter the shift value (e.g., 3): ");
        int shift;
        while (!int.TryParse(Console.ReadLine(), out shift))
        {
            Console.Write("Invalid input. Please enter a number: ");
        }

        Console.Write("Do you want to encrypt (E) or decrypt (D)? ");
        string mode = Console.ReadLine()?.ToUpper();

        if (mode == "E")
        {
            Console.WriteLine("Encrypted text: " + Encrypt(input, shift));
        }
        else if (mode == "D")
        {
            Console.WriteLine("Decrypted text: " + Decrypt(input, shift));
        }
        else
        {
            Console.WriteLine("Invalid selection. Please restart the program and choose E or D.");
        }
    }
}

