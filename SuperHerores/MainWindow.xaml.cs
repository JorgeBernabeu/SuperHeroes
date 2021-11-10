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
        List<Superheroe> Superheroes = Superheroe.GetSamples();
        public MainWindow()
        {
            InitializeComponent();
            numeroHeroeTextBlock.Tag = 0;
            GridSuperHeroe.DataContext = Superheroes[0];
            GrupoImage.DataContext = Superheroes[0].Vengador;
            GrupoImage2.DataContext = Superheroes[0].Xmen;
        }

        private void SuperHeroeAnterior(object sender, RoutedEventArgs e)
        {
            string numHeroe = numeroHeroeTextBlock.Tag.ToString();
            if (int.Parse(numHeroe) - 1 != -1)
            {
                GridSuperHeroe.DataContext = Superheroes[int.Parse(numHeroe) - 1];
                numHeroe = (int.Parse(numHeroe) - 1).ToString();
                numeroHeroeTextBlock.Tag = numHeroe;
                numeroHeroeTextBlock.Text = $"{int.Parse(numHeroe) + 1}/3";
            }
            
        }
        
        private void SiguienteSuperHeroe(object sender, RoutedEventArgs e)
        {
            string numHeroe = numeroHeroeTextBlock.Tag.ToString();

            if (int.Parse(numHeroe) + 1 != 3)
            {
                GridSuperHeroe.DataContext = Superheroes[int.Parse(numHeroe) + 1];
                numHeroe = (int.Parse(numHeroe) + 1).ToString();
                numeroHeroeTextBlock.Tag = numHeroe;
                numeroHeroeTextBlock.Text = $"{int.Parse(numHeroe) + 1}/3";
            }
        }
    }
}
