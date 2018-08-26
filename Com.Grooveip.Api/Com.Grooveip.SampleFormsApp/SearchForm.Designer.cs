namespace Com.Grooveip.SampleFormsApp
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewNumbersSearch = new System.Windows.Forms.ListView();
            this.textBoxAreaCode = new System.Windows.Forms.TextBox();
            this.labelAreaCode = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelValidation = new System.Windows.Forms.Label();
            this.buttonSelectNumber = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewNumbersSearch
            // 
            this.listViewNumbersSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewNumbersSearch.Location = new System.Drawing.Point(1, 87);
            this.listViewNumbersSearch.Name = "listViewNumbersSearch";
            this.listViewNumbersSearch.Size = new System.Drawing.Size(297, 310);
            this.listViewNumbersSearch.TabIndex = 4;
            this.listViewNumbersSearch.UseCompatibleStateImageBehavior = false;
            this.listViewNumbersSearch.UseWaitCursor = true;
            this.listViewNumbersSearch.View = System.Windows.Forms.View.List;
            this.listViewNumbersSearch.Visible = false;
            // 
            // textBoxAreaCode
            // 
            this.textBoxAreaCode.Location = new System.Drawing.Point(12, 34);
            this.textBoxAreaCode.MaxLength = 3;
            this.textBoxAreaCode.Name = "textBoxAreaCode";
            this.textBoxAreaCode.Size = new System.Drawing.Size(74, 20);
            this.textBoxAreaCode.TabIndex = 5;
            // 
            // labelAreaCode
            // 
            this.labelAreaCode.AutoSize = true;
            this.labelAreaCode.Location = new System.Drawing.Point(12, 15);
            this.labelAreaCode.Name = "labelAreaCode";
            this.labelAreaCode.Size = new System.Drawing.Size(57, 13);
            this.labelAreaCode.TabIndex = 6;
            this.labelAreaCode.Text = "Area Code";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(114, 34);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(171, 23);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelValidation
            // 
            this.labelValidation.AutoSize = true;
            this.labelValidation.Location = new System.Drawing.Point(12, 64);
            this.labelValidation.Name = "labelValidation";
            this.labelValidation.Size = new System.Drawing.Size(0, 13);
            this.labelValidation.TabIndex = 8;
            // 
            // buttonSelectNumber
            // 
            this.buttonSelectNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectNumber.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonSelectNumber.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSelectNumber.Location = new System.Drawing.Point(75, 403);
            this.buttonSelectNumber.Name = "buttonSelectNumber";
            this.buttonSelectNumber.Size = new System.Drawing.Size(102, 29);
            this.buttonSelectNumber.TabIndex = 9;
            this.buttonSelectNumber.Text = "Select Number";
            this.buttonSelectNumber.UseVisualStyleBackColor = true;
            this.buttonSelectNumber.Visible = false;
            this.buttonSelectNumber.Click += new System.EventHandler(this.buttonSelectNumber_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(183, 403);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(102, 29);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 438);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSelectNumber);
            this.Controls.Add(this.labelValidation);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelAreaCode);
            this.Controls.Add(this.textBoxAreaCode);
            this.Controls.Add(this.listViewNumbersSearch);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewNumbersSearch;
        private System.Windows.Forms.TextBox textBoxAreaCode;
        private System.Windows.Forms.Label labelAreaCode;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelValidation;
        private System.Windows.Forms.Button buttonSelectNumber;
        private System.Windows.Forms.Button buttonCancel;
    }
}