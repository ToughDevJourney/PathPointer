﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathPointer
{
    class MenuManagement
    {
        public static void ShowMenu(Form form) {
            form.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        public static void HideForm(Form form, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                form.Hide();
            }
        }

    }
}