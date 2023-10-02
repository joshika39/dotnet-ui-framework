using UiFramework.Forms.Manual.Tests.Main;
using UiFramework.Shared;
using DialogResult = UiFramework.Shared.DialogResult;

namespace UiFramework.Forms.Manual.Tests.Main
{
    public partial class MainWindow : Form, IMainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        public DialogResult ShowOnTop()
        {
            var result = ShowDialog();

            switch (result)
            {
                case System.Windows.Forms.DialogResult.Cancel:
                case System.Windows.Forms.DialogResult.Abort:
                    return Shared.DialogResult.Cancelled;
                case System.Windows.Forms.DialogResult.Yes:
                case System.Windows.Forms.DialogResult.OK:
                    return Shared.DialogResult.Resolved;
                case System.Windows.Forms.DialogResult.None:
                case System.Windows.Forms.DialogResult.Retry:
                case System.Windows.Forms.DialogResult.Ignore:
                case System.Windows.Forms.DialogResult.No:
                case System.Windows.Forms.DialogResult.TryAgain:
                case System.Windows.Forms.DialogResult.Continue:
                default:
                    throw new InvalidOperationException("Unsupported dialog result!");
            }
        }
    }
}

