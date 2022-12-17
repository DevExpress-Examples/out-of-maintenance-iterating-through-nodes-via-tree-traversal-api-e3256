Imports System.Windows
Imports DevExpress.Xpf.Grid

Namespace DXTreeList_NodeTraversing

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.treeListControl1.ItemsSource = GetStuff()
        End Sub

        Private Sub treeListControl1_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SmartExpandNodes(4)
        End Sub

        Private Sub SmartExpandNodes(ByVal minChildCount As Integer)
            Dim nodeIterator As TreeListNodeIterator = New TreeListNodeIterator(Me.treeListView1.Nodes, True)
            While nodeIterator.MoveNext()
                nodeIterator.Current.IsExpanded = nodeIterator.Current.Nodes.Count >= minChildCount
            End While
        End Sub
    End Class
End Namespace
