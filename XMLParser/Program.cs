using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XMLParser
{
    class Program
    {
        static void Main(string[] args)
        {

            XmlDocument xml = new XmlDocument();
            xml.Load("whatever.xml");
            XDocument doc = XDocument.Load( "whatever.xml" );
            var platforms = doc.Descendants("platform_name");

            foreach (var platform in platforms)
            {
                Console.WriteLine(platform.Value);
            }
            Console.ReadLine();

            

            /*  
             while (reader.Read())
             {
                switch (reader.NodeType)
                 {
                     case XmlNodeType.Element: // The node is an element.
                         Console.Write("<" + reader.Name);

                         while (reader.MoveToNextAttribute()) // Read the attributes.
                             Console.Write(" " + reader.Name + "='" + reader.Value + "'");
                         Console.WriteLine(">");
                         break;
                 } 
             } 
             */

            Console.ReadLine();
        }
    }
}
