using System.Data;

namespace WinFormsApp3
{
    internal static class Program
    {
        const int ALPHABET_SIZE = 33;
        const string ALPHABET_STRING = "אבגדהו¸זחטיךכלםמןנסעףפץצקרשתûü‎‏ÿ";
        const int ALPHABET_SIZE_ENG = 26;
        const string ALPHABET_STRING_ENG = "abcdefghijklmnopqrstuvwxyz";
        static int GRILLE_SIZE = 4;
        static int GRILLE_STRING_LENGTH = GRILLE_SIZE * GRILLE_SIZE;

        

        public static bool[,] TurnGrille(bool[,] userGrille)
        {
            bool[,] newGrille = new bool[GRILLE_SIZE, GRILLE_SIZE];
            for (int i = 0; i < GRILLE_SIZE; i++)
            {
                for (int j = 0; j < GRILLE_SIZE; j++)
                {
                    if (userGrille[i, j])
                    {
                        newGrille[j, GRILLE_SIZE - i - 1] = true;
                    }
                }
            }
            return newGrille;
        }

        public static string appendString(string baseString)
        {
            string key = string.Empty;
            if (baseString.Length < GRILLE_STRING_LENGTH)
            {
                key = string.Concat(baseString, ALPHABET_STRING_ENG.Remove((GRILLE_STRING_LENGTH - baseString.Length), ALPHABET_STRING_ENG.Length - (GRILLE_STRING_LENGTH - baseString.Length)));
            }
            else if (baseString.Length > 0)
            {
                key = baseString.Remove(GRILLE_STRING_LENGTH, baseString.Length - GRILLE_STRING_LENGTH);
            }

                return key;
        }


        //public static bool InputAccptableGrilleKey(int[][] grille, bool[][] key)
        //{
        //    bool isKeyValid = false;

        //    for (int i = 0; i < GRILLE_SIZE; i++)
        //    {
        //        for (int j = 0; j < GRILLE_SIZE; j++)
        //        {
        //            //if ()
        //        } 
        //    }


        //    return isKeyValid;
        //}
        public static string MakeAcceptableString(string str, string alphabetString)
        {
            int i = 0;
            while (i < str.Length)
            {
                if (alphabetString.IndexOf(str[i]) < 0 && str[i] != ' ')
                {
                    str = str.Remove(i, 1);
                }
                else
                {
                    i++;
                }
                ;
            }
            return str;
        }

        public static char[,] FillCharGrille(bool[,] key, char[,] grille, string plaintext, int pointer)
        {
            for (int i = 0; i < GRILLE_SIZE; i++)
            {
                for (int j = 0; j < GRILLE_SIZE; j++)
                {
                    if (key[i, j])
                    {
                        grille[i, j] = plaintext[pointer++];
                    }
                }
            }
            return grille;
        }

        public static string EncipherGrille(string plaintext, bool[,] key)
        {
            string ciphertext = string.Empty;
            char[,] grille = new char[GRILLE_SIZE, GRILLE_SIZE];

            plaintext = plaintext.ToLower().Trim().Replace(" ", "");
            plaintext = MakeAcceptableString(plaintext, ALPHABET_STRING_ENG);
            plaintext = appendString(plaintext);

            FillCharGrille(key, grille, plaintext, 0);

            for (int i = 1; i < 4; i++)
            {
                key = TurnGrille(key);
                FillCharGrille(key, grille, plaintext, i*GRILLE_SIZE);
            }

            for (int i = 0; i < GRILLE_SIZE; i++)
            {
                for(int j = 0; j < GRILLE_SIZE; j++)
                {
                    ciphertext += grille[i, j];
                }
            }
            return ciphertext;
        }

        public static string KeyConverter(string baseKey, string plainText)
        {
            string key;
            key = baseKey;
            if (key.Length < plainText.Length)
            {
                int counterPosition = 0, counterShift = 1;
                while (key.Length < plainText.Length)
                {
                    key += ALPHABET_STRING[(ALPHABET_STRING.IndexOf(baseKey[counterPosition]) + counterShift) % ALPHABET_SIZE];
                    counterPosition = (counterPosition + 1) % baseKey.Length;
                    if (counterPosition == 0)
                    {
                        counterShift++;
                    }
                }
            }
            return key;
        }


