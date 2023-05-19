namespace InventoryManagementSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.login_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.checkBox_show_password = new System.Windows.Forms.CheckBox();
            this.login_button = new System.Windows.Forms.Button();
            this.PasswordTB = new Bunifu.UI.WinForms.BunifuTextBox();
            this.UserNameTB = new Bunifu.UI.WinForms.BunifuTextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_X = new System.Windows.Forms.Label();
            this.login_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_panel
            // 
            this.login_panel.BackColor = System.Drawing.Color.DodgerBlue;
            this.login_panel.Controls.Add(this.pictureBox1);
            this.login_panel.Controls.Add(this.button_clear);
            this.login_panel.Controls.Add(this.checkBox_show_password);
            this.login_panel.Controls.Add(this.login_button);
            this.login_panel.Controls.Add(this.PasswordTB);
            this.login_panel.Controls.Add(this.UserNameTB);
            this.login_panel.Controls.Add(this.login_label);
            this.login_panel.Location = new System.Drawing.Point(224, 92);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(311, 396);
            this.login_panel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryManagementSystem.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(99, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button_clear
            // 
            this.button_clear.FlatAppearance.BorderSize = 0;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_clear.ForeColor = System.Drawing.Color.Crimson;
            this.button_clear.Location = new System.Drawing.Point(36, 344);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 36);
            this.button_clear.TabIndex = 6;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // checkBox_show_password
            // 
            this.checkBox_show_password.AutoSize = true;
            this.checkBox_show_password.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_show_password.ForeColor = System.Drawing.Color.Crimson;
            this.checkBox_show_password.Location = new System.Drawing.Point(117, 352);
            this.checkBox_show_password.Name = "checkBox_show_password";
            this.checkBox_show_password.Size = new System.Drawing.Size(158, 23);
            this.checkBox_show_password.TabIndex = 5;
            this.checkBox_show_password.Text = "Show Password";
            this.checkBox_show_password.UseVisualStyleBackColor = true;
            this.checkBox_show_password.CheckedChanged += new System.EventHandler(this.checkBox_show_password_CheckedChanged);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.White;
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_button.ForeColor = System.Drawing.Color.DodgerBlue;
            this.login_button.Location = new System.Drawing.Point(37, 293);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(237, 38);
            this.login_button.TabIndex = 3;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // PasswordTB
            // 
            this.PasswordTB.AcceptsReturn = false;
            this.PasswordTB.AcceptsTab = false;
            this.PasswordTB.AnimationSpeed = 200;
            this.PasswordTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PasswordTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PasswordTB.AutoSizeHeight = true;
            this.PasswordTB.BackColor = System.Drawing.Color.Transparent;
            this.PasswordTB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PasswordTB.BackgroundImage")));
            this.PasswordTB.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.PasswordTB.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PasswordTB.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.PasswordTB.BorderColorIdle = System.Drawing.Color.Silver;
            this.PasswordTB.BorderRadius = 1;
            this.PasswordTB.BorderThickness = 1;
            this.PasswordTB.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.PasswordTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PasswordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTB.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.PasswordTB.DefaultText = "";
            this.PasswordTB.FillColor = System.Drawing.Color.DodgerBlue;
            this.PasswordTB.ForeColor = System.Drawing.Color.White;
            this.PasswordTB.HideSelection = true;
            this.PasswordTB.IconLeft = null;
            this.PasswordTB.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTB.IconPadding = 10;
            this.PasswordTB.IconRight = null;
            this.PasswordTB.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTB.Lines = new string[0];
            this.PasswordTB.Location = new System.Drawing.Point(37, 233);
            this.PasswordTB.MaxLength = 32767;
            this.PasswordTB.MinimumSize = new System.Drawing.Size(1, 1);
            this.PasswordTB.Modified = false;
            this.PasswordTB.Multiline = false;
            this.PasswordTB.Name = "PasswordTB";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordTB.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.PasswordTB.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordTB.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.DodgerBlue;
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordTB.OnIdleState = stateProperties4;
            this.PasswordTB.Padding = new System.Windows.Forms.Padding(3);
            this.PasswordTB.PasswordChar = '\0';
            this.PasswordTB.PlaceholderForeColor = System.Drawing.Color.White;
            this.PasswordTB.PlaceholderText = "Password";
            this.PasswordTB.ReadOnly = false;
            this.PasswordTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTB.SelectedText = "";
            this.PasswordTB.SelectionLength = 0;
            this.PasswordTB.SelectionStart = 0;
            this.PasswordTB.ShortcutsEnabled = true;
            this.PasswordTB.Size = new System.Drawing.Size(237, 43);
            this.PasswordTB.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.PasswordTB.TabIndex = 2;
            this.PasswordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PasswordTB.TextMarginBottom = 0;
            this.PasswordTB.TextMarginLeft = 3;
            this.PasswordTB.TextMarginTop = 1;
            this.PasswordTB.TextPlaceholder = "Password";
            this.PasswordTB.UseSystemPasswordChar = true;
            this.PasswordTB.WordWrap = true;
            this.PasswordTB.TextChanged += new System.EventHandler(this.bunifuTextBox2_TextChanged);
            // 
            // UserNameTB
            // 
            this.UserNameTB.AcceptsReturn = false;
            this.UserNameTB.AcceptsTab = false;
            this.UserNameTB.AnimationSpeed = 200;
            this.UserNameTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UserNameTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UserNameTB.AutoSizeHeight = true;
            this.UserNameTB.BackColor = System.Drawing.Color.Transparent;
            this.UserNameTB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserNameTB.BackgroundImage")));
            this.UserNameTB.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.UserNameTB.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UserNameTB.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.UserNameTB.BorderColorIdle = System.Drawing.Color.Silver;
            this.UserNameTB.BorderRadius = 1;
            this.UserNameTB.BorderThickness = 1;
            this.UserNameTB.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.UserNameTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNameTB.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.UserNameTB.DefaultText = "";
            this.UserNameTB.FillColor = System.Drawing.Color.DodgerBlue;
            this.UserNameTB.ForeColor = System.Drawing.Color.White;
            this.UserNameTB.HideSelection = true;
            this.UserNameTB.IconLeft = null;
            this.UserNameTB.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNameTB.IconPadding = 10;
            this.UserNameTB.IconRight = null;
            this.UserNameTB.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNameTB.Lines = new string[0];
            this.UserNameTB.Location = new System.Drawing.Point(37, 170);
            this.UserNameTB.MaxLength = 32767;
            this.UserNameTB.MinimumSize = new System.Drawing.Size(1, 1);
            this.UserNameTB.Modified = false;
            this.UserNameTB.Multiline = false;
            this.UserNameTB.Name = "UserNameTB";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserNameTB.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.UserNameTB.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserNameTB.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.DodgerBlue;
            stateProperties8.ForeColor = System.Drawing.Color.White;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserNameTB.OnIdleState = stateProperties8;
            this.UserNameTB.Padding = new System.Windows.Forms.Padding(3);
            this.UserNameTB.PasswordChar = '\0';
            this.UserNameTB.PlaceholderForeColor = System.Drawing.Color.White;
            this.UserNameTB.PlaceholderText = "UserName";
            this.UserNameTB.ReadOnly = false;
            this.UserNameTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserNameTB.SelectedText = "";
            this.UserNameTB.SelectionLength = 0;
            this.UserNameTB.SelectionStart = 0;
            this.UserNameTB.ShortcutsEnabled = true;
            this.UserNameTB.Size = new System.Drawing.Size(237, 43);
            this.UserNameTB.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.UserNameTB.TabIndex = 1;
            this.UserNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserNameTB.TextMarginBottom = 0;
            this.UserNameTB.TextMarginLeft = 3;
            this.UserNameTB.TextMarginTop = 1;
            this.UserNameTB.TextPlaceholder = "UserName";
            this.UserNameTB.UseSystemPasswordChar = false;
            this.UserNameTB.WordWrap = true;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_label.ForeColor = System.Drawing.Color.White;
            this.login_label.Location = new System.Drawing.Point(110, 14);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(90, 38);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(121, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(502, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.BackColor = System.Drawing.Color.Transparent;
            this.label_X.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_X.ForeColor = System.Drawing.Color.White;
            this.label_X.Location = new System.Drawing.Point(728, -1);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(37, 40);
            this.label_X.TabIndex = 10;
            this.label_X.Text = "X";
            this.label_X.Click += new System.EventHandler(this.label_X_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::InventoryManagementSystem.Properties.Resources.pexels_pixabay_209251;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 571);
            this.Controls.Add(this.label_X);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTextBox UserNameTB;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.CheckBox checkBox_show_password;
        private System.Windows.Forms.Button login_button;
        private Bunifu.UI.WinForms.BunifuTextBox PasswordTB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_X;
    }
}

