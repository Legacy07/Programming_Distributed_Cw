namespace Coursework
{
    partial class LinkTrainStationtoaLine
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
            this.components = new System.ComponentModel.Container();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lineComboBox = new System.Windows.Forms.ComboBox();
            this.lineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lineDataSet = new Coursework.DatabaseDataSet1();
            this.stationCombox = new System.Windows.Forms.ComboBox();
            this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationDataSet = new Coursework.DatabaseDataSet2();
            this.label4 = new System.Windows.Forms.Label();
            this.linkButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationsLineLinkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationsLineLinkDataset = new Coursework.DatabaseDataSet3();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.removeTextbox = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsLineLinkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsLineLinkDataset)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.lineComboBox);
            this.groupBox5.Controls.Add(this.stationCombox);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.linkButton);
            this.groupBox5.Location = new System.Drawing.Point(13, 14);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(333, 142);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Link Train Station to a Train Line";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select a Train Line";
            // 
            // lineComboBox
            // 
            this.lineComboBox.DataSource = this.lineBindingSource;
            this.lineComboBox.DisplayMember = "Name";
            this.lineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lineComboBox.FormattingEnabled = true;
            this.lineComboBox.Location = new System.Drawing.Point(11, 98);
            this.lineComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lineComboBox.Name = "lineComboBox";
            this.lineComboBox.Size = new System.Drawing.Size(141, 24);
            this.lineComboBox.TabIndex = 6;
            this.lineComboBox.ValueMember = "Name";
            // 
            // lineBindingSource
            // 
            this.lineBindingSource.DataMember = "Line";
            this.lineBindingSource.DataSource = this.lineDataSet;
            // 
            // lineDataSet
            // 
            this.lineDataSet.DataSetName = "lineDataSet";
            this.lineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stationCombox
            // 
            this.stationCombox.DataSource = this.stationBindingSource;
            this.stationCombox.DisplayMember = "Name";
            this.stationCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stationCombox.FormattingEnabled = true;
            this.stationCombox.Location = new System.Drawing.Point(11, 49);
            this.stationCombox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stationCombox.Name = "stationCombox";
            this.stationCombox.Size = new System.Drawing.Size(141, 24);
            this.stationCombox.TabIndex = 5;
            this.stationCombox.ValueMember = "Name";
            // 
            // stationBindingSource
            // 
            this.stationBindingSource.DataMember = "Station";
            this.stationBindingSource.DataSource = this.stationDataSet;
            // 
            // stationDataSet
            // 
            this.stationDataSet.DataSetName = "StationDataSet";
            this.stationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Select a Train Station";
            // 
            // linkButton
            // 
            this.linkButton.AutoSize = true;
            this.linkButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.linkButton.Location = new System.Drawing.Point(181, 96);
            this.linkButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.linkButton.Name = "linkButton";
            this.linkButton.Size = new System.Drawing.Size(129, 27);
            this.linkButton.TabIndex = 2;
            this.linkButton.Text = "Link Train Station";
            this.linkButton.UseVisualStyleBackColor = true;
            this.linkButton.Click += new System.EventHandler(this.linkButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.stationDataGridViewTextBoxColumn,
            this.lineDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.stationsLineLinkBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(8, 23);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(459, 185);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_RowHeaderMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stationDataGridViewTextBoxColumn
            // 
            this.stationDataGridViewTextBoxColumn.DataPropertyName = "Station";
            this.stationDataGridViewTextBoxColumn.HeaderText = "Station";
            this.stationDataGridViewTextBoxColumn.Name = "stationDataGridViewTextBoxColumn";
            this.stationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lineDataGridViewTextBoxColumn
            // 
            this.lineDataGridViewTextBoxColumn.DataPropertyName = "Line";
            this.lineDataGridViewTextBoxColumn.HeaderText = "Line";
            this.lineDataGridViewTextBoxColumn.Name = "lineDataGridViewTextBoxColumn";
            this.lineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stationsLineLinkBindingSource
            // 
            this.stationsLineLinkBindingSource.DataMember = "StationsLineLink";
            this.stationsLineLinkBindingSource.DataSource = this.stationsLineLinkDataset;
            // 
            // stationsLineLinkDataset
            // 
            this.stationsLineLinkDataset.DataSetName = "DatabaseDataSet3";
            this.stationsLineLinkDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.removeTextbox);
            this.groupBox1.Controls.Add(this.removeButton);
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(17, 164);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(699, 218);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Linked Train Stations";
            // 
            // removeTextbox
            // 
            this.removeTextbox.Location = new System.Drawing.Point(476, 50);
            this.removeTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeTextbox.Name = "removeTextbox";
            this.removeTextbox.Size = new System.Drawing.Size(157, 22);
            this.removeTextbox.TabIndex = 9;
            // 
            // removeButton
            // 
            this.removeButton.AutoSize = true;
            this.removeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeButton.Location = new System.Drawing.Point(475, 82);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(155, 27);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "Remove Train Station";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // LinkTrainStationtoaLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 476);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LinkTrainStationtoaLine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LinkTrainStationtoaLine";
            this.Load += new System.EventHandler(this.LinkTrainStationtoaLine_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsLineLinkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsLineLinkDataset)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox lineComboBox;
        private System.Windows.Forms.ComboBox stationCombox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button linkButton;
        private DatabaseDataSet1 lineDataSet;
        private System.Windows.Forms.BindingSource lineBindingSource;
        private DatabaseDataSet2 stationDataSet;
        private System.Windows.Forms.BindingSource stationBindingSource;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private DatabaseDataSet3 stationsLineLinkDataset;
        private System.Windows.Forms.BindingSource stationsLineLinkBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox removeTextbox;
        private System.Windows.Forms.Button removeButton;
    }
}