

Console.WriteLine("Please enter a word:");
string result = Console.ReadLine().Trim();
string[] words = result.Split(' ');
List<string> newSentence = new List<string>();
Stack<char> letter = new Stack<char>();

foreach (string word in words)
{
    char [] reverseLetter = new char[word.Length];
    int i = 0;  
    foreach (char w in word)
    {
        letter.Push(w);
    }
    for (i= 0; i < word.Length; i++)
    {
        reverseLetter[i] += letter.Pop();
    }
    
    string reverseWord = new string(reverseLetter);
    newSentence.Add(reverseWord + " ");
}
foreach (string word in newSentence)
{
    Console.WriteLine(word);
}