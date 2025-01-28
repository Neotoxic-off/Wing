using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows;

namespace Wing.ViewModels
{
    public partial class GraphViewModel : ObservableObject
    {
        public ObservableCollection<NodeViewModel> Nodes { get; } = new();

        public GraphViewModel()
        {
        }

        public void AddNode(string content, Point position)
        {
            var newNode = new NodeViewModel(Nodes.Count + 1, content, position);
            Nodes.Add(newNode);
        }

        public void RemoveNode(NodeViewModel node)
        {
            Nodes.Remove(node);
        }
    }
}
