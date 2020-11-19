    using System;
using System.IO;

    /// <summary>
    ///    Class to create an upper case copy of a file
    /// </summary>
    public class CopyFileUpper
    {
		public static void Main()
		{
            string sFrom;
            string sTo;
            StreamReader srFrom;
            StreamWriter swTo;
            
            Console.WriteLine("VVedite imya vhodnogo faila");
            sFrom = Console.ReadLine();
            Console.WriteLine("Vvedite imua vihodnoga faila");
            sTo = Console.ReadLine();
            try
            {
            srFrom = new StreamReader(sFrom);
            swTo = new StreamWriter(sTo);
            while (srFrom.Peek()!=-1)
            {
                string sBuffer = srFrom.ReadLine();
                sBuffer = sBuffer.ToUpper();
                swTo.WriteLine(sBuffer);

            }
            swTo.Close();
            srFrom.Close();

            }
            catch(FileNotFoundException)
            {
            Console.WriteLine("Ne tot formay faila");
            }
            catch(Exception)
            {
            Console.WriteLine("Ne ne tot format faila, zhnazchit vse vozmozhnie drugie isklucheniya");
            }
		}       
    }
