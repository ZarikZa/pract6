using Newtonsoft.Json;
namespace converter
{
    internal class Program
    {
        public static List<chapman> sigi = new List<chapman>();
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            Console.WriteLine("Нажмите любую клавишу");
            do
            {
                key = Console.ReadKey();
                Console.Clear();
                if (key.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);

                }
                if (key.Key != ConsoleKey.F1)
                {
                    Console.WriteLine("Введите полный путь до файла, который хотите открыть");
                    Console.WriteLine("*****************************************************");
                    string path = Console.ReadLine();

                    convertjsxml seve = new convertjsxml(path);

                    bool proverkatxt = path.Contains(".txt");
                    bool proverkajson = path.Contains(".json");
                    bool proverkaxml = path.Contains(".xml");
                
                    if (proverkatxt == true)
                    {
                        Console.Clear();
                        Console.WriteLine("F1 - сохранение в json, txt или xml, Escape(x2) - закрыть программу");
                        convertjsxml.txt();
                        
                    }
                    else if (proverkajson == true)
                    {
                        Console.Clear();
                        Console.WriteLine("F1 - сохранение в json, txt или xml, Escape(x2) - закрыть программу");
                        sigi = convertjsxml.deserjson(sigi);
                    }   
                    else if (proverkaxml == true)
                    {
                        Console.Clear();
                        Console.WriteLine("F1 - сохранение в json, txt или xml, Escape(x2) - закрыть программу");
                        List<chapman> df = convertjsxml.deserxml(sigi);
                    }
                }
                if (key.Key == ConsoleKey.F1)
                {
                    Console.WriteLine("Введите путь для сохранения файла");
                    Console.WriteLine("**********************************");
                    string pathsave = Console.ReadLine();
                    save puti = new save(pathsave);
                    bool proverkatxt2 = pathsave.Contains(".txt");
                    bool proverkajson2 = pathsave.Contains(".json");
                    bool proverkaxml2 = pathsave.Contains(".xml");
                    if (proverkatxt2 == true)
                    {
                        save.textsave();

                    }
                    else if (proverkajson2 == true)
                    {
                        Console.Clear();
                        save.savejson();

                    }
                    else if (proverkaxml2 == true)
                    {
                        Console.Clear();
                        save.xml();


                    }
                }
            } while (key.Key != ConsoleKey.Escape);
        }
    }
}