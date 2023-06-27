using System.Reflection.PortableExecutable;
using System.Xml;

namespace BettingData.BLL.Services
{
    public class XmlReaderService
    {
        private readonly String _URLString = "https://sports.ultraplay.net/sportsxml?clientKey=9C5E796D-4D54-42FD-A535-D7E77906541A&sportId=2357&days=7";
        private readonly XmlTextReader _reader;

        public XmlReaderService()
        {
            _reader = new XmlTextReader(_URLString);
        }

        public void ReadFile()
        {
            while (_reader.Read())
            {
                // Do some work here on the data.
                Console.WriteLine(_reader.Name);
            }

            Console.ReadLine();
        }
    }
}
