﻿namespace DatabaseAppISUCT
{
    partial class FormStoredProcedure
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
            System.Windows.Forms.Label machineIDLabel;
            System.Windows.Forms.Label dateStartLabel;
            System.Windows.Forms.Label typeRepairIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStoredProcedure));
            this.repairBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.repairBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DatabaseAppISUCT.DataSet.DataSet1();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
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
            this.repairTableAdapter = new DatabaseAppISUCT.DataSet.DataSet1TableAdapters.RepairTableAdapter();
            this.tableAdapterManager = new DatabaseAppISUCT.DataSet.DataSet1TableAdapters.TableAdapterManager();
            this.machineIDTextBox = new System.Windows.Forms.TextBox();
            this.dateStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.typeRepairIDTextBox = new System.Windows.Forms.TextBox();
            this.btnInsert = new MaterialSkin.Controls.MaterialButton();
            machineIDLabel = new System.Windows.Forms.Label();
            dateStartLabel = new System.Windows.Forms.Label();
            typeRepairIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repairBindingNavigator)).BeginInit();
            this.repairBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repairBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // machineIDLabel
            // 
            machineIDLabel.AutoSize = true;
            machineIDLabel.Location = new System.Drawing.Point(592, 28);
            machineIDLabel.Name = "machineIDLabel";
            machineIDLabel.Size = new System.Drawing.Size(62, 13);
            machineIDLabel.TabIndex = 2;
            machineIDLabel.Text = "MachineID:";
            // 
            // dateStartLabel
            // 
            dateStartLabel.AutoSize = true;
            dateStartLabel.Location = new System.Drawing.Point(592, 100);
            dateStartLabel.Name = "dateStartLabel";
            dateStartLabel.Size = new System.Drawing.Size(55, 13);
            dateStartLabel.TabIndex = 4;
            dateStartLabel.Text = "DateStart:";
            // 
            // typeRepairIDLabel
            // 
            typeRepairIDLabel.AutoSize = true;
            typeRepairIDLabel.Location = new System.Drawing.Point(592, 61);
            typeRepairIDLabel.Name = "typeRepairIDLabel";
            typeRepairIDLabel.Size = new System.Drawing.Size(76, 13);
            typeRepairIDLabel.TabIndex = 6;
            typeRepairIDLabel.Text = "TypeRepairID:";
            // 
            // repairBindingNavigator
            // 
            this.repairBindingNavigator.AddNewItem = null;
            this.repairBindingNavigator.BindingSource = this.repairBindingSource;
            this.repairBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.repairBindingNavigator.DeleteItem = null;
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
            this.repairBindingNavigatorSaveItem});
            this.repairBindingNavigator.Location = new System.Drawing.Point(12, 0);
            this.repairBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.repairBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.repairBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.repairBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.repairBindingNavigator.Name = "repairBindingNavigator";
            this.repairBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.repairBindingNavigator.Size = new System.Drawing.Size(232, 25);
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
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
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
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
            this.repairDataGridView.Location = new System.Drawing.Point(12, 28);
            this.repairDataGridView.Name = "repairDataGridView";
            this.repairDataGridView.Size = new System.Drawing.Size(574, 421);
            this.repairDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DateStart";
            this.dataGridViewTextBoxColumn1.HeaderText = "DateStart";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MachineID";
            this.dataGridViewTextBoxColumn4.HeaderText = "MachineID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EndDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "EndDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
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
            // machineIDTextBox
            // 
            this.machineIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repairBindingSource, "MachineID", true));
            this.machineIDTextBox.Location = new System.Drawing.Point(697, 25);
            this.machineIDTextBox.Name = "machineIDTextBox";
            this.machineIDTextBox.Size = new System.Drawing.Size(138, 20);
            this.machineIDTextBox.TabIndex = 3;
            // 
            // dateStartDateTimePicker
            // 
            this.dateStartDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.repairBindingSource, "DateStart", true));
            this.dateStartDateTimePicker.Location = new System.Drawing.Point(697, 94);
            this.dateStartDateTimePicker.Name = "dateStartDateTimePicker";
            this.dateStartDateTimePicker.Size = new System.Drawing.Size(138, 20);
            this.dateStartDateTimePicker.TabIndex = 5;
            // 
            // typeRepairIDTextBox
            // 
            this.typeRepairIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repairBindingSource, "TypeRepairID", true));
            this.typeRepairIDTextBox.Location = new System.Drawing.Point(697, 58);
            this.typeRepairIDTextBox.Name = "typeRepairIDTextBox";
            this.typeRepairIDTextBox.Size = new System.Drawing.Size(138, 20);
            this.typeRepairIDTextBox.TabIndex = 7;
            // 
            // btnInsert
            // 
            this.btnInsert.AutoSize = false;
            this.btnInsert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInsert.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInsert.Depth = 0;
            this.btnInsert.HighEmphasis = true;
            this.btnInsert.Icon = null;
            this.btnInsert.Location = new System.Drawing.Point(723, 123);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInsert.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInsert.Size = new System.Drawing.Size(86, 21);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Insert";
            this.btnInsert.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInsert.UseAccentColor = false;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 461);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(typeRepairIDLabel);
            this.Controls.Add(this.typeRepairIDTextBox);
            this.Controls.Add(dateStartLabel);
            this.Controls.Add(this.dateStartDateTimePicker);
            this.Controls.Add(machineIDLabel);
            this.Controls.Add(this.machineIDTextBox);
            this.Controls.Add(this.repairDataGridView);
            this.Controls.Add(this.repairBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStoredProcedure";
            this.Text = "AddRepair";
            this.Load += new System.EventHandler(this.FormStoredProcedure_Load);
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

        private DataSet.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource repairBindingSource;
        private DataSet.DataSet1TableAdapters.RepairTableAdapter repairTableAdapter;
        private DataSet.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator repairBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
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
        private System.Windows.Forms.TextBox machineIDTextBox;
        private System.Windows.Forms.DateTimePicker dateStartDateTimePicker;
        private System.Windows.Forms.TextBox typeRepairIDTextBox;
        private MaterialSkin.Controls.MaterialButton btnInsert;
    }
}