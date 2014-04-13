using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using SpaceExplorers1.Resources;

namespace SpaceExplorers1.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
        }

        /// <summary>
        /// Colección para objetos ItemViewModel.
        /// </summary>
        public ObservableCollection<ItemViewModel> Items { get; private set; }

        private string _sampleProperty = "Sample Runtime Property Value";
        /// <summary>
        /// Propiedad Sample ViewModel; esta propiedad se usa en la vista para mostrar su valor mediante un enlace
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        /// <summary>
        /// Propiedad de ejemplo que devuelve una cadena traducida
        /// </summary>
        public string LocalizedSampleProperty
        {
            get
            {
                return AppResources.SampleProperty;
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Crear y agregar unos pocos objetos ItemViewModel a la colección Items.
        /// </summary>
        public void LoadData()
        {
            // Datos de ejemplo; reemplazar por los datos reales
            this.Items.Add(new ItemViewModel() { LineOne = "Viajero Jr", LineTwo = "Comodín" });
            this.Items.Add(new ItemViewModel() { LineOne = "Descubre la tierra", LineTwo = "Siguiente pregunta" });
            this.Items.Add(new ItemViewModel() { LineOne = "Misión lunar", LineTwo = "Vale doble" });
            this.Items.Add(new ItemViewModel() { LineOne = "Misión Marte", LineTwo = "Salvación" });
            this.Items.Add(new ItemViewModel() { LineOne = "Conquistando Galaxias", LineTwo = "Misión Curiosity" });
            this.Items.Add(new ItemViewModel() { LineOne = "Viajero del futuro", LineTwo = "Gravedad" });
            
            

            this.IsDataLoaded = true;
        }

        
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}