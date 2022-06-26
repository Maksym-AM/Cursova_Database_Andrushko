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
    public partial class bookForm : Form
    {
        Model1 model;
        public bookForm(Model1 model)
        {
            InitializeComponent();
            this.model = model;
            model.Books.Load();
            bookBindingSource.DataSource = model.Books.Local.ToBindingList();
        }

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            bookDataGridView.EndEdit();
        bookBindingSource.EndEdit();
            model.SaveChanges();
        }

        private void bookForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentAccountingDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.studentAccountingDataSet.Book);

        }
    }
}
