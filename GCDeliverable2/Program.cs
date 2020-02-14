using System;
using System.Text;

namespace GCDeliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            byte[] message;
            int checksum = 0;
            ASCIIEncoding ascii = new ASCIIEncoding();

            Console.WriteLine("Please enter a word.");
            input = Console.ReadLine();
            input = input.ToUpper();

            message = ascii.GetBytes(input);
            Console.WriteLine("Your encoded message is:");

            foreach (Byte b in message)
            {
                Console.Write("{0}-", b - 64);
                checksum = checksum + b;
            }
            Console.WriteLine();
           
            Console.WriteLine("Message checksum is " + checksum);
        }
    }
}
