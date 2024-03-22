namespace mainPage
{
    partial class generalPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(generalPage));
            this.pnlMainPage = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblRole = new System.Windows.Forms.Label();
            this.gbxEventsData = new Guna.UI2.WinForms.Guna2GroupBox();
            this.pnlProductEvent = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnWatchOrders = new Guna.UI2.WinForms.Guna2Button();
            this.btnProductOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnProductSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnProductDraft = new Guna.UI2.WinForms.Guna2Button();
            this.btnProductDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnProductAdd = new Guna.UI2.WinForms.Guna2Button();
            this.gbxProductData = new Guna.UI2.WinForms.Guna2GroupBox();
            this.pnlProductInfo = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.tbxCategory = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxId = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxBrand = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClear = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnReboot = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            this.tbxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlTopWindow = new Guna.UI2.WinForms.Guna2Panel();
            this.pbxIconShop = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnCloseForm = new Guna.UI2.WinForms.Guna2ImageButton();
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
            this.pnlMainPage.Controls.Add(this.lblRole);
            this.pnlMainPage.Controls.Add(this.gbxEventsData);
            this.pnlMainPage.Controls.Add(this.gbxProductData);
            this.pnlMainPage.Controls.Add(this.lblTitle);
            this.pnlMainPage.Controls.Add(this.btnClear);
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
            this.pnlMainPage.Size = new System.Drawing.Size(1121, 959);
            this.pnlMainPage.TabIndex = 0;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRole.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRole.Location = new System.Drawing.Point(17, 92);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(261, 41);
            this.lblRole.TabIndex = 14;
            this.lblRole.Text = "С возвращением ";
            // 
            // gbxEventsData
            // 
            this.gbxEventsData.BackColor = System.Drawing.Color.Transparent;
            this.gbxEventsData.Controls.Add(this.pnlProductEvent);
            this.gbxEventsData.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbxEventsData.FillColor = System.Drawing.Color.Transparent;
            this.gbxEventsData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbxEventsData.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbxEventsData.Location = new System.Drawing.Point(18, 524);
            this.gbxEventsData.Name = "gbxEventsData";
            this.gbxEventsData.Size = new System.Drawing.Size(315, 358);
            this.gbxEventsData.TabIndex = 13;
            this.gbxEventsData.Text = "Действия с Данными";
            this.gbxEventsData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlProductEvent
            // 
            this.pnlProductEvent.Controls.Add(this.btnWatchOrders);
            this.pnlProductEvent.Controls.Add(this.btnProductOrder);
            this.pnlProductEvent.Controls.Add(this.btnProductSave);
            this.pnlProductEvent.Controls.Add(this.btnProductDraft);
            this.pnlProductEvent.Controls.Add(this.btnProductDelete);
            this.pnlProductEvent.Controls.Add(this.btnProductAdd);
            this.pnlProductEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductEvent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(75)))), ((int)(((byte)(78)))));
            this.pnlProductEvent.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(52)))), ((int)(((byte)(104)))));
            this.pnlProductEvent.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(49)))), ((int)(((byte)(113)))));
            this.pnlProductEvent.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(47)))), ((int)(((byte)(102)))));
            this.pnlProductEvent.Location = new System.Drawing.Point(0, 40);
            this.pnlProductEvent.Name = "pnlProductEvent";
            this.pnlProductEvent.Size = new System.Drawing.Size(315, 318);
            this.pnlProductEvent.TabIndex = 12;
            // 
            // btnWatchOrders
            // 
            this.btnWatchOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWatchOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnWatchOrders.BorderRadius = 15;
            this.btnWatchOrders.BorderThickness = 1;
            this.btnWatchOrders.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWatchOrders.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWatchOrders.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWatchOrders.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWatchOrders.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnWatchOrders.FocusedColor = System.Drawing.Color.Aqua;
            this.btnWatchOrders.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWatchOrders.ForeColor = System.Drawing.Color.Black;
            this.btnWatchOrders.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.btnWatchOrders.Location = new System.Drawing.Point(46, 65);
            this.btnWatchOrders.Name = "btnWatchOrders";
            this.btnWatchOrders.PressedColor = System.Drawing.Color.Aqua;
            this.btnWatchOrders.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnWatchOrders.Size = new System.Drawing.Size(214, 43);
            this.btnWatchOrders.TabIndex = 17;
            this.btnWatchOrders.Text = "Просмотр заказов";
            this.btnWatchOrders.Click += new System.EventHandler(this.btnWatchOrders_Click);
            // 
            // btnProductOrder
            // 
            this.btnProductOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnProductOrder.BorderRadius = 15;
            this.btnProductOrder.BorderThickness = 1;
            this.btnProductOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProductOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProductOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProductOrder.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnProductOrder.FocusedColor = System.Drawing.Color.Aqua;
            this.btnProductOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProductOrder.ForeColor = System.Drawing.Color.Black;
            this.btnProductOrder.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.btnProductOrder.Location = new System.Drawing.Point(46, 16);
            this.btnProductOrder.Name = "btnProductOrder";
            this.btnProductOrder.PressedColor = System.Drawing.Color.Aqua;
            this.btnProductOrder.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnProductOrder.Size = new System.Drawing.Size(214, 43);
            this.btnProductOrder.TabIndex = 16;
            this.btnProductOrder.Text = "Заказать Товар";
            this.btnProductOrder.Click += new System.EventHandler(this.btnProductOrder_Click);
            // 
            // btnProductSave
            // 
            this.btnProductSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductSave.BackColor = System.Drawing.Color.Transparent;
            this.btnProductSave.BorderRadius = 15;
            this.btnProductSave.BorderThickness = 1;
            this.btnProductSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProductSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProductSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProductSave.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnProductSave.FocusedColor = System.Drawing.Color.Aqua;
            this.btnProductSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProductSave.ForeColor = System.Drawing.Color.Black;
            this.btnProductSave.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.btnProductSave.Location = new System.Drawing.Point(46, 265);
            this.btnProductSave.Name = "btnProductSave";
            this.btnProductSave.PressedColor = System.Drawing.Color.Aqua;
            this.btnProductSave.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnProductSave.Size = new System.Drawing.Size(214, 43);
            this.btnProductSave.TabIndex = 15;
            this.btnProductSave.Text = "Сохранить Товар";
            this.btnProductSave.Click += new System.EventHandler(this.btnProductSave_Click);
            // 
            // btnProductDraft
            // 
            this.btnProductDraft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductDraft.BackColor = System.Drawing.Color.Transparent;
            this.btnProductDraft.BorderRadius = 15;
            this.btnProductDraft.BorderThickness = 1;
            this.btnProductDraft.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProductDraft.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProductDraft.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductDraft.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProductDraft.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnProductDraft.FocusedColor = System.Drawing.Color.Aqua;
            this.btnProductDraft.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProductDraft.ForeColor = System.Drawing.Color.Black;
            this.btnProductDraft.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.btnProductDraft.Location = new System.Drawing.Point(46, 215);
            this.btnProductDraft.Name = "btnProductDraft";
            this.btnProductDraft.PressedColor = System.Drawing.Color.Aqua;
            this.btnProductDraft.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnProductDraft.Size = new System.Drawing.Size(214, 43);
            this.btnProductDraft.TabIndex = 14;
            this.btnProductDraft.Text = "Изменить Товар";
            this.btnProductDraft.Click += new System.EventHandler(this.btnProductDraft_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnProductDelete.BorderRadius = 15;
            this.btnProductDelete.BorderThickness = 1;
            this.btnProductDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProductDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProductDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProductDelete.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnProductDelete.FocusedColor = System.Drawing.Color.Aqua;
            this.btnProductDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProductDelete.ForeColor = System.Drawing.Color.Black;
            this.btnProductDelete.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.btnProductDelete.Location = new System.Drawing.Point(46, 165);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.PressedColor = System.Drawing.Color.Aqua;
            this.btnProductDelete.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnProductDelete.Size = new System.Drawing.Size(214, 43);
            this.btnProductDelete.TabIndex = 13;
            this.btnProductDelete.Text = "Удалить Товар";
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnProductAdd.BorderRadius = 15;
            this.btnProductAdd.BorderThickness = 1;
            this.btnProductAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProductAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProductAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProductAdd.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnProductAdd.FocusedColor = System.Drawing.Color.Aqua;
            this.btnProductAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProductAdd.ForeColor = System.Drawing.Color.Black;
            this.btnProductAdd.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.btnProductAdd.Location = new System.Drawing.Point(46, 114);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.PressedColor = System.Drawing.Color.Aqua;
            this.btnProductAdd.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnProductAdd.Size = new System.Drawing.Size(214, 43);
            this.btnProductAdd.TabIndex = 12;
            this.btnProductAdd.Text = "Добавить Товар";
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // gbxProductData
            // 
            this.gbxProductData.BackColor = System.Drawing.Color.Transparent;
            this.gbxProductData.Controls.Add(this.pnlProductInfo);
            this.gbxProductData.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbxProductData.FillColor = System.Drawing.Color.Transparent;
            this.gbxProductData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbxProductData.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbxProductData.Location = new System.Drawing.Point(18, 179);
            this.gbxProductData.Name = "gbxProductData";
            this.gbxProductData.Size = new System.Drawing.Size(315, 339);
            this.gbxProductData.TabIndex = 12;
            this.gbxProductData.Text = "Данные Записи";
            this.gbxProductData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlProductInfo
            // 
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
            this.tbxCategory.Location = new System.Drawing.Point(23, 214);
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
            this.tbxId.Location = new System.Drawing.Point(23, 38);
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
            this.tbxPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxPrice.ForeColor = System.Drawing.Color.Black;
            this.tbxPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxPrice.Location = new System.Drawing.Point(23, 170);
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
            this.tbxName.Location = new System.Drawing.Point(23, 82);
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
            this.tbxBrand.Location = new System.Drawing.Point(23, 126);
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
            this.lblTitle.Location = new System.Drawing.Point(333, 136);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(93, 31);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Товары";
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
            this.btnClear.Location = new System.Drawing.Point(683, 136);
            this.btnClear.Name = "btnClear";
            this.btnClear.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnClear.Size = new System.Drawing.Size(40, 40);
            this.btnClear.TabIndex = 5;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnReboot.Location = new System.Drawing.Point(626, 136);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.PressedState.ImageSize = new System.Drawing.Size(28, 28);
            this.btnReboot.Size = new System.Drawing.Size(40, 40);
            this.btnReboot.TabIndex = 4;
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
            this.btnSearch.Location = new System.Drawing.Point(741, 136);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PressedState.ImageSize = new System.Drawing.Size(28, 28);
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 3;
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
            this.tbxSearch.Location = new System.Drawing.Point(799, 136);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.PasswordChar = '\0';
            this.tbxSearch.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbxSearch.PlaceholderText = "Введите название для поиска";
            this.tbxSearch.SelectedText = "";
            this.tbxSearch.Size = new System.Drawing.Size(299, 36);
            this.tbxSearch.TabIndex = 2;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 4;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView.Location = new System.Drawing.Point(339, 179);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(759, 703);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridView.ThemeStyle.ReadOnly = true;
            this.dataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.RosyBrown;
            this.dataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // pnlTopWindow
            // 
            this.pnlTopWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTopWindow.Controls.Add(this.pbxIconShop);
            this.pnlTopWindow.Controls.Add(this.btnCloseForm);
            this.pnlTopWindow.Location = new System.Drawing.Point(0, 0);
            this.pnlTopWindow.Name = "pnlTopWindow";
            this.pnlTopWindow.Size = new System.Drawing.Size(1121, 78);
            this.pnlTopWindow.TabIndex = 0;
            // 
            // pbxIconShop
            // 
            this.pbxIconShop.BackColor = System.Drawing.Color.Transparent;
            this.pbxIconShop.Image = global::mainPage.Properties.Resources.logoFirma;
            this.pbxIconShop.ImageRotate = 0F;
            this.pbxIconShop.Location = new System.Drawing.Point(419, 3);
            this.pbxIconShop.Name = "pbxIconShop";
            this.pbxIconShop.Size = new System.Drawing.Size(300, 72);
            this.pbxIconShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxIconShop.TabIndex = 1;
            this.pbxIconShop.TabStop = false;
            this.pbxIconShop.UseTransparentBackground = true;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCloseForm.HoverState.ImageSize = new System.Drawing.Size(36, 36);
            this.btnCloseForm.Image = global::mainPage.Properties.Resources.cross;
            this.btnCloseForm.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCloseForm.ImageRotate = 0F;
            this.btnCloseForm.ImageSize = new System.Drawing.Size(34, 34);
            this.btnCloseForm.Location = new System.Drawing.Point(1069, 21);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnCloseForm.Size = new System.Drawing.Size(40, 40);
            this.btnCloseForm.TabIndex = 0;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // generalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(132)))), ((int)(((byte)(124)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1121, 959);
            this.Controls.Add(this.pnlMainPage);
            this.ForeColor = System.Drawing.Color.RosyBrown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "generalPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная страница магазина";
            this.Load += new System.EventHandler(this.generalPage_Load_1);
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
        private Guna.UI2.WinForms.Guna2ImageButton btnCloseForm;
        private Guna.UI2.WinForms.Guna2PictureBox pbxIconShop;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView;
        private Guna.UI2.WinForms.Guna2TextBox tbxSearch;
        private Guna.UI2.WinForms.Guna2ImageButton btnReboot;
        private Guna.UI2.WinForms.Guna2ImageButton btnSearch;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2ImageButton btnClear;
        private Guna.UI2.WinForms.Guna2TextBox tbxPrice;
        private Guna.UI2.WinForms.Guna2TextBox tbxCategory;
        private Guna.UI2.WinForms.Guna2TextBox tbxBrand;
        private Guna.UI2.WinForms.Guna2TextBox tbxName;
        private Guna.UI2.WinForms.Guna2TextBox tbxId;
        private Guna.UI2.WinForms.Guna2GroupBox gbxProductData;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlProductInfo;
        private Guna.UI2.WinForms.Guna2GroupBox gbxEventsData;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlProductEvent;
        private Guna.UI2.WinForms.Guna2Button btnProductSave;
        private Guna.UI2.WinForms.Guna2Button btnProductDraft;
        private Guna.UI2.WinForms.Guna2Button btnProductDelete;
        private Guna.UI2.WinForms.Guna2Button btnProductAdd;
        private System.Windows.Forms.Label lblRole;
        private Guna.UI2.WinForms.Guna2Button btnProductOrder;
        private Guna.UI2.WinForms.Guna2Button btnWatchOrders;
    }
}

