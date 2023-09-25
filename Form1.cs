using Newtonsoft.Json;
using System;
using System.Data;

namespace Caesar_Cryptography
{
    public partial class Form1 : Form
    {
        static int encryptAddZahl = 2; // by (+) what number to encrypt
        const string caeserAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // Caeser Alphabet

        private string Encrypt(string text) // Encrypt Methode
        {
            outputTextBox.Text = string.Empty;
            char[] textArray = text.ToCharArray(); // User Text to Char Convert

            for (int i = 0; i < textArray.Length; i++) // For Loop for each Index Char
            {
                char aktuelleChar = textArray[i]; // Variable aktuelleChar is the actual Index from each Loop

                if (char.IsLetter(aktuelleChar)) // Looks if the char is a letter
                {
                    int index = caeserAlphabet.IndexOf(aktuelleChar); // Integer index is the index of caeserAlphabet with the same value as aktuelleChar

                    int neueIndex = (index + encryptAddZahl) % caeserAlphabet.Length; // Creates a new integer Index, which is the same Index as the Index from caeserAlphabet + what number was chosen to encrypt with. with modulo "% caeserAlphabet.Length" proves if it goes past the alphabet, if yes then it goes to its beginning

                    textArray[i] = caeserAlphabet[neueIndex]; // Makes the actual index from the loop for textArray, to be the index from caeserAlphaebet's index neueIndex
                }
            }

            return new string(textArray); // return the decrypted string
        }
        private string Decrypt(string text)
        {
            inputTextBox.Text = string.Empty;
            char[] textArray = text.ToCharArray();

            for (int i = 0; i < textArray.Length; i++)
            {
                char aktuelleChar = textArray[i];

                if (char.IsLetter(aktuelleChar))
                {
                    int index = caeserAlphabet.IndexOf(aktuelleChar);
                    int neueIndex = (index - encryptAddZahl) % caeserAlphabet.Length;

                    if (neueIndex < 0)
                    {
                        neueIndex += caeserAlphabet.Length;
                    }

                    textArray[i] = caeserAlphabet[neueIndex];
                }
            }

            return new string(textArray);
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void encryptButton_Click(object sender, EventArgs e)
        {
            string userText = inputTextBox.Text.ToUpper();
            string encryptedText = Encrypt(userText);
            outputTextBox.Text = encryptedText;
        }
        private void decryptButton_Click(object sender, EventArgs e)
        {
            string userText = outputTextBox.Text.ToUpper();
            string decryptedText = Decrypt(userText);
            inputTextBox.Text = decryptedText;
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                string json = JsonConvert.SerializeObject(outputTextBox.Text, Newtonsoft.Json.Formatting.Indented);

                using (StreamWriter sw = new StreamWriter("CaeserWord.json"))
                {
                    sw.WriteLine(json);
                }
                MessageBox.Show("Das Wort wurde gespeichert.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                string json;
                if (File.Exists("CaeserWord.json"))
                {
                    using (StreamReader sr = new StreamReader("CaeserWord.json"))
                    {
                        json = sr.ReadToEnd();
                    }
                    outputTextBox.Text = JsonConvert.DeserializeObject<string>(json);
                    MessageBox.Show("Das Wort wurde geladen.");
                }
                else throw new FileNotFoundException("Es wurden keine Dateien gefunden.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}