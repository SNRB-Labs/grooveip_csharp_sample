using Aaks.Restclient;
using Aaks.RestclientTests.Model;
using Com.Grooveip.Sdk.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Grooveip.SampleFormsApp
{
    public partial class FormNumbersInventory : Form
    {
        public FormNumbersInventory()
        {
            InitializeComponent();
            
        }

        private void FormNumbersInventory_Load(object sender, EventArgs e)
        {   
            InitializeViews();   
        }

        private async void InitializeViews()
        {
            progressBarLoading.Visible = true;
            progressBarLoading.Maximum = 100;
            progressBarLoading.Step = 1;

            var progress = new Progress<int>(v =>
            {
                progressBarLoading.Value = v;
            });

            // Run operation in another thread
            //await

            string url = ApiClient.BuildInventoryUrl(1, 100);

            HttpRestClient client = new HttpRestClient();

            HttpResponse<List<object>> response = await client.GetAsync<List<object>>(url);

            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                if (response.Body != null & response.Body.Count > 0)
                {
                    listViewNumbersInventory.Visible = true;
                }
                else
                {
                    labelNoNumbers.Visible = true;
                }
            }
            else
            {
                labelNoNumbers.Visible = true;
                labelNoNumbers.Text = response.ErrorMessage;
            }

            
        }

        private void buttonSearchNumbers_Click(object sender, EventArgs e)
        {

        }
        
    }
}
