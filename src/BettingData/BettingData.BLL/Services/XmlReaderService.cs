using BettingData.DAL.Entities;
using System.Data.SqlTypes;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace BettingData.BLL.Services
{
    public class XmlReaderService
    {
        private readonly String _URLString = @"https://sports.ultraplay.net/sportsxml?clientKey=9C5E796D-4D54-42FD-A535-D7E77906541A&sportId=2357&days=7";
        private readonly XmlTextReader _reader;

        public XmlReaderService()
        {
            _reader = new XmlTextReader(_URLString);
        }

        public string GetXmlString()
        {
            string text;
            using (var client = new WebClient())
            {
                text = client.DownloadString(_URLString);
            }

            File.WriteAllText("data.xml", text, Encoding.Unicode);

            return text;
        }

        public void ReadXml()
        {
            GetXmlString();

            Console.WriteLine("Output using LINQ");
            foreach (XElement xElement in XElement.Load(@"data.xml").Elements("Sport"))
            {
                Console.WriteLine(xElement.Attribute("ID").Value);
                Console.WriteLine(xElement.Attribute("Name").Value);
                Console.WriteLine();

                var events = xElement.Elements("Event");
                foreach (var item in events)
                {
                    Console.WriteLine(item.FirstAttribute.Value);
                }
            }
        }

        public void SportToObject(string name, string id)
        {
            Sport sport = new Sport() 
            { 
                Id = id,
                Name = name
            };
        }
    }
}
