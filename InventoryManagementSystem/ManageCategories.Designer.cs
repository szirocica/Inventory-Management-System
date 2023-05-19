namespace InventoryManagementSystem
{
    partial class ManageCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCategories));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_X = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_categories_list = new System.Windows.Forms.Label();
            this.categoriesGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.category_home_button = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_add_category = new System.Windows.Forms.Button();
            this.CategoryNameTB = new Bunifu.UI.WinForms.BunifuTextBox();
            this.CategoryIdTB = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label_X);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 100);
            this.panel1.TabIndex = 2;
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_X.ForeColor = System.Drawing.Color.White;
            this.label_X.Location = new System.Drawing.Point(1206, 0);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(37, 40);
            this.label_X.TabIndex = 2;
            this.label_X.Text = "X";
            this.label_X.Click += new System.EventHandler(this.label_X_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(277, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(679, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(444, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Categories";
            // 
            // label_categories_list
            // 
            this.label_categories_list.AutoSize = true;
            this.label_categories_list.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_categories_list.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_categories_list.Location = new System.Drawing.Point(737, 123);
            this.label_categories_list.Name = "label_categories_list";
            this.label_categories_list.Size = new System.Drawing.Size(279, 40);
            this.label_categories_list.TabIndex = 30;
            this.label_categories_list.Text = "CATEGORIES LIST";
            // 
            // categoriesGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.categoriesGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoriesGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.categoriesGV.ColumnHeadersHeight = 25;
            this.categoriesGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoriesGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.categoriesGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.categoriesGV.Location = new System.Drawing.Point(551, 176);
            this.categoriesGV.Name = "categoriesGV";
            this.categoriesGV.RowHeadersVisible = false;
            this.categoriesGV.RowHeadersWidth = 51;
            this.categoriesGV.RowTemplate.Height = 30;
            this.categoriesGV.Size = new System.Drawing.Size(641, 459);
            this.categoriesGV.TabIndex = 29;
            this.categoriesGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.categoriesGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.categoriesGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.categoriesGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.categoriesGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.categoriesGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.categoriesGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.categoriesGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.categoriesGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.categoriesGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.categoriesGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.categoriesGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.categoriesGV.ThemeStyle.HeaderStyle.Height = 25;
            this.categoriesGV.ThemeStyle.ReadOnly = false;
            this.categoriesGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.categoriesGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.categoriesGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.categoriesGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.categoriesGV.ThemeStyle.RowsStyle.Height = 30;
            this.categoriesGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.categoriesGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.categoriesGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoriesGV_CellContentClick);
            // 
            // category_home_button
            // 
            this.category_home_button.BackColor = System.Drawing.Color.Crimson;
            this.category_home_button.FlatAppearance.BorderSize = 0;
            this.category_home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category_home_button.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.category_home_button.ForeColor = System.Drawing.Color.White;
            this.category_home_button.Location = new System.Drawing.Point(185, 349);
            this.category_home_button.Name = "category_home_button";
            this.category_home_button.Size = new System.Drawing.Size(108, 45);
            this.category_home_button.TabIndex = 28;
            this.category_home_button.Text = "Home";
            this.category_home_button.UseVisualStyleBackColor = false;
            this.category_home_button.Click += new System.EventHandler(this.category_home_button_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Crimson;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(299, 298);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(108, 45);
            this.button_delete.TabIndex = 27;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.Crimson;
            this.button_edit.FlatAppearance.BorderSize = 0;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_edit.ForeColor = System.Drawing.Color.White;
            this.button_edit.Location = new System.Drawing.Point(185, 298);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(108, 45);
            this.button_edit.TabIndex = 26;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_add_category
            // 
            this.button_add_category.BackColor = System.Drawing.Color.Crimson;
            this.button_add_category.FlatAppearance.BorderSize = 0;
            this.button_add_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_category.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add_category.ForeColor = System.Drawing.Color.White;
            this.button_add_category.Location = new System.Drawing.Point(71, 298);
            this.button_add_category.Name = "button_add_category";
            this.button_add_category.Size = new System.Drawing.Size(108, 45);
            this.button_add_category.TabIndex = 25;
            this.button_add_category.Text = "Add";
            this.button_add_category.UseVisualStyleBackColor = false;
            this.button_add_category.Click += new System.EventHandler(this.button_add_category_Click);
            // 
            // CategoryNameTB
            // 
            this.CategoryNameTB.AcceptsReturn = false;
            this.CategoryNameTB.AcceptsTab = false;
            this.CategoryNameTB.AnimationSpeed = 200;
            this.CategoryNameTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CategoryNameTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CategoryNameTB.AutoSizeHeight = true;
            this.CategoryNameTB.BackColor = System.Drawing.Color.White;
            this.CategoryNameTB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CategoryNameTB.BackgroundImage")));
            this.CategoryNameTB.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.CategoryNameTB.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CategoryNameTB.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CategoryNameTB.BorderColorIdle = System.Drawing.Color.Silver;
            this.CategoryNameTB.BorderRadius = 1;
            this.CategoryNameTB.BorderThickness = 1;
            this.CategoryNameTB.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.CategoryNameTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CategoryNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CategoryNameTB.DefaultFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CategoryNameTB.DefaultText = "";
            this.CategoryNameTB.FillColor = System.Drawing.Color.White;
            this.CategoryNameTB.ForeColor = System.Drawing.Color.Crimson;
            this.CategoryNameTB.HideSelection = true;
            this.CategoryNameTB.IconLeft = null;
            this.CategoryNameTB.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.CategoryNameTB.IconPadding = 10;
            this.CategoryNameTB.IconRight = null;
            this.CategoryNameTB.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.CategoryNameTB.Lines = new string[0];
            this.CategoryNameTB.Location = new System.Drawing.Point(71, 231);
            this.CategoryNameTB.MaxLength = 32767;
            this.CategoryNameTB.MinimumSize = new System.Drawing.Size(1, 1);
            this.CategoryNameTB.Modified = false;
            this.CategoryNameTB.Multiline = false;
            this.CategoryNameTB.Name = "CategoryNameTB";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CategoryNameTB.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.CategoryNameTB.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CategoryNameTB.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Crimson;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CategoryNameTB.OnIdleState = stateProperties4;
            this.CategoryNameTB.Padding = new System.Windows.Forms.Padding(3);
            this.CategoryNameTB.PasswordChar = '\0';
            this.CategoryNameTB.PlaceholderForeColor = System.Drawing.Color.Crimson;
            this.CategoryNameTB.PlaceholderText = "Category Name";
            this.CategoryNameTB.ReadOnly = false;
            this.CategoryNameTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CategoryNameTB.SelectedText = "";
            this.CategoryNameTB.SelectionLength = 0;
            this.CategoryNameTB.SelectionStart = 0;
            this.CategoryNameTB.ShortcutsEnabled = true;
            this.CategoryNameTB.Size = new System.Drawing.Size(336, 47);
            this.CategoryNameTB.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.CategoryNameTB.TabIndex = 23;
            this.CategoryNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CategoryNameTB.TextMarginBottom = 0;
            this.CategoryNameTB.TextMarginLeft = 3;
            this.CategoryNameTB.TextMarginTop = 1;
            this.CategoryNameTB.TextPlaceholder = "Category Name";
            this.CategoryNameTB.UseSystemPasswordChar = false;
            this.CategoryNameTB.WordWrap = true;
            // 
            // CategoryIdTB
            // 
            this.CategoryIdTB.AcceptsReturn = false;
            this.CategoryIdTB.AcceptsTab = false;
            this.CategoryIdTB.AnimationSpeed = 200;
            this.CategoryIdTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CategoryIdTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CategoryIdTB.AutoSizeHeight = true;
            this.CategoryIdTB.BackColor = System.Drawing.Color.White;
            this.CategoryIdTB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CategoryIdTB.BackgroundImage")));
            this.CategoryIdTB.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.CategoryIdTB.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CategoryIdTB.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CategoryIdTB.BorderColorIdle = System.Drawing.Color.Silver;
            this.CategoryIdTB.BorderRadius = 1;
            this.CategoryIdTB.BorderThickness = 1;
            this.CategoryIdTB.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.CategoryIdTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CategoryIdTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CategoryIdTB.DefaultFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CategoryIdTB.DefaultText = "";
            this.CategoryIdTB.FillColor = System.Drawing.Color.White;
            this.CategoryIdTB.ForeColor = System.Drawing.Color.Crimson;
            this.CategoryIdTB.HideSelection = true;
            this.CategoryIdTB.IconLeft = null;
            this.CategoryIdTB.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.CategoryIdTB.IconPadding = 10;
            this.CategoryIdTB.IconRight = null;
            this.CategoryIdTB.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.CategoryIdTB.Lines = new string[0];
            this.CategoryIdTB.Location = new System.Drawing.Point(71, 178);
            this.CategoryIdTB.MaxLength = 32767;
            this.CategoryIdTB.MinimumSize = new System.Drawing.Size(1, 1);
            this.CategoryIdTB.Modified = false;
            this.CategoryIdTB.Multiline = false;
            this.CategoryIdTB.Name = "CategoryIdTB";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CategoryIdTB.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.CategoryIdTB.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CategoryIdTB.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Crimson;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CategoryIdTB.OnIdleState = stateProperties8;
            this.CategoryIdTB.Padding = new System.Windows.Forms.Padding(3);
            this.CategoryIdTB.PasswordChar = '\0';
            this.CategoryIdTB.PlaceholderForeColor = System.Drawing.Color.Crimson;
            this.CategoryIdTB.PlaceholderText = "Category Id";
            this.CategoryIdTB.ReadOnly = false;
            this.CategoryIdTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CategoryIdTB.SelectedText = "";
            this.CategoryIdTB.SelectionLength = 0;
            this.CategoryIdTB.SelectionStart = 0;
            this.CategoryIdTB.ShortcutsEnabled = true;
            this.CategoryIdTB.Size = new System.Drawing.Size(336, 47);
            this.CategoryIdTB.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.CategoryIdTB.TabIndex = 22;
            this.CategoryIdTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CategoryIdTB.TextMarginBottom = 0;
            this.CategoryIdTB.TextMarginLeft = 3;
            this.CategoryIdTB.TextMarginTop = 1;
            this.CategoryIdTB.TextPlaceholder = "Category Id";
            this.CategoryIdTB.UseSystemPasswordChar = false;
            this.CategoryIdTB.WordWrap = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 659);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1243, 100);
            this.panel2.TabIndex = 31;
            // 
            // ManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 759);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_categories_list);
            this.Controls.Add(this.categoriesGV);
            this.Controls.Add(this.category_home_button);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_add_category);
            this.Controls.Add(this.CategoryNameTB);
            this.Controls.Add(this.CategoryIdTB);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCategories";
            this.Load += new System.EventHandler(this.ManageCategories_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_categories_list;
        private Guna.UI2.WinForms.Guna2DataGridView categoriesGV;
        private System.Windows.Forms.Button category_home_button;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_add_category;
        private Bunifu.UI.WinForms.BunifuTextBox CategoryNameTB;
        private Bunifu.UI.WinForms.BunifuTextBox CategoryIdTB;
        private System.Windows.Forms.Panel panel2;
    }
}