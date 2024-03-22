namespace mainPage
{
    partial class registrationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrationPage));
            this.btnRegister = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMain = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblVisiblePassword = new System.Windows.Forms.Label();
            this.cbxVisibleState = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.lkLblEnter = new System.Windows.Forms.LinkLabel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tbxPasswordRegister = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlTopWindow = new Guna.UI2.WinForms.Guna2Panel();
            this.pbxIconShop = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnCloseForm = new Guna.UI2.WinForms.Guna2ImageButton();
            this.tbxLoginRegister = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnlMain.SuspendLayout();
            this.pnlTopWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconShop)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BorderRadius = 15;
            this.btnRegister.BorderThickness = 1;
            this.btnRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegister.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegister.FocusedColor = System.Drawing.Color.Aqua;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.btnRegister.Location = new System.Drawing.Point(231, 459);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.PressedColor = System.Drawing.Color.Aqua;
            this.btnRegister.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnRegister.Size = new System.Drawing.Size(210, 53);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Зарегистрироваться";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnClear);
            this.pnlMain.Controls.Add(this.lblVisiblePassword);
            this.pnlMain.Controls.Add(this.cbxVisibleState);
            this.pnlMain.Controls.Add(this.lkLblEnter);
            this.pnlMain.Controls.Add(this.lblWelcome);
            this.pnlMain.Controls.Add(this.lblQuestion);
            this.pnlMain.Controls.Add(this.btnRegister);
            this.pnlMain.Controls.Add(this.tbxPasswordRegister);
            this.pnlMain.Controls.Add(this.pnlTopWindow);
            this.pnlMain.Controls.Add(this.tbxLoginRegister);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(75)))), ((int)(((byte)(78)))));
            this.pnlMain.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(52)))), ((int)(((byte)(104)))));
            this.pnlMain.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(49)))), ((int)(((byte)(113)))));
            this.pnlMain.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(47)))), ((int)(((byte)(102)))));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(659, 611);
            this.pnlMain.TabIndex = 1;
            // 
            // lblVisiblePassword
            // 
            this.lblVisiblePassword.AutoSize = true;
            this.lblVisiblePassword.BackColor = System.Drawing.Color.Transparent;
            this.lblVisiblePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVisiblePassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVisiblePassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblVisiblePassword.Location = new System.Drawing.Point(217, 361);
            this.lblVisiblePassword.Name = "lblVisiblePassword";
            this.lblVisiblePassword.Size = new System.Drawing.Size(144, 23);
            this.lblVisiblePassword.TabIndex = 14;
            this.lblVisiblePassword.Text = "Показать пароль";
            // 
            // cbxVisibleState
            // 
            this.cbxVisibleState.BackColor = System.Drawing.Color.Transparent;
            this.cbxVisibleState.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxVisibleState.CheckedState.BorderRadius = 2;
            this.cbxVisibleState.CheckedState.BorderThickness = 1;
            this.cbxVisibleState.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxVisibleState.Location = new System.Drawing.Point(186, 356);
            this.cbxVisibleState.Name = "cbxVisibleState";
            this.cbxVisibleState.Size = new System.Drawing.Size(27, 31);
            this.cbxVisibleState.TabIndex = 13;
            this.cbxVisibleState.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.cbxVisibleState.UncheckedState.BorderRadius = 2;
            this.cbxVisibleState.UncheckedState.BorderThickness = 1;
            this.cbxVisibleState.UncheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cbxVisibleState.Click += new System.EventHandler(this.cbxVisibleState_Click);
            // 
            // lkLblEnter
            // 
            this.lkLblEnter.AutoSize = true;
            this.lkLblEnter.BackColor = System.Drawing.Color.Transparent;
            this.lkLblEnter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lkLblEnter.ForeColor = System.Drawing.Color.Aqua;
            this.lkLblEnter.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lkLblEnter.LinkColor = System.Drawing.Color.Aqua;
            this.lkLblEnter.Location = new System.Drawing.Point(307, 566);
            this.lkLblEnter.Name = "lkLblEnter";
            this.lkLblEnter.Size = new System.Drawing.Size(57, 23);
            this.lkLblEnter.TabIndex = 9;
            this.lkLblEnter.TabStop = true;
            this.lkLblEnter.Text = "Войти";
            this.lkLblEnter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkLblEnter_LinkClicked);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.Location = new System.Drawing.Point(179, 135);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(319, 41);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "Давайте знакомиться!";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestion.Location = new System.Drawing.Point(232, 531);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(203, 23);
            this.lblQuestion.TabIndex = 3;
            this.lblQuestion.Text = "Уже зарегистрированы?";
            // 
            // tbxPasswordRegister
            // 
            this.tbxPasswordRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPasswordRegister.BackColor = System.Drawing.Color.Transparent;
            this.tbxPasswordRegister.BorderColor = System.Drawing.Color.Black;
            this.tbxPasswordRegister.BorderRadius = 15;
            this.tbxPasswordRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPasswordRegister.DefaultText = "";
            this.tbxPasswordRegister.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxPasswordRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxPasswordRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxPasswordRegister.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxPasswordRegister.FocusedState.BorderColor = System.Drawing.Color.Aqua;
            this.tbxPasswordRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxPasswordRegister.ForeColor = System.Drawing.Color.Black;
            this.tbxPasswordRegister.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.tbxPasswordRegister.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.tbxPasswordRegister.HoverState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.tbxPasswordRegister.IconLeft = global::mainPage.Properties.Resources.padlockLight;
            this.tbxPasswordRegister.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.tbxPasswordRegister.Location = new System.Drawing.Point(134, 279);
            this.tbxPasswordRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxPasswordRegister.Name = "tbxPasswordRegister";
            this.tbxPasswordRegister.PasswordChar = '\0';
            this.tbxPasswordRegister.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbxPasswordRegister.PlaceholderText = "Введите пароль";
            this.tbxPasswordRegister.SelectedText = "";
            this.tbxPasswordRegister.Size = new System.Drawing.Size(400, 52);
            this.tbxPasswordRegister.TabIndex = 1;
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
            // tbxLoginRegister
            // 
            this.tbxLoginRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxLoginRegister.BackColor = System.Drawing.Color.Transparent;
            this.tbxLoginRegister.BorderColor = System.Drawing.Color.Black;
            this.tbxLoginRegister.BorderRadius = 15;
            this.tbxLoginRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxLoginRegister.DefaultText = "";
            this.tbxLoginRegister.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxLoginRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxLoginRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxLoginRegister.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxLoginRegister.FocusedState.BorderColor = System.Drawing.Color.Aqua;
            this.tbxLoginRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxLoginRegister.ForeColor = System.Drawing.Color.Black;
            this.tbxLoginRegister.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.tbxLoginRegister.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.tbxLoginRegister.HoverState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.tbxLoginRegister.IconLeft = global::mainPage.Properties.Resources.userLight;
            this.tbxLoginRegister.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.tbxLoginRegister.Location = new System.Drawing.Point(134, 208);
            this.tbxLoginRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxLoginRegister.Name = "tbxLoginRegister";
            this.tbxLoginRegister.PasswordChar = '\0';
            this.tbxLoginRegister.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbxLoginRegister.PlaceholderText = "Введите логин";
            this.tbxLoginRegister.SelectedText = "";
            this.tbxLoginRegister.Size = new System.Drawing.Size(400, 52);
            this.tbxLoginRegister.TabIndex = 0;
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
            this.btnClear.Location = new System.Drawing.Point(134, 353);
            this.btnClear.Name = "btnClear";
            this.btnClear.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnClear.Size = new System.Drawing.Size(40, 40);
            this.btnClear.TabIndex = 14;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // registrationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(132)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(659, 611);
            this.Controls.Add(this.pnlMain);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "registrationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTopWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconShop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnRegister;
        private Guna.UI2.WinForms.Guna2TextBox tbxPasswordRegister;
        private Guna.UI2.WinForms.Guna2TextBox tbxLoginRegister;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlMain;
        private Guna.UI2.WinForms.Guna2Panel pnlTopWindow;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblWelcome;
        private Guna.UI2.WinForms.Guna2ImageButton btnCloseForm;
        private Guna.UI2.WinForms.Guna2PictureBox pbxIconShop;
        private System.Windows.Forms.LinkLabel lkLblEnter;
        private System.Windows.Forms.Label lblVisiblePassword;
        private Guna.UI2.WinForms.Guna2CustomCheckBox cbxVisibleState;
        private Guna.UI2.WinForms.Guna2ImageButton btnClear;
    }
}