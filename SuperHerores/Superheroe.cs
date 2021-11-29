using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.Generic;

namespace SuperHerores
{
    class Superheroe : ObservableObject
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (_nombre != value)
                {
                    SetProperty(ref _nombre, value);
                }
            }
        }

        private string _imagen;

        public string Imagen
        {
            get { return _imagen; }
            set
            {
                if (_imagen != value)
                {
                    SetProperty(ref _imagen, value);
                }
            }
        }


        private bool _vengador;

        public bool Vengador
        {
            get { return _vengador; }
            set
            {
                if (_vengador != value)
                {
                    SetProperty(ref _vengador, value);
                }
            }
        }

        private bool _xmen;

        public bool Xmen
        {
            get { return _xmen; }
            set
            {
                if (_xmen != value)
                {
                    SetProperty(ref _xmen, value);
                }
            }
        }


        private bool _heroe;

        public bool Heroe
        {
            get { return _heroe; }
            set
            {
                if (_heroe != value)
                {
                    SetProperty(ref _heroe, value);
                }
            }
        }


        public Superheroe()
        {
        }

        public Superheroe(string nombre, string imagen, bool vengador, bool xmen, bool heroe)
        {
            Nombre = nombre;
            Imagen = imagen;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
        }

    }
}