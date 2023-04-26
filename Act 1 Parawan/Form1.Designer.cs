namespace AppDevActOnePar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelOneBtn = new System.Windows.Forms.Button();
            this.panelTwoBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputTwoData = new System.Windows.Forms.TextBox();
            this.inputOneData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userControl21 = new AppDevActOnePar.UserControl2();
            this.userControl11 = new AppDevActOnePar.UserControl1();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelTwoBtn);
            this.panel1.Controls.Add(this.panelOneBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 376);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.inputTwoData);
            this.panel2.Controls.Add(this.inputOneData);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(558, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 376);
            this.panel2.TabIndex = 1;
            // 
            // panelOneBtn
            // 
            this.panelOneBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelOneBtn.Location = new System.Drawing.Point(32, 82);
            this.panelOneBtn.Name = "panelOneBtn";
            this.panelOneBtn.Size = new System.Drawing.Size(95, 32);
            this.panelOneBtn.TabIndex = 0;
            this.panelOneBtn.Text = "Panel One";
            this.panelOneBtn.UseVisualStyleBackColor = true;
            this.panelOneBtn.Click += new System.EventHandler(this.panelOneBtn_Click);
            // 
            // panelTwoBtn
            // 
            this.panelTwoBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTwoBtn.Location = new System.Drawing.Point(32, 166);
            this.panelTwoBtn.Name = "panelTwoBtn";
            this.panelTwoBtn.Size = new System.Drawing.Size(95, 32);
            this.panelTwoBtn.TabIndex = 1;
            this.panelTwoBtn.Text = "Panel Two";
            this.panelTwoBtn.UseVisualStyleBackColor = true;
            this.panelTwoBtn.Click += new System.EventHandler(this.panelTwoBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Panel Control Application";
            // 
            // inputTwoData
            // 
            this.inputTwoData.Location = new System.Drawing.Point(19, 208);
            this.inputTwoData.Name = "inputTwoData";
            this.inputTwoData.Size = new System.Drawing.Size(147, 20);
            this.inputTwoData.TabIndex = 8;
            this.inputTwoData.TextChanged += new System.EventHandler(this.inputTwoData_TextChanged);
            // 
            // inputOneData
            // 
            this.inputOneData.Location = new System.Drawing.Point(19, 119);
            this.inputOneData.Name = "inputOneData";
            this.inputOneData.Size = new System.Drawing.Size(147, 20);
            this.inputOneData.TabIndex = 7;
            this.inputOneData.TextChanged += new System.EventHandler(this.inputOneData_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Input Two";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Input One";
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.userControl21.Location = new System.Drawing.Point(151, 55);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(406, 309);
            this.userControl21.TabIndex = 4;
            this.userControl21.Load += new System.EventHandler(this.userControl21_Load);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl11.Location = new System.Drawing.Point(151, 55);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(406, 309);
            this.userControl11.TabIndex = 2;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 376);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Parawan Panel";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private UserControl1 userControl11;
        private System.Windows.Forms.Button panelTwoBtn;
        private System.Windows.Forms.Button panelOneBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputTwoData;
        private System.Windows.Forms.TextBox inputOneData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private UserControl2 userControl21;
    }
}

