using System;
using System.Collections.Generic;
using System.Globalization;


namespace OsobyPlikMaleWielkie
{
    class DownloadDataFromFile
    {

        public static string[] array = System.IO.File.ReadAllLines(@"D:\c#\2017-UG\Zadania-Szymon\2017-02-23\data.txt");

        public void PrintArray()
        {
            foreach (var data in array)
            {
                Console.WriteLine(data);
            }
        }


        public void TrimAfterMonkey()
        {
            for (int i = 0; i < array.Length; i++)
            {
                //int index = array[i].LastIndexOf("@");//poniżej visual zaproponował, nie wiem co to StringComparison.Ordinal...
                int index = array[i].LastIndexOf("@", StringComparison.Ordinal);
                if (index > 0)
                    array[i] = array[i].Substring(0, index);
            }
        }

        public void ReplaceDotToSpace()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i].Replace(".", " ");
            }
        }


        public string ToTitleCase(string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }


        public void FirstCharToUpper()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(array[i].ToLower());
            }
        }

        
        public void RecordToFile()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\c#\2017-UG\Zadania-Szymon\2017-02-23\data-new.txt"))
            {
                foreach (string line in array)
                {
                    file.WriteLine(line);
                }
            }
        }
    }
}




