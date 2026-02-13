// See https://aka.ms/new-console-template for more information

using System.Text;

Console.WriteLine("Hi, Kingly!");
int[] IntArray = { 2, 29, 6, 77, 3, 11, 8, 88, 4, 99 };
Test.SortingIntArray(IntArray);

//char[] CharArray = { 'V', 'B', 'K', 'X', 'M', 'T', 'G', 'R', 'Y', 'A' };
//Test.SortingCharArray(CharArray);

//var strName = "ICICILOMBARD";
//Test.ReverseString(strName);

//var sentence = "LLOYDS METALS & ENERGY AND MINING";
//Test.ReverseSentence(sentence);



Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine($"Success \U0001F600");
Console.Read();
public static class Test
{
    internal static void SortingIntArray(int[] Arr)
    {
        //int[] array = new int[Arr.Length];
        int temp = 0;
        for (int i = 0; i < Arr.Length; i++)
        {
            for (int j = i + 1; j < Arr.Length; j++)
            {
                if (Arr[i] > Arr[j])
                {
                    temp = Arr[i];
                    Arr[i] = Arr[j];
                    Arr[j] = temp;
                }
            }

        }
        Console.WriteLine(string.Join(',',Arr));

    }
    internal static void SortingCharArray(Char[] Arr)
    {
        //int[] array = new int[Arr.Length];
        char temp = ' ';
        for (int i = 0; i < Arr.Length; i++)
        {
            for (int j = i + 1; j < Arr.Length; j++)
            {
                if (Arr[i] > Arr[j])
                {
                    temp = Arr[i];
                    Arr[i] = Arr[j];
                    Arr[j] = temp;
                }
            }

        }

        foreach (var item in Arr)
        {
            Console.WriteLine(item);
        }
    }
    internal static void ReverseString(string str)
    {
        
        char[] charArray = str.ToCharArray();
        StringBuilder _sb=new StringBuilder();
        for (int i = charArray.Length-1;i>=0; i--)
        {
            _sb.Append(charArray[i]);
        }
        Console.WriteLine(_sb.ToString());
    }
    internal static void ReverseSentence(string str)
    {
        string[] words = str.Split(' ');
        StringBuilder _sb = new StringBuilder();

        for (int i = words.Length - 1; i >= 0; i--)
        {
            char[] charWord = words[i].ToCharArray();

            if (i < words.Length - 1)
                _sb.Append(' ');

            for (int k= charWord.Length - 1; k >= 0; k--)
            {
               _sb.Append(charWord[k]);
            }
        }

        Console.WriteLine(_sb.ToString());
    }







}


