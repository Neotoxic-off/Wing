using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows;

namespace Wing.ViewModels
{
    public partial class NodeViewModel : ObservableObject
    {
        [ObservableProperty]
        private int id;

        [ObservableProperty]
        private Point position;

        [ObservableProperty]
        private string content;

        public ObservableCollection<int> Connections { get; } = new();

        public GraphNodeViewModel(int id, string content, Point position)
        {
            ID = id;
            Content = content;
            Position = position;
        }
    }
}
