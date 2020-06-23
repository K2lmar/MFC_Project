namespace MFC_Project
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenClients = new System.Windows.Forms.Button();
            this.buttonOpenEmployees = new System.Windows.Forms.Button();
            this.buttonOpenConsultations = new System.Windows.Forms.Button();
            this.buttonOpenAvailableServices = new System.Windows.Forms.Button();
            this.buttonOpenServices = new System.Windows.Forms.Button();
            this.buttonOpenReports = new System.Windows.Forms.Button();
            this.labelHello = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenClients
            // 
            this.buttonOpenClients.BackColor = System.Drawing.Color.Tomato;
            this.buttonOpenClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenClients.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenClients.Location = new System.Drawing.Point(12, 90);
            this.buttonOpenClients.Name = "buttonOpenClients";
            this.buttonOpenClients.Size = new System.Drawing.Size(176, 50);
            this.buttonOpenClients.TabIndex = 1;
            this.buttonOpenClients.Text = "Клиент";
            this.buttonOpenClients.UseVisualStyleBackColor = false;
            this.buttonOpenClients.Click += new System.EventHandler(this.buttonOpenClients_Click);
            // 
            // buttonOpenEmployees
            // 
            this.buttonOpenEmployees.BackColor = System.Drawing.Color.Tomato;
            this.buttonOpenEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenEmployees.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenEmployees.Location = new System.Drawing.Point(208, 147);
            this.buttonOpenEmployees.Name = "buttonOpenEmployees";
            this.buttonOpenEmployees.Size = new System.Drawing.Size(176, 50);
            this.buttonOpenEmployees.TabIndex = 2;
            this.buttonOpenEmployees.Text = "Сотрудник";
            this.buttonOpenEmployees.UseVisualStyleBackColor = false;
            this.buttonOpenEmployees.Click += new System.EventHandler(this.buttonOpenEmployees_Click);
            // 
            // buttonOpenConsultations
            // 
            this.buttonOpenConsultations.BackColor = System.Drawing.Color.Tomato;
            this.buttonOpenConsultations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenConsultations.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenConsultations.Location = new System.Drawing.Point(12, 203);
            this.buttonOpenConsultations.Name = "buttonOpenConsultations";
            this.buttonOpenConsultations.Size = new System.Drawing.Size(176, 50);
            this.buttonOpenConsultations.TabIndex = 3;
            this.buttonOpenConsultations.Text = "Консультация";
            this.buttonOpenConsultations.UseVisualStyleBackColor = false;
            this.buttonOpenConsultations.Click += new System.EventHandler(this.buttonOpenConsultations_Click);
            // 
            // buttonOpenAvailableServices
            // 
            this.buttonOpenAvailableServices.BackColor = System.Drawing.Color.Tomato;
            this.buttonOpenAvailableServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenAvailableServices.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenAvailableServices.Location = new System.Drawing.Point(208, 203);
            this.buttonOpenAvailableServices.Name = "buttonOpenAvailableServices";
            this.buttonOpenAvailableServices.Size = new System.Drawing.Size(176, 50);
            this.buttonOpenAvailableServices.TabIndex = 4;
            this.buttonOpenAvailableServices.Text = "Доступные услуги";
            this.buttonOpenAvailableServices.UseVisualStyleBackColor = false;
            this.buttonOpenAvailableServices.Click += new System.EventHandler(this.buttonOpenAvailableServices_Click);
            // 
            // buttonOpenServices
            // 
            this.buttonOpenServices.BackColor = System.Drawing.Color.Tomato;
            this.buttonOpenServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenServices.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenServices.Location = new System.Drawing.Point(12, 147);
            this.buttonOpenServices.Name = "buttonOpenServices";
            this.buttonOpenServices.Size = new System.Drawing.Size(176, 50);
            this.buttonOpenServices.TabIndex = 5;
            this.buttonOpenServices.Text = "Услуги";
            this.buttonOpenServices.UseVisualStyleBackColor = false;
            this.buttonOpenServices.Click += new System.EventHandler(this.buttonOpenServices_Click);
            // 
            // buttonOpenReports
            // 
            this.buttonOpenReports.BackColor = System.Drawing.Color.Tomato;
            this.buttonOpenReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenReports.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenReports.Location = new System.Drawing.Point(113, 259);
            this.buttonOpenReports.Name = "buttonOpenReports";
            this.buttonOpenReports.Size = new System.Drawing.Size(176, 50);
            this.buttonOpenReports.TabIndex = 6;
            this.buttonOpenReports.Text = "Отчет";
            this.buttonOpenReports.UseVisualStyleBackColor = false;
            this.buttonOpenReports.Click += new System.EventHandler(this.buttonOpenReports_Click);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.labelHello.Location = new System.Drawing.Point(12, 31);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(72, 20);
            this.labelHello.TabIndex = 7;
            this.labelHello.Text = "Привет";
            this.labelHello.Click += new System.EventHandler(this.labelHello_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::MFC_Project.Properties.Resources._798px_Мои_документы_Logo_svg;
            this.Logo.Location = new System.Drawing.Point(194, -1);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(206, 141);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(400, 316);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.buttonOpenReports);
            this.Controls.Add(this.buttonOpenServices);
            this.Controls.Add(this.buttonOpenAvailableServices);
            this.Controls.Add(this.buttonOpenConsultations);
            this.Controls.Add(this.buttonOpenEmployees);
            this.Controls.Add(this.buttonOpenClients);
            this.Controls.Add(this.Logo);
            this.Name = "Menu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button buttonOpenClients;
        private System.Windows.Forms.Button buttonOpenEmployees;
        private System.Windows.Forms.Button buttonOpenConsultations;
        private System.Windows.Forms.Button buttonOpenAvailableServices;
        private System.Windows.Forms.Button buttonOpenServices;
        private System.Windows.Forms.Button buttonOpenReports;
        private System.Windows.Forms.Label labelHello;
    }
}

