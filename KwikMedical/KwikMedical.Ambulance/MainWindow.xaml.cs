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
using KwikMedical.Ambulance.Model;
using KwikMedical.Ambulance.Communication;

namespace KwikMedical.Ambulance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CallOutDetails _details = null;
        SendToDB ODBCMessage = null;

        public MainWindow()
        {
            InitializeComponent();
            _details = new CallOutDetails();
        }

        private void btnSendInfo_Click(object sender, RoutedEventArgs e)
        {
            _details.PatientNHSNumber = 123;
            _details.Who = tBoxResponse.Text;
            _details.What = tBoxWhat.Text;
            _details.When = tBoxWhen.Text;
            _details.Where = tBoxWhere.Text;
            _details.Action = tBoxAction.Text;
            _details.Time = tBoxTime.Text;

            string message = _details.FormMessage();

            MessageBox.Show(message, "Ambulance Info!", MessageBoxButton.OK);

            ODBCMessage = new SendToDB();
            ODBCMessage.WriteToODBC(_details);

        }
    }
}
