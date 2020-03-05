
namespace sampleSite
{
    using System;

    [Mobilize.WebMap.Common.Attributes.Observable]
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            (Mobilize.Web.Application.CurrentApplication as sample.Application).DoWmInit();
            if (args != null)
            {
                (Mobilize.Web.Application.CurrentApplication as sample.Application).OpenWindow(string.Join(" ", args));
            }
            else
            {
                (Mobilize.Web.Application.CurrentApplication as sample.Application).OpenWindow(string.Empty);
            }
        }
    }
}

