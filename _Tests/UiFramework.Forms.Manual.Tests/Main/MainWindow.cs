using DialogResult = UiFramework.Shared.DialogResult;

namespace UiFramework.Forms.Manual.Tests.Main
{
    public partial class MainWindow : Form, IMainWindow
    {
        public IMainWindowPresenter Presenter { get; }
        public MainWindow(IMainWindowPresenter presenter)
        {
            Presenter = presenter ?? throw new ArgumentNullException(nameof(presenter));
            InitializeComponent();
        }
        
        public DialogResult ShowOnTop()
        {
            return ShowDialog() == System.Windows.Forms.DialogResult.OK ? 
                Shared.DialogResult.Resolved : 
                Shared.DialogResult.Cancelled;
        }
        
    }
}

