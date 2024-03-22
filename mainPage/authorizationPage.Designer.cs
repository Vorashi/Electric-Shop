namespace mainPage
{
    partial class authorizationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authorizationPage));
            this.pnlMain = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblVisiblePassword = new System.Windows.Forms.Label();
            this.cbxVisibleState = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.lklblRegister = new System.Windows.Forms.LinkLabel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnEnter = new Guna.UI2.WinForms.Guna2Button();
            this.tbxPasswordAutoriz = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlTopWindow = new Guna.UI2.WinForms.Guna2Panel();
            this.pbxIconShop = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnCloseForm = new Guna.UI2.WinForms.Guna2ImageButton();
            this.tbxLoginAutoriz = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnlMain.SuspendLayout();
            this.pnlTopWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconShop)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnClear);
            this.pnlMain.Controls.Add(this.lblVisiblePassword);
            this.pnlMain.Controls.Add(this.cbxVisibleState);
            this.pnlMain.Controls.Add(this.lklblRegister);
            this.pnlMain.Controls.Add(this.lblWelcome);
            this.pnlMain.Controls.Add(this.lblQuestion);
            this.pnlMain.Controls.Add(this.btnEnter);
            this.pnlMain.Controls.Add(this.tbxPasswordAutoriz);
            this.pnlMain.Controls.Add(this.pnlTopWindow);
            this.pnlMain.Controls.Add(this.tbxLoginAutoriz);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(75)))), ((int)(((byte)(78)))));
            this.pnlMain.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(52)))), ((int)(((byte)(104)))));
            this.pnlMain.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(49)))), ((int)(((byte)(113)))));
            this.pnlMain.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(47)))), ((int)(((byte)(102)))));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(659, 611);
            this.pnlMain.TabIndex = 2;
            // 
            // lblVisiblePassword
            // 
            this.lblVisiblePassword.AutoSize = true;
            this.lblVisiblePassword.BackColor = System.Drawing.Color.Transparent;
            this.lblVisiblePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVisiblePassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVisiblePassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblVisiblePassword.Location = new System.Drawing.Point(221, 361);
            this.lblVisiblePassword.Name = "lblVisiblePassword";
            this.lblVisiblePassword.Size = new System.Drawing.Size(144, 23);
            this.lblVisiblePassword.TabIndex = 12;
            this.lblVisiblePassword.Text = "Показать пароль";
            // 
            // cbxVisibleState
            // 
            this.cbxVisibleState.BackColor = System.Drawing.Color.Transparent;
            this.cbxVisibleState.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxVisibleState.CheckedState.BorderRadius = 2;
            this.cbxVisibleState.CheckedState.BorderThickness = 1;
            this.cbxVisibleState.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxVisibleState.Location = new System.Drawing.Point(188, 356);
            this.cbxVisibleState.Name = "cbxVisibleState";
            this.cbxVisibleState.Size = new System.Drawing.Size(27, 31);
            this.cbxVisibleState.TabIndex = 11;
            this.cbxVisibleState.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.cbxVisibleState.UncheckedState.BorderRadius = 2;
            this.cbxVisibleState.UncheckedState.BorderThickness = 1;
            this.cbxVisibleState.UncheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cbxVisibleState.Click += new System.EventHandler(this.cbxVisibleState_Click);
            // 
            // lklblRegister
            // 
            this.lklblRegister.AutoSize = true;
            this.lklblRegister.BackColor = System.Drawing.Color.Transparent;
            this.lklblRegister.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lklblRegister.ForeColor = System.Drawing.Color.Aqua;
            this.lklblRegister.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lklblRegister.LinkColor = System.Drawing.Color.Aqua;
            this.lklblRegister.Location = new System.Drawing.Point(282, 561);
            this.lklblRegister.Name = "lklblRegister";
            this.lklblRegister.Size = new System.Drawing.Size(109, 23);
            this.lklblRegister.TabIndex = 9;
            this.lklblRegister.TabStop = true;
            this.lklblRegister.Text = "Регистрация";
            this.lklblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblRegister_LinkClicked);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblWelcome.Location = new System.Drawing.Point(204, 134);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(282, 41);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "Добро пожаловать";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblQuestion.Location = new System.Drawing.Point(267, 529);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(135, 23);
            this.lblQuestion.TabIndex = 3;
            this.lblQuestion.Text = "Впервые здесь?";
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnEnter.BorderRadius = 15;
            this.btnEnter.BorderThickness = 1;
            this.btnEnter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnter.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnter.FocusedColor = System.Drawing.Color.Aqua;
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEnter.ForeColor = System.Drawing.Color.Black;
            this.btnEnter.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.btnEnter.Location = new System.Drawing.Point(229, 456);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.PressedColor = System.Drawing.Color.Aqua;
            this.btnEnter.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnEnter.Size = new System.Drawing.Size(210, 53);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Войти";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tbxPasswordAutoriz
            // 
            this.tbxPasswordAutoriz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPasswordAutoriz.BackColor = System.Drawing.Color.Transparent;
            this.tbxPasswordAutoriz.BorderColor = System.Drawing.Color.Black;
            this.tbxPasswordAutoriz.BorderRadius = 15;
            this.tbxPasswordAutoriz.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPasswordAutoriz.DefaultText = "";
            this.tbxPasswordAutoriz.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxPasswordAutoriz.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxPasswordAutoriz.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxPasswordAutoriz.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxPasswordAutoriz.FocusedState.BorderColor = System.Drawing.Color.Aqua;
            this.tbxPasswordAutoriz.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxPasswordAutoriz.ForeColor = System.Drawing.Color.Black;
            this.tbxPasswordAutoriz.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.tbxPasswordAutoriz.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.tbxPasswordAutoriz.HoverState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.tbxPasswordAutoriz.IconLeft = global::mainPage.Properties.Resources.padlockLight;
            this.tbxPasswordAutoriz.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.tbxPasswordAutoriz.Location = new System.Drawing.Point(134, 279);
            this.tbxPasswordAutoriz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxPasswordAutoriz.Name = "tbxPasswordAutoriz";
            this.tbxPasswordAutoriz.PasswordChar = '\0';
            this.tbxPasswordAutoriz.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbxPasswordAutoriz.PlaceholderText = "Введите пароль";
            this.tbxPasswordAutoriz.SelectedText = "";
            this.tbxPasswordAutoriz.Size = new System.Drawing.Size(400, 52);
            this.tbxPasswordAutoriz.TabIndex = 1;
            // 
            // pnlTopWindow
            // 
            this.pnlTopWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTopWindow.Controls.Add(this.pbxIconShop);
            this.pnlTopWindow.Controls.Add(this.btnCloseForm);
            this.pnlTopWindow.Location = new System.Drawing.Point(0, 0);
            this.pnlTopWindow.Name = "pnlTopWindow";
            this.pnlTopWindow.Size = new System.Drawing.Size(659, 81);
            this.pnlTopWindow.TabIndex = 1;
            // 
            // pbxIconShop
            // 
            this.pbxIconShop.BackColor = System.Drawing.Color.Transparent;
            this.pbxIconShop.Image = global::mainPage.Properties.Resources.logoFirma;
            this.pbxIconShop.ImageRotate = 0F;
            this.pbxIconShop.InitialImage = global::mainPage.Properties.Resources.logoFirma;
            this.pbxIconShop.Location = new System.Drawing.Point(231, 3);
            this.pbxIconShop.Name = "pbxIconShop";
            this.pbxIconShop.Size = new System.Drawing.Size(230, 73);
            this.pbxIconShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxIconShop.TabIndex = 9;
            this.pbxIconShop.TabStop = false;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.CheckedState.ImageSize = new System.Drawing.Size(38, 38);
            this.btnCloseForm.HoverState.ImageSize = new System.Drawing.Size(38, 38);
            this.btnCloseForm.Image = global::mainPage.Properties.Resources.cross;
            this.btnCloseForm.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCloseForm.ImageRotate = 0F;
            this.btnCloseForm.ImageSize = new System.Drawing.Size(34, 34);
            this.btnCloseForm.Location = new System.Drawing.Point(607, 21);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.PressedState.ImageSize = new System.Drawing.Size(36, 36);
            this.btnCloseForm.Size = new System.Drawing.Size(40, 40);
            this.btnCloseForm.TabIndex = 0;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // tbxLoginAutoriz
            // 
            this.tbxLoginAutoriz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxLoginAutoriz.BackColor = System.Drawing.Color.Transparent;
            this.tbxLoginAutoriz.BorderColor = System.Drawing.Color.Black;
            this.tbxLoginAutoriz.BorderRadius = 15;
            this.tbxLoginAutoriz.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxLoginAutoriz.DefaultText = "";
            this.tbxLoginAutoriz.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxLoginAutoriz.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxLoginAutoriz.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxLoginAutoriz.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxLoginAutoriz.FocusedState.BorderColor = System.Drawing.Color.Aqua;
            this.tbxLoginAutoriz.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxLoginAutoriz.ForeColor = System.Drawing.Color.Black;
            this.tbxLoginAutoriz.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.tbxLoginAutoriz.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.tbxLoginAutoriz.HoverState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.tbxLoginAutoriz.IconLeft = global::mainPage.Properties.Resources.userLight;
            this.tbxLoginAutoriz.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.tbxLoginAutoriz.Location = new System.Drawing.Point(134, 208);
            this.tbxLoginAutoriz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxLoginAutoriz.Name = "tbxLoginAutoriz";
            this.tbxLoginAutoriz.PasswordChar = '\0';
            this.tbxLoginAutoriz.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbxLoginAutoriz.PlaceholderText = "Введите логин";
            this.tbxLoginAutoriz.SelectedText = "";
            this.tbxLoginAutoriz.Size = new System.Drawing.Size(400, 52);
            this.tbxLoginAutoriz.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClear.HoverState.ImageSize = new System.Drawing.Size(38, 38);
            this.btnClear.Image = global::mainPage.Properties.Resources.eraser_icon_173850;
            this.btnClear.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClear.ImageRotate = 0F;
            this.btnClear.ImageSize = new System.Drawing.Size(34, 34);
            this.btnClear.Location = new System.Drawing.Point(135, 350);
            this.btnClear.Name = "btnClear";
            this.btnClear.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnClear.Size = new System.Drawing.Size(40, 40);
            this.btnClear.TabIndex = 13;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // authorizationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(132)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(659, 611);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "authorizationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTopWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconShop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlMain;
        private System.Windows.Forms.LinkLabel lklblRegister;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblQuestion;
        private Guna.UI2.WinForms.Guna2Button btnEnter;
        private Guna.UI2.WinForms.Guna2TextBox tbxPasswordAutoriz;
        private Guna.UI2.WinForms.Guna2Panel pnlTopWindow;
        private Guna.UI2.WinForms.Guna2PictureBox pbxIconShop;
        private Guna.UI2.WinForms.Guna2ImageButton btnCloseForm;
        private Guna.UI2.WinForms.Guna2TextBox tbxLoginAutoriz;
        private Guna.UI2.WinForms.Guna2CustomCheckBox cbxVisibleState;
        private System.Windows.Forms.Label lblVisiblePassword;
        private Guna.UI2.WinForms.Guna2ImageButton btnClear;
    }
}