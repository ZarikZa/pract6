using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace converter
{
    internal class save
    {

        private static string pathsave;
        public save(string path)
        {
            pathsave = path;
        }
        
        public static void savejson()
        {
            string json = convertjsxml.json();
            File.WriteAllText(pathsave, json);
            Console.WriteLine("Файл успешно сохранён .-.- / .-- / ---- --- -.- .");
            Environment.Exit(0);
        }
        public static void xml()
        {
            List<chapman> txt1 = convertjsxml.txt();
            XmlSerializer xmlconv = new XmlSerializer(typeof(List<chapman>));
            using (FileStream fs = new FileStream(pathsave, FileMode.OpenOrCreate))
            {
                xmlconv.Serialize(fs, txt1);
            }
            Console.Clear();
            Console.WriteLine("Файл успешно сохранён .-.- / .-- / ---- --- -.- .");
            Environment.Exit(0);
        }
        public static void textsave()
        {
            List<chapman> text2 = new List<chapman>();
            text2 = convertjsxml.text(text2);
            string txt = "";
            string txt1 = "";
            string txt2 = "";
            foreach (var item in text2)
            {
               txt = Convert.ToString(item.name + "\n");
               txt1 = Convert.ToString(item.description + "\n");
               txt2 = Convert.ToString(item.price);
            }
            File.AppendAllText(pathsave, txt);
            File.AppendAllText(pathsave, txt1);
            File.AppendAllText(pathsave, txt2);
            Console.WriteLine("Файл успешно сохранён .-.- / .-- / ---- --- -.- .");
            Environment.Exit(0);
        }
    }
}
