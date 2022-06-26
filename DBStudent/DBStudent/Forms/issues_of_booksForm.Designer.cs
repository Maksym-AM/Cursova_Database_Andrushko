namespace DBStudent.Forms
{
    partial class issues_of_booksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(issues_of_booksForm));
            this.studentAccountingDataSet = new DBStudent.StudentAccountingDataSet();
            this.issues_of_booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.issues_of_booksTableAdapter = new DBStudent.StudentAccountingDataSetTableAdapters.Issues_of_booksTableAdapter();
            this.tableAdapterManager = new DBStudent.StudentAccountingDataSetTableAdapters.TableAdapterManager();
            this.issues_of_booksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.issues_of_booksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.issues_of_booksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentAccountingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issues_of_booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issues_of_booksBindingNavigator)).BeginInit();
            this.issues_of_booksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issues_of_booksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentAccountingDataSet
            // 
            this.studentAccountingDataSet.DataSetName = "StudentAccountingDataSet";
            this.studentAccountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // issues_of_booksBindingSource
            // 
            this.issues_of_booksBindingSource.DataMember = "Issues_of_books";
            this.issues_of_booksBindingSource.DataSource = this.studentAccountingDataSet;
            // 
            // issues_of_booksTableAdapter
            // 
            this.issues_of_booksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.ChangeTrackingTableAdapter = null;
            this.tableAdapterManager.DisciplineTableAdapter = null;
            this.tableAdapterManager.GroupsTableAdapter = null;
            this.tableAdapterManager.Issues_of_booksTableAdapter = this.issues_of_booksTableAdapter;
            this.tableAdapterManager.PersonTableAdapter = null;
            this.tableAdapterManager.Student_gradeTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DBStudent.StudentAccountingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // issues_of_booksBindingNavigator
            // 
            this.issues_of_booksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.issues_of_booksBindingNavigator.BindingSource = this.issues_of_booksBindingSource;
            this.issues_of_booksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.issues_of_booksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.issues_of_booksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.issues_of_booksBindingNavigatorSaveItem});
            this.issues_of_booksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.issues_of_booksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.issues_of_booksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.issues_of_booksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.issues_of_booksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.issues_of_booksBindingNavigator.Name = "issues_of_booksBindingNavigator";
            this.issues_of_booksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.issues_of_booksBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.issues_of_booksBindingNavigator.TabIndex = 0;
            this.issues_of_booksBindingNavigator.Text = "bindingNavigator1";
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
            // issues_of_booksBindingNavigatorSaveItem
            // 
            this.issues_of_booksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.issues_of_booksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("issues_of_booksBindingNavigatorSaveItem.Image")));
            this.issues_of_booksBindingNavigatorSaveItem.Name = "issues_of_booksBindingNavigatorSaveItem";
            this.issues_of_booksBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.issues_of_booksBindingNavigatorSaveItem.Text = "Save Data";
            this.issues_of_booksBindingNavigatorSaveItem.Click += new System.EventHandler(this.issues_of_booksBindingNavigatorSaveItem_Click);
            // 
            // issues_of_booksDataGridView
            // 
            this.issues_of_booksDataGridView.AllowUserToAddRows = false;
            this.issues_of_booksDataGridView.AutoGenerateColumns = false;
            this.issues_of_booksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.issues_of_booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issues_of_booksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.issues_of_booksDataGridView.DataSource = this.issues_of_booksBindingSource;
            this.issues_of_booksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issues_of_booksDataGridView.Location = new System.Drawing.Point(0, 25);
            this.issues_of_booksDataGridView.Name = "issues_of_booksDataGridView";
            this.issues_of_booksDataGridView.Size = new System.Drawing.Size(800, 425);
            this.issues_of_booksDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "issues_of_books_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "issues_of_books_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "date_of_issues";
            this.dataGridViewTextBoxColumn2.HeaderText = "date_of_issues";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "date_of_comeback";
            this.dataGridViewTextBoxColumn3.HeaderText = "date_of_comeback";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "book_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "book_ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "student_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "student_ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // issues_of_booksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.issues_of_booksDataGridView);
            this.Controls.Add(this.issues_of_booksBindingNavigator);
            this.Name = "issues_of_booksForm";
            this.Text = "issues_of_booksForm";
            this.Load += new System.EventHandler(this.issues_of_booksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentAccountingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issues_of_booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issues_of_booksBindingNavigator)).EndInit();
            this.issues_of_booksBindingNavigator.ResumeLayout(false);
            this.issues_of_booksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issues_of_booksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentAccountingDataSet studentAccountingDataSet;
        private System.Windows.Forms.BindingSource issues_of_booksBindingSource;
        private StudentAccountingDataSetTableAdapters.Issues_of_booksTableAdapter issues_of_booksTableAdapter;
        private StudentAccountingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator issues_of_booksBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton issues_of_booksBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView issues_of_booksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}