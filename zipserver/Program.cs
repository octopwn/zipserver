
using System;
using BasicHTTPServer;

namespace zipserver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(args.Length < 1)
            {
                Console.WriteLine("Args: zipfilepath, address, port");
                return;
            }
            string zipfilepath = args[0];
            string address = "127.0.0.1";
            int port = 8000;
            if (args.Length > 1)
            {
                address = args[1]; 
            }
            if (args.Length > 2)
            {
                port=int.Parse(args[2]);
            }
            Console.WriteLine("http://" + address + ":" + port.ToString());
            SimpleHTTPServer server = new SimpleHTTPServer(zipfilepath, address:address, port:port);
        }
    }
}
