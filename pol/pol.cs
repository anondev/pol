using System;
using System.Windows.Forms;

using FFXiMain;

namespace pol {
    static class pol {
        [STAThread]
        static void Main() {
            FFXiDummy.dummy();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
