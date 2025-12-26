namespace CyrillicToLatinWordPlugIn
{
    partial class ConvertButton : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public ConvertButton()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.convertGroup = this.Factory.CreateRibbonGroup();
            this.convertBtn = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.convertGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.ControlId.OfficeId = "TabHome";
            this.tab1.Groups.Add(this.convertGroup);
            this.tab1.Label = "Home";
            this.tab1.Name = "tab1";
            // 
            // convertGroup
            // 
            this.convertGroup.Items.Add(this.convertBtn);
            this.convertGroup.Name = "convertGroup";
            this.convertGroup.Position = this.Factory.RibbonPosition.AfterOfficeId("GroupClipboard");
            // 
            // convertBtn
            // 
            this.convertBtn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.convertBtn.Label = "Cyrilic/Latin";
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.ShowImage = true;
            this.convertBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.convertBtn_Click);
            // 
            // ConvertButton
            // 
            this.Name = "ConvertButton";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.ConvertButton_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.convertGroup.ResumeLayout(false);
            this.convertGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup convertGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton convertBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
    }

    partial class ThisRibbonCollection
    {
        internal ConvertButton ConvertButton
        {
            get { return this.GetRibbon<ConvertButton>(); }
        }
    }
}
