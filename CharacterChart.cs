using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using LiveCharts.Wpf.Charts.Base;

namespace LB1_codes
{
    public partial class CharacterChart : Form
    {
        private readonly string _initialMessage;
        private readonly string _changedMessage;
        private readonly bool _isDecyphered;

        public CharacterChart(string initialMessage, string changedMessage, bool isDecyphered)
        {
            InitializeComponent();
            SeriesCollection initialSeries = new SeriesCollection();
            SeriesCollection changedSeries = new SeriesCollection();

            this._initialMessage = initialMessage;
            this._changedMessage = changedMessage;
            this._isDecyphered = isDecyphered;

            initialSeries.Add(SetupInitialColumnSeries());
            changedSeries.Add(SetupChangedColumnSeries());
            
            cartesianChart1.Series = initialSeries;
            cartesianChart2.Series = changedSeries;

            cartesianChart1.AxisX = new AxesCollection() {
                new Axis(){Title="Символы",Separator=new Separator(){ Step=1,Stroke=new SolidColorBrush(System.Windows.Media.Color.FromRgb(100,255,150))} , Labels=  _initialMessage.Distinct().Select(x=>x.ToString()).ToList() }
            };

            cartesianChart1.AxisY = new AxesCollection() {
                new Axis(){Title="Количество",Separator=new Separator(){ Step=2} }
            };

            cartesianChart2.AxisX = new AxesCollection() {
                new Axis(){Title="Символы",Separator=new Separator(){ Step=1} , Labels = _changedMessage.Distinct().Select(x => x.ToString()).ToList()}
            };

            cartesianChart2.AxisY = new AxesCollection() {
                new Axis(){Title="Количество",Separator=new Separator(){ Step=2} }
            };

            

            cartesianChart1.LegendLocation = LegendLocation.Top;
            cartesianChart1.DataTooltip = null;
            cartesianChart2.LegendLocation = LegendLocation.Top;
            cartesianChart2.DataTooltip = null;

          
        }

        private ColumnSeries SetupInitialColumnSeries() {
            ColumnSeries columnSeries = new ColumnSeries();
            columnSeries.Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 0, 0));
            columnSeries.StrokeThickness = 2;
            columnSeries.Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 100, 100));

            List<char> dictinctiveNums = _initialMessage.Distinct().ToList();
            List<int> numberOfOccurencesNums = new List<int>();
            foreach (char c in dictinctiveNums)
            {
                int count=_initialMessage.Where(x => x == c).Count();
                numberOfOccurencesNums.Add(count);
            }
            

            columnSeries.Values = new ChartValues<int>(numberOfOccurencesNums);
            
            columnSeries.Title = "Исходное сообщение";
            
            return columnSeries;
        }
        private ColumnSeries SetupChangedColumnSeries() {
            ColumnSeries columnSeries = new ColumnSeries();
            columnSeries.Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 0, 0));
            columnSeries.StrokeThickness = 2;
            columnSeries.Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 100, 100));

            List<char> dictinctiveNums = _changedMessage.Distinct().ToList();
            List<int> numberOfOccurencesNums = new List<int>();
            foreach (char c in dictinctiveNums)
            {
                int count = _changedMessage.Where(x => x == c).Count();
                numberOfOccurencesNums.Add(count);
            }



            columnSeries.Values = new ChartValues<int>(numberOfOccurencesNums);
            columnSeries.Title = _isDecyphered ? "Зашифрованное сообщение" : "Расшифрованное сообщение";
            
            return columnSeries;
        }
    }
}
