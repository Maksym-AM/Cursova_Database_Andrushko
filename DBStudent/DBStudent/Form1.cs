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
using DBStudent.Forms;
namespace DBStudent
{
    public partial class Form1 : Form
    {
        Model1 model;
        public Form1()
        {
            InitializeComponent();
            Model1 model1 = new Model1();
            this.model = model1;
            model.Students.Load();
            studentBindingSource.DataSource = model1.Students.Local.ToBindingList();

        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookForm bookForm = new bookForm(model);
            bookForm.ShowDialog();
        }

        private void addDisciplineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            discipline discipline = new discipline(model);
            discipline.ShowDialog();
        }

        private void addGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupForm groupForm = new groupForm(model);
            groupForm.ShowDialog();
        }

        private void addIssuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issues_of_booksForm issues_of_ = new issues_of_booksForm(model);
            issues_of_.ShowDialog();
        }

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personForm personForm = new personForm(model);
            personForm.ShowDialog();
        }

        private void addStudentgradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student_gradeForm student_GradeForm = new student_gradeForm(model);
            student_GradeForm.ShowDialog();
        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teacherForm teacherForm = new teacherForm(model);
            teacherForm.ShowDialog();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            studentDataGridView.EndEdit();
            studentBindingSource.EndEdit();
            model.SaveChanges();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentAccountingDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentAccountingDataSet.Student);

        }
    }
}
