using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var symb1 = 'A';
            bool check = Char.IsWhiteSpace(symb1);  // узнаёт является ли simb1 пробелом 
            check = Char.IsUpper(symb1); //bool  верхний регистр - 1, нижний - 0                                                                                                                                              //bool
            check = Char.IsLower(symb1); //bool  верхний регистр - 0, нижний - 1 
            symb1 = Char.ToLower(symb1); // к нижнему регистру
            symb1 = 'a';                 // переопределение строчик 
            var code = (int)symb1; // номер символа 

            var str = String.Empty;   // создание пустой строчки
            str = "Hello";             // присваивание 
            foreach (var e in str) { } // пербор строки
            var str1 = str + " World!";  // добавление в строчку
            str = new string("It is new string");
            str += @"\n"; // @ читает строку как есть
            str += "\\t"; // / отменяет второй /

            str = "{0}" + str; // шаблон для форматирования String.Format
            str = String.Format(str, "~~~~~\n");  // форматирование строки, заменяет предыущий шаблон на "~~~~~\n"

            str = $"{str1}\n{str}"; //str1 + \n + str
            var find = str.Contains("new");   // bool содержит ли new
            var empty = string.IsNullOrEmpty(str); // bool пустая ли
            var strB = new StringBuilder(str);         // инициализация билдера
            strB.AppendLine("Using of StringBuilder");     // добавление строчки в билдер
            str = strB.ToString();                     // присваиваем переменной str всё, что успели внести в билдер
            str = str.Substring(0,5);        //выкидывает первые (5)
            var equal = str.Equals(str1);   //сравнение
       
        }
    }
}
