﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wing.Views;

namespace Wing.Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            GraphControl graphControl = new GraphControl();
            graphControl.ViewModel.AddNode("Node A", new Point(100, 100));
            graphControl.ViewModel.AddNode("Node B", new Point(300, 200));
        }
    }
}