// See https://aka.ms/new-console-template for more information
using System.Linq;
using System.Text;

namespace EPAM_Tasks_1;
///////////////////////1.1.1////////////////////////
/// 
/// читаем строку для ширины 
/*string src;
bool pravda;
int width;
int height;
do
{


    src = Console.ReadLine();
    /// Пытаемся распарсить строку для ширины
     pravda = int.TryParse(src, out width);
    /// Если удалось распарсить
    if (pravda == true)
    {
        /// проверяем это на <=0
        if (width <= 0)
        {
            /// Выводим ошибку
            Console.WriteLine("ERROR!");
        }
    }
} while(pravda == false);

do {
    src = Console.ReadLine();
    pravda = int.TryParse(src, out height);
    /// Если удалось распарсить
    if (pravda == true)
    {
        /// проверяем это на <=0
        if (height <= 0)
        {
            /// Выводим ошибку
            Console.WriteLine("ERROR!");
        }
    }
}while(pravda == false);
int square = width* height;
Console.WriteLine(square);*/

/// считаем площадь
/// выводим ее на консоль
/// 

///////////////////////1.1.2////////////////////////
/*int value = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= value; i++)
{
    Console.WriteLine(new String('*', i));
}
*/
///////////////2 вариант////////////////////
/*int value = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= value; i++)
{
    for (int b = 1; b <= i; b++)
    {
        Console.Write("*");
    }

    Console.WriteLine("");*/


///////////////////////1.1.3////////////////////////
/*    int value = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= value; i++)
{
    int count = i + (i - 1);
    int probels = value - i;
    Console.Write(new String(' ', probels));
    Console.WriteLine(new String('*', count));
}*/

/////////////////////////1.4/////////////////////////
/*int value = Convert.ToInt32(Console.ReadLine());
for (int v = 1;v <= value ;v++) {
    for (int i = 1; i <= v; i++)
    {
        int count = i + (i - 1);
        int probels = value - i;
        Console.Write(new String(' ', probels));
        Console.WriteLine(new String('*', count));
    }
}*/

//////////////////////1.1.5//////////////////////////
/*int sum=0;
for(int i = 3;i<1000; i++)
{
    if (i%5==0||i%3==0)
    {
        sum += i;
    }
}
Console.WriteLine(sum);*/

/////////////////////1.1.6//////////////////////////

/*[Flags]
public enum FontStyle
{
    bold = 1,
    italic = 2,
    underline = 4,
    none = 0
}

public class programm
{
    private static FontStyle _fontStyle;

    public static void Main(string[] args)
    {
       while (true)
        {
            Console.WriteLine("Параметры надписи :" + _fontStyle);
            Console.WriteLine("Введите: \n 1: bold \n 2: italic \n 3: underline");
            string r = Console.ReadLine();
            
            switch (r)
            {
                case "1":
                    _fontStyle |= FontStyle.bold;
                    break;
                case "2":
                    _fontStyle |= FontStyle.italic;
                    break;
                case "3":
                    _fontStyle |= FontStyle.underline;
                    break;
            }
        }
    }
}*/
//прочитать про перечисления(enum) и флаги 

/////////////////////1.1.7///////////////////////////
///{
/*class Program
{
    static void Main(string[] args)
    {
        int minValue = int.MaxValue;
        int maxValue = int.MinValue;
        int[] arr = new int[15];
        Random rand = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(-100, 100);
            Console.WriteLine(arr[i]);
                if ( arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }          
                if(arr[i] < minValue)
                {
                minValue = arr[i];  
                }
        }
        Console.WriteLine("Max " + maxValue);
        Console.WriteLine("Min " + minValue);
    }
}*/

