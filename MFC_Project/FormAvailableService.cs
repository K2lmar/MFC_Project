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
    public partial class FormAvailableService : Form
    {
        public FormAvailableService()
        {
            InitializeComponent();
            ShowAvailableService();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxNameService.Text != "" && comboBoxCategoryService.Text != null && comboBoxTypeService.Text != null && textBoxPrice.Text != "")
            {
                AvailableServicesSet availableServiceSet = new AvailableServicesSet();
                availableServiceSet.NameService = textBoxNameService.Text;
                availableServiceSet.CategoryService = comboBoxCategoryService.Text;
                availableServiceSet.TypeService = comboBoxTypeService.Text;
                availableServiceSet.Price = Convert.ToInt32(textBoxPrice.Text);
                Program.wftDb.AvailableServicesSet.Add(availableServiceSet);
                Program.wftDb.SaveChanges();
                ShowAvailableService();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowAvailableService()
        {
            listViewAvailableService.Items.Clear();
            foreach (AvailableServicesSet availableServiceSet in Program.wftDb.AvailableServicesSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    availableServiceSet.Id.ToString() + "",
                    availableServiceSet.NameService.ToString(),
                    availableServiceSet.CategoryService.ToString(),
                    availableServiceSet.TypeService.ToString(),
                    availableServiceSet.Price.ToString()
                });
                item.Tag = availableServiceSet;
                listViewAvailableService.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAvailableService.SelectedItems.Count == 1)
            {
                AvailableServicesSet availableServiceSet = listViewAvailableService.SelectedItems[0].Tag as AvailableServicesSet;
                availableServiceSet.NameService = textBoxNameService.Text;
                availableServiceSet.CategoryService = comboBoxCategoryService.Text;
                availableServiceSet.TypeService = comboBoxTypeService.Text;
                availableServiceSet.Price = Convert.ToInt32(textBoxPrice.Text);
                Program.wftDb.SaveChanges();
                ShowAvailableService();
            }
        }

        private void listViewAvailableService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAvailableService.SelectedItems.Count == 1)
            {
                AvailableServicesSet availableServiceSet = listViewAvailableService.SelectedItems[0].Tag as AvailableServicesSet;
                textBoxNameService.Text = availableServiceSet.NameService.ToString();
                comboBoxCategoryService.Text = availableServiceSet.CategoryService.ToString();
                comboBoxTypeService.Text = availableServiceSet.TypeService.ToString();
                textBoxPrice.Text = availableServiceSet.Price.ToString();
            }
            else
            {
                textBoxNameService.Text = "";
                comboBoxCategoryService.Text = null;
                comboBoxTypeService.Text = null;
                textBoxPrice.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAvailableService.SelectedItems.Count == 1)
                {
                    AvailableServicesSet availableServiceSet = listViewAvailableService.SelectedItems[0].Tag as AvailableServicesSet;
                    Program.wftDb.AvailableServicesSet.Remove(availableServiceSet);
                    Program.wftDb.SaveChanges();
                    ShowAvailableService();
                }
                textBoxNameService.Text = "";
                comboBoxCategoryService.Text = null;
                comboBoxTypeService.Text = null;
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
