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
    public partial class teacherForm : Form
    {
        Model1 model;
        public teacherForm(Model1 model)
        {
            InitializeComponent();
            this.model = model;
            model.Teachers.Load();
            teacherBindingSource.DataSource = model.Teachers.Local.ToBindingList();
        }

        private void teacherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
      teacherDataGridView.EndEdit();
            teacherBindingSource.EndEdit();
            model.Teachers.Load();

        }

        private void teacherForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentAccountingDataSet.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.studentAccountingDataSet.Teacher);

        }
    }
}
