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
using System.Windows.Forms.DataVisualization.Charting;

namespace Попытка_Не_Пытка
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            chart.ChartAreas.Add(new ChartArea("Default"));
            chart.Series.Add(new Series("Series1"));
            chart.Series["Series1"].ChartArea = "Default";
            chart.Series["Series1"].ChartType = SeriesChartType.Line;
            string[] axisXData = new string[] { "a", "b", "c" };
            double[] axisYData = new double[] { 0.1, 1.5, 1.9 };
            chart.Series["Series1"].Points.DataBindXY(axisXData, axisYData);
        }
    }
}
