using System;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;
namespace pract44
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создать Словарь, нечувствительный к регистру и независимый от культуры.
            ListDictionary list = new ListDictionary(new CaseInsensitiveComparer(CultureInfo.InvariantCulture));
            // Добавить несколько элементов
            list["Estados Unidos"] = "United States of America";
            list["Canada"] = "Canada";
            list["Espana"] = "Spain";
            //  Показать результаты
            Console.WriteLine(list["Estados Unidos"]);
            Console.WriteLine(list["Canada"]);
            Console.WriteLine(list["Espana"]);
        }
    }

}
    

