using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace SNGenerator
{
    public class Generator
    {
        readonly private StreamReader _namesReader;
        readonly private StreamReader _adjReader;
        readonly private Random random = new Random();


        private string GetName()
        {
            string[] names = _namesReader.ReadToEnd().Split('$');
            return names[random.Next(names.Length)];
        }

        private string GetAdjective()
        {
            string[] adjectives = _adjReader.ReadToEnd().Split('$');
            return adjectives[random.Next(adjectives.Length)];
        }

        public string GetSN()
        {
            return $"{GetName()} {GetAdjective()}";
        }

        public Generator()
        {
            _namesReader = new StreamReader("C:\\Users\\Lenovo\\source\\repos\\SNGenerator\\Names.txt");
            _adjReader = new StreamReader("C:\\Users\\Lenovo\\source\\repos\\SNGenerator\\Adjectives.txt");
        }

        ~Generator()
        {
            _adjReader.Close();
            _namesReader.Close();
        }

        public static Generator GetInstance() => new Generator();
    }
}
