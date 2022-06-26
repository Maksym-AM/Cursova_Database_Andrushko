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
    public partial class student_gradeForm : Form
    {
        Model1 model;
        public student_gradeForm(Model1 model)
        {
            InitializeComponent();
            this.model = model;
            student_gradeBindingSource.DataSource = model.Student_grade.Local.ToBindingList();
           
        }

        private void student_gradeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            student_gradeDataGridView.EndEdit();
            student_gradeBindingSource.EndEdit();
            model.SaveChanges();

        }

        private void student_gradeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentAccountingDataSet.Student_grade' table. You can move, or remove it, as needed.
            this.student_gradeTableAdapter.Fill(this.studentAccountingDataSet.Student_grade);

        }
    }
}
