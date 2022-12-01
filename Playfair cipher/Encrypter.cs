using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playfair_cipher
{
    public class Encrypter
    {
        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ !,.".ToCharArray(); // 30 символов 
        public string outtext = "";

        public void Encryption(string word, string key)
        {
            int i_first = 0, i_second = 0, j_first = 0, j_second = 0; // индексы 
            string sumbol1 = "", sumbol2 = ""; //строки для хранения зашифрованного символа 
            int rows = 5, columns = 6; // таблица 5x6 элементов
            var table = CreateTable(key, rows, columns);

            int wordlength = word.Length; // длинна слова
            if (wordlength % 2 != 0) // если длинна слова нечет - добавление справа до чет
                word = word.PadRight(wordlength + 1, 'Z');
            wordlength += 1;

            int len = wordlength / 2;
            string[] str = new string[len]; //новый массив
            int l = -1; //служебная переменная
            for (int i = 0; i < wordlength; i += 2) //в старом массиве шаг равен 2
            {
                l++; //индексы для нового массива 
                if (l < len) //Элемент_нового_массива[i] =  Элемент_старого_массива[i] +  Элемент_старого_массива[i+1]
                    str[l] = Convert.ToString(word[i]) + Convert.ToString(word[i + 1]);
            }


            ///координаты очередного найденного символа из каждой пары
            foreach (string both in str)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        //координаты первого символа пары в исходной матрице
                        if (both[0] == (table[i, j]))
                        {
                            i_first = i;
                            j_first = j;
                        }
                        //координаты второго символа пары в исходной матрице
                        if (both[1] == (table[i, j]))
                        {
                            i_second = i;
                            j_second = j;
                        }
                    }
                }
                ///если пара символов находится в одной строке
                if (i_first == i_second)
                {
                    if (j_first == columns - 1) /*если символ последний в строке, кодируем его первым символом из матрицы*/
                        sumbol1 = Convert.ToString(table[i_first, 0]);
                    //если символ не последний, кодируем его стоящим справа от него
                    else
                        sumbol1 = Convert.ToString(table[i_first, j_first + 1]);
                    if (j_second == columns - 1) /*если символ последний в строке кодируем его первым символом из матрицы*/
                        sumbol2 = Convert.ToString(table[i_second, 0]);
                    //если символ не последний, кодируем его стоящим справа от него
                    else
                        sumbol2 = Convert.ToString(table[i_second, j_second + 1]);
                }
                ///если пара символов находится в одном столбце
                if (j_first == j_second)
                {
                    if (i_first == rows - 1)
                        sumbol1 = Convert.ToString(table[0, j_first]);
                    else
                        sumbol1 = Convert.ToString(table[i_first + 1, j_first]);
                    if (i_second == rows - 1)
                        sumbol2 = Convert.ToString(table[0, j_second]);
                    else
                        sumbol2 = Convert.ToString(table[i_second + 1, j_second]);
                }
                ///если пара символов находиться в разных столбцах и строках
                if (i_first != i_second && j_first != j_second)
                {
                    sumbol1 = Convert.ToString(table[i_first, j_second]);
                    sumbol2 = Convert.ToString(table[i_second, j_first]);
                }
                if (sumbol1 == sumbol2)
                    outtext = outtext + sumbol1 + "Z" + sumbol2;
                else //записыавем результат кодирования
                    outtext = outtext + sumbol1 + sumbol2;
            }
        }

        public void Descryption(string word, string key)
        {
            int i_first = 0, i_second = 0, j_first = 0, j_second = 0; // индексы 
            string sumbol1 = "", sumbol2 = ""; //строки для хранения зашифрованного символа 
            int rows = 5, columns = 6; // таблица 5x6 элементов
            var table = CreateTable(key, rows, columns);


            for (int i = 1; i < word.Length - 1; i++)
                if (word[i - 1] == word[i + 1] && word[i] == 'Z') // 
                    word = word.Remove(i, 1);


            int wordlength = word.Length;
            int len = wordlength / 2;
            string[] str = new string[len]; //новый массив
            int l = -1; //служебная переменная
            for (int i = 0; i < wordlength; i += 2) //в старом массиве шаг равен 2
            {
                l++; //индексы для нового массива 
                if (l < len) //Элемент_нового_массива[i] =  Элемент_старого_массива[i] +  Элемент_старого_массива[i+1]
                    str[l] = Convert.ToString(word[i]) + Convert.ToString(word[i + 1]);
            }
            ///координаты очередного найденного символа из каждой пары
            foreach (string both in str)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        //координаты первого символа пары в исходной матрице
                        if (both[0] == (table[i, j]))
                        {
                            i_first = i;
                            j_first = j;
                        }
                        //координаты второго символа пары в исходной матрице
                        if (both[1] == (table[i, j]))
                        {
                            i_second = i;
                            j_second = j;
                        }
                    }
                }
                ///если пара символов находится в одной строке
                if (i_first == i_second)
                {
                    if (j_first == 0) //если символ последний в строке, кодируем его первым символом из матрицы
                        sumbol1 = Convert.ToString(table[i_first, columns - 1]);
                    else //если символ не последний, кодируем его стоящим справа от него
                        sumbol1 = Convert.ToString(table[i_first, j_first - 1]);
                    if (j_second == 0) /*если символ последний в строке кодируем его первым символом из матрицы*/
                        sumbol2 = Convert.ToString(table[i_second, columns - 1]);
                    else //если символ не последний, кодируем его стоящим справа от него
                        sumbol2 = Convert.ToString(table[i_second, j_second - 1]);
                }
                ///если пара символов находится в одном столбце
                if (j_first == j_second)
                {
                    if (i_first == 0)
                        sumbol1 = Convert.ToString(table[rows - 1, j_first]);
                    else
                        sumbol1 = Convert.ToString(table[i_first - 1, j_first]);
                    if (i_second == 0)
                        sumbol2 = Convert.ToString(table[rows - 1, j_second]);
                    else
                        sumbol2 = Convert.ToString(table[i_second - 1, j_second]);
                }
                ///если пара символов находиться в разных столбцах и строках
                if (i_first != i_second && j_first != j_second)
                {
                    sumbol1 = Convert.ToString(table[i_first, j_second]);
                    sumbol2 = Convert.ToString(table[i_second, j_first]);
                }
                outtext = outtext + sumbol1 + sumbol2;
            }
            wordlength = outtext.Length; // длинна слова
            if (wordlength % 2 == 0 && outtext[wordlength - 1] == 'Z') // если длинна слова нечет - добавление справа до чет
                outtext = outtext.Remove(wordlength - 1, 1);
        }

        public char[,] CreateTable(string key, int rows, int columns)
        {
            int keylength = 0;
            var table = new char[rows, columns];
            if (!(key == null || key == ""))
            {
                for (int i = 0; i < key.Length; i++) // заполнение ключем
                    table[i / columns, i % columns] = key[i];
                alphabet = alphabet.Except(key).ToArray(); // исключение из алфавита букв ключа
                keylength = key.Length;
            }
            for (int i = 0; i < alphabet.Length; i++) // заполнение таблицы
            {
                int position = i + keylength;
                table[position / columns, position % columns] = alphabet[i];
            }
            return table;
        }
    }
}
