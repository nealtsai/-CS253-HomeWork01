using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Result
    {
        public static void GetResult(int GuestA, int GuestB)
        {
            string message = "GuestA {0}, GuestB {1}, Result [ {2} ]";
            string result;
            string guestAInput;
            string guestBInput;
            if (GuestA == GuestB)
            {
                result = "Draw";
            }
            else if ((GuestA == 1 && GuestB == 2) || (GuestA == 2 && GuestB == 3) || (GuestA == 3 && GuestB == 1))
            {
                result = "GuestB Victory";
            }
            else
            {
                result = "GuestA Victory";
            }

            if (GuestA == 1)
            {
                guestAInput = "剪刀";
            }
            else if (GuestA == 2)
            {
                guestAInput = "石頭";
            }
            else guestAInput = "布";

            if (GuestB == 1)
            {
                guestBInput = "剪刀";
            }
            else if (GuestB == 2)
            {
                guestBInput = "石頭";
            }
            else guestBInput = "布";
            message = string.Format(message, guestAInput, guestBInput, result);
            Console.WriteLine(message);
        }
    }
}