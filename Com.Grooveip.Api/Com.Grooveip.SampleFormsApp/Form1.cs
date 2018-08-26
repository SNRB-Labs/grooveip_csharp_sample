using Aaks.Restclient;
using Aaks.RestclientTests.Model;
using Com.Grooveip.Sdk.Api;
using Com.Grooveip.Sdk.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
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
            labelNoNumbers.Text = "Getting your numbers";

            UseWaitCursor = true;

            string url = ApiClient.BuildInventoryUrl(1, 100);

            HttpRestClient client = new HttpRestClient();

            HttpResponse<List<NumbersInventoryResponse>> response = await client.GetAsync<List<NumbersInventoryResponse>>(url);

            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                UseWaitCursor = false;

                if (response.Body != null & response.Body.Count > 0)
                {
                    foreach(NumbersInventoryResponse r in response.Body)
                    {
                        listViewNumbersInventory.Items.Add(r.PhoneNumber);
                    }

                    listViewNumbersInventory.Visible = true;
                }
                else
                {
                    labelNoNumbers.Visible = true;
                }
            }
            else
            {
                UseWaitCursor = false;

                labelNoNumbers.Visible = true;

                using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(response.ErrorMessage)))
                {
                    stream.Position = 0;
                    DataContractJsonSerializer serizlizer = new DataContractJsonSerializer(typeof(ErrorResponse));
                    ErrorResponse errorResponse = serizlizer.ReadObject(stream) as ErrorResponse;
                    labelNoNumbers.Text = errorResponse.Message;
                }
            }

            
        }

        private void buttonSearchNumbers_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            DialogResult dr = searchForm.ShowDialog(this);

            if(dr == DialogResult.OK)
            {
                ListViewItem li = new ListViewItem();
                li.Text = searchForm.SelectedNumber;
                listViewNumbersInventory.Items.Add(li);
            }
            else
            {
                searchForm.Close();
            }
        }
        
    }
}
