﻿
namespace GoodsManagementSystem
{
    partial class ViewOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrders));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.OrdersGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ViewOrder = new Guna.UI2.WinForms.Guna2Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 123);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(312, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Замовлення";
            // 
            // OrdersGV
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.OrdersGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.OrdersGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersGV.BackgroundColor = System.Drawing.Color.White;
            this.OrdersGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrdersGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrdersGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.OrdersGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrdersGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.OrdersGV.EnableHeadersVisualStyles = false;
            this.OrdersGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrdersGV.Location = new System.Drawing.Point(63, 193);
            this.OrdersGV.Name = "OrdersGV";
            this.OrdersGV.RowHeadersVisible = false;
            this.OrdersGV.RowHeadersWidth = 51;
            this.OrdersGV.RowTemplate.Height = 30;
            this.OrdersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersGV.Size = new System.Drawing.Size(803, 289);
            this.OrdersGV.TabIndex = 28;
            this.OrdersGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.OrdersGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.OrdersGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.OrdersGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.OrdersGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.OrdersGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.OrdersGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.OrdersGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrdersGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.OrdersGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrdersGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.OrdersGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.OrdersGV.ThemeStyle.HeaderStyle.Height = 25;
            this.OrdersGV.ThemeStyle.ReadOnly = false;
            this.OrdersGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.OrdersGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrdersGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.OrdersGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OrdersGV.ThemeStyle.RowsStyle.Height = 30;
            this.OrdersGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrdersGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OrdersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersGV_CellContentClick);
            // 
            // ViewOrder
            // 
            this.ViewOrder.CheckedState.Parent = this.ViewOrder;
            this.ViewOrder.CustomImages.Parent = this.ViewOrder;
            this.ViewOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ViewOrder.ForeColor = System.Drawing.Color.White;
            this.ViewOrder.HoverState.Parent = this.ViewOrder;
            this.ViewOrder.Location = new System.Drawing.Point(400, 503);
            this.ViewOrder.Name = "ViewOrder";
            this.ViewOrder.ShadowDecoration.Parent = this.ViewOrder;
            this.ViewOrder.Size = new System.Drawing.Size(130, 30);
            this.ViewOrder.TabIndex = 36;
            this.ViewOrder.Text = "Back";
            this.ViewOrder.Click += new System.EventHandler(this.ViewOrder_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 545);
            this.Controls.Add(this.ViewOrder);
            this.Controls.Add(this.OrdersGV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewOrders";
            this.Text = "ViewOrders";
            this.Load += new System.EventHandler(this.ViewOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView OrdersGV;
        private Guna.UI2.WinForms.Guna2Button ViewOrder;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}