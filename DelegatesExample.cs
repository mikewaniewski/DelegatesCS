using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            myDelegate md = null;
            md += printMessage;
            md += printMessage2;
            md += printMessage2;
            md -= printMessage2;
           

            md += delegate(string _msg, string _msg2)
                    {
                        Console.WriteLine(String.Format("Call from anonymous delegate: {0} {1}", _msg, _msg2));
                    };
            md.Invoke("testMessage", "msg2");
            Console.ReadLine();
        }

        public delegate void myDelegate(string _myMessage, string _myMessage2);

        static void printMessage(string _msg, string _msg2)
        {
            Console.WriteLine(String.Format("Message printed by printMessage method: {0} {1}", _msg, _msg2));
        }

        static void printMessage2(string _msg, string _msg2)
        {
            Console.WriteLine(String.Format("Message printed by the second method: {0} {1}", _msg, _msg2 ));
        }
    }
}