///////////////////////////////////////////////////
/////////////////////1.1.8///////////////////////////
/*class Programm
{
    static void Main(string[] args) 
    {
        int[,,] myArr = new int[5, 6, 7];
        Random rand = new Random();
        
        for (int i = 0; i < myArr.GetLength(0); i++)
        {
            for (int j = 0; j < myArr.GetLength(1); j++)
            {
                for(int k = 0; k < myArr.GetLength(2); k++)
                {
                    myArr[i, j, k] = rand.Next(-100, 100);
                   if( myArr[i, j, k] > 0)
                    {
                        myArr[i, j, k] = 0;
                    }
                    Console.WriteLine(myArr[i,j,k]);
                }
            }
        }
    }
}*/
///прочитать многомерные массивы
///
///////////////////////////////////////////////////
/////////////////////1.1.9///////////////////////////
/*class Programm
{
    static void Main(string[] args)
    {
        int[] myArray = new int[5];
        int values = 0;
        Random rnd = new Random();
        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = rnd.Next(-10, 10);
            if(myArray[i] > 0)
            {
                values += myArray[i]; 
            }
            Console.WriteLine(myArray[i]);
        }
        Console.WriteLine(values);
    }
}*/


///////////////////////////////////////////////////
/////////////////////1.1.10//////////////////////////
/*class Programm
{
    static void Main(string[] args)
    {
        int[,] myArray = new int[5, 4];
        Random random = new Random();
        int values = 0;
        for (int i = 0; i< myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                myArray[i, j] = random.Next(-100,100);
                if ((i+j)%2 == 0)
                {
                    values += myArray[i, j];
                }
                Console.WriteLine(myArray[i, j]);
            }
        }
        Console.WriteLine("Summ polojitelnih = " + values);
    }
}*/
////прочитать вывод массива таблицей

/////////////////////1.2.1//////////////////////////
/*class Programm
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите предложение");
        returnStrings();
        
    }
    public static void returnStrings()
    {
        string strings = Console.ReadLine();
        int a = 0;
        int b = 0;
        char[] chars = { '!', ',', '.', '!', ' ', '?' };
        string[] massivSlov = strings.Split(chars);
        foreach (string s in massivSlov)
        {
            Console.WriteLine(s);
            a += s.Length; 
        }
        b = a / massivSlov.Length;
        Console.WriteLine(b);
    }
}*/
//прочитать регулярные выражения
////////////////////////////////////////////////////
/////////////////////1.2.2//////////////////////////
/*class Programm
{
    static void Main(string[] args)
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();
        StringBuilder str = new StringBuilder();
        for (int i = 0; i < first.Length; i++)
        {
            if(second.Contains(first[i]) == true)
            {
                str.Append(first[i]);
                str.Append(first[i]);
            }
            else
            {
                str.Append(first[i]);
            }
        }
        Console.WriteLine(str);
    }
}*/

////////////////////////////////////////////////////
/////////////////////1.2.3//////////////////////////
/*class Programm
{
    static void Main(string[] args)
    {
        string yourString = Console.ReadLine();
        string[] words = yourString.Split(new char[] { '!', ',', '.', '!', ' ', '?' });
        int wordsLowFirstChar = 0;
        List<string> list = new List<string>();

        foreach (string s in words)
        {
            if (Char.IsLower(s[0]))
            {
                list.Add(s);
                wordsLowFirstChar = list.Count;
            }
        }
        Console.WriteLine("Слов , начинающихся со строчного символа: " + wordsLowFirstChar);
    }
}*/
////////////////////////////////////////////////////
/////////////////////1.2.4//////////////////////////
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите текст: ");
        string str = Console.ReadLine();
        StringBuilder Strings = new StringBuilder();
        var array = str.ToCharArray();
        Strings.Append(Char.ToUpper(array[0]));
        Strings.Append(array[1]);


        for (int i = 2; i < array.Length; i++)
        {
            if (IsRightSymbol(array[i - 2]) && Char.IsLetter(array[i]))
            {
                Strings.Append(Char.ToUpper(array[i]));
            }
            else
            {
                Strings.Append(array[i]);
            }
        }
        Console.WriteLine(Strings);

    }
    static bool IsRightSymbol(char c)
    {
        return c == '.' || c == '!' || c == '?' ;
    }
}
////////////////////////////////////////////////////