        public static string DecipherVigenere(string baseCipherText, string baseKey)
        {
            string cipherText = makeDataAcceptable(baseCipherText);
            baseKey = makeDataAcceptable(baseKey);
            string plainText = string.Empty;
            string key = KeyConverter(baseKey, cipherText); //+ ALPHABET_SIZE
            Console.WriteLine(key);
            for (int i = 0; i < cipherText.Length; i++)
            {
                plainText += ALPHABET_STRING[(ALPHABET_STRING.IndexOf(cipherText[i]) + ALPHABET_SIZE - ALPHABET_STRING.IndexOf(key[i])) % ALPHABET_SIZE];
            }
            plainText = putSpacesBack(plainText, baseCipherText);
            return plainText;
        }


        public static string makeDataAcceptable(string key)
        {
            key = key.ToLower().Trim().Replace(" ", "");
            key = MakeAcceptableString(key, ALPHABET_STRING);
            return key;
        }

        public static string putSpacesBack(string cipherText, string plainText)
        {
            int i = 0;  
            while (cipherText.Length < plainText.Length)
            {
                if (plainText[i] == ' ')
                {
                    cipherText = cipherText.Insert(i, " ");
                }
                i++;
            }
            return cipherText;
        }

        public static string EncipherVigenere(string basePlainText, string baseKey)
        {
            string plainText = makeDataAcceptable(basePlainText);
            baseKey = makeDataAcceptable(baseKey);
            string cipherText = string.Empty;
            string key = KeyConverter(baseKey, plainText);
            Console.WriteLine(key);
            for (int i = 0; i < plainText.Length; i++)
            {
                cipherText += ALPHABET_STRING[(ALPHABET_STRING.IndexOf(plainText[i]) + ALPHABET_STRING.IndexOf(key[i])) % ALPHABET_SIZE];
            }
            cipherText = putSpacesBack(cipherText, basePlainText);
            return cipherText;
        }


        public static bool[,] TurnGrilleCounterClockWise(bool[,] userGrille)
        {
            bool[,] newGrille = new bool[GRILLE_SIZE, GRILLE_SIZE];
            for (int i = 0; i < GRILLE_SIZE; i++)
            {
                for (int j = 0; j < GRILLE_SIZE; j++)
                {
                    if (userGrille[i, j])
                    {
                        newGrille[GRILLE_SIZE - j - 1, i] = true;
                    }
                }
            }
            return newGrille;
        }

        public static string FillOutCharGrille(bool[,] key, char[,] grille)
        {
            string plaintext = string.Empty;
            for (int i = GRILLE_SIZE - 1; i >= 0; i--)
            {
                for (int j = GRILLE_SIZE - 1; j >= 0 ; j--)
                {
                    if (key[i, j])
                    {
                        plaintext = grille[i, j] + plaintext;
                    }
                }
            }
            return plaintext;
        }



        public static string DecipherGrille(string ciphertext, bool[,] key)
        {
            string plaintext = string.Empty;
            ciphertext = ciphertext.Trim().ToLower().Replace(" ", "");
            ciphertext = MakeAcceptableString(ciphertext, ALPHABET_STRING_ENG);
       
            char[,] grille = new char[GRILLE_SIZE, GRILLE_SIZE];

            for (int i = 0; i < GRILLE_SIZE; i++)
            {
                for (int j = 0; j < GRILLE_SIZE; j++)
                {
                    grille[i, j] = ciphertext[i * GRILLE_SIZE + j];
                }
            }

            for (int i = 1; i <= 4; i++)
            {
                key = TurnGrilleCounterClockWise(key);
                plaintext = string.Concat(FillOutCharGrille(key, grille), plaintext);
            }

           
            return plaintext;


        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new formLab1());


        }

        
    }
}