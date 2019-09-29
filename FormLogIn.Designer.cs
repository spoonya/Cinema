namespace Cinema
{
    partial class FormLogIn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pageSign = new Bunifu.UI.WinForms.BunifuPages();
            this.tabPageSignIn = new System.Windows.Forms.TabPage();
            this.lblAlert = new System.Windows.Forms.Label();
            this.lblRememberMe = new System.Windows.Forms.Label();
            this.cbRememberMe = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.tbPassword = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.tbLogin = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnSignInConfirm = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tabPageSignUp = new System.Windows.Forms.TabPage();
            this.lblLoginCor = new System.Windows.Forms.Label();
            this.lblPassLen = new System.Windows.Forms.Label();
            this.lblSignUpAlert = new System.Windows.Forms.Label();
            this.tbPasswordRepeatSignUp = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.tbPasswordSignUp = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.tbLoginSignUp = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.tbSecName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.tbName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnSignUpConfirm = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSignIn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSignUp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.transButton = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.pageSign.SuspendLayout();
            this.tabPageSignIn.SuspendLayout();
            this.tabPageSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = false;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = false;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = false;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = false;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = false;
            this.bunifuFormDock1.DockingOptions.DockLeft = false;
            this.bunifuFormDock1.DockingOptions.DockRight = false;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = false;
            this.bunifuFormDock1.DockingOptions.DockTopRight = false;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = false;
            this.bunifuFormDock1.ShowDockingIndicators = false;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // btnClose
            // 
            this.btnClose.ActiveImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ActiveImage")));
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowZooming = false;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.transButton.SetDecoration(this.btnClose, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ErrorImage")));
            this.btnClose.FadeWhenInactive = false;
            this.btnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageActive")));
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 60;
            this.btnClose.ImageSize = new System.Drawing.Size(-28, -28);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(32, 32);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(400, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 9;
            this.btnClose.TabStop = false;
            this.btnClose.ToolTipText = "";
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 60;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // pageSign
            // 
            this.pageSign.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pageSign.Controls.Add(this.tabPageSignIn);
            this.pageSign.Controls.Add(this.tabPageSignUp);
            this.transButton.SetDecoration(this.pageSign, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pageSign.Location = new System.Drawing.Point(29, 100);
            this.pageSign.Multiline = true;
            this.pageSign.Name = "pageSign";
            this.pageSign.SelectedIndex = 0;
            this.pageSign.Size = new System.Drawing.Size(391, 324);
            this.pageSign.TabIndex = 8;
            // 
            // tabPageSignIn
            // 
            this.tabPageSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tabPageSignIn.Controls.Add(this.lblAlert);
            this.tabPageSignIn.Controls.Add(this.lblRememberMe);
            this.tabPageSignIn.Controls.Add(this.cbRememberMe);
            this.tabPageSignIn.Controls.Add(this.tbPassword);
            this.tabPageSignIn.Controls.Add(this.tbLogin);
            this.tabPageSignIn.Controls.Add(this.btnSignInConfirm);
            this.transButton.SetDecoration(this.tabPageSignIn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tabPageSignIn.Location = new System.Drawing.Point(4, 4);
            this.tabPageSignIn.Name = "tabPageSignIn";
            this.tabPageSignIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSignIn.Size = new System.Drawing.Size(383, 298);
            this.tabPageSignIn.TabIndex = 0;
            this.tabPageSignIn.Text = "Вход";
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.transButton.SetDecoration(this.lblAlert, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblAlert.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAlert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblAlert.Location = new System.Drawing.Point(3, -4);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(217, 20);
            this.lblAlert.TabIndex = 16;
            this.lblAlert.Text = "Неверный логин или пароль!";
            this.lblAlert.Visible = false;
            // 
            // lblRememberMe
            // 
            this.lblRememberMe.AutoSize = true;
            this.transButton.SetDecoration(this.lblRememberMe, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblRememberMe.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRememberMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblRememberMe.Location = new System.Drawing.Point(33, 142);
            this.lblRememberMe.Name = "lblRememberMe";
            this.lblRememberMe.Size = new System.Drawing.Size(126, 20);
            this.lblRememberMe.TabIndex = 15;
            this.lblRememberMe.Text = "Запомнить меня";
            // 
            // cbRememberMe
            // 
            this.cbRememberMe.AllowBindingControlAnimation = true;
            this.cbRememberMe.AllowBindingControlColorChanges = false;
            this.cbRememberMe.AllowBindingControlLocation = true;
            this.cbRememberMe.AllowCheckBoxAnimation = true;
            this.cbRememberMe.AllowCheckmarkAnimation = true;
            this.cbRememberMe.AllowOnHoverStates = true;
            this.cbRememberMe.AutoCheck = true;
            this.cbRememberMe.BackColor = System.Drawing.Color.Transparent;
            this.cbRememberMe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbRememberMe.BackgroundImage")));
            this.cbRememberMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cbRememberMe.BindingControl = null;
            this.cbRememberMe.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.cbRememberMe.Checked = false;
            this.cbRememberMe.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.cbRememberMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbRememberMe.CustomCheckmarkImage = null;
            this.transButton.SetDecoration(this.cbRememberMe, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.cbRememberMe.Location = new System.Drawing.Point(6, 141);
            this.cbRememberMe.MinimumSize = new System.Drawing.Size(17, 17);
            this.cbRememberMe.Name = "cbRememberMe";
            this.cbRememberMe.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.cbRememberMe.OnCheck.BorderRadius = 2;
            this.cbRememberMe.OnCheck.BorderThickness = 2;
            this.cbRememberMe.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.cbRememberMe.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.cbRememberMe.OnCheck.CheckmarkThickness = 2;
            this.cbRememberMe.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.cbRememberMe.OnDisable.BorderRadius = 2;
            this.cbRememberMe.OnDisable.BorderThickness = 2;
            this.cbRememberMe.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.cbRememberMe.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.cbRememberMe.OnDisable.CheckmarkThickness = 2;
            this.cbRememberMe.OnHoverChecked.BorderColor = System.Drawing.Color.Red;
            this.cbRememberMe.OnHoverChecked.BorderRadius = 2;
            this.cbRememberMe.OnHoverChecked.BorderThickness = 2;
            this.cbRememberMe.OnHoverChecked.CheckBoxColor = System.Drawing.Color.Red;
            this.cbRememberMe.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.cbRememberMe.OnHoverChecked.CheckmarkThickness = 2;
            this.cbRememberMe.OnHoverUnchecked.BorderColor = System.Drawing.Color.Gray;
            this.cbRememberMe.OnHoverUnchecked.BorderRadius = 2;
            this.cbRememberMe.OnHoverUnchecked.BorderThickness = 2;
            this.cbRememberMe.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.cbRememberMe.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.cbRememberMe.OnUncheck.BorderRadius = 2;
            this.cbRememberMe.OnUncheck.BorderThickness = 2;
            this.cbRememberMe.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.cbRememberMe.Size = new System.Drawing.Size(21, 21);
            this.cbRememberMe.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.cbRememberMe.TabIndex = 14;
            this.cbRememberMe.TabStop = false;
            this.cbRememberMe.ThreeState = false;
            this.cbRememberMe.ToolTipText = "";
            this.cbRememberMe.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.cbRememberMe_CheckedChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.AcceptsReturn = false;
            this.tbPassword.AcceptsTab = false;
            this.tbPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbPassword.BackgroundImage")));
            this.tbPassword.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.tbPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.tbPassword.BorderColorHover = System.Drawing.Color.Gray;
            this.tbPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.tbPassword.BorderRadius = 3;
            this.tbPassword.BorderThickness = 1;
            this.tbPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transButton.SetDecoration(this.tbPassword, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tbPassword.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.DefaultText = "";
            this.tbPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.HideSelection = true;
            this.tbPassword.IconLeft = null;
            this.tbPassword.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.tbPassword.IconPadding = 10;
            this.tbPassword.IconRight = null;
            this.tbPassword.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.tbPassword.Location = new System.Drawing.Point(6, 85);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.MinimumSize = new System.Drawing.Size(100, 35);
            this.tbPassword.Modified = false;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.ReadOnly = false;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.ShortcutsEnabled = true;
            this.tbPassword.Size = new System.Drawing.Size(368, 35);
            this.tbPassword.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.tbPassword.TabIndex = 13;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPassword.TextMarginLeft = 5;
            this.tbPassword.TextPlaceholder = "Пароль";
            this.tbPassword.UseSystemPasswordChar = false;
            // 
            // tbLogin
            // 
            this.tbLogin.AcceptsReturn = false;
            this.tbLogin.AcceptsTab = false;
            this.tbLogin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbLogin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbLogin.BackColor = System.Drawing.Color.Transparent;
            this.tbLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbLogin.BackgroundImage")));
            this.tbLogin.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.tbLogin.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.tbLogin.BorderColorHover = System.Drawing.Color.Gray;
            this.tbLogin.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.tbLogin.BorderRadius = 3;
            this.tbLogin.BorderThickness = 1;
            this.tbLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transButton.SetDecoration(this.tbLogin, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tbLogin.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.DefaultText = "";
            this.tbLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tbLogin.ForeColor = System.Drawing.Color.White;
            this.tbLogin.HideSelection = true;
            this.tbLogin.IconLeft = null;
            this.tbLogin.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.tbLogin.IconPadding = 10;
            this.tbLogin.IconRight = null;
            this.tbLogin.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.tbLogin.Location = new System.Drawing.Point(6, 27);
            this.tbLogin.MaxLength = 32767;
            this.tbLogin.MinimumSize = new System.Drawing.Size(100, 35);
            this.tbLogin.Modified = false;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.PasswordChar = '\0';
            this.tbLogin.ReadOnly = false;
            this.tbLogin.SelectedText = "";
            this.tbLogin.SelectionLength = 0;
            this.tbLogin.SelectionStart = 0;
            this.tbLogin.ShortcutsEnabled = true;
            this.tbLogin.Size = new System.Drawing.Size(368, 35);
            this.tbLogin.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.tbLogin.TabIndex = 12;
            this.tbLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbLogin.TextMarginLeft = 5;
            this.tbLogin.TextPlaceholder = "Логин";
            this.tbLogin.UseSystemPasswordChar = false;
            // 
            // btnSignInConfirm
            // 
            this.btnSignInConfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSignInConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnSignInConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignInConfirm.BackgroundImage")));
            this.btnSignInConfirm.ButtonText = "Войти";
            this.btnSignInConfirm.ButtonTextMarginLeft = 0;
            this.btnSignInConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transButton.SetDecoration(this.btnSignInConfirm, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSignInConfirm.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSignInConfirm.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnSignInConfirm.DisabledForecolor = System.Drawing.Color.White;
            this.btnSignInConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSignInConfirm.ForeColor = System.Drawing.Color.White;
            this.btnSignInConfirm.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSignInConfirm.IconPadding = 10;
            this.btnSignInConfirm.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSignInConfirm.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnSignInConfirm.IdleBorderRadius = 3;
            this.btnSignInConfirm.IdleBorderThickness = 0;
            this.btnSignInConfirm.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnSignInConfirm.IdleIconLeftImage = null;
            this.btnSignInConfirm.IdleIconRightImage = null;
            this.btnSignInConfirm.Location = new System.Drawing.Point(6, 262);
            this.btnSignInConfirm.Name = "btnSignInConfirm";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnSignInConfirm.onHoverState = stateProperties1;
            this.btnSignInConfirm.Size = new System.Drawing.Size(368, 45);
            this.btnSignInConfirm.TabIndex = 3;
            this.btnSignInConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignInConfirm.Click += new System.EventHandler(this.btnSignInConfirm_Click);
            // 
            // tabPageSignUp
            // 
            this.tabPageSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tabPageSignUp.Controls.Add(this.lblLoginCor);
            this.tabPageSignUp.Controls.Add(this.lblPassLen);
            this.tabPageSignUp.Controls.Add(this.lblSignUpAlert);
            this.tabPageSignUp.Controls.Add(this.tbPasswordRepeatSignUp);
            this.tabPageSignUp.Controls.Add(this.tbPasswordSignUp);
            this.tabPageSignUp.Controls.Add(this.tbLoginSignUp);
            this.tabPageSignUp.Controls.Add(this.tbSecName);
            this.tabPageSignUp.Controls.Add(this.tbName);
            this.tabPageSignUp.Controls.Add(this.btnSignUpConfirm);
            this.transButton.SetDecoration(this.tabPageSignUp, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tabPageSignUp.Location = new System.Drawing.Point(4, 4);
            this.tabPageSignUp.Name = "tabPageSignUp";
            this.tabPageSignUp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSignUp.Size = new System.Drawing.Size(383, 298);
            this.tabPageSignUp.TabIndex = 1;
            this.tabPageSignUp.Text = "Регистрация";
            // 
            // lblLoginCor
            // 
            this.lblLoginCor.AutoSize = true;
            this.transButton.SetDecoration(this.lblLoginCor, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblLoginCor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLoginCor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblLoginCor.Location = new System.Drawing.Point(6, 65);
            this.lblLoginCor.Name = "lblLoginCor";
            this.lblLoginCor.Size = new System.Drawing.Size(159, 20);
            this.lblLoginCor.TabIndex = 19;
            this.lblLoginCor.Text = "Некорректный логин";
            this.lblLoginCor.Visible = false;
            // 
            // lblPassLen
            // 
            this.lblPassLen.AutoSize = true;
            this.transButton.SetDecoration(this.lblPassLen, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblPassLen.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassLen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblPassLen.Location = new System.Drawing.Point(6, 123);
            this.lblPassLen.Name = "lblPassLen";
            this.lblPassLen.Size = new System.Drawing.Size(307, 20);
            this.lblPassLen.TabIndex = 18;
            this.lblPassLen.Text = "Длина пароля не менее восьми символов";
            this.lblPassLen.Visible = false;
            // 
            // lblSignUpAlert
            // 
            this.lblSignUpAlert.AutoSize = true;
            this.transButton.SetDecoration(this.lblSignUpAlert, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblSignUpAlert.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSignUpAlert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblSignUpAlert.Location = new System.Drawing.Point(6, -4);
            this.lblSignUpAlert.Name = "lblSignUpAlert";
            this.lblSignUpAlert.Size = new System.Drawing.Size(213, 20);
            this.lblSignUpAlert.TabIndex = 17;
            this.lblSignUpAlert.Text = "Введите корректные данные";
            this.lblSignUpAlert.Visible = false;
            // 
            // tbPasswordRepeatSignUp
            // 
            this.tbPasswordRepeatSignUp.AcceptsReturn = false;
            this.tbPasswordRepeatSignUp.AcceptsTab = false;
            this.tbPasswordRepeatSignUp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbPasswordRepeatSignUp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbPasswordRepeatSignUp.BackColor = System.Drawing.Color.Transparent;
            this.tbPasswordRepeatSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbPasswordRepeatSignUp.BackgroundImage")));
            this.tbPasswordRepeatSignUp.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.tbPasswordRepeatSignUp.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.tbPasswordRepeatSignUp.BorderColorHover = System.Drawing.Color.Gray;
            this.tbPasswordRepeatSignUp.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.tbPasswordRepeatSignUp.BorderRadius = 3;
            this.tbPasswordRepeatSignUp.BorderThickness = 1;
            this.tbPasswordRepeatSignUp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPasswordRepeatSignUp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transButton.SetDecoration(this.tbPasswordRepeatSignUp, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tbPasswordRepeatSignUp.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPasswordRepeatSignUp.DefaultText = "";
            this.tbPasswordRepeatSignUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tbPasswordRepeatSignUp.ForeColor = System.Drawing.Color.White;
            this.tbPasswordRepeatSignUp.HideSelection = true;
            this.tbPasswordRepeatSignUp.IconLeft = null;
            this.tbPasswordRepeatSignUp.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.tbPasswordRepeatSignUp.IconPadding = 10;
            this.tbPasswordRepeatSignUp.IconRight = null;
            this.tbPasswordRepeatSignUp.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.tbPasswordRepeatSignUp.Location = new System.Drawing.Point(6, 201);
            this.tbPasswordRepeatSignUp.MaxLength = 32767;
            this.tbPasswordRepeatSignUp.MinimumSize = new System.Drawing.Size(100, 35);
            this.tbPasswordRepeatSignUp.Modified = false;
            this.tbPasswordRepeatSignUp.Name = "tbPasswordRepeatSignUp";
            this.tbPasswordRepeatSignUp.PasswordChar = '*';
            this.tbPasswordRepeatSignUp.ReadOnly = false;
            this.tbPasswordRepeatSignUp.SelectedText = "";
            this.tbPasswordRepeatSignUp.SelectionLength = 0;
            this.tbPasswordRepeatSignUp.SelectionStart = 0;
            this.tbPasswordRepeatSignUp.ShortcutsEnabled = true;
            this.tbPasswordRepeatSignUp.Size = new System.Drawing.Size(368, 35);
            this.tbPasswordRepeatSignUp.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.tbPasswordRepeatSignUp.TabIndex = 12;
            this.tbPasswordRepeatSignUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPasswordRepeatSignUp.TextMarginLeft = 5;
            this.tbPasswordRepeatSignUp.TextPlaceholder = "Подтвердите пароль*";
            this.tbPasswordRepeatSignUp.UseSystemPasswordChar = false;
            // 
            // tbPasswordSignUp
            // 
            this.tbPasswordSignUp.AcceptsReturn = false;
            this.tbPasswordSignUp.AcceptsTab = false;
            this.tbPasswordSignUp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbPasswordSignUp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbPasswordSignUp.BackColor = System.Drawing.Color.Transparent;
            this.tbPasswordSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbPasswordSignUp.BackgroundImage")));
            this.tbPasswordSignUp.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.tbPasswordSignUp.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.tbPasswordSignUp.BorderColorHover = System.Drawing.Color.Gray;
            this.tbPasswordSignUp.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.tbPasswordSignUp.BorderRadius = 3;
            this.tbPasswordSignUp.BorderThickness = 1;
            this.tbPasswordSignUp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPasswordSignUp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transButton.SetDecoration(this.tbPasswordSignUp, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tbPasswordSignUp.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPasswordSignUp.DefaultText = "";
            this.tbPasswordSignUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tbPasswordSignUp.ForeColor = System.Drawing.Color.White;
            this.tbPasswordSignUp.HideSelection = true;
            this.tbPasswordSignUp.IconLeft = null;
            this.tbPasswordSignUp.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.tbPasswordSignUp.IconPadding = 10;
            this.tbPasswordSignUp.IconRight = null;
            this.tbPasswordSignUp.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.tbPasswordSignUp.Location = new System.Drawing.Point(6, 143);
            this.tbPasswordSignUp.MaxLength = 32767;
            this.tbPasswordSignUp.MinimumSize = new System.Drawing.Size(100, 35);
            this.tbPasswordSignUp.Modified = false;
            this.tbPasswordSignUp.Name = "tbPasswordSignUp";
            this.tbPasswordSignUp.PasswordChar = '*';
            this.tbPasswordSignUp.ReadOnly = false;
            this.tbPasswordSignUp.SelectedText = "";
            this.tbPasswordSignUp.SelectionLength = 0;
            this.tbPasswordSignUp.SelectionStart = 0;
            this.tbPasswordSignUp.ShortcutsEnabled = true;
            this.tbPasswordSignUp.Size = new System.Drawing.Size(368, 35);
            this.tbPasswordSignUp.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.tbPasswordSignUp.TabIndex = 11;
            this.tbPasswordSignUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPasswordSignUp.TextMarginLeft = 5;
            this.tbPasswordSignUp.TextPlaceholder = "Пароль*";
            this.tbPasswordSignUp.UseSystemPasswordChar = false;
            // 
            // tbLoginSignUp
            // 
            this.tbLoginSignUp.AcceptsReturn = false;
            this.tbLoginSignUp.AcceptsTab = false;
            this.tbLoginSignUp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbLoginSignUp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbLoginSignUp.BackColor = System.Drawing.Color.Transparent;
            this.tbLoginSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbLoginSignUp.BackgroundImage")));
            this.tbLoginSignUp.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.tbLoginSignUp.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.tbLoginSignUp.BorderColorHover = System.Drawing.Color.Gray;
            this.tbLoginSignUp.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.tbLoginSignUp.BorderRadius = 3;
            this.tbLoginSignUp.BorderThickness = 1;
            this.tbLoginSignUp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbLoginSignUp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transButton.SetDecoration(this.tbLoginSignUp, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tbLoginSignUp.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLoginSignUp.DefaultText = "";
            this.tbLoginSignUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tbLoginSignUp.ForeColor = System.Drawing.Color.White;
            this.tbLoginSignUp.HideSelection = true;
            this.tbLoginSignUp.IconLeft = null;
            this.tbLoginSignUp.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.tbLoginSignUp.IconPadding = 10;
            this.tbLoginSignUp.IconRight = null;
            this.tbLoginSignUp.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.tbLoginSignUp.Location = new System.Drawing.Point(6, 85);
            this.tbLoginSignUp.MaxLength = 32767;
            this.tbLoginSignUp.MinimumSize = new System.Drawing.Size(100, 35);
            this.tbLoginSignUp.Modified = false;
            this.tbLoginSignUp.Name = "tbLoginSignUp";
            this.tbLoginSignUp.PasswordChar = '\0';
            this.tbLoginSignUp.ReadOnly = false;
            this.tbLoginSignUp.SelectedText = "";
            this.tbLoginSignUp.SelectionLength = 0;
            this.tbLoginSignUp.SelectionStart = 0;
            this.tbLoginSignUp.ShortcutsEnabled = true;
            this.tbLoginSignUp.Size = new System.Drawing.Size(368, 35);
            this.tbLoginSignUp.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.tbLoginSignUp.TabIndex = 10;
            this.tbLoginSignUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbLoginSignUp.TextMarginLeft = 5;
            this.tbLoginSignUp.TextPlaceholder = "Логин*";
            this.tbLoginSignUp.UseSystemPasswordChar = false;
            // 
            // tbSecName
            // 
            this.tbSecName.AcceptsReturn = false;
            this.tbSecName.AcceptsTab = false;
            this.tbSecName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbSecName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbSecName.BackColor = System.Drawing.Color.Transparent;
            this.tbSecName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbSecName.BackgroundImage")));
            this.tbSecName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.tbSecName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.tbSecName.BorderColorHover = System.Drawing.Color.Gray;
            this.tbSecName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.tbSecName.BorderRadius = 3;
            this.tbSecName.BorderThickness = 1;
            this.tbSecName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbSecName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transButton.SetDecoration(this.tbSecName, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tbSecName.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSecName.DefaultText = "";
            this.tbSecName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tbSecName.ForeColor = System.Drawing.Color.White;
            this.tbSecName.HideSelection = true;
            this.tbSecName.IconLeft = null;
            this.tbSecName.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.tbSecName.IconPadding = 10;
            this.tbSecName.IconRight = null;
            this.tbSecName.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.tbSecName.Location = new System.Drawing.Point(201, 27);
            this.tbSecName.MaxLength = 32767;
            this.tbSecName.MinimumSize = new System.Drawing.Size(100, 35);
            this.tbSecName.Modified = false;
            this.tbSecName.Name = "tbSecName";
            this.tbSecName.PasswordChar = '\0';
            this.tbSecName.ReadOnly = false;
            this.tbSecName.SelectedText = "";
            this.tbSecName.SelectionLength = 0;
            this.tbSecName.SelectionStart = 0;
            this.tbSecName.ShortcutsEnabled = true;
            this.tbSecName.Size = new System.Drawing.Size(173, 35);
            this.tbSecName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.tbSecName.TabIndex = 9;
            this.tbSecName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSecName.TextMarginLeft = 5;
            this.tbSecName.TextPlaceholder = "Фамилия*";
            this.tbSecName.UseSystemPasswordChar = false;
            // 
            // tbName
            // 
            this.tbName.AcceptsReturn = false;
            this.tbName.AcceptsTab = false;
            this.tbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbName.BackColor = System.Drawing.Color.Transparent;
            this.tbName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbName.BackgroundImage")));
            this.tbName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.tbName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.tbName.BorderColorHover = System.Drawing.Color.Gray;
            this.tbName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.tbName.BorderRadius = 3;
            this.tbName.BorderThickness = 1;
            this.tbName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transButton.SetDecoration(this.tbName, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tbName.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.DefaultText = "";
            this.tbName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.HideSelection = true;
            this.tbName.IconLeft = null;
            this.tbName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.IconPadding = 10;
            this.tbName.IconRight = null;
            this.tbName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.Location = new System.Drawing.Point(6, 27);
            this.tbName.MaxLength = 32767;
            this.tbName.MinimumSize = new System.Drawing.Size(100, 35);
            this.tbName.Modified = false;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.ReadOnly = false;
            this.tbName.SelectedText = "";
            this.tbName.SelectionLength = 0;
            this.tbName.SelectionStart = 0;
            this.tbName.ShortcutsEnabled = true;
            this.tbName.Size = new System.Drawing.Size(173, 35);
            this.tbName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.tbName.TabIndex = 8;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbName.TextMarginLeft = 5;
            this.tbName.TextPlaceholder = "Имя*";
            this.tbName.UseSystemPasswordChar = false;
            // 
            // btnSignUpConfirm
            // 
            this.btnSignUpConfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSignUpConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUpConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignUpConfirm.BackgroundImage")));
            this.btnSignUpConfirm.ButtonText = "Зарегистрироваться";
            this.btnSignUpConfirm.ButtonTextMarginLeft = 0;
            this.btnSignUpConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transButton.SetDecoration(this.btnSignUpConfirm, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSignUpConfirm.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSignUpConfirm.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnSignUpConfirm.DisabledForecolor = System.Drawing.Color.White;
            this.btnSignUpConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSignUpConfirm.ForeColor = System.Drawing.Color.White;
            this.btnSignUpConfirm.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSignUpConfirm.IconPadding = 10;
            this.btnSignUpConfirm.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSignUpConfirm.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnSignUpConfirm.IdleBorderRadius = 3;
            this.btnSignUpConfirm.IdleBorderThickness = 0;
            this.btnSignUpConfirm.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnSignUpConfirm.IdleIconLeftImage = null;
            this.btnSignUpConfirm.IdleIconRightImage = null;
            this.btnSignUpConfirm.Location = new System.Drawing.Point(6, 262);
            this.btnSignUpConfirm.Name = "btnSignUpConfirm";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnSignUpConfirm.onHoverState = stateProperties2;
            this.btnSignUpConfirm.Size = new System.Drawing.Size(368, 45);
            this.btnSignUpConfirm.TabIndex = 4;
            this.btnSignUpConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignUpConfirm.Click += new System.EventHandler(this.btnSignUpConfirm_Click_1);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Active = true;
            this.btnSignIn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignIn.BorderRadius = 0;
            this.btnSignIn.ButtonText = "Вход";
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transButton.SetDecoration(this.btnSignIn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSignIn.DisabledColor = System.Drawing.Color.Gray;
            this.btnSignIn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSignIn.Iconimage = null;
            this.btnSignIn.Iconimage_right = null;
            this.btnSignIn.Iconimage_right_Selected = null;
            this.btnSignIn.Iconimage_Selected = null;
            this.btnSignIn.IconMarginLeft = 0;
            this.btnSignIn.IconMarginRight = 0;
            this.btnSignIn.IconRightVisible = true;
            this.btnSignIn.IconRightZoom = 0D;
            this.btnSignIn.IconVisible = true;
            this.btnSignIn.IconZoom = 90D;
            this.btnSignIn.IsTab = true;
            this.btnSignIn.Location = new System.Drawing.Point(35, 38);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnSignIn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnSignIn.OnHoverTextColor = System.Drawing.Color.LightGray;
            this.btnSignIn.selected = true;
            this.btnSignIn.Size = new System.Drawing.Size(176, 44);
            this.btnSignIn.TabIndex = 7;
            this.btnSignIn.TabStop = false;
            this.btnSignIn.Text = "Вход";
            this.btnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignIn.Textcolor = System.Drawing.Color.White;
            this.btnSignIn.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click_1);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Active = false;
            this.btnSignUp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignUp.BorderRadius = 0;
            this.btnSignUp.ButtonText = "Регистрация";
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transButton.SetDecoration(this.btnSignUp, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSignUp.DisabledColor = System.Drawing.Color.Gray;
            this.btnSignUp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSignUp.Iconimage = null;
            this.btnSignUp.Iconimage_right = null;
            this.btnSignUp.Iconimage_right_Selected = null;
            this.btnSignUp.Iconimage_Selected = null;
            this.btnSignUp.IconMarginLeft = 0;
            this.btnSignUp.IconMarginRight = 0;
            this.btnSignUp.IconRightVisible = true;
            this.btnSignUp.IconRightZoom = 0D;
            this.btnSignUp.IconVisible = true;
            this.btnSignUp.IconZoom = 90D;
            this.btnSignUp.IsTab = true;
            this.btnSignUp.Location = new System.Drawing.Point(217, 38);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnSignUp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnSignUp.OnHoverTextColor = System.Drawing.Color.LightGray;
            this.btnSignUp.selected = false;
            this.btnSignUp.Size = new System.Drawing.Size(186, 44);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.TabStop = false;
            this.btnSignUp.Text = "Регистрация";
            this.btnSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignUp.Textcolor = System.Drawing.Color.White;
            this.btnSignUp.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click_1);
            // 
            // transButton
            // 
            this.transButton.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Transparent;
            this.transButton.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.transButton.DefaultAnimation = animation1;
            this.transButton.TimeStep = 0.05F;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(432, 436);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pageSign);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnSignUp);
            this.transButton.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cosmos";
            this.Load += new System.EventHandler(this.FormSign_Load);
            this.Shown += new System.EventHandler(this.FormSign_Shown);
            this.pageSign.ResumeLayout(false);
            this.tabPageSignIn.ResumeLayout(false);
            this.tabPageSignIn.PerformLayout();
            this.tabPageSignUp.ResumeLayout(false);
            this.tabPageSignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private Bunifu.UI.WinForms.BunifuPages pageSign;
        private System.Windows.Forms.TabPage tabPageSignIn;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.Label lblRememberMe;
        private Bunifu.UI.WinForms.BunifuCheckBox cbRememberMe;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox tbPassword;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox tbLogin;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSignInConfirm;
        private System.Windows.Forms.TabPage tabPageSignUp;
        private System.Windows.Forms.Label lblLoginCor;
        private System.Windows.Forms.Label lblPassLen;
        private System.Windows.Forms.Label lblSignUpAlert;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox tbPasswordRepeatSignUp;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox tbPasswordSignUp;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox tbLoginSignUp;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox tbSecName;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox tbName;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSignUpConfirm;
        private Bunifu.Framework.UI.BunifuFlatButton btnSignIn;
        private Bunifu.Framework.UI.BunifuFlatButton btnSignUp;
        private Bunifu.UI.WinForms.BunifuTransition transButton;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
    }
}