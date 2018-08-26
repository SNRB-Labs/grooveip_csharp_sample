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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Grooveip.SampleFormsApp
{
    public partial class SearchForm : Form
    {
        private string _lastSearchedAreaCode;

        public string SelectedNumber { get; set; }

        public SearchForm()
        {
            InitializeComponent();
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            if(textBoxAreaCode.Text.Length != 3)
            {
                labelValidation.Text = "Area Code Must be 3 Digits in Length";
                listViewNumbersSearch.Visible = false;
            }
            else
            {
                buttonSelectNumber.Visible = true;
                labelValidation.Text = string.Empty;
                listViewNumbersSearch.Visible = true;

                _lastSearchedAreaCode = textBoxAreaCode.Text;
                string url = ApiClient.BuildSearchUrl(textBoxAreaCode.Text);

                HttpRestClient client = new HttpRestClient();
                
                HttpResponse<string[]> response = client.Get<string[]>(url);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    UseWaitCursor = false;

                    if (response.Body != null)
                    {

                        for (int i = 0; i < response.Body.Length; i++)
                        {
                            listViewNumbersSearch.Items.Add(response.Body[i]);
                        }

                        labelValidation.Visible = true;
                    }
                    else
                    {
                        labelValidation.Visible = true;
                    }
                }
                else
                {
                    UseWaitCursor = false;

                    labelValidation.Visible = true;

                    using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(response.ErrorMessage)))
                    {
                        stream.Position = 0;
                        DataContractJsonSerializer serizlizer = new DataContractJsonSerializer(typeof(ErrorResponse));
                        ErrorResponse errorResponse = serizlizer.ReadObject(stream) as ErrorResponse;
                        labelValidation.Text = errorResponse.Message;
                    }
                }

            }
        }

        private void buttonSelectNumber_Click(object sender, EventArgs e)
        {
            if(listViewNumbersSearch.SelectedItems != null && listViewNumbersSearch.SelectedItems.Count > 0)
            {
                SelectedNumber = listViewNumbersSearch.SelectedItems[0].Text;
                
                string url = ApiClient.GetNumberReserveUrl();
                
                HttpRestClient client = new HttpRestClient();

                NumberReserveRequest request = ApiClient.BuildNumberResesrveRequest(listViewNumbersSearch.SelectedItems[0].Text, _lastSearchedAreaCode);

                HttpResponse<List<NumberReserveResponse>> response = client.Post<List<NumberReserveResponse>, NumberReserveRequest>(url, request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    UseWaitCursor = false;

                    if (response.Body != null & response.Body.Count > 0)
                    {
                        foreach (NumberReserveResponse r in response.Body)
                        {
                            listViewNumbersSearch.Items.Add(r.PhoneNumber);
                        }

                        labelValidation.Visible = true;
                    }
                    else
                    {
                        labelValidation.Visible = true;
                    }
                }
                else
                {
                    UseWaitCursor = false;

                    labelValidation.Visible = true;

                    using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(response.ErrorMessage)))
                    {
                        stream.Position = 0;
                        DataContractJsonSerializer serizlizer = new DataContractJsonSerializer(typeof(ErrorResponse));
                        ErrorResponse errorResponse = serizlizer.ReadObject(stream) as ErrorResponse;
                        labelValidation.Text = errorResponse.Message;
                    }
                }

                Close();
            }
            else
            {
                labelValidation.Text = "No number selected";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
