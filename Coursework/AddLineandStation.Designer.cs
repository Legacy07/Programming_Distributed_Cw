namespace Coursework
{
    partial class AddLineandStation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lineTextbox = new System.Windows.Forms.TextBox();
            this.addLineButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.outputLabelStation = new System.Windows.Forms.Label();
            this.stationTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addStationButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteStationButton = new System.Windows.Forms.Button();
            this.updateStationTextBox = new System.Windows.Forms.TextBox();
            this.updateStationbutton = new System.Windows.Forms.Button();
            this.stationGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationDataSet = new Coursework.DatabaseDataSet();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.deleteLineButton = new System.Windows.Forms.Button();
            this.updateLineTextBox = new System.Windows.Forms.TextBox();
            this.updateLineButton = new System.Windows.Forms.Button();
            this.lineDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lineDataset = new Coursework.LineDataset();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outputLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lineTextbox);
            this.groupBox1.Controls.Add(this.addLineButton);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(355, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Train Line";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(8, 111);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 17);
            this.outputLabel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Train Line";
            // 
            // lineTextbox
            // 
            this.lineTextbox.Location = new System.Drawing.Point(12, 65);
            this.lineTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.lineTextbox.Name = "lineTextbox";
            this.lineTextbox.Size = new System.Drawing.Size(211, 22);
            this.lineTextbox.TabIndex = 3;
            // 
            // addLineButton
            // 
            this.addLineButton.AutoSize = true;
            this.addLineButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addLineButton.Location = new System.Drawing.Point(232, 65);
            this.addLineButton.Margin = new System.Windows.Forms.Padding(4);
            this.addLineButton.Name = "addLineButton";
            this.addLineButton.Size = new System.Drawing.Size(111, 27);
            this.addLineButton.TabIndex = 2;
            this.addLineButton.Text = "Add Train Line";
            this.addLineButton.UseVisualStyleBackColor = true;
            this.addLineButton.Click += new System.EventHandler(this.addLineButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.outputLabelStation);
            this.groupBox2.Controls.Add(this.stationTextbox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.addStationButton);
            this.groupBox2.Location = new System.Drawing.Point(379, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(355, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Train Station";
            // 
            // outputLabelStation
            // 
            this.outputLabelStation.AutoSize = true;
            this.outputLabelStation.Location = new System.Drawing.Point(8, 111);
            this.outputLabelStation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabelStation.Name = "outputLabelStation";
            this.outputLabelStation.Size = new System.Drawing.Size(0, 17);
            this.outputLabelStation.TabIndex = 6;
            // 
            // stationTextbox
            // 
            this.stationTextbox.Location = new System.Drawing.Point(8, 69);
            this.stationTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.stationTextbox.Name = "stationTextbox";
            this.stationTextbox.Size = new System.Drawing.Size(197, 22);
            this.stationTextbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Train Station";
            // 
            // addStationButton
            // 
            this.addStationButton.AutoSize = true;
            this.addStationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addStationButton.Location = new System.Drawing.Point(215, 69);
            this.addStationButton.Margin = new System.Windows.Forms.Padding(4);
            this.addStationButton.Name = "addStationButton";
            this.addStationButton.Size = new System.Drawing.Size(128, 27);
            this.addStationButton.TabIndex = 3;
            this.addStationButton.Text = "Add Train Station";
            this.addStationButton.UseVisualStyleBackColor = true;
            this.addStationButton.Click += new System.EventHandler(this.addStationButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deleteStationButton);
            this.groupBox3.Controls.Add(this.updateStationTextBox);
            this.groupBox3.Controls.Add(this.updateStationbutton);
            this.groupBox3.Controls.Add(this.stationGridView);
            this.groupBox3.Location = new System.Drawing.Point(379, 178);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(355, 289);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit / Delete Stations";
            // 
            // deleteStationButton
            // 
            this.deleteStationButton.Location = new System.Drawing.Point(116, 253);
            this.deleteStationButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteStationButton.Name = "deleteStationButton";
            this.deleteStationButton.Size = new System.Drawing.Size(100, 28);
            this.deleteStationButton.TabIndex = 8;
            this.deleteStationButton.Text = "Delete";
            this.deleteStationButton.UseVisualStyleBackColor = true;
            this.deleteStationButton.Click += new System.EventHandler(this.deleteStationButton_Click);
            // 
            // updateStationTextBox
            // 
            this.updateStationTextBox.Location = new System.Drawing.Point(8, 223);
            this.updateStationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.updateStationTextBox.Name = "updateStationTextBox";
            this.updateStationTextBox.Size = new System.Drawing.Size(211, 22);
            this.updateStationTextBox.TabIndex = 7;
            // 
            // updateStationbutton
            // 
            this.updateStationbutton.Location = new System.Drawing.Point(8, 253);
            this.updateStationbutton.Margin = new System.Windows.Forms.Padding(4);
            this.updateStationbutton.Name = "updateStationbutton";
            this.updateStationbutton.Size = new System.Drawing.Size(100, 28);
            this.updateStationbutton.TabIndex = 2;
            this.updateStationbutton.Text = "Update";
            this.updateStationbutton.UseVisualStyleBackColor = true;
            this.updateStationbutton.Click += new System.EventHandler(this.updateStationbutton_Click);
            // 
            // stationGridView
            // 
            this.stationGridView.AutoGenerateColumns = false;
            this.stationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stationGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.stationGridView.DataSource = this.stationBindingSource;
            this.stationGridView.Location = new System.Drawing.Point(9, 25);
            this.stationGridView.Margin = new System.Windows.Forms.Padding(4);
            this.stationGridView.Name = "stationGridView";
            this.stationGridView.ReadOnly = true;
            this.stationGridView.Size = new System.Drawing.Size(323, 185);
            this.stationGridView.TabIndex = 0;
            this.stationGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.stationGridView_RowHeaderMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.deleteLineButton);
            this.groupBox4.Controls.Add(this.updateLineTextBox);
            this.groupBox4.Controls.Add(this.updateLineButton);
            this.groupBox4.Controls.Add(this.lineDataGridView);
            this.groupBox4.Location = new System.Drawing.Point(16, 178);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(355, 289);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Edit / Delete Line";
            // 
            // deleteLineButton
            // 
            this.deleteLineButton.Location = new System.Drawing.Point(116, 253);
            this.deleteLineButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteLineButton.Name = "deleteLineButton";
            this.deleteLineButton.Size = new System.Drawing.Size(100, 28);
            this.deleteLineButton.TabIndex = 7;
            this.deleteLineButton.Text = "Delete";
            this.deleteLineButton.UseVisualStyleBackColor = true;
            this.deleteLineButton.Click += new System.EventHandler(this.deleteLineButton_Click);
            // 
            // updateLineTextBox
            // 
            this.updateLineTextBox.Location = new System.Drawing.Point(8, 223);
            this.updateLineTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.updateLineTextBox.Name = "updateLineTextBox";
            this.updateLineTextBox.Size = new System.Drawing.Size(211, 22);
            this.updateLineTextBox.TabIndex = 6;
            // 
            // updateLineButton
            // 
            this.updateLineButton.Location = new System.Drawing.Point(8, 253);
            this.updateLineButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateLineButton.Name = "updateLineButton";
            this.updateLineButton.Size = new System.Drawing.Size(100, 28);
            this.updateLineButton.TabIndex = 1;
            this.updateLineButton.Text = "Update";
            this.updateLineButton.UseVisualStyleBackColor = true;
            this.updateLineButton.Click += new System.EventHandler(this.updateLineButton_Click);
            // 
            // lineDataGridView
            // 
            this.lineDataGridView.AutoGenerateColumns = false;
            this.lineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lineDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.lineDataGridView.DataSource = this.lineBindingSource;
            this.lineDataGridView.Location = new System.Drawing.Point(8, 25);
            this.lineDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.lineDataGridView.Name = "lineDataGridView";
            this.lineDataGridView.ReadOnly = true;
            this.lineDataGridView.Size = new System.Drawing.Size(323, 185);
            this.lineDataGridView.TabIndex = 0;
            this.lineDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.lineDataGridView_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // lineBindingSource
            // 
            this.lineBindingSource.DataMember = "Line";
            this.lineBindingSource.DataSource = this.lineDataset;
            // 
            // lineDataset
            // 
            this.lineDataset.DataSetName = "LineDataset";
            this.lineDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddLineandStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 488);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddLineandStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddLineandStation";
            this.Load += new System.EventHandler(this.AddLineandStation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineDataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addLineButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lineTextbox;
        private System.Windows.Forms.TextBox stationTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addStationButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label outputLabelStation;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView stationGridView;
        private DatabaseDataSet stationDataSet;
        private System.Windows.Forms.BindingSource stationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView lineDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private LineDataset lineDataset;
        private System.Windows.Forms.BindingSource lineBindingSource;
        private System.Windows.Forms.Button updateStationbutton;
        private System.Windows.Forms.Button updateLineButton;
        private System.Windows.Forms.TextBox updateLineTextBox;
        private System.Windows.Forms.TextBox updateStationTextBox;
        private System.Windows.Forms.Button deleteStationButton;
        private System.Windows.Forms.Button deleteLineButton;
    }
}