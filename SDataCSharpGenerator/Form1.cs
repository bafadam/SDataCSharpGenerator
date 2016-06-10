using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDataCSharpGenerator.Classes;

namespace SDataCSharpGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SetupConfig _setup;

        private async void button1_Click(object sender, EventArgs e)
        {
            btnLoadTypes.Enabled = false;
            ResetForm();

            SetupConfig setup = new SetupConfig();
            setup.Username = "apinilla";
            setup.Password = "apinilla99";
            setup.SDataUrl = "https://slxweb.sssworld.com/sdata/slx/dynamic/-/";

            SDataHelper sdata = new SDataHelper(setup);

            var sdataTypes = await sdata.GetResourceTypes();
            PopulateResouceTypes(sdataTypes);

            btnLoadTypes.Enabled = true;
        }

        private void PopulateResouceTypes(Dictionary<string, string> resourceTypes)
        {
            cmbResourceTypes.Items.Clear();

            foreach (var resourceType in resourceTypes)
            {
                cmbResourceTypes.Items.Add(resourceType);
            }

            cmbResourceTypes.ValueMember = "Key";
            cmbResourceTypes.DisplayMember = "Value";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _setup = new SetupConfig();
            _setup.Username = "apinilla";
            _setup.Password = "apinilla99";
            _setup.SDataUrl = "https://slxweb.sssworld.com/sdata/slx/dynamic/-/";
        }

        public void ResetForm()
        {
            cmbResourceTypes.Items.Clear();
        }

        private void btnGetTemplate_Click(object sender, EventArgs e)
        {
            if (cmbResourceTypes.SelectedItem != null)
            {
                var item = cmbResourceTypes.SelectedItem as KeyValuePair<string, string>?;
                SDataHelper _sdata = new SDataHelper(_setup);
                _sdata.GetProperties(item.Value.Key);
            }
        }
    }
}
