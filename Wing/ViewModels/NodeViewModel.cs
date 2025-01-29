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

        public NodeViewModel(int id, string content, Point position)
        {
            Id = id;
            Content = content;
            Position = position;
        }
    }
}
