using System.Windows;
using DevExpress.Xpf.Grid;

namespace DXTreeList_NodeTraversing {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            treeListControl1.ItemsSource = Stuff.GetStuff();
        }

        private void treeListControl1_Loaded(object sender, RoutedEventArgs e) {
            SmartExpandNodes(4);
        }

        private void SmartExpandNodes(int minChildCount) {
            TreeListNodeIterator nodeIterator = new TreeListNodeIterator(treeListView1.Nodes, true);
            while (nodeIterator.MoveNext())
                nodeIterator.Current.IsExpanded = nodeIterator.Current.Nodes.Count >= minChildCount;
        }
    }
}
