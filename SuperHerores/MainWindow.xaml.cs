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

namespace SuperHerores
{
    public partial class MainWindow : Window
    {
        MainWindowsVM vm = new MainWindowsVM();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = vm;
        }

        private void SuperHeroeAnterior(object sender, RoutedEventArgs e)
        {
            vm.Retroceder();
            
        }
        
        private void SiguienteSuperHeroe(object sender, RoutedEventArgs e)
        {
            vm.Avanzar();
        }
    }
}
