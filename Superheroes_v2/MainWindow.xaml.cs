using System.Collections.Generic;
using System.Windows;

namespace Superheroes_v2
{
    public partial class MainWindow : Window
    {
        public List<Superheroe> Superheroes { get; set; }

        public MainWindow()
        {
            Superheroes = Superheroe.GetSamples();
            InitializeComponent();
        }
    }
}
