using System;
using System.Collections.Generic;
using System.IO.Ports;
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


namespace Project_ICT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SerialPort _serialPort;


        public MainWindow()
        {
            InitializeComponent();
            _serialPort = new SerialPort();

            

            cbxCOMPoort.Items.Add("None");
            foreach (string s in SerialPort.GetPortNames())
                cbxCOMPoort.Items.Add(s);
        }

        private void cbxCOMPoort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            {
                if (_serialPort != null)
                {
                    if (_serialPort.IsOpen)
                        _serialPort.Close();

                    if (cbxCOMPoort.SelectedItem.ToString() != "None")
                    {
                        _serialPort.PortName = cbxCOMPoort.SelectedItem.ToString();
                        _serialPort.Open();
                        tbkMorseCode.IsEnabled = true;
                        tbxTekst.IsEnabled = true;
                        btnVertaal.IsEnabled = true;
                    }
                    if (cbxCOMPoort.SelectedItem.ToString() == "None")
                    {
                        tbkMorseCode.IsEnabled = false;
                        tbxTekst.IsEnabled = false;
                        btnVertaal.IsEnabled = false;
                    }
                }

            }

        }

        private void btnVertaal_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
