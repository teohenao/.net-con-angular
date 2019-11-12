

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LeerXML
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Funcionalidad que permite Leer archivos XML por nodos hijos
             */
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\Mateo Henao R\\Documents\\ArchivoXML.xml");
            XmlNodeList xPersonas = doc.GetElementsByTagName("personas");
            XmlNodeList lista = ((XmlElement)xPersonas[0]).GetElementsByTagName("nombre");

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                if (node.HasChildNodes)
                {
                    for (int i = 0; i < node.ChildNodes.Count; i++)
                    {
                        Console.WriteLine(node.ChildNodes[i].Name + " : " + node.ChildNodes[i].InnerText);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

