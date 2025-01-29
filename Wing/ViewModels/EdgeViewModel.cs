using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wing.ViewModels
{
    public partial class EdgeViewModel : ObservableObject
    {
        [ObservableProperty]
        private NodeViewModel startNode;

        [ObservableProperty]
        private NodeViewModel endNode;

        public EdgeViewModel(NodeViewModel start, NodeViewModel end)
        {
            StartNode = start;
            EndNode = end;
        }
    }
}
