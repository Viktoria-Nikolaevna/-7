using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;
using ЛР7.Classes;
using ЛР7.DataModel;
using ЛР7.CustomControls;

namespace ЛР7.Windows
{
    /// <summary>
    /// Логика взаимодействия для ShowWeatherAtTimeWindow.xaml
    /// </summary>
    public partial class ShowWeatherAtTimeWindow : Window
    {
        private Prognosis prognosis;
        public ShowWeatherAtTimeWindow(Prognosis prog)
        {
            InitializeComponent();
            prognosis = prog;
            labelContent.Content += " " + prognosis.Date.Value.ToShortDateString();
            LoadDateWrapPanel(prog.Time);
        }

        private void LoadDateWrapPanel(string info)
        {
            List<ComplexWeatherInfo> infos;
            XmlSerializer xmlSerialiser = new XmlSerializer(typeof(List<ComplexWeatherInfo>));
            using (StringReader reader = new StringReader(info))
            {
                infos = xmlSerialiser.Deserialize(reader) as List<ComplexWeatherInfo>;
            }
            infos.ForEach(item => wrapPanelWeather.Children.Add(new WeatherCustomControl(item)));
        }
    }
}
