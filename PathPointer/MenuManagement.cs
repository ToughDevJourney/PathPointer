using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathPointer
{
    public static class MenuManagement
    {
        public static bool AreAllFormsClosed { get; set; }
        public static bool questCheck = true;

        public static void HideForm(Form form, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                form.Hide();
            }
            AreAllFormsClosed = true;
        }

        public static void ShowForm(Form sender, Form formToOpen){
            Form form = formToOpen;
            AreAllFormsClosed = false;

            form.Show();
            sender.Hide();
        }

        public static void TrayShow(Form form) {
            if (AreAllFormsClosed == true) {
                form.Show();
            }
        }

    }
}
