Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes

Namespace DockingMVVM.SL
    Partial Public Class MainPage
        Inherits UserControl

        Private dockLayoutManagerViewModel As DockLayoutManagerViewModel

        Public Sub New()
            InitializeComponent()
            dockLayoutManagerViewModel = New DockLayoutManagerViewModel()
            DataContext = dockLayoutManagerViewModel
        End Sub


        Private Sub AddPanel_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim panelViewModel1 As New PanelViewModel()
            panelViewModel1.Content = "Panel View Model"
            panelViewModel1.DisplayName = "Panel View Model"
            dockLayoutManagerViewModel.Workspaces.Add(panelViewModel1)
        End Sub

        Private Sub AddDocument_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim documentViewModel1 As New DocumentViewModel()
            documentViewModel1.Content = "Document View Model"
            documentViewModel1.DisplayName = "Document View Model"
            dockLayoutManagerViewModel.Workspaces.Add(documentViewModel1)
        End Sub
    End Class
End Namespace
