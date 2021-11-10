using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHerores
{
    class MainWindowsVM : INotifyPropertyChanged
    {
        public Superheroe superheroeActual;

        public Superheroe SuperheroeActual {
            get { return superheroeActual; }
            set
            {
                superheroeActual = value;
                NotifyPropertyChanged("SuperheroeActual");
            } 
        }

        public int numHeroeActual;
        public int NumHeroeActual { 
            get { return numHeroeActual; }
            set
            {
                numHeroeActual = value;
                NotifyPropertyChanged("NumHeroeActual");
            }
        }

        public int numHeroesLista;
        public int NumHeroesLista { 
            get { return numHeroesLista;  }
            set
            {
                numHeroesLista = value;
                NotifyPropertyChanged("NumHeroesLista");
            }
        }

        List<Superheroe> lista = Superheroe.GetSamples();

        public MainWindowsVM()
        {
            
            SuperheroeActual = lista[0];
            NumHeroeActual = 1;
            NumHeroesLista = lista.Count;
        }

        public void Avanzar()
        {
            if (NumHeroeActual < NumHeroesLista)
            {
                NumHeroeActual++;
                SuperheroeActual = lista[NumHeroesLista - 1];
            }
        }

        public void Retroceder()
        {
            if (NumHeroeActual > 1)
            {
                NumHeroeActual--;
                SuperheroeActual = lista[NumHeroesLista - 1];
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
