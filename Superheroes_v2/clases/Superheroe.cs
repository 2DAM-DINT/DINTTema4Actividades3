using System.Collections.Generic;
using System.ComponentModel;

namespace Superheroes_v2
{
    public class Superheroe : INotifyPropertyChanged
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value != nombre)
                {
                    nombre = value;
                    this.NotifyPropertyChanged("Nombre");
                }
            }
        }

        private string imagen;
        public string Imagen
        {
            get { return imagen; }
            set
            {
                if (value != imagen)
                {
                    imagen = value;
                    this.NotifyPropertyChanged("Imagen");
                }
            }
        }

        private bool vengador;
        public bool Vengador
        {
            get { return vengador; }
            set
            {
                if (value != vengador)
                {
                    vengador = value;
                    this.NotifyPropertyChanged("Vengador");
                }
            }
        }

        private bool xmen;
        public bool Xmen
        {
            get { return xmen; }
            set
            {
                if (value != xmen)
                {
                    xmen = value;
                    this.NotifyPropertyChanged("Xmen");
                }
            }
        }


        private bool heroe;
        public bool Heroe
        {
            get { return heroe; }
            set
            {
                if (value != heroe)
                {
                    heroe = value;
                    this.NotifyPropertyChanged("Heroe");
                }
            }
        }


        private bool villano;
        public bool Villano
        {
            get { return villano; }
            set
            {
                if (value != villano)
                {
                    villano = value;
                    this.NotifyPropertyChanged("Villano");
                    if (Villano)
                    {
                        Vengador = false;
                        Xmen = false;
                    }
                }
            }
        }

        public Superheroe()
        {
            Heroe = true;
        }

        public Superheroe(string nombre, string imagen, bool vengador, bool xmen, bool heroe, bool villano)
        {
            Nombre = nombre;
            Imagen = imagen;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
            Villano = villano;
        }

        public Superheroe(Superheroe superheroe)
        {
            Nombre = superheroe.Nombre;
            Imagen = superheroe.Imagen;
            Vengador = superheroe.Vengador;
            Xmen = superheroe.Xmen;
            Heroe = superheroe.Heroe;
            Villano = superheroe.Villano;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static List<Superheroe> GetSamples()
        {
            List<Superheroe> ejemplos = new List<Superheroe>();

            Superheroe ironman = new Superheroe("Ironman", @"https://sm.ign.com/ign_latam/screenshot/default/ybbpqktez5whedr0-1592031889_31aa.jpg", true, false, true, false);
            Superheroe kingpin = new Superheroe("Kingpin", @"https://www.comicbasics.com/wp-content/uploads/2017/09/Kingpin.jpg", false, false, false, true);
            Superheroe spiderman = new Superheroe("Spiderman", @"https://wipy.tv/wp-content/uploads/2019/08/destino-de-%E2%80%98Spider-Man%E2%80%99-en-los-Comics.jpg", true, true, true, false);

            ejemplos.Add(ironman);
            ejemplos.Add(kingpin);
            ejemplos.Add(spiderman);

            return ejemplos;
        }
    }
}