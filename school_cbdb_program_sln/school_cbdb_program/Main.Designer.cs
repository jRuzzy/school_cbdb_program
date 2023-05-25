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
            this.mainStoreButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridASCB = new System.Windows.Forms.DataGridView();
            this.mainSearchButton = new System.Windows.Forms.Button();
            this.mainAssignButton = new System.Windows.Forms.Button();
            this.dataGridSTCB = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridASCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSTCB)).BeginInit();
            this.SuspendLayout();
            // 
            // mainStoreButton
            // 
            this.mainStoreButton.Location = new System.Drawing.Point(92, 11);
            this.mainStoreButton.Margin = new System.Windows.Forms.Padding(2);
            this.mainStoreButton.Name = "mainStoreButton";
            this.mainStoreButton.Size = new System.Drawing.Size(69, 19);
            this.mainStoreButton.TabIndex = 0;
            this.mainStoreButton.Text = "STORE";
            this.mainStoreButton.UseVisualStyleBackColor = true;
            this.mainStoreButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(668, 11);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 19);
            this.button4.TabIndex = 7;
            this.button4.Text = "HELP";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridASCB
            // 
            this.dataGridASCB.AllowUserToAddRows = false;
            this.dataGridASCB.AllowUserToDeleteRows = false;
            this.dataGridASCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridASCB.Location = new System.Drawing.Point(12, 36);
            this.dataGridASCB.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridASCB.Name = "dataGridASCB";
            this.dataGridASCB.ReadOnly = true;
            this.dataGridASCB.RowHeadersWidth = 51;
            this.dataGridASCB.RowTemplate.Height = 24;
            this.dataGridASCB.Size = new System.Drawing.Size(377, 424);
            this.dataGridASCB.TabIndex = 9;
            // 
            // mainSearchButton
            // 
            this.mainSearchButton.Location = new System.Drawing.Point(166, 12);
            this.mainSearchButton.Name = "mainSearchButton";
            this.mainSearchButton.Size = new System.Drawing.Size(71, 19);
            this.mainSearchButton.TabIndex = 15;
            this.mainSearchButton.Text = "Search";
            this.mainSearchButton.UseVisualStyleBackColor = true;
            // 
            // mainAssignButton
            // 
            this.mainAssignButton.Location = new System.Drawing.Point(12, 12);
            this.mainAssignButton.Name = "mainAssignButton";
            this.mainAssignButton.Size = new System.Drawing.Size(75, 19);
            this.mainAssignButton.TabIndex = 17;
            this.mainAssignButton.Text = "ASSIGN";
            this.mainAssignButton.UseVisualStyleBackColor = true;
            this.mainAssignButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridSTCB
            // 
            this.dataGridSTCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSTCB.Location = new System.Drawing.Point(394, 36);
            this.dataGridSTCB.Name = "dataGridSTCB";
            this.dataGridSTCB.Size = new System.Drawing.Size(332, 424);
            this.dataGridSTCB.TabIndex = 18;
            // 
            // Form1
            // 
            this.AcceptButton = this.mainStoreButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(735, 472);
            this.Controls.Add(this.dataGridSTCB);
            this.Controls.Add(this.mainAssignButton);
            this.Controls.Add(this.mainSearchButton);
            this.Controls.Add(this.dataGridASCB);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.mainStoreButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridASCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSTCB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainStoreButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridASCB;
        private System.Windows.Forms.Button mainSearchButton;
        private System.Windows.Forms.Button mainAssignButton;
        private System.Windows.Forms.DataGridView dataGridSTCB;
    }
}

