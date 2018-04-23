using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace DockingMVVM.SL {
    public partial class MainPage : UserControl {

        DockLayoutManagerViewModel dockLayoutManagerViewModel;

        public MainPage() {
            InitializeComponent();
            dockLayoutManagerViewModel = new DockLayoutManagerViewModel();
            DataContext = dockLayoutManagerViewModel;
        }
        

        private void AddPanel_Click(object sender, RoutedEventArgs e) {
            PanelViewModel panelViewModel1 = new PanelViewModel();
            panelViewModel1.Content = "Panel View Model";
            panelViewModel1.DisplayName = "Panel View Model";
            dockLayoutManagerViewModel.Workspaces.Add(panelViewModel1);
        }

        private void AddDocument_Click(object sender, RoutedEventArgs e) {
            DocumentViewModel documentViewModel1 = new DocumentViewModel();
            documentViewModel1.Content = "Document View Model";
            documentViewModel1.DisplayName = "Document View Model";
            dockLayoutManagerViewModel.Workspaces.Add(documentViewModel1);
        }
    }
}
