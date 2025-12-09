using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace SNGenerator
{
    public class Messages
    {
        private readonly StreamReader _msgReader;
        private readonly string[] messages;

        public string this[int index]
        {
            get
            {
                return messages[index];
            }
        }

        public Messages()
        {
            _msgReader = new StreamReader("C:\\Users\\Lenovo\\source\\repos\\SNGenerator\\Messages.txt");
            messages = _msgReader.ReadToEnd().Split('$');
        }

        ~Messages()
        {
            _msgReader.Close();
        }

        public static Messages GetInstance() => new Messages();

    }
}
