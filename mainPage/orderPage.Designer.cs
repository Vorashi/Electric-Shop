namespace mainPage
{
    partial class orderPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMainPage = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnClear = new Guna.UI2.WinForms.Guna2ImageButton();
            this.gbxEventsData = new Guna.UI2.WinForms.Guna2GroupBox();
            this.pnlProductEvent = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnOrderSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrderDraft = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrderDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnProductWatch = new Guna.UI2.WinForms.Guna2Button();
            this.gbxProductData = new Guna.UI2.WinForms.Guna2GroupBox();
            this.pnlProductInfo = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.tbxLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxCategory = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxId = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxBrand = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnReboot = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            this.tbxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlTopWindow = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCloseForm = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pbxIconShop = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlMainPage.SuspendLayout();
            this.gbxEventsData.SuspendLayout();
            this.pnlProductEvent.SuspendLayout();
            this.gbxProductData.SuspendLayout();
            this.pnlProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.pnlTopWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconShop)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainPage
            // 
            this.pnlMainPage.BackColor = System.Drawing.Color.Transparent;
            this.pnlMainPage.Controls.Add(this.btnClear);
            this.pnlMainPage.Controls.Add(this.gbxEventsData);
            this.pnlMainPage.Controls.Add(this.gbxProductData);
            this.pnlMainPage.Controls.Add(this.lblTitle);
            this.pnlMainPage.Controls.Add(this.btnReboot);
            this.pnlMainPage.Controls.Add(this.btnSearch);
            this.pnlMainPage.Controls.Add(this.tbxSearch);
            this.pnlMainPage.Controls.Add(this.dataGridView);
            this.pnlMainPage.Controls.Add(this.pnlTopWindow);
            this.pnlMainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainPage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(75)))), ((int)(((byte)(78)))));
            this.pnlMainPage.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(52)))), ((int)(((byte)(104)))));
            this.pnlMainPage.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(49)))), ((int)(((byte)(113)))));
            this.pnlMainPage.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(47)))), ((int)(((byte)(102)))));
            this.pnlMainPage.Location = new System.Drawing.Point(0, 0);
            this.pnlMainPage.Name = "pnlMainPage";
            this.pnlMainPage.Size = new System.Drawing.Size(1184, 788);
            this.pnlMainPage.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClear.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnClear.Image = global::mainPage.Properties.Resources.eraser_icon_173850;
            this.btnClear.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClear.ImageRotate = 0F;
            this.btnClear.ImageSize = new System.Drawing.Size(32, 32);
            this.btnClear.Location = new System.Drawing.Point(284, 115);
            this.btnClear.Name = "btnClear";
            this.btnClear.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnClear.Size = new System.Drawing.Size(40, 40);
            this.btnClear.TabIndex = 6;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbxEventsData
            // 
            this.gbxEventsData.BackColor = System.Drawing.Color.Transparent;
            this.gbxEventsData.Controls.Add(this.pnlProductEvent);
            this.gbxEventsData.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbxEventsData.FillColor = System.Drawing.Color.Transparent;
            this.gbxEventsData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbxEventsData.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbxEventsData.Location = new System.Drawing.Point(835, 464);
            this.gbxEventsData.Name = "gbxEventsData";
            this.gbxEventsData.Size = new System.Drawing.Size(315, 252);
            this.gbxEventsData.TabIndex = 14;
            this.gbxEventsData.Text = "Действия с Данными";
            this.gbxEventsData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlProductEvent
            // 
            this.pnlProductEvent.Controls.Add(this.btnOrderSave);
            this.pnlProductEvent.Controls.Add(this.btnOrderDraft);
            this.pnlProductEvent.Controls.Add(this.btnOrderDelete);
            this.pnlProductEvent.Controls.Add(this.btnProductWatch);
            this.pnlProductEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductEvent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(75)))), ((int)(((byte)(78)))));
            this.pnlProductEvent.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(52)))), ((int)(((byte)(104)))));
            this.pnlProductEvent.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(49)))), ((int)(((byte)(113)))));
            this.pnlProductEvent.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(47)))), ((int)(((byte)(102)))));
            this.pnlProductEvent.Location = new System.Drawing.Point(0, 40);
            this.pnlProductEvent.Name = "pnlProductEvent";
            this.pnlProductEvent.Size = new System.Drawing.Size(315, 212);
            this.pnlProductEvent.TabIndex = 12;
            // 
            // btnOrderSave
            // 
            this.btnOrderSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrderSave.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderSave.BorderRadius = 15;
            this.btnOrderSave.BorderThickness = 1;
            this.btnOrderSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrderSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrderSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrderSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrderSave.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnOrderSave.FocusedColor = System.Drawing.Color.Aqua;
            this.btnOrderSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOrderSave.ForeColor = System.Drawing.Color.Black;
            this.btnOrderSave.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.btnOrderSave.Location = new System.Drawing.Point(50, 153);
            this.btnOrderSave.Name = "btnOrderSave";
            this.btnOrderSave.PressedColor = System.Drawing.Color.Aqua;
            this.btnOrderSave.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnOrderSave.Size = new System.Drawing.Size(214, 41);
            this.btnOrderSave.TabIndex = 19;
            this.btnOrderSave.Text = "Сохранить Заказ";
            this.btnOrderSave.Click += new System.EventHandler(this.btnOrderSave_Click);
            // 
            // btnOrderDraft
            // 
            this.btnOrderDraft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrderDraft.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderDraft.BorderRadius = 15;
            this.btnOrderDraft.BorderThickness = 1;
            this.btnOrderDraft.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrderDraft.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrderDraft.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrderDraft.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrderDraft.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnOrderDraft.FocusedColor = System.Drawing.Color.Aqua;
            this.btnOrderDraft.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOrderDraft.ForeColor = System.Drawing.Color.Black;
            this.btnOrderDraft.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.btnOrderDraft.Location = new System.Drawing.Point(50, 105);
            this.btnOrderDraft.Name = "btnOrderDraft";
            this.btnOrderDraft.PressedColor = System.Drawing.Color.Aqua;
            this.btnOrderDraft.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnOrderDraft.Size = new System.Drawing.Size(214, 41);
            this.btnOrderDraft.TabIndex = 18;
            this.btnOrderDraft.Text = "Изменить Заказ";
            this.btnOrderDraft.Click += new System.EventHandler(this.btnOrderDraft_Click);
            // 
            // btnOrderDelete
            // 
            this.btnOrderDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrderDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderDelete.BorderRadius = 15;
            this.btnOrderDelete.BorderThickness = 1;
            this.btnOrderDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrderDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrderDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrderDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrderDelete.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnOrderDelete.FocusedColor = System.Drawing.Color.Aqua;
            this.btnOrderDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOrderDelete.ForeColor = System.Drawing.Color.Black;
            this.btnOrderDelete.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.btnOrderDelete.Location = new System.Drawing.Point(50, 57);
            this.btnOrderDelete.Name = "btnOrderDelete";
            this.btnOrderDelete.PressedColor = System.Drawing.Color.Aqua;
            this.btnOrderDelete.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnOrderDelete.Size = new System.Drawing.Size(214, 41);
            this.btnOrderDelete.TabIndex = 17;
            this.btnOrderDelete.Text = "Удалить Заказ";
            this.btnOrderDelete.Click += new System.EventHandler(this.btnOrderDelete_Click);
            // 
            // btnProductWatch
            // 
            this.btnProductWatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductWatch.BackColor = System.Drawing.Color.Transparent;
            this.btnProductWatch.BorderRadius = 15;
            this.btnProductWatch.BorderThickness = 1;
            this.btnProductWatch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProductWatch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProductWatch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductWatch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProductWatch.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnProductWatch.FocusedColor = System.Drawing.Color.Aqua;
            this.btnProductWatch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProductWatch.ForeColor = System.Drawing.Color.Black;
            this.btnProductWatch.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.btnProductWatch.Location = new System.Drawing.Point(50, 10);
            this.btnProductWatch.Name = "btnProductWatch";
            this.btnProductWatch.PressedColor = System.Drawing.Color.Aqua;
            this.btnProductWatch.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnProductWatch.Size = new System.Drawing.Size(214, 41);
            this.btnProductWatch.TabIndex = 16;
            this.btnProductWatch.Text = "Просмотр Товаров";
            this.btnProductWatch.Click += new System.EventHandler(this.btnProductWatch_Click);
            // 
            // gbxProductData
            // 
            this.gbxProductData.BackColor = System.Drawing.Color.Transparent;
            this.gbxProductData.Controls.Add(this.pnlProductInfo);
            this.gbxProductData.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbxProductData.FillColor = System.Drawing.Color.Transparent;
            this.gbxProductData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbxProductData.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbxProductData.Location = new System.Drawing.Point(835, 119);
            this.gbxProductData.Name = "gbxProductData";
            this.gbxProductData.Size = new System.Drawing.Size(315, 339);
            this.gbxProductData.TabIndex = 13;
            this.gbxProductData.Text = "Данные Записи";
            this.gbxProductData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlProductInfo
            // 
            this.pnlProductInfo.Controls.Add(this.tbxLogin);
            this.pnlProductInfo.Controls.Add(this.tbxCategory);
            this.pnlProductInfo.Controls.Add(this.tbxId);
            this.pnlProductInfo.Controls.Add(this.tbxPrice);
            this.pnlProductInfo.Controls.Add(this.tbxName);
            this.pnlProductInfo.Controls.Add(this.tbxBrand);
            this.pnlProductInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(75)))), ((int)(((byte)(78)))));
            this.pnlProductInfo.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(52)))), ((int)(((byte)(104)))));
            this.pnlProductInfo.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(49)))), ((int)(((byte)(113)))));
            this.pnlProductInfo.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(47)))), ((int)(((byte)(102)))));
            this.pnlProductInfo.Location = new System.Drawing.Point(0, 40);
            this.pnlProductInfo.Name = "pnlProductInfo";
            this.pnlProductInfo.Size = new System.Drawing.Size(315, 299);
            this.pnlProductInfo.TabIndex = 12;
            // 
            // tbxLogin
            // 
            this.tbxLogin.BackColor = System.Drawing.Color.Transparent;
            this.tbxLogin.BorderColor = System.Drawing.Color.Black;
            this.tbxLogin.BorderRadius = 15;
            this.tbxLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxLogin.DefaultText = "";
            this.tbxLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxLogin.ForeColor = System.Drawing.Color.Black;
            this.tbxLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxLogin.Location = new System.Drawing.Point(24, 242);
            this.tbxLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.PasswordChar = '\0';
            this.tbxLogin.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbxLogin.PlaceholderText = "Введите логин заказчика";
            this.tbxLogin.SelectedText = "";
            this.tbxLogin.Size = new System.Drawing.Size(268, 36);
            this.tbxLogin.TabIndex = 12;
            // 
            // tbxCategory
            // 
            this.tbxCategory.BackColor = System.Drawing.Color.Transparent;
            this.tbxCategory.BorderColor = System.Drawing.Color.Black;
            this.tbxCategory.BorderRadius = 15;
            this.tbxCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxCategory.DefaultText = "";
            this.tbxCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxCategory.ForeColor = System.Drawing.Color.Black;
            this.tbxCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxCategory.Location = new System.Drawing.Point(24, 198);
            this.tbxCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxCategory.Name = "tbxCategory";
            this.tbxCategory.PasswordChar = '\0';
            this.tbxCategory.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbxCategory.PlaceholderText = "Введите категорию";
            this.tbxCategory.SelectedText = "";
            this.tbxCategory.Size = new System.Drawing.Size(268, 36);
            this.tbxCategory.TabIndex = 10;
            // 
            // tbxId
            // 
            this.tbxId.BackColor = System.Drawing.Color.Transparent;
            this.tbxId.BorderColor = System.Drawing.Color.Black;
            this.tbxId.BorderRadius = 15;
            this.tbxId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxId.DefaultText = "";
            this.tbxId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxId.Enabled = false;
            this.tbxId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxId.ForeColor = System.Drawing.Color.Black;
            this.tbxId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxId.Location = new System.Drawing.Point(24, 22);
            this.tbxId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxId.Name = "tbxId";
            this.tbxId.PasswordChar = '\0';
            this.tbxId.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbxId.PlaceholderText = "Введите id для продукта";
            this.tbxId.SelectedText = "";
            this.tbxId.Size = new System.Drawing.Size(268, 36);
            this.tbxId.TabIndex = 7;
            // 
            // tbxPrice
            // 
            this.tbxPrice.BackColor = System.Drawing.Color.Transparent;
            this.tbxPrice.BorderColor = System.Drawing.Color.Black;
            this.tbxPrice.BorderRadius = 15;
            this.tbxPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPrice.DefaultText = "";
            this.tbxPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxPrice.Enabled = false;
            this.tbxPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxPrice.ForeColor = System.Drawing.Color.Black;
            this.tbxPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxPrice.Location = new System.Drawing.Point(24, 154);
            this.tbxPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.PasswordChar = '\0';
            this.tbxPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbxPrice.PlaceholderText = "Введите цену продукта";
            this.tbxPrice.SelectedText = "";
            this.tbxPrice.Size = new System.Drawing.Size(268, 36);
            this.tbxPrice.TabIndex = 11;
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.Color.Transparent;
            this.tbxName.BorderColor = System.Drawing.Color.Black;
            this.tbxName.BorderRadius = 15;
            this.tbxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxName.DefaultText = "";
            this.tbxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxName.ForeColor = System.Drawing.Color.Black;
            this.tbxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxName.Location = new System.Drawing.Point(24, 66);
            this.tbxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxName.Name = "tbxName";
            this.tbxName.PasswordChar = '\0';
            this.tbxName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbxName.PlaceholderText = "Введите название для продукта";
            this.tbxName.SelectedText = "";
            this.tbxName.Size = new System.Drawing.Size(268, 36);
            this.tbxName.TabIndex = 8;
            // 
            // tbxBrand
            // 
            this.tbxBrand.BackColor = System.Drawing.Color.Transparent;
            this.tbxBrand.BorderColor = System.Drawing.Color.Black;
            this.tbxBrand.BorderRadius = 15;
            this.tbxBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxBrand.DefaultText = "";
            this.tbxBrand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxBrand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxBrand.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxBrand.ForeColor = System.Drawing.Color.Black;
            this.tbxBrand.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxBrand.Location = new System.Drawing.Point(24, 110);
            this.tbxBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxBrand.Name = "tbxBrand";
            this.tbxBrand.PasswordChar = '\0';
            this.tbxBrand.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbxBrand.PlaceholderText = "Введите название бренда";
            this.tbxBrand.SelectedText = "";
            this.tbxBrand.Size = new System.Drawing.Size(268, 36);
            this.tbxBrand.TabIndex = 9;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(25, 124);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(87, 31);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Заказы";
            // 
            // btnReboot
            // 
            this.btnReboot.BackColor = System.Drawing.Color.Transparent;
            this.btnReboot.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnReboot.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReboot.Image = global::mainPage.Properties.Resources.refresh_arrow_icon_icons_com_73442;
            this.btnReboot.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnReboot.ImageRotate = 0F;
            this.btnReboot.ImageSize = new System.Drawing.Size(28, 28);
            this.btnReboot.Location = new System.Drawing.Point(330, 115);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.PressedState.ImageSize = new System.Drawing.Size(28, 28);
            this.btnReboot.Size = new System.Drawing.Size(40, 40);
            this.btnReboot.TabIndex = 9;
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSearch.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSearch.Image = global::mainPage.Properties.Resources.magnifier_icon_icons_com_48267;
            this.btnSearch.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSearch.ImageRotate = 0F;
            this.btnSearch.ImageSize = new System.Drawing.Size(28, 28);
            this.btnSearch.Location = new System.Drawing.Point(383, 115);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PressedState.ImageSize = new System.Drawing.Size(28, 28);
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 8;
            // 
            // tbxSearch
            // 
            this.tbxSearch.BackColor = System.Drawing.Color.Transparent;
            this.tbxSearch.BorderColor = System.Drawing.Color.Black;
            this.tbxSearch.BorderRadius = 15;
            this.tbxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSearch.DefaultText = "";
            this.tbxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxSearch.ForeColor = System.Drawing.Color.Black;
            this.tbxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxSearch.Location = new System.Drawing.Point(429, 119);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.PasswordChar = '\0';
            this.tbxSearch.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbxSearch.PlaceholderText = "Введите название для поиска";
            this.tbxSearch.SelectedText = "";
            this.tbxSearch.Size = new System.Drawing.Size(361, 36);
            this.tbxSearch.TabIndex = 7;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 4;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView.Location = new System.Drawing.Point(31, 167);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(755, 549);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridView.ThemeStyle.ReadOnly = true;
            this.dataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick_1);
            // 
            // pnlTopWindow
            // 
            this.pnlTopWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTopWindow.Controls.Add(this.btnCloseForm);
            this.pnlTopWindow.Controls.Add(this.pbxIconShop);
            this.pnlTopWindow.Location = new System.Drawing.Point(0, 0);
            this.pnlTopWindow.Name = "pnlTopWindow";
            this.pnlTopWindow.Size = new System.Drawing.Size(1184, 100);
            this.pnlTopWindow.TabIndex = 0;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCloseForm.HoverState.ImageSize = new System.Drawing.Size(36, 36);
            this.btnCloseForm.Image = global::mainPage.Properties.Resources.cross;
            this.btnCloseForm.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCloseForm.ImageRotate = 0F;
            this.btnCloseForm.ImageSize = new System.Drawing.Size(34, 34);
            this.btnCloseForm.Location = new System.Drawing.Point(1132, 30);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnCloseForm.Size = new System.Drawing.Size(40, 40);
            this.btnCloseForm.TabIndex = 3;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // pbxIconShop
            // 
            this.pbxIconShop.BackColor = System.Drawing.Color.Transparent;
            this.pbxIconShop.Image = global::mainPage.Properties.Resources.logoFirma;
            this.pbxIconShop.ImageRotate = 0F;
            this.pbxIconShop.Location = new System.Drawing.Point(469, 0);
            this.pbxIconShop.Name = "pbxIconShop";
            this.pbxIconShop.Size = new System.Drawing.Size(300, 97);
            this.pbxIconShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxIconShop.TabIndex = 2;
            this.pbxIconShop.TabStop = false;
            this.pbxIconShop.UseTransparentBackground = true;
            // 
            // orderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 788);
            this.Controls.Add(this.pnlMainPage);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "orderPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказ Товара";
            this.Load += new System.EventHandler(this.orderProduct_Load);
            this.pnlMainPage.ResumeLayout(false);
            this.pnlMainPage.PerformLayout();
            this.gbxEventsData.ResumeLayout(false);
            this.pnlProductEvent.ResumeLayout(false);
            this.gbxProductData.ResumeLayout(false);
            this.pnlProductInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.pnlTopWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconShop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlMainPage;
        private Guna.UI2.WinForms.Guna2Panel pnlTopWindow;
        private Guna.UI2.WinForms.Guna2PictureBox pbxIconShop;
        private Guna.UI2.WinForms.Guna2ImageButton btnCloseForm;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2ImageButton btnReboot;
        private Guna.UI2.WinForms.Guna2ImageButton btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox tbxSearch;
        private Guna.UI2.WinForms.Guna2GroupBox gbxProductData;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlProductInfo;
        private Guna.UI2.WinForms.Guna2TextBox tbxCategory;
        private Guna.UI2.WinForms.Guna2TextBox tbxId;
        private Guna.UI2.WinForms.Guna2TextBox tbxPrice;
        private Guna.UI2.WinForms.Guna2TextBox tbxName;
        private Guna.UI2.WinForms.Guna2TextBox tbxBrand;
        private Guna.UI2.WinForms.Guna2GroupBox gbxEventsData;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlProductEvent;
        private Guna.UI2.WinForms.Guna2Button btnOrderSave;
        private Guna.UI2.WinForms.Guna2Button btnOrderDraft;
        private Guna.UI2.WinForms.Guna2Button btnOrderDelete;
        private Guna.UI2.WinForms.Guna2Button btnProductWatch;
        private Guna.UI2.WinForms.Guna2TextBox tbxLogin;
        private Guna.UI2.WinForms.Guna2ImageButton btnClear;
    }
}