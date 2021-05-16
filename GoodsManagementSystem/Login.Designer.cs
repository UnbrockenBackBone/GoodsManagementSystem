
namespace GoodsManagementSystem
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PasswordTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.UnameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add = new Guna.UI2.WinForms.Guna2Button();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 106);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(57, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(647, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "Система управління товарами";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ShowPassword);
            this.panel2.Controls.Add(this.Add);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.PasswordTb);
            this.panel2.Controls.Add(this.UnameTb);
            this.panel2.Location = new System.Drawing.Point(168, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 337);
            this.panel2.TabIndex = 3;
            // 
            // PasswordTb
            // 
            this.PasswordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTb.DefaultText = "";
            this.PasswordTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTb.DisabledState.Parent = this.PasswordTb;
            this.PasswordTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTb.FocusedState.Parent = this.PasswordTb;
            this.PasswordTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTb.HoverState.Parent = this.PasswordTb;
            this.PasswordTb.Location = new System.Drawing.Point(130, 167);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.PasswordChar = '*';
            this.PasswordTb.PlaceholderText = "PasswordTb";
            this.PasswordTb.SelectedText = "";
            this.PasswordTb.ShadowDecoration.Parent = this.PasswordTb;
            this.PasswordTb.Size = new System.Drawing.Size(179, 36);
            this.PasswordTb.TabIndex = 5;
            // 
            // UnameTb
            // 
            this.UnameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UnameTb.DefaultText = "";
            this.UnameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UnameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UnameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UnameTb.DisabledState.Parent = this.UnameTb;
            this.UnameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UnameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UnameTb.FocusedState.Parent = this.UnameTb;
            this.UnameTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UnameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UnameTb.HoverState.Parent = this.UnameTb;
            this.UnameTb.Location = new System.Drawing.Point(130, 83);
            this.UnameTb.Name = "UnameTb";
            this.UnameTb.PasswordChar = '\0';
            this.UnameTb.PlaceholderText = "UserName";
            this.UnameTb.SelectedText = "";
            this.UnameTb.ShadowDecoration.Parent = this.UnameTb;
            this.UnameTb.Size = new System.Drawing.Size(179, 36);
            this.UnameTb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(162, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вхід";
            // 
            // Add
            // 
            this.Add.CheckedState.Parent = this.Add;
            this.Add.CustomImages.Parent = this.Add;
            this.Add.FillColor = System.Drawing.Color.MidnightBlue;
            this.Add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.HoverState.Parent = this.Add;
            this.Add.Location = new System.Drawing.Point(130, 238);
            this.Add.Name = "Add";
            this.Add.ShadowDecoration.Parent = this.Add;
            this.Add.Size = new System.Drawing.Size(179, 39);
            this.Add.TabIndex = 7;
            this.Add.Text = "Додати";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Location = new System.Drawing.Point(279, 302);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(144, 21);
            this.ShowPassword.TabIndex = 8;
            this.ShowPassword.Text = "Показати пароль";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(126, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Очистити";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 505);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Вхід";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTb;
        private Guna.UI2.WinForms.Guna2TextBox UnameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ShowPassword;
        private Guna.UI2.WinForms.Guna2Button Add;
    }
}

