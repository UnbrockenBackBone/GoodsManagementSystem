
namespace GoodsManagementSystem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.X = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.GoodsBox = new System.Windows.Forms.PictureBox();
            this.CustomersBox = new System.Windows.Forms.PictureBox();
            this.CategoryBox = new System.Windows.Forms.PictureBox();
            this.UsersBox = new System.Windows.Forms.PictureBox();
            this.OrdersBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Add = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.X);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 123);
            this.panel1.TabIndex = 1;
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X.ForeColor = System.Drawing.Color.Red;
            this.X.Location = new System.Drawing.Point(1067, 0);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(31, 29);
            this.X.TabIndex = 2;
            this.X.Text = "X";
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(173, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(788, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "Система управління товарами";
            // 
            // Pan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Pan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Pan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Pan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Pan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Pan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Pan.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Pan.DefaultCellStyle = dataGridViewCellStyle3;
            this.Pan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pan.EnableHeadersVisualStyles = false;
            this.Pan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Pan.Location = new System.Drawing.Point(0, 123);
            this.Pan.Name = "Pan";
            this.Pan.RowHeadersVisible = false;
            this.Pan.RowHeadersWidth = 51;
            this.Pan.RowTemplate.Height = 30;
            this.Pan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Pan.Size = new System.Drawing.Size(1098, 413);
            this.Pan.TabIndex = 13;
            this.Pan.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.Pan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Pan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Pan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Pan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Pan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Pan.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Pan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.Pan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Pan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Pan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Pan.ThemeStyle.HeaderStyle.Height = 25;
            this.Pan.ThemeStyle.ReadOnly = false;
            this.Pan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Pan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Pan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Pan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Pan.ThemeStyle.RowsStyle.Height = 30;
            this.Pan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Pan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // GoodsBox
            // 
            this.GoodsBox.Image = ((System.Drawing.Image)(resources.GetObject("GoodsBox.Image")));
            this.GoodsBox.Location = new System.Drawing.Point(113, 232);
            this.GoodsBox.Name = "GoodsBox";
            this.GoodsBox.Size = new System.Drawing.Size(100, 80);
            this.GoodsBox.TabIndex = 14;
            this.GoodsBox.TabStop = false;
            this.GoodsBox.Click += new System.EventHandler(this.GoodsBox_Click);
            // 
            // CustomersBox
            // 
            this.CustomersBox.Image = ((System.Drawing.Image)(resources.GetObject("CustomersBox.Image")));
            this.CustomersBox.Location = new System.Drawing.Point(113, 426);
            this.CustomersBox.Name = "CustomersBox";
            this.CustomersBox.Size = new System.Drawing.Size(100, 80);
            this.CustomersBox.TabIndex = 15;
            this.CustomersBox.TabStop = false;
            this.CustomersBox.Click += new System.EventHandler(this.CustomersBox_Click);
            // 
            // CategoryBox
            // 
            this.CategoryBox.Image = ((System.Drawing.Image)(resources.GetObject("CategoryBox.Image")));
            this.CategoryBox.Location = new System.Drawing.Point(510, 328);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(100, 80);
            this.CategoryBox.TabIndex = 16;
            this.CategoryBox.TabStop = false;
            this.CategoryBox.Click += new System.EventHandler(this.CategoryBox_Click);
            // 
            // UsersBox
            // 
            this.UsersBox.Image = ((System.Drawing.Image)(resources.GetObject("UsersBox.Image")));
            this.UsersBox.Location = new System.Drawing.Point(883, 232);
            this.UsersBox.Name = "UsersBox";
            this.UsersBox.Size = new System.Drawing.Size(100, 80);
            this.UsersBox.TabIndex = 17;
            this.UsersBox.TabStop = false;
            this.UsersBox.Click += new System.EventHandler(this.UsersBox_Click);
            // 
            // OrdersBox
            // 
            this.OrdersBox.Image = ((System.Drawing.Image)(resources.GetObject("OrdersBox.Image")));
            this.OrdersBox.Location = new System.Drawing.Point(883, 426);
            this.OrdersBox.Name = "OrdersBox";
            this.OrdersBox.Size = new System.Drawing.Size(100, 80);
            this.OrdersBox.TabIndex = 18;
            this.OrdersBox.TabStop = false;
            this.OrdersBox.Click += new System.EventHandler(this.OrdersBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(95, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "Товари";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(95, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 39);
            this.label3.TabIndex = 20;
            this.label3.Text = "Покупці";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(474, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 39);
            this.label4.TabIndex = 21;
            this.label4.Text = "Категорії";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(811, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 39);
            this.label5.TabIndex = 22;
            this.label5.Text = "Користувачі";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(811, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 39);
            this.label6.TabIndex = 23;
            this.label6.Text = "Замовлення";
            // 
            // Add
            // 
            this.Add.CheckedState.Parent = this.Add;
            this.Add.CustomImages.Parent = this.Add;
            this.Add.FillColor = System.Drawing.Color.Navy;
            this.Add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.HoverState.Parent = this.Add;
            this.Add.Location = new System.Drawing.Point(510, 476);
            this.Add.Name = "Add";
            this.Add.ShadowDecoration.Parent = this.Add;
            this.Add.Size = new System.Drawing.Size(112, 30);
            this.Add.TabIndex = 24;
            this.Add.Text = "Вихід";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 536);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrdersBox);
            this.Controls.Add(this.UsersBox);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.CustomersBox);
            this.Controls.Add(this.GoodsBox);
            this.Controls.Add(this.Pan);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView Pan;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.PictureBox GoodsBox;
        private System.Windows.Forms.PictureBox CustomersBox;
        private System.Windows.Forms.PictureBox CategoryBox;
        private System.Windows.Forms.PictureBox UsersBox;
        private System.Windows.Forms.PictureBox OrdersBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button Add;
    }
}