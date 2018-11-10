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
using KwikMedical.Emergency.Model;
using KwikMedical.Emergency.Communication;

namespace KwikMedical.Emergency
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Patient _Patient = null;

        SendMessage Emergency = null;
        public MainWindow()
        {
            InitializeComponent();
            _Patient = new Patient();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _Patient.PatientName = tBoxPName.Text;
            _Patient.PatientDOB = pDOB.SelectedDate.ToString();
            _Patient.Address = tBosPAddr.Text;
            _Patient.NHSRegNos = tBoxNHSNos.Text;
            _Patient.MedicalCondition = tBoxMedCond.Text;           
            string message = _Patient.FormMessage();

            MessageBox.Show(message, "Patient info!!", MessageBoxButton.OK);

            Emergency = new SendMessage(_Patient);

            Emergency.PrepareData();
        }
    }
}
