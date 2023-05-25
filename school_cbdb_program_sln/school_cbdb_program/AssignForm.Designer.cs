namespace school_cbdb_program
{
    partial class AssignForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.assignLastEntry = new System.Windows.Forms.TextBox();
            this.assignFirstEntry = new System.Windows.Forms.TextBox();
            this.assignAssetEntry = new System.Windows.Forms.TextBox();
            this.assignAutoCheckbox = new System.Windows.Forms.CheckBox();
            this.assignButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Asset Tag";
            // 
            // assignLastEntry
            // 
            this.assignLastEntry.Location = new System.Drawing.Point(173, 24);
            this.assignLastEntry.Margin = new System.Windows.Forms.Padding(2);
            this.assignLastEntry.Name = "assignLastEntry";
            this.assignLastEntry.Size = new System.Drawing.Size(76, 20);
            this.assignLastEntry.TabIndex = 16;
            // 
            // assignFirstEntry
            // 
            this.assignFirstEntry.Location = new System.Drawing.Point(93, 24);
            this.assignFirstEntry.Margin = new System.Windows.Forms.Padding(2);
            this.assignFirstEntry.Name = "assignFirstEntry";
            this.assignFirstEntry.Size = new System.Drawing.Size(76, 20);
            this.assignFirstEntry.TabIndex = 15;
            // 
            // assignAssetEntry
            // 
            this.assignAssetEntry.Location = new System.Drawing.Point(13, 24);
            this.assignAssetEntry.Margin = new System.Windows.Forms.Padding(2);
            this.assignAssetEntry.Name = "assignAssetEntry";
            this.assignAssetEntry.Size = new System.Drawing.Size(76, 20);
            this.assignAssetEntry.TabIndex = 14;
            // 
            // assignAutoCheckbox
            // 
            this.assignAutoCheckbox.AutoSize = true;
            this.assignAutoCheckbox.Location = new System.Drawing.Point(13, 50);
            this.assignAutoCheckbox.Name = "assignAutoCheckbox";
            this.assignAutoCheckbox.Size = new System.Drawing.Size(48, 17);
            this.assignAutoCheckbox.TabIndex = 20;
            this.assignAutoCheckbox.Text = "Auto";
            this.assignAutoCheckbox.UseVisualStyleBackColor = true;
            // 
            // assignButton
            // 
            this.assignButton.Location = new System.Drawing.Point(174, 49);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(75, 23);
            this.assignButton.TabIndex = 21;
            this.assignButton.Text = "ASSIGN";
            this.assignButton.UseVisualStyleBackColor = true;
            // 
            // AssignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 85);
            this.Controls.Add(this.assignButton);
            this.Controls.Add(this.assignAutoCheckbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.assignLastEntry);
            this.Controls.Add(this.assignFirstEntry);
            this.Controls.Add(this.assignAssetEntry);
            this.Name = "AssignForm";
            this.Text = "AssignForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox assignLastEntry;
        private System.Windows.Forms.TextBox assignFirstEntry;
        private System.Windows.Forms.TextBox assignAssetEntry;
        private System.Windows.Forms.CheckBox assignAutoCheckbox;
        private System.Windows.Forms.Button assignButton;
    }
}