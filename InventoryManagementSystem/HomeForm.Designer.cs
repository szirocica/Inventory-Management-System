namespace InventoryManagementSystem
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.categories_pictureBox = new System.Windows.Forms.PictureBox();
            this.home_upper_panel = new System.Windows.Forms.Panel();
            this.label_X = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_categories = new System.Windows.Forms.Label();
            this.users_label = new System.Windows.Forms.Label();
            this.users_pictureBox = new System.Windows.Forms.PictureBox();
            this.orders_label = new System.Windows.Forms.Label();
            this.orders_pictureBox = new System.Windows.Forms.PictureBox();
            this.products_label = new System.Windows.Forms.Label();
            this.products_pictureBox = new System.Windows.Forms.PictureBox();
            this.customers_label = new System.Windows.Forms.Label();
            this.customers_pictureBox = new System.Windows.Forms.PictureBox();
            this.logout_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categories_pictureBox)).BeginInit();
            this.home_upper_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customers_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 659);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1243, 100);
            this.panel2.TabIndex = 21;
            // 
            // categories_pictureBox
            // 
            this.categories_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("categories_pictureBox.Image")));
            this.categories_pictureBox.Location = new System.Drawing.Point(126, 252);
            this.categories_pictureBox.Name = "categories_pictureBox";
            this.categories_pictureBox.Size = new System.Drawing.Size(127, 118);
            this.categories_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.categories_pictureBox.TabIndex = 22;
            this.categories_pictureBox.TabStop = false;
            this.categories_pictureBox.Click += new System.EventHandler(this.categories_pictureBox_Click);
            // 
            // home_upper_panel
            // 
            this.home_upper_panel.BackColor = System.Drawing.Color.Transparent;
            this.home_upper_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home_upper_panel.BackgroundImage")));
            this.home_upper_panel.Controls.Add(this.label_X);
            this.home_upper_panel.Controls.Add(this.label2);
            this.home_upper_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.home_upper_panel.Location = new System.Drawing.Point(0, 0);
            this.home_upper_panel.Name = "home_upper_panel";
            this.home_upper_panel.Size = new System.Drawing.Size(1243, 172);
            this.home_upper_panel.TabIndex = 2;
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.BackColor = System.Drawing.Color.Transparent;
            this.label_X.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_X.ForeColor = System.Drawing.Color.Crimson;
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
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(232, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(799, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label_categories
            // 
            this.label_categories.AutoSize = true;
            this.label_categories.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_categories.ForeColor = System.Drawing.Color.White;
            this.label_categories.Location = new System.Drawing.Point(88, 196);
            this.label_categories.Name = "label_categories";
            this.label_categories.Size = new System.Drawing.Size(218, 40);
            this.label_categories.TabIndex = 23;
            this.label_categories.Text = "CATEGORIES";
            // 
            // users_label
            // 
            this.users_label.AutoSize = true;
            this.users_label.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.users_label.ForeColor = System.Drawing.Color.White;
            this.users_label.Location = new System.Drawing.Point(939, 196);
            this.users_label.Name = "users_label";
            this.users_label.Size = new System.Drawing.Size(108, 40);
            this.users_label.TabIndex = 25;
            this.users_label.Text = "USERS";
            // 
            // users_pictureBox
            // 
            this.users_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("users_pictureBox.Image")));
            this.users_pictureBox.Location = new System.Drawing.Point(932, 252);
            this.users_pictureBox.Name = "users_pictureBox";
            this.users_pictureBox.Size = new System.Drawing.Size(125, 118);
            this.users_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.users_pictureBox.TabIndex = 24;
            this.users_pictureBox.TabStop = false;
            this.users_pictureBox.Click += new System.EventHandler(this.users_pictureBox_Click);
            // 
            // orders_label
            // 
            this.orders_label.AutoSize = true;
            this.orders_label.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.orders_label.ForeColor = System.Drawing.Color.White;
            this.orders_label.Location = new System.Drawing.Point(925, 427);
            this.orders_label.Name = "orders_label";
            this.orders_label.Size = new System.Drawing.Size(145, 40);
            this.orders_label.TabIndex = 27;
            this.orders_label.Text = "ORDERS";
            // 
            // orders_pictureBox
            // 
            this.orders_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("orders_pictureBox.Image")));
            this.orders_pictureBox.Location = new System.Drawing.Point(932, 485);
            this.orders_pictureBox.Name = "orders_pictureBox";
            this.orders_pictureBox.Size = new System.Drawing.Size(125, 118);
            this.orders_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.orders_pictureBox.TabIndex = 26;
            this.orders_pictureBox.TabStop = false;
            this.orders_pictureBox.Click += new System.EventHandler(this.orders_pictureBox_Click);
            // 
            // products_label
            // 
            this.products_label.AutoSize = true;
            this.products_label.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.products_label.ForeColor = System.Drawing.Color.White;
            this.products_label.Location = new System.Drawing.Point(103, 413);
            this.products_label.Name = "products_label";
            this.products_label.Size = new System.Drawing.Size(188, 40);
            this.products_label.TabIndex = 29;
            this.products_label.Text = "PRODUCTS";
            // 
            // products_pictureBox
            // 
            this.products_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("products_pictureBox.Image")));
            this.products_pictureBox.Location = new System.Drawing.Point(128, 470);
            this.products_pictureBox.Name = "products_pictureBox";
            this.products_pictureBox.Size = new System.Drawing.Size(125, 118);
            this.products_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.products_pictureBox.TabIndex = 28;
            this.products_pictureBox.TabStop = false;
            this.products_pictureBox.Click += new System.EventHandler(this.products_pictureBox_Click);
            // 
            // customers_label
            // 
            this.customers_label.AutoSize = true;
            this.customers_label.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customers_label.ForeColor = System.Drawing.Color.White;
            this.customers_label.Location = new System.Drawing.Point(496, 311);
            this.customers_label.Name = "customers_label";
            this.customers_label.Size = new System.Drawing.Size(208, 40);
            this.customers_label.TabIndex = 31;
            this.customers_label.Text = "CUSTOMERS";
            // 
            // customers_pictureBox
            // 
            this.customers_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("customers_pictureBox.Image")));
            this.customers_pictureBox.Location = new System.Drawing.Point(535, 363);
            this.customers_pictureBox.Name = "customers_pictureBox";
            this.customers_pictureBox.Size = new System.Drawing.Size(125, 118);
            this.customers_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customers_pictureBox.TabIndex = 30;
            this.customers_pictureBox.TabStop = false;
            this.customers_pictureBox.Click += new System.EventHandler(this.customers_pictureBox_Click);
            // 
            // logout_button
            // 
            this.logout_button.BackColor = System.Drawing.Color.Crimson;
            this.logout_button.FlatAppearance.BorderSize = 0;
            this.logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_button.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logout_button.ForeColor = System.Drawing.Color.White;
            this.logout_button.Location = new System.Drawing.Point(503, 558);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(201, 45);
            this.logout_button.TabIndex = 32;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = false;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1243, 759);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.customers_label);
            this.Controls.Add(this.customers_pictureBox);
            this.Controls.Add(this.products_label);
            this.Controls.Add(this.products_pictureBox);
            this.Controls.Add(this.orders_label);
            this.Controls.Add(this.orders_pictureBox);
            this.Controls.Add(this.users_label);
            this.Controls.Add(this.users_pictureBox);
            this.Controls.Add(this.label_categories);
            this.Controls.Add(this.categories_pictureBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.home_upper_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categories_pictureBox)).EndInit();
            this.home_upper_panel.ResumeLayout(false);
            this.home_upper_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customers_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel home_upper_panel;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox categories_pictureBox;
        private System.Windows.Forms.Label label_categories;
        private System.Windows.Forms.Label users_label;
        private System.Windows.Forms.PictureBox users_pictureBox;
        private System.Windows.Forms.Label orders_label;
        private System.Windows.Forms.PictureBox orders_pictureBox;
        private System.Windows.Forms.Label products_label;
        private System.Windows.Forms.PictureBox products_pictureBox;
        private System.Windows.Forms.Label customers_label;
        private System.Windows.Forms.PictureBox customers_pictureBox;
        private System.Windows.Forms.Button logout_button;
    }
}