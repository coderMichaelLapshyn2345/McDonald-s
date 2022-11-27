namespace McDonald_s
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.BurgerBtn = new System.Windows.Forms.ToolStripButton();
            this.NuggetsBtn = new System.Windows.Forms.ToolStripButton();
            this.McCafeBtn = new System.Windows.Forms.ToolStripButton();
            this.DessertsBtn = new System.Windows.Forms.ToolStripButton();
            this.DrinksBtn = new System.Windows.Forms.ToolStripButton();
            this.LINQSearchBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CancelOrderBtn = new System.Windows.Forms.Button();
            this.CheckOrderBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Price1 = new System.Windows.Forms.Label();
            this.Price2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.BurgerBtn,
            this.NuggetsBtn,
            this.McCafeBtn,
            this.DessertsBtn,
            this.DrinksBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(253, 863);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(250, 40);
            this.toolStripLabel1.Text = "Меню";
            // 
            // BurgerBtn
            // 
            this.BurgerBtn.AutoSize = false;
            this.BurgerBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BurgerBtn.Image = ((System.Drawing.Image)(resources.GetObject("BurgerBtn.Image")));
            this.BurgerBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BurgerBtn.Name = "BurgerBtn";
            this.BurgerBtn.Size = new System.Drawing.Size(250, 50);
            this.BurgerBtn.Text = "Бургери ";
            this.BurgerBtn.Click += new System.EventHandler(this.BurgerBtn_Click);
            // 
            // NuggetsBtn
            // 
            this.NuggetsBtn.AutoSize = false;
            this.NuggetsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.NuggetsBtn.Image = ((System.Drawing.Image)(resources.GetObject("NuggetsBtn.Image")));
            this.NuggetsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuggetsBtn.Name = "NuggetsBtn";
            this.NuggetsBtn.Size = new System.Drawing.Size(250, 50);
            this.NuggetsBtn.Text = "Наггетси";
            this.NuggetsBtn.Click += new System.EventHandler(this.NuggetsBtn_Click);
            // 
            // McCafeBtn
            // 
            this.McCafeBtn.AutoSize = false;
            this.McCafeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.McCafeBtn.Image = ((System.Drawing.Image)(resources.GetObject("McCafeBtn.Image")));
            this.McCafeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.McCafeBtn.Name = "McCafeBtn";
            this.McCafeBtn.Size = new System.Drawing.Size(250, 50);
            this.McCafeBtn.Text = "McCafe";
            this.McCafeBtn.Click += new System.EventHandler(this.McCafeBtn_Click);
            // 
            // DessertsBtn
            // 
            this.DessertsBtn.AutoSize = false;
            this.DessertsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DessertsBtn.Image = ((System.Drawing.Image)(resources.GetObject("DessertsBtn.Image")));
            this.DessertsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DessertsBtn.Name = "DessertsBtn";
            this.DessertsBtn.Size = new System.Drawing.Size(250, 50);
            this.DessertsBtn.Text = "Десерти ";
            this.DessertsBtn.Click += new System.EventHandler(this.DessertsBtn_Click);
            // 
            // DrinksBtn
            // 
            this.DrinksBtn.AutoSize = false;
            this.DrinksBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DrinksBtn.Image = ((System.Drawing.Image)(resources.GetObject("DrinksBtn.Image")));
            this.DrinksBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrinksBtn.Name = "DrinksBtn";
            this.DrinksBtn.Size = new System.Drawing.Size(250, 50);
            this.DrinksBtn.Text = "Напої";
            this.DrinksBtn.Click += new System.EventHandler(this.DrinksBtn_Click);
            // 
            // LINQSearchBtn
            // 
            this.LINQSearchBtn.Location = new System.Drawing.Point(1004, 4);
            this.LINQSearchBtn.Name = "LINQSearchBtn";
            this.LINQSearchBtn.Size = new System.Drawing.Size(299, 46);
            this.LINQSearchBtn.TabIndex = 2;
            this.LINQSearchBtn.Text = "Пошук";
            this.LINQSearchBtn.UseVisualStyleBackColor = true;
            this.LINQSearchBtn.Click += new System.EventHandler(this.LINQSearchBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Найдешевший товар в каталозі",
            "Найдорожчий товар в каталозі"});
            this.comboBox1.Location = new System.Drawing.Point(442, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(501, 26);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Оберіть критерій пошуку із запропонованих списком";
            // 
            // CancelOrderBtn
            // 
            this.CancelOrderBtn.Location = new System.Drawing.Point(276, 751);
            this.CancelOrderBtn.Name = "CancelOrderBtn";
            this.CancelOrderBtn.Size = new System.Drawing.Size(433, 87);
            this.CancelOrderBtn.TabIndex = 4;
            this.CancelOrderBtn.Text = "Відмінити замовлення ";
            this.CancelOrderBtn.UseVisualStyleBackColor = true;
            this.CancelOrderBtn.Click += new System.EventHandler(this.CancelOrderBtn_Click);
            // 
            // CheckOrderBtn
            // 
            this.CheckOrderBtn.BackColor = System.Drawing.Color.Yellow;
            this.CheckOrderBtn.Location = new System.Drawing.Point(1004, 751);
            this.CheckOrderBtn.Name = "CheckOrderBtn";
            this.CheckOrderBtn.Size = new System.Drawing.Size(388, 87);
            this.CheckOrderBtn.TabIndex = 5;
            this.CheckOrderBtn.Text = "Переглянути замовлення";
            this.CheckOrderBtn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(999, 686);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 36);
            this.label5.TabIndex = 6;
            this.label5.Text = "Всього:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceLabel
            // 
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.Location = new System.Drawing.Point(1180, 690);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(85, 34);
            this.PriceLabel.TabIndex = 7;
            this.PriceLabel.Text = "0.00";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1292, 686);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 36);
            this.label6.TabIndex = 8;
            this.label6.Text = "₴";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Price2);
            this.panel1.Controls.Add(this.Price1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(296, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 558);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(34, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(378, 415);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(603, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(365, 415);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Price1
            // 
            this.Price1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price1.Location = new System.Drawing.Point(215, 473);
            this.Price1.Name = "Price1";
            this.Price1.Size = new System.Drawing.Size(142, 35);
            this.Price1.TabIndex = 2;
            this.Price1.Text = "label1";
            // 
            // Price2
            // 
            this.Price2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price2.Location = new System.Drawing.Point(774, 473);
            this.Price2.Name = "Price2";
            this.Price2.Size = new System.Drawing.Size(143, 38);
            this.Price2.TabIndex = 3;
            this.Price2.Text = "label2";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(363, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "₴";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(917, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "₴";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 863);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CheckOrderBtn);
            this.Controls.Add(this.CancelOrderBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LINQSearchBtn);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton BurgerBtn;
        private System.Windows.Forms.ToolStripButton NuggetsBtn;
        private System.Windows.Forms.ToolStripButton McCafeBtn;
        private System.Windows.Forms.ToolStripButton DessertsBtn;
        private System.Windows.Forms.ToolStripButton DrinksBtn;
        private System.Windows.Forms.Button LINQSearchBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button CancelOrderBtn;
        private System.Windows.Forms.Button CheckOrderBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Price2;
        private System.Windows.Forms.Label Price1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}