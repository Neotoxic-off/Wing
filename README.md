# Wing
☋ WPF Node Graph library

## Usage
```XML
<Window x:Class="GraphNodesApp.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:graph="clr-namespace:Wing.Views;assembly=Wing"
        Title="Graph Nodes App" Height="450" Width="800">
    <Grid>
        <graph:GraphControl />
    </Grid>
</Window>
```
```C#
GraphControl graphControl = new GraphControl();
graphControl.ViewModel.AddNode("New Node", new Point(150, 200));
```
