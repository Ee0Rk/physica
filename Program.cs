﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using physica.editor;
using System.Windows.Forms;

namespace physica
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new editorWindow());
        }
    }
}
