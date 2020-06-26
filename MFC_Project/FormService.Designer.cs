namespace MFC_Project
{
    partial class FormService
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
            this.labelIdNameService = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.comboBoxIdClient = new System.Windows.Forms.ComboBox();
            this.comboBoxIdNameService = new System.Windows.Forms.ComboBox();
            this.listViewService = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIdClient
            // 
            this.labelIdClient.AutoSize = true;
            this.labelIdClient.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.labelIdClient.Location = new System.Drawing.Point(12, 229);
            this.labelIdClient.Name = "labelIdClient";
            this.labelIdClient.Size = new System.Drawing.Size(70, 20);
            this.labelIdClient.TabIndex = 0;
            this.labelIdClient.Text = "Клиент";
            // 
            // labelIdNameService
            // 
            this.labelIdNameService.AutoSize = true;
            this.labelIdNameService.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.labelIdNameService.Location = new System.Drawing.Point(251, 229);
            this.labelIdNameService.Name = "labelIdNameService";
            this.labelIdNameService.Size = new System.Drawing.Size(150, 20);
            this.labelIdNameService.TabIndex = 1;
            this.labelIdNameService.Text = "Название услуги";
            this.labelIdNameService.Click += new System.EventHandler(this.labelIdNameService_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Tomato;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.buttonAdd.Location = new System.Drawing.Point(559, 143);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(138, 39);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Tomato;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.buttonEdit.Location = new System.Drawing.Point(559, 198);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(138, 39);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Tomato;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.buttonDel.Location = new System.Drawing.Point(559, 252);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(138, 39);
            this.buttonDel.TabIndex = 4;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // comboBoxIdClient
            // 
            this.comboBoxIdClient.Font = new System.Drawing.Font("Bahnschrift", 10.2F);
            this.comboBoxIdClient.FormattingEnabled = true;
            this.comboBoxIdClient.Location = new System.Drawing.Point(12, 252);
            this.comboBoxIdClient.Name = "comboBoxIdClient";
            this.comboBoxIdClient.Size = new System.Drawing.Size(216, 29);
            this.comboBoxIdClient.TabIndex = 5;
            // 
            // comboBoxIdNameService
            // 
            this.comboBoxIdNameService.Font = new System.Drawing.Font("Bahnschrift", 10.2F);
            this.comboBoxIdNameService.FormattingEnabled = true;
            this.comboBoxIdNameService.Location = new System.Drawing.Point(255, 252);
            this.comboBoxIdNameService.Name = "comboBoxIdNameService";
            this.comboBoxIdNameService.Size = new System.Drawing.Size(216, 29);
            this.comboBoxIdNameService.TabIndex = 6;
            // 
            // listViewService
            // 
            this.listViewService.BackColor = System.Drawing.Color.Tomato;
            this.listViewService.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewService.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F);
            this.listViewService.FullRowSelect = true;
            this.listViewService.GridLines = true;
            this.listViewService.HideSelection = false;
            this.listViewService.Location = new System.Drawing.Point(12, 12);
            this.listViewService.MultiSelect = false;
            this.listViewService.Name = "listViewService";
            this.listViewService.Size = new System.Drawing.Size(529, 204);
            this.listViewService.TabIndex = 8;
            this.listViewService.UseCompatibleStateImageBehavior = false;
            this.listViewService.View = System.Windows.Forms.View.Details;
            this.listViewService.SelectedIndexChanged += new System.EventHandler(this.listViewService_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id услуги";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Id";
            this.columnHeader2.Width = 52;
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
            this.columnHeader5.Width = 137;
            // 
            // Logo
            // 
            this.Logo.Image = global::MFC_Project.Properties.Resources._798px_Мои_документы_Logo_svg;
            this.Logo.Location = new System.Drawing.Point(547, 1);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(171, 127);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 7;
            this.Logo.TabStop = false;
            // 
            // FormService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(721, 303);
            this.Controls.Add(this.listViewService);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.comboBoxIdNameService);
            this.Controls.Add(this.comboBoxIdClient);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelIdNameService);
            this.Controls.Add(this.labelIdClient);
            this.Name = "FormService";
            this.Text = "Услуги";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIdClient;
        private System.Windows.Forms.Label labelIdNameService;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ComboBox comboBoxIdClient;
        private System.Windows.Forms.ComboBox comboBoxIdNameService;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.ListView listViewService;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}