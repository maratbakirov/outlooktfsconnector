using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookTfsConnectorRegistrationTool
{
    public partial class Form1 : Form
    {
        private const string RegistryAddinPath = @"Software\Microsoft\Office\Outlook\Addins\OutlookTfsConnector";
        //private const string RegistryDataPath = @"Software\Microsoft\Office\Outlook\AddinsData\OutlookTfsConnector";

        public Form1()
        {
            InitializeComponent();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            //var path = "file:\\"+Path.GetDirectoryName(Application.StartupPath) + "\\OutlookTfsConnector.vsto|vstolocal";
            //path = path.Replace('\\', '/');

            var openFileDialog = new OpenFileDialog()
            {

                Filter = "VSTO extension (*.vsto)|*.vsto",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "vsto",
                InitialDirectory = Path.GetDirectoryName(Application.StartupPath),
                RestoreDirectory = true
            };
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var path = "file:///" + openFileDialog.FileName + "|vstolocal";
            path = path.Replace('\\', '/');


            //Registry.CurrentUser.CreateSubKey(RegistryDataPath);
            var key = Registry.CurrentUser.CreateSubKey(RegistryAddinPath);
            key.SetValue("LoadBehavior",3);
            key.SetValue("Description", "OutlookTfsConnector");
            key.SetValue("FriendlyName", "OutlookTfsConnector");
            key.SetValue("Manifest", path);
            MessageBox.Show("Successfully registered the connector");
        }

        private void btUnregister_Click(object sender, EventArgs e)
        {
            Registry.CurrentUser.DeleteSubKeyTree(RegistryAddinPath);
            MessageBox.Show("Successfully deregistered the connector");
        }
    }
}
