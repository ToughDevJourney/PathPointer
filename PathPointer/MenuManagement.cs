using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathPointer
{
    static class MenuManagement
    {
        public static bool AreAllFormsClosed { get; set; }
        public static bool questCheck = true;

        public static void ShowMenu(Form form) {
            form.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            mainMenu.TrayIcon.Dispose();
            mainMenu = null;
            
        }

        public static void HideForm(Form form, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                form.Hide();
            }
            AreAllFormsClosed = true;
        }

        public static void TrayShow(Form form) {
            if (AreAllFormsClosed == true) {
                form.Show();
            }
        }

    }
}
