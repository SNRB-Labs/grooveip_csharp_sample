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
            Cursor.Current = Cursors.WaitCursor;
            InitializeViews();
            Cursor.Current = Cursors.AppStarting;
        }

        private void InitializeViews()
        {
            Thread.Sleep(10000);
            labelNoNumbers.Visible = true;
        }

        private void buttonSearchNumbers_Click(object sender, EventArgs e)
        {

        }
        
    }
}
