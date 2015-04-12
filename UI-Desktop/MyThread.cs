using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class MyThread
    {
        public static void ShowFromToMain()
        {
            Application.Run(new ShowForm());
        }
        public static void MainFromToShow()
        {
            Application.Run(new MainForm());
        }
       
    }
}
