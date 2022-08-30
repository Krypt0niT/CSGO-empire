using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSGO_empire
{

    class Program
    {


        //---------tohto sa nechytat
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        //-----------------------------
        


        static void Main(string[] args)
        {
            

            void Click(int x,int y)
            {
                SetCursorPos(x, y);
                mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
            }
            void Click_CLEAR()
            {
                Click(986, 423);
            }
            void Click_001()
            {
                Click(1045, 423);
            }
            void Click_X2()
            {
                Click(1363,423);
            }

            


            


            

            void StartRound()
            {
                Click_CLEAR();
                Click_001();
                Click_X2();
                Click_X2();
                Click_X2();
            }

            StartRound();
            

            Console.ReadLine();
        }
        
    }
}
