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
    public partial class discipline : Form
    {
        Model1 model;
        public discipline(Model1 model)
        {
            InitializeComponent();
            this.model = model;
            model.Disciplines.Load();
            disciplineBindingSource.DataSource = model.Disciplines.Local.ToBindingList();
        }

        private void disciplineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           disciplineDataGridView.EndEdit();
            disciplineBindingSource.EndEdit();
            model.SaveChanges();

        }

        private void discipline_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentAccountingDataSet.Discipline' table. You can move, or remove it, as needed.
            this.disciplineTableAdapter.Fill(this.studentAccountingDataSet.Discipline);

        }
    }
}
