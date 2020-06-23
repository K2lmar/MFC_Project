using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFC_Project
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
            ShowEmployee();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EmployeesSet employeeSet = new EmployeesSet();
            employeeSet.FirstName = textBoxFirstName.Text;
            employeeSet.MiddleName = textBoxMiddleName.Text;
            employeeSet.LastName = textBoxLastName.Text;
            Program.wftDb.EmployeesSet.Add(employeeSet);
            Program.wftDb.SaveChanges();
            ShowEmployee();
        }
        void ShowEmployee()
        {
            listViewEmployee.Items.Clear();
            foreach (EmployeesSet employeeSet in Program.wftDb.EmployeesSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                  employeeSet.Id.ToString(), employeeSet.LastName, employeeSet.FirstName,
                  employeeSet.MiddleName
                });
                item.Tag = employeeSet;
                listViewEmployee.Items.Add(item);
            }
            listViewEmployee.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewEmployee.SelectedItems.Count == 1)
            {
                EmployeesSet employeeSet = listViewEmployee.SelectedItems[0].Tag as EmployeesSet;
                employeeSet.LastName = textBoxLastName.Text;
                employeeSet.FirstName = textBoxFirstName.Text;
                employeeSet.MiddleName = textBoxMiddleName.Text;
                Program.wftDb.SaveChanges();
                ShowEmployee();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewEmployee.SelectedItems.Count == 1)
                {
                    EmployeesSet employeeSet = listViewEmployee.SelectedItems[0].Tag as EmployeesSet;
                    Program.wftDb.EmployeesSet.Remove(employeeSet);
                    Program.wftDb.SaveChanges();
                    ShowEmployee();
                }
                textBoxLastName.Text = "";
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEmployee.SelectedItems.Count == 1)
            {
                EmployeesSet employeeSet = listViewEmployee.SelectedItems[0].Tag as EmployeesSet;
                textBoxLastName.Text = employeeSet.LastName;
                textBoxFirstName.Text = employeeSet.FirstName;
                textBoxMiddleName.Text = employeeSet.MiddleName;
            }
            else
            {
                textBoxLastName.Text = "";
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
            }
        }
    }
}
