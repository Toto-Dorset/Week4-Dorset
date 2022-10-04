using System.Globalization;
using System.Security.Cryptography.X509Certificates;

static string CharactersInverter(string word)
{
    char temp, temp2;
    string word2;
    temp = word[word.Length - 1];
    temp2 = word[0];
    
    word2 = temp + word.Substring(1, word.Length - 2) + temp2;

    return word2;
}

static bool SequenceCheck(int[] sequence, int[]array)
{
    bool result = false;

    for(int i =0; i < array.Length; i++)
    {
        if(array[i] == sequence[0])
        {
            for(int j =0; j < sequence.Length; j++)
            {
                if (array[i+j] != sequence[j])
                {
                    break;
                }
                else if (array[i+j] == sequence[j] && j == sequence.Length -1)
                {
                    result = true;
                }
            }
        }

        if(result == true)
        {
            break;
        }
    }

    return result;
}

static int ASCII(char a)
{
    return (int)a;
}

static char[] SortedString(string str)
{
    int[] asciiArray = new int[str.Length];
    for(int i = 0; i < str.Length; i++)
    {
        asciiArray[i] = ASCII(str[i]);
    }

    Array.Reverse(asciiArray);

    char[] strSorted = new char[str.Length];
    for(int i =0; i < asciiArray.Length; i++)
    {
        strSorted[i] = (char)asciiArray[i];
    }

    return strSorted;
}

static string CompressString(string str)
{
    string result = "";
    int counter = 1;

    for(int i = 0; i < str.Length; i++)
    {
        if (i != str.Length-1 && str[i] == str[i+1])
        {
            counter++;
        }
        else
        {

            result += (char)str[i];
            result += counter;
            counter = 1;
        }
    }

    return result;
}

static int[] ArmstrongNumber()
{
    int[] armstrong = new int[10];
    int counter = 0;
    string number;

    for (int i = 0; i < 1000; i++)
    {
        if(i < 10)
        {
            if(Math.Pow(i,3) == i)
            {
                armstrong[counter] = i;
            }
        }
        if(i < 100)
        {
            number = i.ToString();
            if (Math.Pow(number[0],3) + Math.Pow(number[1],3) == i)
            {
                armstrong[counter] = i;
            }
        }
        if(i < 1000)
        {
            number = i.ToString();
            if (Math.Pow(number[0], 3) + Math.Pow(number[1], 3) + Math.Pow(number[2],3) == i)
            {
                armstrong[counter] = i;
            }
        }
    }

    return armstrong;
}
/*
//Exercice 1
Console.WriteLine("Enter the word you want to exchange the first and last characters : ");
string word = Console.ReadLine();
Console.WriteLine("The result is : "+CharactersInverter(word));

//Exercice 2
int[] sequence = new int[] { 3,4,5 };
int[] array = new int[] { 7, 5, 2, 3, 4, 5, 0, 9, 9 };
int[] array2 = new int[] { 5, 3, 4, 8, 9 };
Console.WriteLine(SequenceCheck(sequence, array));
Console.WriteLine(SequenceCheck(sequence, array2));

//Exercice 3.a
char a= 'a';
Console.WriteLine(ASCII(a));

//Exercice 3
string str = "abcdefghijklmnopqrstuvwxyz";
SortedString(str);

//Exercice 4
string tryy = "p555ppp7www";
Console.WriteLine(CompressString(tryy)); */
ArmstrongNumber();

