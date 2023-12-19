using System;
using System.IO;
using System.Text;

namespace Geeks
{

    class uhhuhuh
    {

        static void Main(string[] args)
        {

            string strPath = "C:\\Users\\Елизавета\\OneDrive\\Рабочий стол\\хлам\\imtrying.jpg";

            string filename = null;

            filename = Path.GetFileName(strPath);
            Console.WriteLine("File = " + filename);

            Console.ReadLine();
        }
    }
}