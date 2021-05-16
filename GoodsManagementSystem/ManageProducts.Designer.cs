
namespace GoodsManagementSystem
{
    partial class ManageProducts
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProPriceTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProdQtTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProdNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProdIdTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProdDescTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.CatCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Home = new Guna.UI2.WinForms.Guna2Button();
            this.Delete = new Guna.UI2.WinForms.Guna2Button();
            this.Edit = new Guna.UI2.WinForms.Guna2Button();
            this.Add = new Guna.UI2.WinForms.Guna2Button();
            this.ProductsGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SearchCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Search = new Guna.UI2.WinForms.Guna2Button();
            this.Refresh = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 123);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(240, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(647, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "Система управління товарами";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(361, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Управління товарами";
            // 
            // ProPriceTb
            // 
            this.ProPriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProPriceTb.DefaultText = "";
            this.ProPriceTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProPriceTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProPriceTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProPriceTb.DisabledState.Parent = this.ProPriceTb;
            this.ProPriceTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProPriceTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProPriceTb.FocusedState.Parent = this.ProPriceTb;
            this.ProPriceTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProPriceTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProPriceTb.HoverState.Parent = this.ProPriceTb;
            this.ProPriceTb.Location = new System.Drawing.Point(24, 313);
            this.ProPriceTb.Name = "ProPriceTb";
            this.ProPriceTb.PasswordChar = '\0';
            this.ProPriceTb.PlaceholderText = "ProductPrice";
            this.ProPriceTb.SelectedText = "";
            this.ProPriceTb.ShadowDecoration.Parent = this.ProPriceTb;
            this.ProPriceTb.Size = new System.Drawing.Size(179, 36);
            this.ProPriceTb.TabIndex = 9;
            // 
            // ProdQtTb
            // 
            this.ProdQtTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdQtTb.DefaultText = "";
            this.ProdQtTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProdQtTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProdQtTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdQtTb.DisabledState.Parent = this.ProdQtTb;
            this.ProdQtTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdQtTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdQtTb.FocusedState.Parent = this.ProdQtTb;
            this.ProdQtTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProdQtTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdQtTb.HoverState.Parent = this.ProdQtTb;
            this.ProdQtTb.Location = new System.Drawing.Point(24, 255);
            this.ProdQtTb.Name = "ProdQtTb";
            this.ProdQtTb.PasswordChar = '\0';
            this.ProdQtTb.PlaceholderText = "ProductQty";
            this.ProdQtTb.SelectedText = "";
            this.ProdQtTb.ShadowDecoration.Parent = this.ProdQtTb;
            this.ProdQtTb.Size = new System.Drawing.Size(179, 36);
            this.ProdQtTb.TabIndex = 8;
            // 
            // ProdNameTb
            // 
            this.ProdNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdNameTb.DefaultText = "";
            this.ProdNameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProdNameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProdNameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdNameTb.DisabledState.Parent = this.ProdNameTb;
            this.ProdNameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdNameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdNameTb.FocusedState.Parent = this.ProdNameTb;
            this.ProdNameTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProdNameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdNameTb.HoverState.Parent = this.ProdNameTb;
            this.ProdNameTb.Location = new System.Drawing.Point(24, 199);
            this.ProdNameTb.Name = "ProdNameTb";
            this.ProdNameTb.PasswordChar = '\0';
            this.ProdNameTb.PlaceholderText = "ProductName";
            this.ProdNameTb.SelectedText = "";
            this.ProdNameTb.ShadowDecoration.Parent = this.ProdNameTb;
            this.ProdNameTb.Size = new System.Drawing.Size(179, 36);
            this.ProdNameTb.TabIndex = 7;
            // 
            // ProdIdTb
            // 
            this.ProdIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdIdTb.DefaultText = "";
            this.ProdIdTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProdIdTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProdIdTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdIdTb.DisabledState.Parent = this.ProdIdTb;
            this.ProdIdTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdIdTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdIdTb.FocusedState.Parent = this.ProdIdTb;
            this.ProdIdTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProdIdTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdIdTb.HoverState.Parent = this.ProdIdTb;
            this.ProdIdTb.Location = new System.Drawing.Point(24, 145);
            this.ProdIdTb.Name = "ProdIdTb";
            this.ProdIdTb.PasswordChar = '\0';
            this.ProdIdTb.PlaceholderText = "ProductId";
            this.ProdIdTb.SelectedText = "";
            this.ProdIdTb.ShadowDecoration.Parent = this.ProdIdTb;
            this.ProdIdTb.Size = new System.Drawing.Size(179, 36);
            this.ProdIdTb.TabIndex = 6;
            // 
            // ProdDescTb
            // 
            this.ProdDescTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdDescTb.DefaultText = "";
            this.ProdDescTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProdDescTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProdDescTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdDescTb.DisabledState.Parent = this.ProdDescTb;
            this.ProdDescTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdDescTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdDescTb.FocusedState.Parent = this.ProdDescTb;
            this.ProdDescTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProdDescTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdDescTb.HoverState.Parent = this.ProdDescTb;
            this.ProdDescTb.Location = new System.Drawing.Point(24, 370);
            this.ProdDescTb.Name = "ProdDescTb";
            this.ProdDescTb.PasswordChar = '\0';
            this.ProdDescTb.PlaceholderText = "Description";
            this.ProdDescTb.SelectedText = "";
            this.ProdDescTb.ShadowDecoration.Parent = this.ProdDescTb;
            this.ProdDescTb.Size = new System.Drawing.Size(179, 36);
            this.ProdDescTb.TabIndex = 10;
            // 
            // CatCombo
            // 
            this.CatCombo.BackColor = System.Drawing.Color.Transparent;
            this.CatCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CatCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CatCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CatCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CatCombo.FocusedState.Parent = this.CatCombo;
            this.CatCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CatCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CatCombo.HoverState.Parent = this.CatCombo;
            this.CatCombo.ItemHeight = 30;
            this.CatCombo.ItemsAppearance.Parent = this.CatCombo;
            this.CatCombo.Location = new System.Drawing.Point(24, 431);
            this.CatCombo.Name = "CatCombo";
            this.CatCombo.ShadowDecoration.Parent = this.CatCombo;
            this.CatCombo.Size = new System.Drawing.Size(179, 36);
            this.CatCombo.TabIndex = 11;
            // 
            // Home
            // 
            this.Home.CheckedState.Parent = this.Home;
            this.Home.CustomImages.Parent = this.Home;
            this.Home.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.HoverState.Parent = this.Home;
            this.Home.Location = new System.Drawing.Point(142, 536);
            this.Home.Name = "Home";
            this.Home.ShadowDecoration.Parent = this.Home;
            this.Home.Size = new System.Drawing.Size(95, 30);
            this.Home.TabIndex = 20;
            this.Home.Text = "Головна";
            // 
            // Delete
            // 
            this.Delete.CheckedState.Parent = this.Delete;
            this.Delete.CustomImages.Parent = this.Delete;
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.HoverState.Parent = this.Delete;
            this.Delete.Location = new System.Drawing.Point(24, 536);
            this.Delete.Name = "Delete";
            this.Delete.ShadowDecoration.Parent = this.Delete;
            this.Delete.Size = new System.Drawing.Size(112, 30);
            this.Delete.TabIndex = 19;
            this.Delete.Text = "Видалити";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.CheckedState.Parent = this.Edit;
            this.Edit.CustomImages.Parent = this.Edit;
            this.Edit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Edit.ForeColor = System.Drawing.Color.White;
            this.Edit.HoverState.Parent = this.Edit;
            this.Edit.Location = new System.Drawing.Point(142, 488);
            this.Edit.Name = "Edit";
            this.Edit.ShadowDecoration.Parent = this.Edit;
            this.Edit.Size = new System.Drawing.Size(95, 30);
            this.Edit.TabIndex = 18;
            this.Edit.Text = "Змінити";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.CheckedState.Parent = this.Add;
            this.Add.CustomImages.Parent = this.Add;
            this.Add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.HoverState.Parent = this.Add;
            this.Add.Location = new System.Drawing.Point(24, 488);
            this.Add.Name = "Add";
            this.Add.ShadowDecoration.Parent = this.Add;
            this.Add.Size = new System.Drawing.Size(112, 30);
            this.Add.TabIndex = 17;
            this.Add.Text = "Додати";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ProductsGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ProductsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsGV.BackgroundColor = System.Drawing.Color.White;
            this.ProductsGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductsGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductsGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductsGV.EnableHeadersVisualStyles = false;
            this.ProductsGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductsGV.Location = new System.Drawing.Point(249, 199);
            this.ProductsGV.Name = "ProductsGV";
            this.ProductsGV.RowHeadersVisible = false;
            this.ProductsGV.RowHeadersWidth = 51;
            this.ProductsGV.RowTemplate.Height = 30;
            this.ProductsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsGV.Size = new System.Drawing.Size(820, 395);
            this.ProductsGV.TabIndex = 21;
            this.ProductsGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ProductsGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductsGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProductsGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProductsGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProductsGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProductsGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProductsGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductsGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.ProductsGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductsGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductsGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProductsGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductsGV.ThemeStyle.HeaderStyle.Height = 25;
            this.ProductsGV.ThemeStyle.ReadOnly = false;
            this.ProductsGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductsGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductsGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProductsGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductsGV.ThemeStyle.RowsStyle.Height = 30;
            this.ProductsGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductsGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGV_CellContentClick);
            // 
            // SearchCombo
            // 
            this.SearchCombo.BackColor = System.Drawing.Color.Transparent;
            this.SearchCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SearchCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchCombo.FocusedState.Parent = this.SearchCombo;
            this.SearchCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SearchCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SearchCombo.HoverState.Parent = this.SearchCombo;
            this.SearchCombo.ItemHeight = 30;
            this.SearchCombo.ItemsAppearance.Parent = this.SearchCombo;
            this.SearchCombo.Location = new System.Drawing.Point(558, 145);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.ShadowDecoration.Parent = this.SearchCombo;
            this.SearchCombo.Size = new System.Drawing.Size(179, 36);
            this.SearchCombo.TabIndex = 22;
            this.SearchCombo.SelectedIndexChanged += new System.EventHandler(this.SearchCombo_SelectedIndexChanged);
            // 
            // Search
            // 
            this.Search.CheckedState.Parent = this.Search;
            this.Search.CustomImages.Parent = this.Search;
            this.Search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.HoverState.Parent = this.Search;
            this.Search.Location = new System.Drawing.Point(743, 145);
            this.Search.Name = "Search";
            this.Search.ShadowDecoration.Parent = this.Search;
            this.Search.Size = new System.Drawing.Size(95, 36);
            this.Search.TabIndex = 23;
            this.Search.Text = "Шукати";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Refresh
            // 
            this.Refresh.CheckedState.Parent = this.Refresh;
            this.Refresh.CustomImages.Parent = this.Refresh;
            this.Refresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Refresh.ForeColor = System.Drawing.Color.White;
            this.Refresh.HoverState.Parent = this.Refresh;
            this.Refresh.Location = new System.Drawing.Point(844, 145);
            this.Refresh.Name = "Refresh";
            this.Refresh.ShadowDecoration.Parent = this.Refresh;
            this.Refresh.Size = new System.Drawing.Size(102, 36);
            this.Refresh.TabIndex = 24;
            this.Refresh.Text = "Обновити";
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 631);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchCombo);
            this.Controls.Add(this.ProductsGV);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.CatCombo);
            this.Controls.Add(this.ProdDescTb);
            this.Controls.Add(this.ProPriceTb);
            this.Controls.Add(this.ProdQtTb);
            this.Controls.Add(this.ProdNameTb);
            this.Controls.Add(this.ProdIdTb);
            this.Controls.Add(this.panel1);
            this.Name = "ManageProducts";
            this.Text = "Управління товарами";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox ProPriceTb;
        private Guna.UI2.WinForms.Guna2TextBox ProdQtTb;
        private Guna.UI2.WinForms.Guna2TextBox ProdNameTb;
        private Guna.UI2.WinForms.Guna2TextBox ProdIdTb;
        private Guna.UI2.WinForms.Guna2TextBox ProdDescTb;
        private Guna.UI2.WinForms.Guna2ComboBox CatCombo;
        private Guna.UI2.WinForms.Guna2Button Home;
        private Guna.UI2.WinForms.Guna2Button Delete;
        private Guna.UI2.WinForms.Guna2Button Edit;
        private Guna.UI2.WinForms.Guna2Button Add;
        private Guna.UI2.WinForms.Guna2DataGridView ProductsGV;
        private Guna.UI2.WinForms.Guna2ComboBox SearchCombo;
        private Guna.UI2.WinForms.Guna2Button Search;
        private Guna.UI2.WinForms.Guna2Button Refresh;
    }
}