namespace school_cbdb_program
{
    partial class CreateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.createComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.createAssetEntry = new System.Windows.Forms.TextBox();
            this.createLocationButton = new System.Windows.Forms.Button();
            this.createAssetButton = new System.Windows.Forms.Button();
            this.createAutoCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            // 
            // createComboBox
            // 
            this.createComboBox.FormattingEnabled = true;
            this.createComboBox.Location = new System.Drawing.Point(13, 30);
            this.createComboBox.Name = "createComboBox";
            this.createComboBox.Size = new System.Drawing.Size(169, 21);
            this.createComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Asset";
            // 
            // createAssetEntry
            // 
            this.createAssetEntry.Location = new System.Drawing.Point(13, 75);
            this.createAssetEntry.Name = "createAssetEntry";
            this.createAssetEntry.Size = new System.Drawing.Size(121, 20);
            this.createAssetEntry.TabIndex = 3;
            // 
            // createLocationButton
            // 
            this.createLocationButton.Location = new System.Drawing.Point(188, 28);
            this.createLocationButton.Name = "createLocationButton";
            this.createLocationButton.Size = new System.Drawing.Size(75, 23);
            this.createLocationButton.TabIndex = 4;
            this.createLocationButton.Text = "NEW";
            this.createLocationButton.UseVisualStyleBackColor = true;
            this.createLocationButton.Click += new System.EventHandler(this.createLocationButton_Click);
            // 
            // createAssetButton
            // 
            this.createAssetButton.Location = new System.Drawing.Point(189, 73);
            this.createAssetButton.Name = "createAssetButton";
            this.createAssetButton.Size = new System.Drawing.Size(75, 23);
            this.createAssetButton.TabIndex = 5;
            this.createAssetButton.Text = "ADD";
            this.createAssetButton.UseVisualStyleBackColor = true;
            // 
            // createAutoCheckbox
            // 
            this.createAutoCheckbox.AutoSize = true;
            this.createAutoCheckbox.Location = new System.Drawing.Point(140, 77);
            this.createAutoCheckbox.Name = "createAutoCheckbox";
            this.createAutoCheckbox.Size = new System.Drawing.Size(48, 17);
            this.createAutoCheckbox.TabIndex = 6;
            this.createAutoCheckbox.Text = "Auto";
            this.createAutoCheckbox.UseVisualStyleBackColor = true;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 112);
            this.Controls.Add(this.createAutoCheckbox);
            this.Controls.Add(this.createAssetButton);
            this.Controls.Add(this.createLocationButton);
            this.Controls.Add(this.createAssetEntry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createComboBox);
            this.Controls.Add(this.label1);
            this.Name = "CreateForm";
            this.Text = "CreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox createComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox createAssetEntry;
        private System.Windows.Forms.Button createLocationButton;
        private System.Windows.Forms.Button createAssetButton;
        private System.Windows.Forms.CheckBox createAutoCheckbox;
    }
}