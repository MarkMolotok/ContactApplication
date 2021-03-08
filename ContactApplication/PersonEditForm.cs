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
    public partial class PersonEditForm : Form
    {
        public PersonEditForm()
        {
            // Данный конструктор используется для создания новой записи
            InitializeComponent();
            this.contactsTableAdapter.Fill(this.notebook_newDataSet.Contacts);
            this.contactTypeTableAdapter.Fill(this.notebook_newDataSet.ContactType);

            personsBindingSource.AddNew();
        }

        public PersonEditForm(int index)
        {
            //Данный конструктор используется для редактирования существующей записи
            InitializeComponent();
            this.personsTableAdapter.Fill(this.notebook_newDataSet.Persons);
            this.contactsTableAdapter.Fill(this.notebook_newDataSet.Contacts);
            this.contactTypeTableAdapter.Fill(this.notebook_newDataSet.ContactType);
            personsBindingSource.Position = index;
        }

        //private void personsbindingnavigatorsaveitem_click(object sender, eventargs e)
        //{
        //    this.validate();
        //    this.personsbindingsource.endedit();
        //    this.tableadaptermanager.updateall(this.notebook_newdataset);

        //}

        private void PersonEditForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "notebook_newDataSet.ContactType". При необходимости она может быть перемещена или удалена.
            //this.contactTypeTableAdapter.Fill(this.notebook_newDataSet.ContactType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "notebook_newDataSet.Contacts". При необходимости она может быть перемещена или удалена.
            //this.contactsTableAdapter.Fill(this.notebook_newDataSet.Contacts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "notebook_newDataSet.Persons". При необходимости она может быть перемещена или удалена.
            //this.personsTableAdapter.Fill(this.notebook_newDataSet.Persons);

        }

        //сохранение почему-то не работает, разобраться!!!
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            personsBindingSource.EndEdit();
            personsTableAdapter.Update(notebook_newDataSet.Persons);
            contactsTableAdapter.Update(notebook_newDataSet.Contacts);

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
