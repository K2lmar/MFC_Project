namespace MFC_Project
{
    partial class FormReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelIdClient = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelIdNameService = new System.Windows.Forms.Label();
            this.labelIdConsultation = new System.Windows.Forms.Label();
            this.comboBoxIdClient = new System.Windows.Forms.ComboBox();
            this.comboBoxIdNameService = new System.Windows.Forms.ComboBox();
            this.comboBoxIdConsultation = new System.Windows.Forms.ComboBox();
            this.listViewReport = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIdClient
            // 
            this.labelIdClient.AutoSize = true;
            this.labelIdClient.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.labelIdClient.Location = new System.Drawing.Point(11, 234);
            this.labelIdClient.Name = "labelIdClient";
            this.labelIdClient.Size = new System.Drawing.Size(70, 20);
            this.labelIdClient.TabIndex = 0;
            this.labelIdClient.Text = "Клиент";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Tomato;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.buttonAdd.Location = new System.Drawing.Point(859, 171);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(138, 39);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Tomato;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.buttonEdit.Location = new System.Drawing.Point(859, 228);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(138, 39);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Tomato;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.buttonDel.Location = new System.Drawing.Point(859, 292);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(138, 39);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Bahnschrift", 10.2F);
            this.textBoxPrice.Location = new System.Drawing.Point(12, 321);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(216, 28);
            this.textBoxPrice.TabIndex = 5;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.labelPrice.Location = new System.Drawing.Point(11, 298);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(52, 20);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Цена";
            // 
            // labelIdNameService
            // 
            this.labelIdNameService.AutoSize = true;
            this.labelIdNameService.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.labelIdNameService.Location = new System.Drawing.Point(253, 234);
            this.labelIdNameService.Name = "labelIdNameService";
            this.labelIdNameService.Size = new System.Drawing.Size(150, 20);
            this.labelIdNameService.TabIndex = 7;
            this.labelIdNameService.Text = "Название услуги";
            // 
            // labelIdConsultation
            // 
            this.labelIdConsultation.AutoSize = true;
            this.labelIdConsultation.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.labelIdConsultation.Location = new System.Drawing.Point(500, 234);
            this.labelIdConsultation.Name = "labelIdConsultation";
            this.labelIdConsultation.Size = new System.Drawing.Size(127, 20);
            this.labelIdConsultation.TabIndex = 8;
            this.labelIdConsultation.Text = "Консультация";
            // 
            // comboBoxIdClient
            // 
            this.comboBoxIdClient.Font = new System.Drawing.Font("Bahnschrift", 10.2F);
            this.comboBoxIdClient.FormattingEnabled = true;
            this.comboBoxIdClient.Location = new System.Drawing.Point(12, 257);
            this.comboBoxIdClient.Name = "comboBoxIdClient";
            this.comboBoxIdClient.Size = new System.Drawing.Size(216, 29);
            this.comboBoxIdClient.TabIndex = 9;
            // 
            // comboBoxIdNameService
            // 
            this.comboBoxIdNameService.Font = new System.Drawing.Font("Bahnschrift", 10.2F);
            this.comboBoxIdNameService.FormattingEnabled = true;
            this.comboBoxIdNameService.Location = new System.Drawing.Point(257, 257);
            this.comboBoxIdNameService.Name = "comboBoxIdNameService";
            this.comboBoxIdNameService.Size = new System.Drawing.Size(216, 29);
            this.comboBoxIdNameService.TabIndex = 10;
            // 
            // comboBoxIdConsultation
            // 
            this.comboBoxIdConsultation.Font = new System.Drawing.Font("Bahnschrift", 10.2F);
            this.comboBoxIdConsultation.FormattingEnabled = true;
            this.comboBoxIdConsultation.Location = new System.Drawing.Point(504, 257);
            this.comboBoxIdConsultation.Name = "comboBoxIdConsultation";
            this.comboBoxIdConsultation.Size = new System.Drawing.Size(216, 29);
            this.comboBoxIdConsultation.TabIndex = 11;
            // 
            // listViewReport
            // 
            this.listViewReport.BackColor = System.Drawing.Color.Tomato;
            this.listViewReport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader9});
            this.listViewReport.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.listViewReport.FullRowSelect = true;
            this.listViewReport.GridLines = true;
            this.listViewReport.HideSelection = false;
            this.listViewReport.Location = new System.Drawing.Point(12, 12);
            this.listViewReport.MultiSelect = false;
            this.listViewReport.Name = "listViewReport";
            this.listViewReport.Size = new System.Drawing.Size(817, 209);
            this.listViewReport.TabIndex = 12;
            this.listViewReport.UseCompatibleStateImageBehavior = false;
            this.listViewReport.View = System.Windows.Forms.View.Details;
            this.listViewReport.SelectedIndexChanged += new System.EventHandler(this.listViewReport_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id отчета";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Id";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Клиент";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Название услуги";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id консультации";
            this.columnHeader6.Width = 160;
            // 
            // Logo
            // 
            this.Logo.Image = global::MFC_Project.Properties.Resources._798px_Мои_документы_Logo_svg;
            this.Logo.Location = new System.Drawing.Point(835, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(191, 147);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 4;
            this.Logo.TabStop = false;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Цена";
            this.columnHeader9.Width = 102;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1027, 357);
            this.Controls.Add(this.listViewReport);
            this.Controls.Add(this.comboBoxIdConsultation);
            this.Controls.Add(this.comboBoxIdNameService);
            this.Controls.Add(this.comboBoxIdClient);
            this.Controls.Add(this.labelIdConsultation);
            this.Controls.Add(this.labelIdNameService);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelIdClient);
            this.Name = "FormReport";
            this.Text = "FormReport";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIdClient;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelIdNameService;
        private System.Windows.Forms.Label labelIdConsultation;
        private System.Windows.Forms.ComboBox comboBoxIdClient;
        private System.Windows.Forms.ComboBox comboBoxIdNameService;
        private System.Windows.Forms.ComboBox comboBoxIdConsultation;
        private System.Windows.Forms.ListView listViewReport;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}