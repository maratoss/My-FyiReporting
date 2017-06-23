namespace fyiReporting.RdlViewer
{
    using System;
    using System.Drawing.Printing;

    using RdlEngine;

    public class PrintManager
    {
        private const string SET_DEFAULT_PRINTER = "Default";

        public static void SilentPrint(string reportPath, string parameters, string printerName = null)
        {
            LogManager.Logger.Info("start printing\n" + reportPath + " " + parameters + " " + printerName);

            var rdlViewer = new fyiReporting.RdlViewer.RdlViewer();
            rdlViewer.Visible = false;
            rdlViewer.SourceFile = new Uri(reportPath);
            rdlViewer.Parameters = parameters;
            rdlViewer.Rebuild();

            var pd = new PrintDocument();
            pd.DocumentName = rdlViewer.SourceFile.LocalPath;
            pd.PrinterSettings.FromPage = 1;
            pd.PrinterSettings.ToPage = rdlViewer.PageCount;
            pd.PrinterSettings.MaximumPage = rdlViewer.PageCount;
            pd.PrinterSettings.MinimumPage = 1;
            pd.DefaultPageSettings.Landscape = rdlViewer.PageWidth > rdlViewer.PageHeight;
            pd.PrintController = new StandardPrintController();
            // convert pt to hundredths of an inch.
            pd.DefaultPageSettings.PaperSize = new PaperSize(
                "",
                (int)((rdlViewer.PageWidth / 72.27) * 100),
                (int)((rdlViewer.PageHeight / 72.27) * 100));

            if (!string.IsNullOrWhiteSpace(printerName) && printerName != SET_DEFAULT_PRINTER)
            {
                pd.DefaultPageSettings.PrinterSettings.PrinterName = printerName;
            }

            try
            {
                if (pd.PrinterSettings.PrintRange == PrintRange.Selection)
                {
                    pd.PrinterSettings.FromPage = rdlViewer.PageCurrent;
                }

                rdlViewer.Print(pd);
                LogManager.Logger.Info("printing end");
            }
            catch (Exception ex)
            {
                LogManager.Logger.Error(ex);
            }
        }

        public static void SilentPrintFromSource(string sourceRdl, string parameters, string printerName = null)
        {
            LogManager.Logger.Debug("printing started. rdl:\n" + sourceRdl);

            var rdlViewer = new RdlViewer();
            rdlViewer.Visible = false;
            rdlViewer.SourceRdl = sourceRdl;
            rdlViewer.Parameters = parameters;
            rdlViewer.Rebuild();

            var pd = new PrintDocument();
            pd.DocumentName = "lm solo printing";
            pd.PrinterSettings.FromPage = 1;
            pd.PrinterSettings.ToPage = rdlViewer.PageCount;
            pd.PrinterSettings.MaximumPage = rdlViewer.PageCount;
            pd.PrinterSettings.MinimumPage = 1;
            pd.DefaultPageSettings.Landscape = rdlViewer.PageWidth > rdlViewer.PageHeight;
            pd.PrintController = new StandardPrintController();
            // convert pt to hundredths of an inch.
            pd.DefaultPageSettings.PaperSize = new PaperSize(
                "",
                (int)((rdlViewer.PageWidth / 72.27) * 100),
                (int)((rdlViewer.PageHeight / 72.27) * 100));

            if (!string.IsNullOrWhiteSpace(printerName) && printerName != SET_DEFAULT_PRINTER)
            {
                pd.DefaultPageSettings.PrinterSettings.PrinterName = printerName;
            }

            try
            {
                if (pd.PrinterSettings.PrintRange == PrintRange.Selection)
                {
                    pd.PrinterSettings.FromPage = rdlViewer.PageCurrent;
                }

                rdlViewer.Print(pd);
                LogManager.Logger.Info("printing end");
            }
            catch (Exception ex)
            {
                LogManager.Logger.Error(ex);
            }
        }
    }
}