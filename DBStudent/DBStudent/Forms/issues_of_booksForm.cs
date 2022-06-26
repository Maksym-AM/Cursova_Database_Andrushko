using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace DBStudent.Forms
{
    public partial class issues_of_booksForm : Form
    {
        Model1 model;

        public issues_of_booksForm(Model1 model)
        {
            InitializeComponent();
            this.model = model;
            model.Issues_of_books.Load();
            issues_of_booksBindingSource.DataSource = model.Issues_of_books.Local.ToBindingList();

        }

        private void issues_of_booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           issues_of_booksDataGridView.EndEdit();
           issues_of_booksBindingSource.EndEdit();
           model.SaveChanges();

        }


        //Model1 model;
        //public student_gradeForm(Model1 model)
        //{
        //    InitializeComponent();
        //    this.model = model;
        //    student_gradeBindingSource.DataSource = model.Student_grade.Local.ToBindingList();

        //}

        //private void student_gradeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    student_gradeDataGridView.EndEdit();
        //    student_gradeBindingSource.EndEdit();
        //    model.SaveChanges();

        //}

        private void issues_of_booksForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentAccountingDataSet.Issues_of_books' table. You can move, or remove it, as needed.
            this.issues_of_booksTableAdapter.Fill(this.studentAccountingDataSet.Issues_of_books);

        }
    }
}
