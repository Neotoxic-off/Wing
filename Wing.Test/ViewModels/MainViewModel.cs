using CommunityToolkit.Mvvm.ComponentModel;
using Wing.ViewModels;

namespace Wing.Test.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private GraphViewModel graphViewModel = new();

        public MainViewModel()
        {
            // Add test nodes
            GraphViewModel.AddNode("Node A", new System.Windows.Point(100, 100));
            GraphViewModel.AddNode("Node B", new System.Windows.Point(300, 200));
        }
    }
}
