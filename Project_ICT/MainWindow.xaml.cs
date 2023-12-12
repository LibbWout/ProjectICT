using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
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
using static System.Net.Mime.MediaTypeNames;


namespace Project_ICT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SerialPort _serialPort;
        int _wachtTijd = 1700;


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
                      
                    }
                    if (cbxCOMPoort.SelectedItem.ToString() == "None")
                    {
                        tbkMorseCode.IsEnabled = false;
                        tbxTekst.IsEnabled = false;
                        btnVertaal.IsEnabled = false;
                        btnVerstuur.IsEnabled = false;
                    }
                }

            }

        }

        private void btnVertaal_Click(object sender, RoutedEventArgs e)
        {
            MorseCode morse = new MorseCode();
            
            morse.Vertaal(tbxTekst.Text);
            tbkMorseCode.Text = morse.Code.ToString();
            

        }

        private void stuurNaarMicro(MorseCode morse)
        {
            if ((_serialPort != null) && (_serialPort.IsOpen))
            {
                foreach (char a in morse.Code)
                {
                    string i = a.ToString();
                    _serialPort.Write(i);
                    Thread.Sleep(_wachtTijd);

                }
                
            }
        }

        private void btnVerstuur_Click(object sender, RoutedEventArgs e)
        {
            MorseCode morse = new MorseCode();
            morse.Vertaal(tbxTekst.Text);
            stuurNaarMicro(morse);
        }

        private void tbxTekst_TextChanged(object sender, TextChangedEventArgs e)
        {

            btnVertaal.IsEnabled = false;
            btnVerstuur.IsEnabled = false;
            if (tbxTekst.Text != "")
            {
                btnVertaal.IsEnabled = true;
                btnVerstuur.IsEnabled = true;
            }

        }
    }
}
