using System.Diagnostics;
using System;

namespace CyrillicToLatinWordPlugIn
{
    public partial class ThisPlugIn
    {
        private ConvertButton convertButton;
        private void ThisPlugIn_Startup(object sender, EventArgs e)
        {
            Debug.WriteLine("ThisPlugIn_Startup called");
            convertButton = new ConvertButton();
        }

        private void ThisPlugIn_Shutdown(object sender, EventArgs e)
        {
            Debug.WriteLine("ThisPlugIn_Shutdown called");
            convertButton?.ConvertButton_Unload();
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisPlugIn_Startup);
            this.Shutdown += new System.EventHandler(ThisPlugIn_Shutdown);
        }
        
        #endregion
    }
}
