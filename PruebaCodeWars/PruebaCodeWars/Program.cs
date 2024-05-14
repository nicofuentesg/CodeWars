// See https://aka.ms/new-console-template for more information

string[] letters = ["h", "e", "l", "o", "c", "f", "f", "x", "y", "e"];
string[] words = ["hello", "coffee", "ley", "xyz"];
comparativeLetter(letters, words);
comparativeLetterArrays(letters,words);
//kyu 6
int Solution(int value)
{
    if (value < 0)
    {
        return 0;
    }

    int comebackValue = value;
    int contenderSumValue = 0;
    for (int i = 0; i < value; i++)
    {
        if (comebackValue % 3 == 0 || comebackValue % 5 == 0)
        {
            contenderSumValue += comebackValue;
        }

        comebackValue -= 1;
    }

    return contenderSumValue;
}


//kyu 6
void Sum(string roman)
{
    //Creamos un diccionario con los valores MCMLIV
    Dictionary<char, int> romanValues = new Dictionary<char, int>()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };
    int result = 0;
    for (int i = 0; i < roman.Length; i++)
    {
        var value = romanValues[roman[i]];

        if (i + 1 < roman.Length && value < romanValues[roman[i + 1]])
        {
            result -= value;
        }
        else
        {
            result += value;
        }
    }
}
/*
 * Letters and words
Given two arrays one with letters and another with words, create  a function that returns the words that can be written with the letters available in the first array.
 Example
letters = ["h", "e", "l", "o", "c", "f", "f", "x", "y", "e"]
words = ["hello", "coffee", "ley", "xyz"]
Expected result: "coffee", "ley"
 */

void comparativeLetter(string[] letters, string[] words)
{
    List<string> wordAccepter = new List<string>();
    List<string> letterComparative = letters.ToList();
    List<string> letterAdd = new List<string>();
    foreach (var word in words)
    {
        string wordFormatter = ""; 
        foreach (var letter in word)
        {
            if (letterComparative.Contains(letter.ToString())) 
            {
                wordFormatter += letter.ToString();
                letterComparative.Remove(letter.ToString());
                letterAdd.Add(letter.ToString());
            }
        }

        if (words.Contains(wordFormatter))
        {
            wordAccepter.Add(word);
        }
        foreach (var VARIABLE in letterAdd)
        {
            letterComparative.Add(VARIABLE);
        }
    }

    foreach (var word in wordAccepter)
    {
        Console.WriteLine(word);
    }
    
}

void comparativeLetterArrays(string[] letters, string[] words)
{
    List<string> wordAccepter = new List<string>();
    
    foreach (var word in words)
    {
        bool[] letterUsed = new bool[letters.Length]; // Array para marcar qué letras han sido utilizadas
        string wordFormatter = "";

        foreach (var letter in word)
        {
            bool found = false;
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] == letter.ToString() && !letterUsed[i])
                {
                    wordFormatter += letter.ToString();
                    letterUsed[i] = true; // Marcar la letra como utilizada
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                // Si una letra de la palabra no se encuentra en las letras disponibles, salir del bucle y descartar la palabra
                break;
            }
        }

        if (wordFormatter.Length == word.Length)
        {
            wordAccepter.Add(word);
        }
    }

    foreach (var word in wordAccepter)
    {
        Console.WriteLine(word);
    }
}
