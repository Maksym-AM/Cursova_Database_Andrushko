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
    public partial class personForm : Form
    {
        Model1 model;
        public personForm(Model1 model)
        {
            InitializeComponent();
            this.model = model;
            model.People.Load();
            personBindingSource.DataSource = model.People.Local.ToBindingList();
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
      personDataGridView.EndEdit();
            personBindingSource.EndEdit();
            model.SaveChanges();

        }

        private void personForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentAccountingDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.studentAccountingDataSet.Person);

        }
    }
}
