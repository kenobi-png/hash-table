using System;
using System.Collections;

class Example
{
    public static void Main()
    {
        Hashtable openWith = new Hashtable();

        openWith.Add("АО", "Апелляционный орган");
        openWith.Add("АЭС", "Атомная электростанция");
        openWith.Add("ГЭС", "Гидроэлектростанция");
        openWith.Add("ЗИС", "Заинтересованные стороны");

        try
        {
            openWith.Add("АО", "Акционерное общество");
        }
        catch
        {
            Console.WriteLine("Элемент с ключом = \"АО\" уже существует.");
        }

        Console.WriteLine("Для ключа = \"ЗИС\", значение = {0}.", openWith["ЗИС"]);

        
        openWith["ЧП"] = "Чрезвычайное происшествие";
        Console.WriteLine("Для ключа = \"ЗИС\", значение = {0}.", openWith["ЗИС"]);

        
        openWith["ГЭ"] = "Чрезвычайное происшествие";

       
        if (!openWith.ContainsKey("ДК"))
        {
            openWith.Add("ДК", "Двусторонняя комиссия");
            Console.WriteLine("Добавление ключа = \"ДК\": {0}", openWith["ДК"]);
        }

        Console.WriteLine();
        foreach (DictionaryEntry de in openWith)
        {
            Console.WriteLine("Ключ = {0}, Значение = {1}", de.Key, de.Value);
        }

        ICollection valueColl = openWith.Values;

        Console.WriteLine();
        foreach (string s in valueColl)
        {
            Console.WriteLine("Значение = {0}", s);
        }

        ICollection keyColl = openWith.Keys;

        Console.WriteLine();
        foreach (string s in keyColl)
        {
            Console.WriteLine("Ключ = {0}", s);
        }
        
        Console.WriteLine("\nВозврат(\"ГЭ\")");
        openWith.Remove("ГЭ");

        if (!openWith.ContainsKey("ГЭ"))
        {
            Console.WriteLine("Ключ \"ГЭ\" не найден.");
        }
        Console.ReadKey();
    }
}

