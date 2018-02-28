namespace Coursework
{
    partial class Main
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
            this.addTrainButton = new System.Windows.Forms.Button();
            this.addDistanceButton = new System.Windows.Forms.Button();
            this.linkButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addTrainButton
            // 
            this.addTrainButton.AutoSize = true;
            this.addTrainButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addTrainButton.Location = new System.Drawing.Point(13, 4);
            this.addTrainButton.Margin = new System.Windows.Forms.Padding(4);
            this.addTrainButton.Name = "addTrainButton";
            this.addTrainButton.Size = new System.Drawing.Size(187, 27);
            this.addTrainButton.TabIndex = 0;
            this.addTrainButton.Text = "Add Train Line and Station";
            this.addTrainButton.UseVisualStyleBackColor = true;
            this.addTrainButton.Click += new System.EventHandler(this.addTrainButton_Click);
            // 
            // addDistanceButton
            // 
            this.addDistanceButton.AutoSize = true;
            this.addDistanceButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addDistanceButton.Location = new System.Drawing.Point(98, 39);
            this.addDistanceButton.Margin = new System.Windows.Forms.Padding(4);
            this.addDistanceButton.Name = "addDistanceButton";
            this.addDistanceButton.Size = new System.Drawing.Size(102, 27);
            this.addDistanceButton.TabIndex = 1;
            this.addDistanceButton.Text = "Add Distance";
            this.addDistanceButton.UseVisualStyleBackColor = true;
            this.addDistanceButton.Click += new System.EventHandler(this.addDistanceButton_Click);
            // 
            // linkButton
            // 
            this.linkButton.AutoSize = true;
            this.linkButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.linkButton.Location = new System.Drawing.Point(208, 4);
            this.linkButton.Margin = new System.Windows.Forms.Padding(4);
            this.linkButton.Name = "linkButton";
            this.linkButton.Size = new System.Drawing.Size(225, 27);
            this.linkButton.TabIndex = 2;
            this.linkButton.Text = "Link Train Station to a Train Line";
            this.linkButton.UseVisualStyleBackColor = true;
            this.linkButton.Click += new System.EventHandler(this.linkButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchButton.Location = new System.Drawing.Point(208, 39);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(63, 27);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 79);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.linkButton);
            this.Controls.Add(this.addDistanceButton);
            this.Controls.Add(this.addTrainButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTrainButton;
        private System.Windows.Forms.Button addDistanceButton;
        private System.Windows.Forms.Button linkButton;
        private System.Windows.Forms.Button searchButton;
    }
}