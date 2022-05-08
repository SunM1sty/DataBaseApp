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
            System.Windows.Forms.Label machineIDLabel;
            System.Windows.Forms.Label typeMachineIDLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMachine));
            this.machineBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.machineBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.machineBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.machineDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateIssueTextBox = new System.Windows.Forms.TextBox();
            this.btnInsert = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new MaterialSkin.Controls.MaterialButton();
            this.machineIDTextBox = new System.Windows.Forms.TextBox();
            this.machineTableAdapter = new DatabaseAppISUCT.DataSet.DataSet1TableAdapters.MachineTableAdapter();
            this.tableAdapterManager = new DatabaseAppISUCT.DataSet.DataSet1TableAdapters.TableAdapterManager();
            this.typeMachineIDTextBox = new System.Windows.Forms.TextBox();
            typeMachineIDLabel = new System.Windows.Forms.Label();
            dateIssueLabel = new System.Windows.Forms.Label();
            machineIDLabel = new System.Windows.Forms.Label();
            typeMachineIDLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.machineBindingNavigator)).BeginInit();
            this.machineBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.machineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machineDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // typeMachineIDLabel
            // 
            typeMachineIDLabel.AutoSize = true;
            typeMachineIDLabel.Location = new System.Drawing.Point(402, 62);
            typeMachineIDLabel.Name = "typeMachineIDLabel";
            typeMachineIDLabel.Size = new System.Drawing.Size(75, 13);
            typeMachineIDLabel.TabIndex = 6;
            typeMachineIDLabel.Text = "TypeMachine:";
            // 
            // dateIssueLabel
            // 
            dateIssueLabel.AutoSize = true;
            dateIssueLabel.Location = new System.Drawing.Point(402, 31);
            dateIssueLabel.Name = "dateIssueLabel";
            dateIssueLabel.Size = new System.Drawing.Size(58, 13);
            dateIssueLabel.TabIndex = 4;
            dateIssueLabel.Text = "DateIssue:";
            // 
            // machineIDLabel
            // 
            machineIDLabel.AutoSize = true;
            machineIDLabel.Location = new System.Drawing.Point(402, 7);
            machineIDLabel.Name = "machineIDLabel";
            machineIDLabel.Size = new System.Drawing.Size(65, 13);
            machineIDLabel.TabIndex = 17;
            machineIDLabel.Text = "Machine ID:";
            // 
            // typeMachineIDLabel1
            // 
            typeMachineIDLabel1.AutoSize = true;
            typeMachineIDLabel1.Location = new System.Drawing.Point(402, 167);
            typeMachineIDLabel1.Name = "typeMachineIDLabel1";
            typeMachineIDLabel1.Size = new System.Drawing.Size(141, 13);
            typeMachineIDLabel1.TabIndex = 18;
            typeMachineIDLabel1.Text = "TypeMachineID (Additional):";
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
            // machineBindingSource
            // 
            this.machineBindingSource.DataMember = "Machine";
            this.machineBindingSource.DataSource = this.dataSet1;
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigator);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigator);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigator);
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
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigator);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigator);
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
            this.machineBindingNavigatorSaveItem.Click += new System.EventHandler(this.bindingNavigator);
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
            this.machineDataGridView.Enabled = false;
            this.machineDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.machineDataGridView.Location = new System.Drawing.Point(12, 28);
            this.machineDataGridView.MultiSelect = false;
            this.machineDataGridView.Name = "machineDataGridView";
            this.machineDataGridView.ReadOnly = true;
            this.machineDataGridView.Size = new System.Drawing.Size(384, 421);
            this.machineDataGridView.TabIndex = 1;
            this.machineDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bindingNavigator);
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
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TypeMachineID";
            this.dataGridViewTextBoxColumn3.HeaderText = "TypeMachineID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dateIssueTextBox
            // 
            this.dateIssueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.machineBindingSource, "DateIssue", true));
            this.dateIssueTextBox.Location = new System.Drawing.Point(521, 28);
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
            this.btnInsert.Location = new System.Drawing.Point(425, 110);
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
            this.btnSave.Location = new System.Drawing.Point(537, 110);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(521, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = false;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.HighEmphasis = true;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(650, 110);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdate.Size = new System.Drawing.Size(86, 20);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdate.UseAccentColor = false;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // machineIDTextBox
            // 
            this.machineIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.machineBindingSource, "MachineID", true));
            this.machineIDTextBox.Location = new System.Drawing.Point(521, 2);
            this.machineIDTextBox.Name = "machineIDTextBox";
            this.machineIDTextBox.ReadOnly = true;
            this.machineIDTextBox.Size = new System.Drawing.Size(103, 20);
            this.machineIDTextBox.TabIndex = 18;
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
            // typeMachineIDTextBox
            // 
            this.typeMachineIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.machineBindingSource, "TypeMachineID", true));
            this.typeMachineIDTextBox.Location = new System.Drawing.Point(591, 164);
            this.typeMachineIDTextBox.Name = "typeMachineIDTextBox";
            this.typeMachineIDTextBox.ReadOnly = true;
            this.typeMachineIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeMachineIDTextBox.TabIndex = 19;
            // 
            // FormMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 469);
            this.Controls.Add(typeMachineIDLabel1);
            this.Controls.Add(this.typeMachineIDTextBox);
            this.Controls.Add(machineIDLabel);
            this.Controls.Add(this.machineIDTextBox);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(dateIssueLabel);
            this.Controls.Add(this.dateIssueTextBox);
            this.Controls.Add(typeMachineIDLabel);
            this.Controls.Add(this.machineDataGridView);
            this.Controls.Add(this.machineBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Machine";
            this.Load += new System.EventHandler(this.FormMachine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.machineBindingNavigator)).EndInit();
            this.machineBindingNavigator.ResumeLayout(false);
            this.machineBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.machineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
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
        private System.Windows.Forms.TextBox dateIssueTextBox;
        private MaterialSkin.Controls.MaterialButton btnInsert;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private System.Windows.Forms.TextBox machineIDTextBox;
        private System.Windows.Forms.TextBox typeMachineIDTextBox;
    }
}