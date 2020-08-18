using Microsoft.TeamFoundation.VersionControl.Common.Internal;
using OutlookTfsConnector;
using OutlookTfsConnector.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookTfsConnector
{
    public partial class SettingsForm : Form
    {

        public SettingsForm()
        {
            InitializeComponent();
            var settings = Globals.ThisAddIn.Settings;
            txtRegExp.Text = settings.RegexToParseEmailSubjects;

            //var list = new List<TfsConfigurationItem>();
            //list.AddRange(settings.TfsConfigurations.Select(x => (TfsConfigurationItem)x.Clone()));
            //dataGridView1.AutoGenerateColumns = true;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dataGridView1.DataSource = list;

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "TfsUrl";
            dataGridView1.Columns[1].Name = "TfsProject";
            dataGridView1.Columns[2].Name = "TfsUserName";
            dataGridView1.Columns[3].Name = "TfsUserToken";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView1.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;

            settings.TfsConfigurations.ForEach(config => {
                string[] row = new string[] { config.TfsUrl, config.TfsProject, config.TfsUserName, config.TfsUserToken };
                dataGridView1.Rows.Add(row);
            });

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnSaveNClose_Click(object sender, EventArgs e)
        {
            var settings = Globals.ThisAddIn.Settings;
            settings.RegexToParseEmailSubjects = txtRegExp.Text;

            settings.TfsConfigurations.Clear();
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    settings.TfsConfigurations.Add(new TfsConfigurationItem(
                        (string)row.Cells[0].Value ?? "",
                        (string)row.Cells[1].Value ?? "" ,
                        (string)row.Cells[2].Value ?? "" ,
                        (string)row.Cells[3].Value ?? "" 
                        ));
                }
            }

            settings.Save();

            this.Close();
            this.Dispose();
        }

        private void pbDonate_Click(object sender, EventArgs e)
        {
            Utils.OpenDonateUrl();
        }
    }
}
