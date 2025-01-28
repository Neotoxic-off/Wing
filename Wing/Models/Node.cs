using System.Collections.ObjectModel;
using System.Windows;

namespace Wing.Models
{
    public class Node
    {
        public int ID { get; set; }
        public Point Position { get; set; }
        public string Content { get; set; }
        public ObservableCollection<int> Connections { get; set; } = new();
    }
}
