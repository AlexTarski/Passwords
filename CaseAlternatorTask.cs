namespace Passwords;

public class CaseAlternatorTask
{
	//Тесты будут вызывать этот метод
	public static List<string> AlternateCharCases(string lowercaseWord)
	{
		var result = new List<string>();
		AlternateCharCases(lowercaseWord.ToCharArray(), 0, result);
		return result;
	}

	static void AlternateCharCases(char[] word, int startIndex, List<string> result)
	{
        if (startIndex == word.Length)
        {
            result.Add(new string(word));
            return;
        }

        char Char = word[startIndex];
        if (char.IsLetter(Char) && Char != 223 && (Char < 1425 || Char > 1524))
        {
            word[startIndex] = char.ToLower(word[startIndex]);
            AlternateCharCases(word, startIndex + 1, result);
            word[startIndex] = char.ToUpper(word[startIndex]);
            AlternateCharCases(word, startIndex + 1, result);
        }
        else
        {
            AlternateCharCases(word, startIndex + 1, result);
        }
    }
}