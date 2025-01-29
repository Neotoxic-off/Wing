using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows;

namespace Wing.ViewModels
{
    public partial class GraphViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<NodeViewModel> nodes = new();

        [ObservableProperty] 
        private ObservableCollection<EdgeViewModel> edges = new();

        [ObservableProperty] private NodeViewModel? selectedNode;

        public GraphViewModel()
        {
        }

        public void AddNode(string content, Point position)
        {
            var newNode = new NodeViewModel(Nodes.Count + 1, content, position);
            Nodes.Add(newNode);
        }

        public void RemoveNode()
        {
            if (SelectedNode != null)
            {
                Edges = new ObservableCollection<EdgeViewModel>(
                    Edges.Where(e => e.StartNode != SelectedNode && e.EndNode != SelectedNode)
                );

                Nodes.Remove(SelectedNode);
                SelectedNode = null;
            }
        }

        public void LinkNodes(NodeViewModel startNode, NodeViewModel endNode)
        {
            if (startNode == endNode) return;

            startNode.Connections.Add(endNode.Id);
            endNode.Connections.Add(startNode.Id);

            Edges.Add(new EdgeViewModel(startNode, endNode));
        }
    }
}
