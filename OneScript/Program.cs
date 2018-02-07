using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using OnePoint.OneScript.Model;

namespace OneScript
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OneScript APP");
            Console.WriteLine("--------------");
            XmlDocument xmlDoc = new XmlDocument();
            StringBuilder script = new StringBuilder();
            string filename = @"C:\Media\my.txt";

            xmlDoc.Load(filename);
           
            script = new QuestionEditorScript().GenerateScript(xmlDoc.InnerXml.ToString());
            string xml = script.ToString();
            Console.WriteLine(xml);
            Console.ReadLine();
        }
    }
}
