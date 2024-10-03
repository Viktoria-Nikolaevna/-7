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
using System.Windows.Shapes;
using ЛР7.Classes;
using ЛР7.DataModel;
using ЛР7.CustomControls;
using ЛР7.Windows;

namespace ЛР7.Windows
{
    /// <summary>
    /// Логика взаимодействия для ShowWeatherWindow.xaml
    /// </summary>
    public partial class ShowWeatherWindow : Window
    {
        public ShowWeatherWindow()
        {
            InitializeComponent();
            LoadDate();
        }
        private void LoadDate() => new ModelEF().Prognosis.ToList().ForEach(Item => wrapPanelWeather.Children.Add(new PrognosisWeather(Item)));

        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
