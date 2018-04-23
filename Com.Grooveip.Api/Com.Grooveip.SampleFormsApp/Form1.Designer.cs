namespace Com.Grooveip.SampleFormsApp
{
    partial class FormNumbersInventory
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
            this.buttonSearchNumbers = new System.Windows.Forms.Button();
            this.labelNoNumbers = new System.Windows.Forms.Label();
            this.listViewNumbersInventory = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // buttonSearchNumbers
            // 
            this.buttonSearchNumbers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSearchNumbers.Location = new System.Drawing.Point(0, 409);
            this.buttonSearchNumbers.Name = "buttonSearchNumbers";
            this.buttonSearchNumbers.Size = new System.Drawing.Size(297, 29);
            this.buttonSearchNumbers.TabIndex = 0;
            this.buttonSearchNumbers.Text = "Search Numbers";
            this.buttonSearchNumbers.UseVisualStyleBackColor = true;
            this.buttonSearchNumbers.Click += new System.EventHandler(this.buttonSearchNumbers_Click);
            // 
            // labelNoNumbers
            // 
            this.labelNoNumbers.AutoSize = true;
            this.labelNoNumbers.Location = new System.Drawing.Point(95, 188);
            this.labelNoNumbers.MaximumSize = new System.Drawing.Size(200, 0);
            this.labelNoNumbers.Name = "labelNoNumbers";
            this.labelNoNumbers.Size = new System.Drawing.Size(111, 13);
            this.labelNoNumbers.TabIndex = 1;
            this.labelNoNumbers.Text = "You have no numbers";
            this.labelNoNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNoNumbers.Visible = false;
            // 
            // listViewNumbersInventory
            // 
            this.listViewNumbersInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewNumbersInventory.Location = new System.Drawing.Point(0, 0);
            this.listViewNumbersInventory.Name = "listViewNumbersInventory";
            this.listViewNumbersInventory.Size = new System.Drawing.Size(297, 403);
            this.listViewNumbersInventory.TabIndex = 3;
            this.listViewNumbersInventory.UseCompatibleStateImageBehavior = false;
            this.listViewNumbersInventory.View = System.Windows.Forms.View.List;
            this.listViewNumbersInventory.Visible = false;
            // 
            // FormNumbersInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 438);
            this.Controls.Add(this.listViewNumbersInventory);
            this.Controls.Add(this.labelNoNumbers);
            this.Controls.Add(this.buttonSearchNumbers);
            this.Name = "FormNumbersInventory";
            this.Text = "My Numbers";
            this.Load += new System.EventHandler(this.FormNumbersInventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearchNumbers;
        private System.Windows.Forms.Label labelNoNumbers;
        private System.Windows.Forms.ListView listViewNumbersInventory;
    }
}

