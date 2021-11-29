using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHerores
{
    class MainWindowsVM : ObservableObject
    {
        public Superheroe superheroeActual;
        private ListaSuperheroesService servicioHeroes;
        private List<Superheroe> lista;
        public Superheroe SuperheroeActual {
            get { return superheroeActual; }
            set
            {
                SetProperty(ref superheroeActual, value);
            } 
        }

        public int numHeroeActual;
        public int NumHeroeActual { 
            get { return numHeroeActual; }
            set
            { 
                SetProperty(ref numHeroeActual, value);
            }
        }

        public int numHeroesLista;
        public int NumHeroesLista { 
            get { return numHeroesLista;  }
            set
            {
                SetProperty(ref numHeroesLista, value);
            }
        }

        public MainWindowsVM()
        {
            servicioHeroes = new ListaSuperheroesService();
            lista = servicioHeroes.GetSamples();
            SuperheroeActual = lista[0];
            NumHeroeActual = 1;
            NumHeroesLista = lista.Count;
        }

        public void Avanzar()
        {
            if (NumHeroeActual < NumHeroesLista)
            {
                NumHeroeActual++;
                SuperheroeActual = lista[NumHeroeActual - 1];
            }
        }

        public void Retroceder()
        {
            if (NumHeroeActual > 1)
            {
                NumHeroeActual--;
                SuperheroeActual = lista[NumHeroeActual - 1];
            }
        }
    }
}
