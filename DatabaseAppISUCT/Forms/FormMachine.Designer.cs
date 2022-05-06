using DatabaseAppISUCT.DataSet;

namespace DatabaseAppISUCT
{
    partial class FormMachine
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
            System.Windows.Forms.Label typeMachineIDLabel;
            System.Windows.Forms.Label dateIssueLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMachine));
            this.dataSet1 = new DatabaseAppISUCT.DataSet.DataSet1();
            this.machineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.machineTableAdapter = new DatabaseAppISUCT.DataSet.DataSet1TableAdapters.MachineTableAdapter();
            this.tableAdapterManager = new DatabaseAppISUCT.DataSet.DataSet1TableAdapters.TableAdapterManager();
            this.machineBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.machineBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.machineDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeMachineIDTextBox = new System.Windows.Forms.TextBox();
            this.dateIssueTextBox = new System.Windows.Forms.TextBox();
            this.btnInsert = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            typeMachineIDLabel = new System.Windows.Forms.Label();
            dateIssueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machineBindingNavigator)).BeginInit();
            this.machineBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.machineDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // typeMachineIDLabel
            // 
            typeMachineIDLabel.AutoSize = true;
            typeMachineIDLabel.Location = new System.Drawing.Point(402, 54);
            typeMachineIDLabel.Name = "typeMachineIDLabel";
            typeMachineIDLabel.Size = new System.Drawing.Size(86, 13);
            typeMachineIDLabel.TabIndex = 6;
            typeMachineIDLabel.Text = "TypeMachineID:";
            // 
            // dateIssueLabel
            // 
            dateIssueLabel.AutoSize = true;
            dateIssueLabel.Location = new System.Drawing.Point(402, 28);
            dateIssueLabel.Name = "dateIssueLabel";
            dateIssueLabel.Size = new System.Drawing.Size(58, 13);
            dateIssueLabel.TabIndex = 4;
            dateIssueLabel.Text = "DateIssue:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // machineBindingSource
            // 
            this.machineBindingSource.DataMember = "Machine";
            this.machineBindingSource.DataSource = this.dataSet1;
            // 
            // machineTableAdapter
            // 
            this.machineTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LoggerTableAdapter = null;
            this.tableAdapterManager.MachineTableAdapter = this.machineTableAdapter;
            this.tableAdapterManager.RepairTableAdapter = null;
            this.tableAdapterManager.Type_MachineTableAdapter = null;
            this.tableAdapterManager.Type_RepairTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DatabaseAppISUCT.DataSet.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // machineBindingNavigator
            // 
            this.machineBindingNavigator.AddNewItem = null;
            this.machineBindingNavigator.BindingSource = this.machineBindingSource;
            this.machineBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.machineBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.machineBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.machineBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.machineBindingNavigatorSaveItem});
            this.machineBindingNavigator.Location = new System.Drawing.Point(12, 0);
            this.machineBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.machineBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.machineBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.machineBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.machineBindingNavigator.Name = "machineBindingNavigator";
            this.machineBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.machineBindingNavigator.Size = new System.Drawing.Size(255, 25);
            this.machineBindingNavigator.TabIndex = 0;
            this.machineBindingNavigator.Text = "bindingNavigator1";
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
            // machineBindingNavigatorSaveItem
            // 
            this.machineBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.machineBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("machineBindingNavigatorSaveItem.Image")));
            this.machineBindingNavigatorSaveItem.Name = "machineBindingNavigatorSaveItem";
            this.machineBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.machineBindingNavigatorSaveItem.Text = "Save Data";
            this.machineBindingNavigatorSaveItem.Click += new System.EventHandler(this.machineBindingNavigatorSaveItem_Click);
            // 
            // machineDataGridView
            // 
            this.machineDataGridView.AutoGenerateColumns = false;
            this.machineDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.machineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.machineDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.machineDataGridView.DataSource = this.machineBindingSource;
            this.machineDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.machineDataGridView.Location = new System.Drawing.Point(12, 28);
            this.machineDataGridView.Name = "machineDataGridView";
            this.machineDataGridView.Size = new System.Drawing.Size(384, 421);
            this.machineDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MachineID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MachineID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DateIssue";
            this.dataGridViewTextBoxColumn2.HeaderText = "DateIssue";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TypeMachineID";
            this.dataGridViewTextBoxColumn3.HeaderText = "TypeMachineID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // typeMachineIDTextBox
            // 
            this.typeMachineIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.machineBindingSource, "TypeMachineID", true));
            this.typeMachineIDTextBox.Location = new System.Drawing.Point(521, 51);
            this.typeMachineIDTextBox.Name = "typeMachineIDTextBox";
            this.typeMachineIDTextBox.Size = new System.Drawing.Size(103, 20);
            this.typeMachineIDTextBox.TabIndex = 7;
            // 
            // dateIssueTextBox
            // 
            this.dateIssueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.machineBindingSource, "DateIssue", true));
            this.dateIssueTextBox.Location = new System.Drawing.Point(521, 25);
            this.dateIssueTextBox.Name = "dateIssueTextBox";
            this.dateIssueTextBox.Size = new System.Drawing.Size(103, 20);
            this.dateIssueTextBox.TabIndex = 5;
            // 
            // btnInsert
            // 
            this.btnInsert.AutoSize = false;
            this.btnInsert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInsert.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInsert.Depth = 0;
            this.btnInsert.HighEmphasis = true;
            this.btnInsert.Icon = null;
            this.btnInsert.Location = new System.Drawing.Point(426, 82);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInsert.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInsert.Size = new System.Drawing.Size(86, 20);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "Insert";
            this.btnInsert.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInsert.UseAccentColor = false;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(538, 82);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(86, 20);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 461);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(dateIssueLabel);
            this.Controls.Add(this.dateIssueTextBox);
            this.Controls.Add(typeMachineIDLabel);
            this.Controls.Add(this.typeMachineIDTextBox);
            this.Controls.Add(this.machineDataGridView);
            this.Controls.Add(this.machineBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Machine";
            this.Load += new System.EventHandler(this.FormMachine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machineBindingNavigator)).EndInit();
            this.machineBindingNavigator.ResumeLayout(false);
            this.machineBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.machineDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource machineBindingSource;
        private DataSet.DataSet1TableAdapters.MachineTableAdapter machineTableAdapter;
        private DataSet.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator machineBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton machineBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView machineDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox typeMachineIDTextBox;
        private System.Windows.Forms.TextBox dateIssueTextBox;
        private MaterialSkin.Controls.MaterialButton btnInsert;
        private MaterialSkin.Controls.MaterialButton btnSave;
    }
}