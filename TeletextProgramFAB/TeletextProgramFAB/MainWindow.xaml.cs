using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TeletextProgramFAB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FABClasses.CommunicationFAB.OpenProgramFABTeletextEditor();
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            int i = FABClasses.CommunicationFAB.OpenSession();
            int red = 3;

            if (i != 0)
            {
                FABClasses.CommunicationFAB.WriteToPageLine(i, "\x0003Test", red);
            }
        }
    }
}
