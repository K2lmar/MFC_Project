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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (FormAuthorization.users.type == "client")
            {
                buttonOpenEmployees.Enabled = false;
                buttonOpenAvailableServices.Enabled = false;
                buttonOpenReports.Enabled = false;
            }
            labelHello.Text = "Добро пожаловать, " + FormAuthorization.users.login;
        }

        private void buttonOpenClients_Click(object sender, EventArgs e)
        {
            Form formClient = new FormClient();
            formClient.Show();
        }

        private void buttonOpenEmployees_Click(object sender, EventArgs e)
        {
            Form formEmployee = new FormEmployee();
            formEmployee.Show();
        }

        private void buttonOpenConsultations_Click(object sender, EventArgs e)
        {
            Form formConsultation = new FormConsultation();
            formConsultation.Show();
        }

        private void buttonOpenAvailableServices_Click(object sender, EventArgs e)
        {
            Form formAvailableService = new FormAvailableService();
            formAvailableService.Show();
        }

        private void buttonOpenServices_Click(object sender, EventArgs e)
        {
            Form formService = new FormService();
            formService.Show();
        }

        private void buttonOpenReports_Click(object sender, EventArgs e)
        {
            Form formReport = new FormReport();
            formReport.Show();
        }

        private void labelHello_Click(object sender, EventArgs e)
        {

        }
    }
}
