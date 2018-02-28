namespace Coursework
{
    partial class AddDistance
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
            this.station1Combobox = new System.Windows.Forms.ComboBox();
            this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationDataset = new Coursework.DatabaseDataSet7();
            this.station2Combobox = new System.Windows.Forms.ComboBox();
            this.station2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.station2Dataset = new Coursework.station2Dataset();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addDistanceTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.minusbutton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.line2Combobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.line1Combobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.distanceDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.station1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.station2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.distanceDataset = new Coursework.distanceDataset();
            this.label6 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.idRemoveTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.station2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.station2Dataset)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distanceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // station1Combobox
            // 
            this.station1Combobox.DataSource = this.stationBindingSource;
            this.station1Combobox.DisplayMember = "Name";
            this.station1Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.station1Combobox.FormattingEnabled = true;
            this.station1Combobox.Location = new System.Drawing.Point(88, 23);
            this.station1Combobox.Margin = new System.Windows.Forms.Padding(4);
            this.station1Combobox.Name = "station1Combobox";
            this.station1Combobox.Size = new System.Drawing.Size(160, 24);
            this.station1Combobox.TabIndex = 0;
            this.station1Combobox.ValueMember = "Name";
            this.station1Combobox.TextChanged += new System.EventHandler(this.station1Combobox_TextChanged);
            // 
            // stationBindingSource
            // 
            this.stationBindingSource.DataMember = "Station";
            this.stationBindingSource.DataSource = this.stationDataset;
            // 
            // stationDataset
            // 
            this.stationDataset.DataSetName = "stationDataset";
            this.stationDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // station2Combobox
            // 
            this.station2Combobox.DataSource = this.station2BindingSource;
            this.station2Combobox.DisplayMember = "Name";
            this.station2Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.station2Combobox.FormattingEnabled = true;
            this.station2Combobox.Location = new System.Drawing.Point(88, 62);
            this.station2Combobox.Margin = new System.Windows.Forms.Padding(4);
            this.station2Combobox.Name = "station2Combobox";
            this.station2Combobox.Size = new System.Drawing.Size(160, 24);
            this.station2Combobox.TabIndex = 1;
            this.station2Combobox.ValueMember = "Name";
            this.station2Combobox.TextChanged += new System.EventHandler(this.station2Combobox_TextChanged);
            // 
            // station2BindingSource
            // 
            this.station2BindingSource.DataMember = "Station";
            this.station2BindingSource.DataSource = this.station2Dataset;
            // 
            // station2Dataset
            // 
            this.station2Dataset.DataSetName = "station2Dataset";
            this.station2Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Station 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Station 2";
            // 
            // addDistanceTextbox
            // 
            this.addDistanceTextbox.Location = new System.Drawing.Point(112, 113);
            this.addDistanceTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.addDistanceTextbox.Name = "addDistanceTextbox";
            this.addDistanceTextbox.ReadOnly = true;
            this.addDistanceTextbox.Size = new System.Drawing.Size(39, 22);
            this.addDistanceTextbox.TabIndex = 4;
            this.addDistanceTextbox.Text = "5";
            this.addDistanceTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addDistanceTextbox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Distance";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.minusbutton);
            this.groupBox1.Controls.Add(this.plusButton);
            this.groupBox1.Controls.Add(this.line2Combobox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.line1Combobox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.station1Combobox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.station2Combobox);
            this.groupBox1.Controls.Add(this.addDistanceTextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(523, 145);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Distance";
            // 
            // minusbutton
            // 
            this.minusbutton.AutoSize = true;
            this.minusbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.minusbutton.Location = new System.Drawing.Point(81, 110);
            this.minusbutton.Margin = new System.Windows.Forms.Padding(4);
            this.minusbutton.Name = "minusbutton";
            this.minusbutton.Size = new System.Drawing.Size(23, 27);
            this.minusbutton.TabIndex = 12;
            this.minusbutton.Text = "-";
            this.minusbutton.UseVisualStyleBackColor = true;
            this.minusbutton.Click += new System.EventHandler(this.minusbutton_Click);
            // 
            // plusButton
            // 
            this.plusButton.AutoSize = true;
            this.plusButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.plusButton.Location = new System.Drawing.Point(191, 110);
            this.plusButton.Margin = new System.Windows.Forms.Padding(4);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(26, 27);
            this.plusButton.TabIndex = 11;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // line2Combobox
            // 
            this.line2Combobox.DisplayMember = "Name";
            this.line2Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.line2Combobox.FormattingEnabled = true;
            this.line2Combobox.Location = new System.Drawing.Point(321, 62);
            this.line2Combobox.Margin = new System.Windows.Forms.Padding(4);
            this.line2Combobox.Name = "line2Combobox";
            this.line2Combobox.Size = new System.Drawing.Size(160, 24);
            this.line2Combobox.TabIndex = 9;
            this.line2Combobox.ValueMember = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Line 2";
            // 
            // line1Combobox
            // 
            this.line1Combobox.DisplayMember = "Name";
            this.line1Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.line1Combobox.FormattingEnabled = true;
            this.line1Combobox.Location = new System.Drawing.Point(321, 23);
            this.line1Combobox.Margin = new System.Windows.Forms.Padding(4);
            this.line1Combobox.Name = "line1Combobox";
            this.line1Combobox.Size = new System.Drawing.Size(160, 24);
            this.line1Combobox.TabIndex = 7;
            this.line1Combobox.ValueMember = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Line 1";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(269, 110);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 28);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.idRemoveTextbox);
            this.groupBox2.Controls.Add(this.removeButton);
            this.groupBox2.Controls.Add(this.distanceDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(16, 167);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(888, 220);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Distance between two stations";
            // 
            // distanceDataGridView
            // 
            this.distanceDataGridView.AutoGenerateColumns = false;
            this.distanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.distanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.station1DataGridViewTextBoxColumn,
            this.station2DataGridViewTextBoxColumn,
            this.line1DataGridViewTextBoxColumn,
            this.line2DataGridViewTextBoxColumn,
            this.distanceDataGridViewTextBoxColumn});
            this.distanceDataGridView.DataSource = this.distanceBindingSource;
            this.distanceDataGridView.Location = new System.Drawing.Point(9, 25);
            this.distanceDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.distanceDataGridView.Name = "distanceDataGridView";
            this.distanceDataGridView.ReadOnly = true;
            this.distanceDataGridView.Size = new System.Drawing.Size(645, 185);
            this.distanceDataGridView.TabIndex = 0;
            this.distanceDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.distanceDataGridView_RowHeaderMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // station1DataGridViewTextBoxColumn
            // 
            this.station1DataGridViewTextBoxColumn.DataPropertyName = "Station1";
            this.station1DataGridViewTextBoxColumn.HeaderText = "Station1";
            this.station1DataGridViewTextBoxColumn.Name = "station1DataGridViewTextBoxColumn";
            this.station1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // station2DataGridViewTextBoxColumn
            // 
            this.station2DataGridViewTextBoxColumn.DataPropertyName = "Station2";
            this.station2DataGridViewTextBoxColumn.HeaderText = "Station2";
            this.station2DataGridViewTextBoxColumn.Name = "station2DataGridViewTextBoxColumn";
            this.station2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // line1DataGridViewTextBoxColumn
            // 
            this.line1DataGridViewTextBoxColumn.DataPropertyName = "Line1";
            this.line1DataGridViewTextBoxColumn.HeaderText = "Line1";
            this.line1DataGridViewTextBoxColumn.Name = "line1DataGridViewTextBoxColumn";
            this.line1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // line2DataGridViewTextBoxColumn
            // 
            this.line2DataGridViewTextBoxColumn.DataPropertyName = "Line2";
            this.line2DataGridViewTextBoxColumn.HeaderText = "Line2";
            this.line2DataGridViewTextBoxColumn.Name = "line2DataGridViewTextBoxColumn";
            this.line2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distanceDataGridViewTextBoxColumn
            // 
            this.distanceDataGridViewTextBoxColumn.DataPropertyName = "Distance";
            this.distanceDataGridViewTextBoxColumn.HeaderText = "Distance";
            this.distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
            this.distanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distanceBindingSource
            // 
            this.distanceBindingSource.DataMember = "Distance";
            this.distanceBindingSource.DataSource = this.distanceDataset;
            // 
            // distanceDataset
            // 
            this.distanceDataset.DataSetName = "distanceDataset";
            this.distanceDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "km";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(687, 57);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(100, 28);
            this.removeButton.TabIndex = 15;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // idRemoveTextbox
            // 
            this.idRemoveTextbox.Location = new System.Drawing.Point(687, 28);
            this.idRemoveTextbox.Name = "idRemoveTextbox";
            this.idRemoveTextbox.Size = new System.Drawing.Size(100, 22);
            this.idRemoveTextbox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(662, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Id";
            // 
            // AddDistance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 418);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddDistance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDistance";
            this.Load += new System.EventHandler(this.AddDistance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.station2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.station2Dataset)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distanceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceDataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox station1Combobox;
        private System.Windows.Forms.ComboBox station2Combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addDistanceTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox line2Combobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox line1Combobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView distanceDataGridView;
        private DatabaseDataSet7 stationDataset;
        private System.Windows.Forms.BindingSource stationBindingSource;
        private distanceDataset distanceDataset;
        private System.Windows.Forms.BindingSource distanceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn station1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn station2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn line1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn line2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private station2Dataset station2Dataset;
        private System.Windows.Forms.BindingSource station2BindingSource;
        private System.Windows.Forms.Button minusbutton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idRemoveTextbox;
        private System.Windows.Forms.Button removeButton;
    }
}