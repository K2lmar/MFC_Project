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
    public partial class FormService : Form
    {
        public FormService()
        {
            InitializeComponent();
            ShowClient();
            ShowAvailableService();
            ShowService();
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
                  availableServiceSet.Price.ToString() };
                comboBoxIdNameService.Items.Add(string.Join("", item));
            }
        }

        private void labelIdNameService_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxIdClient.SelectedItem != null && comboBoxIdNameService.SelectedItem != null )
            {
                ServicesSet serviceSet = new ServicesSet();
                serviceSet.IdClient = Convert.ToInt32(comboBoxIdClient.SelectedItem.ToString().Split('.')[0]);
                serviceSet.IdNameService = Convert.ToInt32(comboBoxIdNameService.SelectedItem.ToString().Split('.')[0]);
                Program.wftDb.ServicesSet.Add(serviceSet);
                Program.wftDb.SaveChanges();
                ShowService();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowService()
        {
            listViewService.Items.Clear();
            foreach (ServicesSet serviceSet in Program.wftDb.ServicesSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    serviceSet.Id.ToString() + ".",
                    serviceSet.IdClient.ToString(),
                    serviceSet.ClientsSet.LastName+" "+serviceSet.ClientsSet.FirstName+" "+serviceSet.ClientsSet.MiddleName,
                    serviceSet.IdNameService.ToString() + ".",
                    serviceSet.AvailableServicesSet.NameService+" "+serviceSet.AvailableServicesSet.CategoryService+" "+serviceSet.AvailableServicesSet.TypeService+" "+serviceSet.AvailableServicesSet.Price
                });
                item.Tag = serviceSet;
                listViewService.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewService.SelectedItems.Count == 1)
            {
                ServicesSet serviceSet = listViewService.SelectedItems[0].Tag as ServicesSet;
                serviceSet.IdClient = Convert.ToInt32(comboBoxIdClient.SelectedItem.ToString().Split('.')[0]);
                serviceSet.IdNameService = Convert.ToInt32(comboBoxIdNameService.SelectedItem.ToString().Split('.')[0]);
                Program.wftDb.SaveChanges();
                ShowService();
            }
        }

        private void listViewService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewService.SelectedItems.Count == 1)
            {
                ServicesSet serviceSet = listViewService.SelectedItems[0].Tag as ServicesSet;
                comboBoxIdClient.SelectedIndex = comboBoxIdClient.FindString(serviceSet.IdClient.ToString());
                comboBoxIdNameService.SelectedIndex = comboBoxIdNameService.FindString(serviceSet.IdNameService.ToString());
            }
            else
            {
                comboBoxIdClient.SelectedItem = null;
                comboBoxIdNameService.SelectedItem = null;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewService.SelectedItems.Count == 1)
                {
                    ServicesSet serviceSet = listViewService.SelectedItems[0].Tag as ServicesSet;
                    Program.wftDb.ServicesSet.Remove(serviceSet);
                    Program.wftDb.SaveChanges();
                    ShowService();
                }
                comboBoxIdClient.SelectedItem = null;
                comboBoxIdNameService.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
