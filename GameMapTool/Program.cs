using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMapTool
{
    static class Program
    {
        static Form1 Mainform;

        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Mainform = new Form1();
            MapPalette.Initialize();
            Application.Run(Mainform);
        }

        static public Form1 GetMainfrom()
        {
            return Mainform;
        }

       
    }
}
