using System;
using System.Globalization;
using System.Windows.Forms;

namespace fyiReporting.RdlDesign
{
    public class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string version = typeof(Program).Assembly.GetName().Version.ToString().Replace(".", "");

            string ipcChannelPortName = string.Format("RdlProject{0}", version);
            // Determine if an instance is already running?
            bool firstInstance;
            string mName = string.Format("Local\\RdlDesigner{0}", version);
            //   can't use Assembly in this context
            System.Threading.Mutex mutex = new System.Threading.Mutex(false, mName, out firstInstance);

            if (firstInstance)
            {
                // just start up the designer when we're first in line
                var thread = System.Threading.Thread.CurrentThread;

                try
                {
                    thread.CurrentCulture = new CultureInfo(DialogToolOptions.DesktopConfiguration.Language);
                }
                catch
                {
                    thread.CurrentCulture = new CultureInfo(thread.CurrentCulture.Name);
                }

                if (thread.CurrentCulture.Equals(CultureInfo.InvariantCulture))
                {
                    thread.CurrentCulture = new CultureInfo("en-US");
                }
                // for working in non-default cultures
                thread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ".";
                thread.CurrentUICulture = thread.CurrentCulture;

                Application.EnableVisualStyles();
                Application.DoEvents();

                var rdlDesigner = new RdlDesigner(ipcChannelPortName, true);

                var args = Environment.GetCommandLineArgs();
                string fileName = null;
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i] == "-f" && i + 1 < args.Length)
                    {
                        fileName = args[i + 1];
                        i++;
                    }
                }

                if (!string.IsNullOrWhiteSpace(fileName))
                {
                    rdlDesigner.OpenFile(fileName);
                }

                Application.Run(rdlDesigner);
                return;
            }

            // Process already running.   Notify other process that is might need to open another file
        }
    }
}
