using converter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace converter
{
    internal class convertjsxml
    {
        public static string pathfile;
        public convertjsxml(string path)
        {
            pathfile = path;
        }

        private static List<chapman> sigi = new List<chapman>();
        private static chapman txt1 = new chapman();
        public static List<chapman> txt()
        {
            string[] txt = File.ReadAllLines(pathfile);
            foreach (string line in txt)
            {
                Console.WriteLine(line);
            }
            List<chapman> sigi1 = text(sigi);
            return sigi1;
        }
        public static List<chapman> deserjson(List<chapman> jsonpls)
        {
            string txtjson = File.ReadAllText(pathfile);
            jsonpls = JsonConvert.DeserializeObject<List<chapman>>(txtjson);
            foreach (var item in jsonpls)
            {
                Console.WriteLine(item.name);
                Console.WriteLine(item.description);
                Console.WriteLine(item.price);
            }
            return jsonpls;
        }
        public static string json()
        {
            sigi = text(sigi);
            string json = JsonConvert.SerializeObject(sigi);
            return json;
        }
        public static List<chapman> deserxml(List<chapman> txt1)
        {
            XmlSerializer xmlconv = new XmlSerializer(typeof(List<chapman>));
            using (FileStream fs2 = new FileStream(pathfile, FileMode.Open))
            {
                txt1 = (List<chapman>)xmlconv.Deserialize(fs2);
            }


            foreach (var item in txt1)
            {
                Console.WriteLine(item.name);
                Console.WriteLine(item.description);
                Console.WriteLine(item.price);
            }
            return txt1;
        }
        public static List<chapman> text(List<chapman> txt)
        {
           
            List<chapman> txt1 = new List<chapman>();
            chapman xmk = new chapman();
            if (pathfile.EndsWith(".json"))
            {
                txt1 = deserjson(txt1);
                Console.Clear();
            }
            if (pathfile.EndsWith(".xml"))
            {
                txt1 = deserxml(txt1);
                Console.Clear();
            }
            if (pathfile.EndsWith(".txt"))
            {
                string[] txtfile = File.ReadAllLines(pathfile);
                for (int i = 0; i < 1; i++)
                {
                    xmk.name = txtfile[0];
                    xmk.description = txtfile[1];
                    xmk.price = txtfile[2];
                }
                txt1.Add(xmk);
            }
            return txt1;
        }
    }
}
