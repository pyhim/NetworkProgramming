using System.Net.NetworkInformation;

namespace Homework1
{
    public partial class Form1 : Form
    {
        private readonly NetworkInterface[] _adapters = NetworkInterface.GetAllNetworkInterfaces();

        public Form1()
        {
            InitializeComponent();
            InitializeInformation();
        }

        private void InitializeInformation()
        {
            networkDevicesCountTextBox.Text = _adapters.Length.ToString();
        }

        private void PropertiesButton_Click(object sender, EventArgs e)
        {

        }
    }
}
