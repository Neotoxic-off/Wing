using Wing.ViewModels;
using System.Windows.Controls;

namespace Wing.Views
{
    public partial class GraphControl : UserControl
    {
        public GraphControl()
        {
            InitializeComponent();
            DataContext = new GraphViewModel(); // Default ViewModel, replaceable if needed
        }

        public GraphViewModel ViewModel => (GraphViewModel)DataContext;
    }
}
