using Avalonia.Controls;
using RBWRMultitool.ViewModels;
using System.ComponentModel;
using System.Diagnostics;

namespace RBWRMultitool.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get the selected ListBox
            ListBox selectedListBox = (ListBox)sender;

            // Clear the selection in the other ListBox
            if (selectedListBox == ListBox1)
            {
                ListBox2.SelectedIndex = -1;
            }
            else if (selectedListBox == ListBox2)
            {
                ListBox1.SelectedIndex = -1;
            }
        }
    }
}