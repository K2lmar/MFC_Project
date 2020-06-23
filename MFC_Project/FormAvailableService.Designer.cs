namespace MFC_Project
{
    partial class FormAvailableService
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
            this.labelNameService = new System.Windows.Forms.Label();
            this.labelCategoryService = new System.Windows.Forms.Label();
            this.labelTypeService = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxNameService = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.listViewAvailableService = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxTypeService = new System.Windows.Forms.ComboBox();
            this.comboBoxCategoryService = new System.Windows.Forms.ComboBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameService
            // 
            this.labelNameService.AutoSize = true;
            this.labelNameService.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.labelNameService.Location = new System.Drawing.Point(12, 228);
            this.labelNameService.Name = "labelNameService";
            this.labelNameService.Size = new System.Drawing.Size(150, 20);
            this.labelNameService.TabIndex = 1;
            this.labelNameService.Text = "Название услуги";
            // 
            // labelCategoryService
            // 
            this.labelCategoryService.AutoSize = true;
            this.labelCategoryService.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.labelCategoryService.Location = new System.Drawing.Point(237, 228);
            this.labelCategoryService.Name = "labelCategoryService";
            this.labelCategoryService.Size = new System.Drawing.Size(157, 20);
            this.labelCategoryService.TabIndex = 2;
            this.labelCategoryService.Text = "Категория услуги";
            // 
            // labelTypeService
            // 
            this.labelTypeService.AutoSize = true;
            this.labelTypeService.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.labelTypeService.Location = new System.Drawing.Point(462, 228);
            this.labelTypeService.Name = "labelTypeService";
            this.labelTypeService.Size = new System.Drawing.Size(98, 20);
            this.labelTypeService.TabIndex = 3;
            this.labelTypeService.Text = "Тип услуги";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.labelPrice.Location = new System.Drawing.Point(12, 294);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(52, 20);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Цена";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Tomato;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.buttonAdd.Location = new System.Drawing.Point(707, 156);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(138, 39);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Tomato;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.buttonEdit.Location = new System.Drawing.Point(707, 221);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(138, 39);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Tomato;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.buttonDel.Location = new System.Drawing.Point(707, 285);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(138, 39);
            this.buttonDel.TabIndex = 7;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxNameService
            // 
            this.textBoxNameService.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameService.Location = new System.Drawing.Point(16, 261);
            this.textBoxNameService.Name = "textBoxNameService";
            this.textBoxNameService.Size = new System.Drawing.Size(216, 28);
            this.textBoxNameService.TabIndex = 8;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Bahnschrift", 10.2F);
            this.textBoxPrice.Location = new System.Drawing.Point(16, 326);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(216, 28);
            this.textBoxPrice.TabIndex = 11;
            // 
            // listViewAvailableService
            // 
            this.listViewAvailableService.BackColor = System.Drawing.Color.Tomato;
            this.listViewAvailableService.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewAvailableService.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.listViewAvailableService.FullRowSelect = true;
            this.listViewAvailableService.GridLines = true;
            this.listViewAvailableService.HideSelection = false;
            this.listViewAvailableService.Location = new System.Drawing.Point(12, 12);
            this.listViewAvailableService.MultiSelect = false;
            this.listViewAvailableService.Name = "listViewAvailableService";
            this.listViewAvailableService.Size = new System.Drawing.Size(665, 204);
            this.listViewAvailableService.TabIndex = 12;
            this.listViewAvailableService.UseCompatibleStateImageBehavior = false;
            this.listViewAvailableService.View = System.Windows.Forms.View.Details;
            this.listViewAvailableService.SelectedIndexChanged += new System.EventHandler(this.listViewAvailableService_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 49;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название услуги";
            this.columnHeader2.Width = 135;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Категория услуги";
            this.columnHeader3.Width = 138;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Тип услуги";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Цена";
            // 
            // comboBoxTypeService
            // 
            this.comboBoxTypeService.Font = new System.Drawing.Font("Bahnschrift", 10.2F);
            this.comboBoxTypeService.FormattingEnabled = true;
            this.comboBoxTypeService.Items.AddRange(new object[] {
            "Бесплатная",
            "Платная"});
            this.comboBoxTypeService.Location = new System.Drawing.Point(466, 260);
            this.comboBoxTypeService.Name = "comboBoxTypeService";
            this.comboBoxTypeService.Size = new System.Drawing.Size(216, 29);
            this.comboBoxTypeService.TabIndex = 13;
            // 
            // comboBoxCategoryService
            // 
            this.comboBoxCategoryService.Font = new System.Drawing.Font("Bahnschrift", 10.2F);
            this.comboBoxCategoryService.FormattingEnabled = true;
            this.comboBoxCategoryService.Items.AddRange(new object[] {
            "Налоги и финансы",
            "Семья и дети",
            "Паспорта, регистрации, визы",
            "Транспорт и вождение",
            "Образование",
            "Лицензии, справки, аккредитации",
            "Квартира, строительство и земля"});
            this.comboBoxCategoryService.Location = new System.Drawing.Point(241, 260);
            this.comboBoxCategoryService.Name = "comboBoxCategoryService";
            this.comboBoxCategoryService.Size = new System.Drawing.Size(216, 29);
            this.comboBoxCategoryService.TabIndex = 14;
            // 
            // Logo
            // 
            this.Logo.Image = global::MFC_Project.Properties.Resources._798px_Мои_документы_Logo_svg;
            this.Logo.Location = new System.Drawing.Point(683, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(182, 136);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // FormAvailableService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(867, 361);
            this.Controls.Add(this.comboBoxCategoryService);
            this.Controls.Add(this.comboBoxTypeService);
            this.Controls.Add(this.listViewAvailableService);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxNameService);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelTypeService);
            this.Controls.Add(this.labelCategoryService);
            this.Controls.Add(this.labelNameService);
            this.Controls.Add(this.Logo);
            this.Name = "FormAvailableService";
            this.Text = "FormAvailableService";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label labelNameService;
        private System.Windows.Forms.Label labelCategoryService;
        private System.Windows.Forms.Label labelTypeService;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox textBoxNameService;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ListView listViewAvailableService;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox comboBoxTypeService;
        private System.Windows.Forms.ComboBox comboBoxCategoryService;
    }
}