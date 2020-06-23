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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
            ShowClient();
            ShowAvailableService();
            ShowConsultation();
            ShowReport();
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
        void ShowAvailableService()
        {
            comboBoxIdNameService.Items.Clear();
            foreach (AvailableServicesSet availableServiceSet in Program.wftDb.AvailableServicesSet)
            {
                string[] item = {availableServiceSet.Id.ToString() + ".",
                    availableServiceSet.NameService.ToString(),
                    availableServiceSet.CategoryService,
                    availableServiceSet.TypeService,
                    availableServiceSet.Price.ToString()
                };
                comboBoxIdNameService.Items.Add(string.Join("", item));
            }
        }
        void ShowConsultation()
        {
            comboBoxIdConsultation.Items.Clear();
            foreach (ConsultationsSet consultationSet in Program.wftDb.ConsultationsSet)
            {
                string[] item = {consultationSet.Id.ToString() + ".",
                    consultationSet.IdClient.ToString(),
                    consultationSet.ClientsSet.LastName+" "+consultationSet.ClientsSet.FirstName+" "+consultationSet.ClientsSet.MiddleName,
                    consultationSet.IdEmployee.ToString() + ".",
                    consultationSet.EmployeesSet.LastName+" "+consultationSet.ClientsSet.FirstName+" "+consultationSet.ClientsSet.MiddleName };
                comboBoxIdConsultation.Items.Add(string.Join("", item));
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxIdClient.SelectedItem != null && comboBoxIdNameService.SelectedItem != null)
            {
                ReportsSet reportSet = new ReportsSet();
                reportSet.IdClient = Convert.ToInt32(comboBoxIdClient.SelectedItem.ToString().Split('.')[0]);
                reportSet.IdNameService = Convert.ToInt32(comboBoxIdNameService.SelectedItem.ToString().Split('.')[0]);
                reportSet.IdConsultation = Convert.ToInt32(comboBoxIdConsultation.SelectedItem.ToString().Split('.')[0]);
                reportSet.Price = Convert.ToInt32(textBoxPrice.Text);
                Program.wftDb.ReportsSet.Add(reportSet);
                Program.wftDb.SaveChanges();
                ShowReport();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowReport()
        {
            listViewReport.Items.Clear();
            foreach (ReportsSet reportSet in Program.wftDb.ReportsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    reportSet.Id.ToString() + ".",
                    reportSet.IdClient.ToString(),
                    reportSet.ClientsSet.LastName+" "+reportSet.ClientsSet.FirstName+" "+reportSet.ClientsSet.MiddleName,
                    reportSet.IdNameService.ToString() + ".",
                    reportSet.AvailableServicesSet.NameService+" "+reportSet.AvailableServicesSet.CategoryService+" "+reportSet.AvailableServicesSet.TypeService+" "+reportSet.AvailableServicesSet.Price,
                    reportSet.IdConsultation.ToString(),
                    reportSet.Price.ToString()
                });
                item.Tag = reportSet;
                listViewReport.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewReport.SelectedItems.Count == 1)
            {
                ReportsSet reportSet = listViewReport.SelectedItems[0].Tag as ReportsSet;
                reportSet.IdClient = Convert.ToInt32(comboBoxIdClient.SelectedItem.ToString().Split('.')[0]);
                reportSet.IdNameService = Convert.ToInt32(comboBoxIdNameService.SelectedItem.ToString().Split('.')[0]);
                reportSet.IdConsultation = Convert.ToInt32(comboBoxIdConsultation.SelectedItem.ToString().Split('.')[0]);
                reportSet.Price = Convert.ToInt32(textBoxPrice.Text);
                Program.wftDb.SaveChanges();
                ShowReport();
            }
        }

        private void listViewReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewReport.SelectedItems.Count == 1)
            {
                ReportsSet reportSett = listViewReport.SelectedItems[0].Tag as ReportsSet;
                comboBoxIdClient.SelectedIndex = comboBoxIdClient.FindString(reportSett.IdClient.ToString());
                comboBoxIdNameService.SelectedIndex = comboBoxIdNameService.FindString(reportSett.IdNameService.ToString());
                comboBoxIdConsultation.SelectedIndex = comboBoxIdConsultation.FindString(reportSett.IdConsultation.ToString());
                textBoxPrice.Text = reportSett.Price.ToString();
            }
            else
            {
                comboBoxIdClient.SelectedItem = null;
                comboBoxIdNameService.SelectedItem = null;
                comboBoxIdConsultation.SelectedItem = null;
                textBoxPrice.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewReport.SelectedItems.Count == 1)
                {
                    ReportsSet reportSett = listViewReport.SelectedItems[0].Tag as ReportsSet;
                    Program.wftDb.ReportsSet.Remove(reportSett);
                    Program.wftDb.SaveChanges();
                    ShowReport();
                }
                comboBoxIdClient.SelectedItem = null;
                comboBoxIdNameService.SelectedItem = null;
                comboBoxIdConsultation.SelectedItem = null;
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
