using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class User
    {
        public static int UserInput()
        {
            Console.Write("請輸入你要出的招：1.剪刀，2.石頭，3.布 : ");
            return int.Parse(Console.ReadLine());
        }

        public static int NpcInput()
        {
            Random random = new Random();
            return random.Next(1, 4);
        }
    }
}