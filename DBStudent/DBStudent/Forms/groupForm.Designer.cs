﻿namespace DBStudent.Forms
{
    partial class groupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(groupForm));
            this.studentAccountingDataSet = new DBStudent.StudentAccountingDataSet();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupsTableAdapter = new DBStudent.StudentAccountingDataSetTableAdapters.GroupsTableAdapter();
            this.tableAdapterManager = new DBStudent.StudentAccountingDataSetTableAdapters.TableAdapterManager();
            this.groupsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.groupsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentAccountingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingNavigator)).BeginInit();
            this.groupsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentAccountingDataSet
            // 
            this.studentAccountingDataSet.DataSetName = "StudentAccountingDataSet";
            this.studentAccountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.studentAccountingDataSet;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.ChangeTrackingTableAdapter = null;
            this.tableAdapterManager.DisciplineTableAdapter = null;
            this.tableAdapterManager.GroupsTableAdapter = this.groupsTableAdapter;
            this.tableAdapterManager.Issues_of_booksTableAdapter = null;
            this.tableAdapterManager.PersonTableAdapter = null;
            this.tableAdapterManager.Student_gradeTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DBStudent.StudentAccountingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupsBindingNavigator
            // 
            this.groupsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.groupsBindingNavigator.BindingSource = this.groupsBindingSource;
            this.groupsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.groupsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.groupsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.groupsBindingNavigatorSaveItem});
            this.groupsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.groupsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.groupsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.groupsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.groupsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.groupsBindingNavigator.Name = "groupsBindingNavigator";
            this.groupsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.groupsBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.groupsBindingNavigator.TabIndex = 0;
            this.groupsBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // groupsBindingNavigatorSaveItem
            // 
            this.groupsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.groupsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("groupsBindingNavigatorSaveItem.Image")));
            this.groupsBindingNavigatorSaveItem.Name = "groupsBindingNavigatorSaveItem";
            this.groupsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.groupsBindingNavigatorSaveItem.Text = "Save Data";
            this.groupsBindingNavigatorSaveItem.Click += new System.EventHandler(this.groupsBindingNavigatorSaveItem_Click);
            // 
            // groupsDataGridView
            // 
            this.groupsDataGridView.AllowUserToAddRows = false;
            this.groupsDataGridView.AutoGenerateColumns = false;
            this.groupsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groupsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.groupsDataGridView.DataSource = this.groupsBindingSource;
            this.groupsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupsDataGridView.Location = new System.Drawing.Point(0, 25);
            this.groupsDataGridView.Name = "groupsDataGridView";
            this.groupsDataGridView.Size = new System.Drawing.Size(800, 425);
            this.groupsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "group_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "group_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "group_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "group_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // groupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupsDataGridView);
            this.Controls.Add(this.groupsBindingNavigator);
            this.Name = "groupForm";
            this.Text = "groupForm";
            this.Load += new System.EventHandler(this.groupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentAccountingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingNavigator)).EndInit();
            this.groupsBindingNavigator.ResumeLayout(false);
            this.groupsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentAccountingDataSet studentAccountingDataSet;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private StudentAccountingDataSetTableAdapters.GroupsTableAdapter groupsTableAdapter;
        private StudentAccountingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator groupsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
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
        private System.Windows.Forms.ToolStripButton groupsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView groupsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}