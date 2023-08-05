string[] words = new string[5] {"watermelon" , "banana" , "ant" , "sugr" , "art"};
Array.Sort(words, (str1, str2) => str1.Length  .CompareTo(str2.Length));
Array.Reverse(words);
foreach (var word in words)
{
    Console.WriteLine(word); 
}