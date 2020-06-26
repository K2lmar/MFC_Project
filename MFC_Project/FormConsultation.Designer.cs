namespace MFC_Project
{
    partial class FormConsultation
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
            this.labelIdEmployee = new System.Windows.Forms.Label();
            this.labelDateAcceptance = new System.Windows.Forms.Label();
            this.textBoxDateAcceptance = new System.Windows.Forms.TextBox();
            this.comboBoxIdClient = new System.Windows.Forms.ComboBox();
            this.comboBoxIdEmployee = new System.Windows.Forms.ComboBox();
            this.listViewConsultation = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIdClient
            // 
            this.labelIdClient.AutoSize = true;
            this.labelIdClient.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.labelIdClient.Location = new System.Drawing.Point(8, 225);
            this.labelIdClient.Name = "labelIdClient";
            this.labelIdClient.Size = new System.Drawing.Size(70, 20);
            this.labelIdClient.TabIndex = 0;
            this.labelIdClient.Text = "Клиент";
            // 
            // labelIdEmployee
            // 
            this.labelIdEmployee.AutoSize = true;
            this.labelIdEmployee.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.labelIdEmployee.Location = new System.Drawing.Point(231, 225);
            this.labelIdEmployee.Name = "labelIdEmployee";
            this.labelIdEmployee.Size = new System.Drawing.Size(100, 20);
            this.labelIdEmployee.TabIndex = 1;
            this.labelIdEmployee.Text = "Сотрудник";
            // 
            // labelDateAcceptance
            // 
            this.labelDateAcceptance.AutoSize = true;
            this.labelDateAcceptance.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.labelDateAcceptance.Location = new System.Drawing.Point(455, 225);
            this.labelDateAcceptance.Name = "labelDateAcceptance";
            this.labelDateAcceptance.Size = new System.Drawing.Size(120, 20);
            this.labelDateAcceptance.TabIndex = 2;
            this.labelDateAcceptance.Text = "Дата приема";
            // 
            // textBoxDateAcceptance
            // 
            this.textBoxDateAcceptance.Font = new System.Drawing.Font("Bahnschrift", 10.2F);
            this.textBoxDateAcceptance.Location = new System.Drawing.Point(459, 248);
            this.textBoxDateAcceptance.Name = "textBoxDateAcceptance";
            this.textBoxDateAcceptance.Size = new System.Drawing.Size(216, 28);
            this.textBoxDateAcceptance.TabIndex = 4;
            // 
            // comboBoxIdClient
            // 
            this.comboBoxIdClient.Font = new System.Drawing.Font("Bahnschrift", 10.2F);
            this.comboBoxIdClient.FormattingEnabled = true;
            this.comboBoxIdClient.Location = new System.Drawing.Point(12, 248);
            this.comboBoxIdClient.Name = "comboBoxIdClient";
            this.comboBoxIdClient.Size = new System.Drawing.Size(216, 29);
            this.comboBoxIdClient.TabIndex = 5;
            // 
            // comboBoxIdEmployee
            // 
            this.comboBoxIdEmployee.Font = new System.Drawing.Font("Bahnschrift", 10.2F);
            this.comboBoxIdEmployee.FormattingEnabled = true;
            this.comboBoxIdEmployee.Location = new System.Drawing.Point(235, 248);
            this.comboBoxIdEmployee.Name = "comboBoxIdEmployee";
            this.comboBoxIdEmployee.Size = new System.Drawing.Size(216, 29);
            this.comboBoxIdEmployee.TabIndex = 6;
            // 
            // listViewConsultation
            // 
            this.listViewConsultation.BackColor = System.Drawing.Color.Tomato;
            this.listViewConsultation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewConsultation.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.listViewConsultation.FullRowSelect = true;
            this.listViewConsultation.GridLines = true;
            this.listViewConsultation.HideSelection = false;
            this.listViewConsultation.Location = new System.Drawing.Point(12, 12);
            this.listViewConsultation.MultiSelect = false;
            this.listViewConsultation.Name = "listViewConsultation";
            this.listViewConsultation.Size = new System.Drawing.Size(663, 204);
            this.listViewConsultation.TabIndex = 7;
            this.listViewConsultation.UseCompatibleStateImageBehavior = false;
            this.listViewConsultation.View = System.Windows.Forms.View.Details;
            this.listViewConsultation.SelectedIndexChanged += new System.EventHandler(this.listViewConsultation_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id консультации";
            this.columnHeader1.Width = 122;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Id";
            this.columnHeader2.Width = 45;
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
            this.columnHeader5.Text = "Сотрудник";
            this.columnHeader5.Width = 94;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Дата приема";
            this.columnHeader6.Width = 107;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Tomato;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.buttonAdd.Location = new System.Drawing.Point(712, 144);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(138, 39);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Tomato;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.buttonEdit.Location = new System.Drawing.Point(712, 206);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(138, 39);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Tomato;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.buttonDel.Location = new System.Drawing.Point(712, 267);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(138, 39);
            this.buttonDel.TabIndex = 10;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::MFC_Project.Properties.Resources._798px_Мои_документы_Logo_svg;
            this.Logo.Location = new System.Drawing.Point(681, 1);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(188, 129);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // FormConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(870, 314);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewConsultation);
            this.Controls.Add(this.comboBoxIdEmployee);
            this.Controls.Add(this.comboBoxIdClient);
            this.Controls.Add(this.textBoxDateAcceptance);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.labelDateAcceptance);
            this.Controls.Add(this.labelIdEmployee);
            this.Controls.Add(this.labelIdClient);
            this.Name = "FormConsultation";
            this.Text = "Консультация";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIdClient;
        private System.Windows.Forms.Label labelIdEmployee;
        private System.Windows.Forms.Label labelDateAcceptance;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TextBox textBoxDateAcceptance;
        private System.Windows.Forms.ComboBox comboBoxIdClient;
        private System.Windows.Forms.ComboBox comboBoxIdEmployee;
        private System.Windows.Forms.ListView listViewConsultation;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
    }
}