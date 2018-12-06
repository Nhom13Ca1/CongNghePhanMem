using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace ApplicationWinform
{
    static class Program
    {
        public static FrmMain frmmain = null;
        public static FrmLogin frmlogin = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            frmlogin = new FrmLogin();
            Application.Run(frmlogin);
            //Application.Run(new FrmMain());
        }
    }
}
