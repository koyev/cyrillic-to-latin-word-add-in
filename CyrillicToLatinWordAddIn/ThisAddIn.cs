using System.Diagnostics;
using System;

namespace CyrillicToLatinWordAddIn
{
    public partial class ThisAddIn
    {
        private ConvertButton convertButton;
        private void ThisAddIn_Startup(object sender, EventArgs e)
        {
            Debug.WriteLine("ThisAddIn_Startup called");
            convertButton = new ConvertButton();
        }

        private void ThisAddIn_Shutdown(object sender, EventArgs e)
        {
            Debug.WriteLine("ThisAddIn_Shutdown called");
            convertButton?.ConvertButton_Unload();
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
