namespace school_cbdb_program
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.assetTagEntry = new System.Windows.Forms.TextBox();
            this.firstNameEntry = new System.Windows.Forms.TextBox();
            this.locationEntry = new System.Windows.Forms.TextBox();
            this.lastNameEntry = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridCB = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCB)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "EDIT";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(176, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "REMOVE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // assetTagEntry
            // 
            this.assetTagEntry.Location = new System.Drawing.Point(118, 63);
            this.assetTagEntry.Name = "assetTagEntry";
            this.assetTagEntry.Size = new System.Drawing.Size(100, 22);
            this.assetTagEntry.TabIndex = 3;
            // 
            // firstNameEntry
            // 
            this.firstNameEntry.Location = new System.Drawing.Point(224, 63);
            this.firstNameEntry.Name = "firstNameEntry";
            this.firstNameEntry.Size = new System.Drawing.Size(100, 22);
            this.firstNameEntry.TabIndex = 4;
            // 
            // locationEntry
            // 
            this.locationEntry.AutoCompleteCustomSource.AddRange(new string[] {
            "DELL90 1",
            "DELL90 2"});
            this.locationEntry.Location = new System.Drawing.Point(12, 63);
            this.locationEntry.Name = "locationEntry";
            this.locationEntry.Size = new System.Drawing.Size(100, 22);
            this.locationEntry.TabIndex = 5;
            // 
            // lastNameEntry
            // 
            this.lastNameEntry.Location = new System.Drawing.Point(330, 63);
            this.lastNameEntry.Name = "lastNameEntry";
            this.lastNameEntry.Size = new System.Drawing.Size(100, 22);
            this.lastNameEntry.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(637, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "HELP";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(257, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "LOCATIONS";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dataGridCB
            // 
            this.dataGridCB.AllowUserToAddRows = false;
            this.dataGridCB.AllowUserToDeleteRows = false;
            this.dataGridCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCB.Location = new System.Drawing.Point(12, 91);
            this.dataGridCB.Name = "dataGridCB";
            this.dataGridCB.ReadOnly = true;
            this.dataGridCB.RowHeadersWidth = 51;
            this.dataGridCB.RowTemplate.Height = 24;
            this.dataGridCB.Size = new System.Drawing.Size(699, 522);
            this.dataGridCB.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Asset Tag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Last Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 625);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridCB);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lastNameEntry);
            this.Controls.Add(this.locationEntry);
            this.Controls.Add(this.firstNameEntry);
            this.Controls.Add(this.assetTagEntry);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox assetTagEntry;
        private System.Windows.Forms.TextBox firstNameEntry;
        private System.Windows.Forms.TextBox locationEntry;
        private System.Windows.Forms.TextBox lastNameEntry;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

