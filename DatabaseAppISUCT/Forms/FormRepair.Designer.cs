using DatabaseAppISUCT.DataSet;

namespace DatabaseAppISUCT
{
    partial class FormRepair
    {
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.Label dateStartLabel;
            System.Windows.Forms.Label typeRepairIDLabel;
            System.Windows.Forms.Label machineIDLabel;
            System.Windows.Forms.Label endDateLabel;
            System.Windows.Forms.Label repairIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRepair));
            System.Windows.Forms.Label machineIDLabel1;
            System.Windows.Forms.Label typeRepairIDLabel1;
            this.repairBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.repairBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DatabaseAppISUCT.DataSet.DataSet1();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.repairBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.repairDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnInsert = new MaterialSkin.Controls.MaterialButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btn_Update = new MaterialSkin.Controls.MaterialButton();
            this.repairTableAdapter = new DatabaseAppISUCT.DataSet.DataSet1TableAdapters.RepairTableAdapter();
            this.tableAdapterManager = new DatabaseAppISUCT.DataSet.DataSet1TableAdapters.TableAdapterManager();
            this.repairIDTextBox = new System.Windows.Forms.TextBox();
            this.machineIDTextBox = new System.Windows.Forms.TextBox();
            this.typeRepairIDTextBox = new System.Windows.Forms.TextBox();
            dateStartLabel = new System.Windows.Forms.Label();
            typeRepairIDLabel = new System.Windows.Forms.Label();
            machineIDLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            repairIDLabel = new System.Windows.Forms.Label();
            machineIDLabel1 = new System.Windows.Forms.Label();
            typeRepairIDLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repairBindingNavigator)).BeginInit();
            this.repairBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repairBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateStartLabel
            // 
            dateStartLabel.AutoSize = true;
            dateStartLabel.Location = new System.Drawing.Point(584, 21);
            dateStartLabel.Name = "dateStartLabel";
            dateStartLabel.Size = new System.Drawing.Size(55, 13);
            dateStartLabel.TabIndex = 2;
            dateStartLabel.Text = "DateStart:";
            // 
            // typeRepairIDLabel
            // 
            typeRepairIDLabel.AutoSize = true;
            typeRepairIDLabel.Location = new System.Drawing.Point(584, 50);
            typeRepairIDLabel.Name = "typeRepairIDLabel";
            typeRepairIDLabel.Size = new System.Drawing.Size(65, 13);
            typeRepairIDLabel.TabIndex = 6;
            typeRepairIDLabel.Text = "TypeRepair:";
            // 
            // machineIDLabel
            // 
            machineIDLabel.AutoSize = true;
            machineIDLabel.Location = new System.Drawing.Point(584, 77);
            machineIDLabel.Name = "machineIDLabel";
            machineIDLabel.Size = new System.Drawing.Size(51, 13);
            machineIDLabel.TabIndex = 8;
            machineIDLabel.Text = "Machine:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new System.Drawing.Point(584, 107);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(52, 13);
            endDateLabel.TabIndex = 10;
            endDateLabel.Text = "EndDate:";
            // 
            // repairIDLabel
            // 
            repairIDLabel.AutoSize = true;
            repairIDLabel.Location = new System.Drawing.Point(599, 277);
            repairIDLabel.Name = "repairIDLabel";
            repairIDLabel.Size = new System.Drawing.Size(107, 13);
            repairIDLabel.TabIndex = 23;
            repairIDLabel.Text = "RepairID (Additional):";
            // 
            // repairBindingNavigator
            // 
            this.repairBindingNavigator.AddNewItem = null;
            this.repairBindingNavigator.BindingSource = this.repairBindingSource;
            this.repairBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.repairBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.repairBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.repairBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.repairBindingNavigatorSaveItem});
            this.repairBindingNavigator.Location = new System.Drawing.Point(12, 0);
            this.repairBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.repairBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.repairBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.repairBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.repairBindingNavigator.Name = "repairBindingNavigator";
            this.repairBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.repairBindingNavigator.Size = new System.Drawing.Size(255, 25);
            this.repairBindingNavigator.TabIndex = 0;
            this.repairBindingNavigator.Text = "bindingNavigator1";
            // 
            // repairBindingSource
            // 
            this.repairBindingSource.DataMember = "Repair";
            this.repairBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // repairBindingNavigatorSaveItem
            // 
            this.repairBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.repairBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("repairBindingNavigatorSaveItem.Image")));
            this.repairBindingNavigatorSaveItem.Name = "repairBindingNavigatorSaveItem";
            this.repairBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.repairBindingNavigatorSaveItem.Text = "Save Data";
            this.repairBindingNavigatorSaveItem.Click += new System.EventHandler(this.repairBindingNavigatorSaveItem_Click);
            // 
            // repairDataGridView
            // 
            this.repairDataGridView.AutoGenerateColumns = false;
            this.repairDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.repairDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.repairDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.repairDataGridView.DataSource = this.repairBindingSource;
            this.repairDataGridView.Enabled = false;
            this.repairDataGridView.Location = new System.Drawing.Point(12, 28);
            this.repairDataGridView.Name = "repairDataGridView";
            this.repairDataGridView.ReadOnly = true;
            this.repairDataGridView.Size = new System.Drawing.Size(566, 421);
            this.repairDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DateStart";
            this.dataGridViewTextBoxColumn1.HeaderText = "DateStart";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RepairID";
            this.dataGridViewTextBoxColumn2.HeaderText = "RepairID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TypeRepairID";
            this.dataGridViewTextBoxColumn3.HeaderText = "TypeRepairID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MachineID";
            this.dataGridViewTextBoxColumn4.HeaderText = "MachineID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EndDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "EndDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dateStartDateTimePicker
            // 
            this.dateStartDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.repairBindingSource, "DateStart", true));
            this.dateStartDateTimePicker.Location = new System.Drawing.Point(683, 21);
            this.dateStartDateTimePicker.Name = "dateStartDateTimePicker";
            this.dateStartDateTimePicker.Size = new System.Drawing.Size(138, 20);
            this.dateStartDateTimePicker.TabIndex = 3;
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.repairBindingSource, "EndDate", true));
            this.endDateDateTimePicker.Location = new System.Drawing.Point(683, 101);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(138, 20);
            this.endDateDateTimePicker.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(690, 144);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(86, 20);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.AutoSize = false;
            this.btnInsert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInsert.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInsert.Depth = 0;
            this.btnInsert.HighEmphasis = true;
            this.btnInsert.Icon = null;
            this.btnInsert.Location = new System.Drawing.Point(585, 144);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInsert.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInsert.Size = new System.Drawing.Size(86, 20);
            this.btnInsert.TabIndex = 19;
            this.btnInsert.Text = "Insert";
            this.btnInsert.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInsert.UseAccentColor = false;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(683, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(355, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(683, 74);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(355, 21);
            this.comboBox2.TabIndex = 22;
            // 
            // btn_Update
            // 
            this.btn_Update.AutoSize = false;
            this.btn_Update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Update.Depth = 0;
            this.btn_Update.HighEmphasis = true;
            this.btn_Update.Icon = null;
            this.btn_Update.Location = new System.Drawing.Point(795, 144);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Update.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Update.Size = new System.Drawing.Size(86, 20);
            this.btn_Update.TabIndex = 23;
            this.btn_Update.Text = "Update";
            this.btn_Update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Update.UseAccentColor = false;
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // repairTableAdapter
            // 
            this.repairTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LoggerTableAdapter = null;
            this.tableAdapterManager.MachineTableAdapter = null;
            this.tableAdapterManager.RepairTableAdapter = this.repairTableAdapter;
            this.tableAdapterManager.Type_MachineTableAdapter = null;
            this.tableAdapterManager.Type_RepairTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DatabaseAppISUCT.DataSet.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // repairIDTextBox
            // 
            this.repairIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repairBindingSource, "RepairID", true));
            this.repairIDTextBox.Location = new System.Drawing.Point(804, 277);
            this.repairIDTextBox.Name = "repairIDTextBox";
            this.repairIDTextBox.ReadOnly = true;
            this.repairIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.repairIDTextBox.TabIndex = 24;
            // 
            // machineIDLabel1
            // 
            machineIDLabel1.AutoSize = true;
            machineIDLabel1.Location = new System.Drawing.Point(599, 309);
            machineIDLabel1.Name = "machineIDLabel1";
            machineIDLabel1.Size = new System.Drawing.Size(117, 13);
            machineIDLabel1.TabIndex = 24;
            machineIDLabel1.Text = "MachineID (Additional):";
            // 
            // machineIDTextBox
            // 
            this.machineIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repairBindingSource, "MachineID", true));
            this.machineIDTextBox.Location = new System.Drawing.Point(804, 306);
            this.machineIDTextBox.Name = "machineIDTextBox";
            this.machineIDTextBox.ReadOnly = true;
            this.machineIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.machineIDTextBox.TabIndex = 25;
            // 
            // typeRepairIDLabel1
            // 
            typeRepairIDLabel1.AutoSize = true;
            typeRepairIDLabel1.Location = new System.Drawing.Point(599, 341);
            typeRepairIDLabel1.Name = "typeRepairIDLabel1";
            typeRepairIDLabel1.Size = new System.Drawing.Size(131, 13);
            typeRepairIDLabel1.TabIndex = 25;
            typeRepairIDLabel1.Text = "TypeRepairID (Additional):";
            // 
            // typeRepairIDTextBox
            // 
            this.typeRepairIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repairBindingSource, "TypeRepairID", true));
            this.typeRepairIDTextBox.Location = new System.Drawing.Point(804, 334);
            this.typeRepairIDTextBox.Name = "typeRepairIDTextBox";
            this.typeRepairIDTextBox.ReadOnly = true;
            this.typeRepairIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeRepairIDTextBox.TabIndex = 26;
            // 
            // FormRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 469);
            this.Controls.Add(typeRepairIDLabel1);
            this.Controls.Add(this.typeRepairIDTextBox);
            this.Controls.Add(machineIDLabel1);
            this.Controls.Add(this.machineIDTextBox);
            this.Controls.Add(repairIDLabel);
            this.Controls.Add(this.repairIDTextBox);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(dateStartLabel);
            this.Controls.Add(this.dateStartDateTimePicker);
            this.Controls.Add(typeRepairIDLabel);
            this.Controls.Add(machineIDLabel);
            this.Controls.Add(endDateLabel);
            this.Controls.Add(this.endDateDateTimePicker);
            this.Controls.Add(this.repairDataGridView);
            this.Controls.Add(this.repairBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRepair";
            this.Text = "Repair";
            this.Load += new System.EventHandler(this.FormRepair_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repairBindingNavigator)).EndInit();
            this.repairBindingNavigator.ResumeLayout(false);
            this.repairBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repairBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource repairBindingSource;
        private DataSet.DataSet1TableAdapters.RepairTableAdapter repairTableAdapter;
        private DataSet.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator repairBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton repairBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView repairDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DateTimePicker dateStartDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnInsert;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private MaterialSkin.Controls.MaterialButton btn_Update;
        private System.Windows.Forms.TextBox repairIDTextBox;
        private System.Windows.Forms.TextBox machineIDTextBox;
        private System.Windows.Forms.TextBox typeRepairIDTextBox;
    }
}