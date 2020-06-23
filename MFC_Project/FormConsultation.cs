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
    public partial class FormConsultation : Form
    {
        public FormConsultation()
        {
            InitializeComponent();
            ShowClient();
            ShowEmployee();
            ShowConsultation();
        }

        void ShowClient()
        {
            comboBoxIdClient.Items.Clear();
            foreach (ClientsSet clientSet in Program.wftDb.ClientsSet)
            {
                string[] item = {clientSet.Id.ToString() + ".", clientSet.LastName, clientSet.FirstName,
                                 clientSet.MiddleName, clientSet.Phone };
                comboBoxIdClient.Items.Add(string.Join("", item));
            }
        }
        void ShowEmployee()
        {
            comboBoxIdEmployee.Items.Clear();
            foreach (EmployeesSet employeeSet in Program.wftDb.EmployeesSet)
            {
                string[] item = {employeeSet.Id.ToString() + ".", employeeSet.LastName, employeeSet.FirstName,
                                 employeeSet.MiddleName};
                comboBoxIdEmployee.Items.Add(string.Join("", item));
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxIdClient.SelectedItem != null && comboBoxIdEmployee.SelectedItem != null && textBoxDateAcceptance.Text != "" )
            {
                ConsultationsSet consultationSet = new ConsultationsSet();
                consultationSet.IdClient = Convert.ToInt32(comboBoxIdClient.SelectedItem.ToString().Split('.')[0]);
                consultationSet.IdEmployee = Convert.ToInt32(comboBoxIdEmployee.SelectedItem.ToString().Split('.')[0]);
                consultationSet.DateAcceptance = textBoxDateAcceptance.Text;
                Program.wftDb.ConsultationsSet.Add(consultationSet);
                Program.wftDb.SaveChanges();
                ShowConsultation();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowConsultation()
        {
            listViewConsultation.Items.Clear();
            foreach (ConsultationsSet consultationSet in Program.wftDb.ConsultationsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    consultationSet.Id.ToString() + ".",
                    consultationSet.IdClient.ToString(),
                    consultationSet.ClientsSet.LastName+" "+consultationSet.ClientsSet.FirstName+" "+consultationSet.ClientsSet.MiddleName,
                    consultationSet.IdEmployee.ToString() + ".",
                    consultationSet.EmployeesSet.LastName+" "+consultationSet.ClientsSet.FirstName+" "+consultationSet.ClientsSet.MiddleName,
                    consultationSet.DateAcceptance.ToString()
                });
                item.Tag = consultationSet;
                listViewConsultation.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewConsultation.SelectedItems.Count == 1)
            {
                ConsultationsSet consultationSet = listViewConsultation.SelectedItems[0].Tag as ConsultationsSet;
                consultationSet.IdClient = Convert.ToInt32(comboBoxIdClient.SelectedItem.ToString().Split('.')[0]);
                consultationSet.IdEmployee = Convert.ToInt32(comboBoxIdEmployee.SelectedItem.ToString().Split('.')[0]);
                consultationSet.DateAcceptance = textBoxDateAcceptance.Text;
                Program.wftDb.SaveChanges();
                ShowConsultation();
            }
        }

        private void listViewConsultation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewConsultation.SelectedItems.Count == 1)
            {
                ConsultationsSet consultationSet = listViewConsultation.SelectedItems[0].Tag as ConsultationsSet;
                comboBoxIdClient.SelectedIndex = comboBoxIdClient.FindString(consultationSet.IdClient.ToString());
                comboBoxIdEmployee.SelectedIndex = comboBoxIdEmployee.FindString(consultationSet.IdEmployee.ToString());
                textBoxDateAcceptance.Text = consultationSet.DateAcceptance.ToString();
            }
            else
            {
                comboBoxIdClient.SelectedItem = null;
                comboBoxIdEmployee.SelectedItem = null;
                textBoxDateAcceptance.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewConsultation.SelectedItems.Count == 1)
                {
                    ConsultationsSet consultationSet = listViewConsultation.SelectedItems[0].Tag as ConsultationsSet;
                    Program.wftDb.ConsultationsSet.Remove(consultationSet);
                    Program.wftDb.SaveChanges();
                    ShowConsultation();
                }
                comboBoxIdClient.SelectedItem = null;
                comboBoxIdEmployee.SelectedItem = null;
                textBoxDateAcceptance.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
