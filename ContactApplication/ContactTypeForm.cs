using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactApplication
{
    public partial class ContactTypeForm : Form
    {
        public ContactTypeForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ContactTypeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "notebook_newDataSet.ContactType". При необходимости она может быть перемещена или удалена.
            this.contactTypeTableAdapter.Fill(this.notebook_newDataSet.ContactType);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            contactTypeTableAdapter.Update(notebook_newDataSet.ContactType);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
