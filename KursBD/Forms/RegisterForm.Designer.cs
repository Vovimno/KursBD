namespace KursBD
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.CloseButton = new System.Windows.Forms.Label();
            this.LoginCancelbutton = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordRegisterField = new System.Windows.Forms.TextBox();
            this.RegisterField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanelRegister = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordConfirmField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainPanelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CloseButton.Location = new System.Drawing.Point(779, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(18, 20);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click_1);
            // 
            // LoginCancelbutton
            // 
            this.LoginCancelbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginCancelbutton.FlatAppearance.BorderSize = 0;
            this.LoginCancelbutton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.LoginCancelbutton.Location = new System.Drawing.Point(413, 339);
            this.LoginCancelbutton.Name = "LoginCancelbutton";
            this.LoginCancelbutton.Size = new System.Drawing.Size(122, 29);
            this.LoginCancelbutton.TabIndex = 7;
            this.LoginCancelbutton.Text = "CANCEL";
            this.LoginCancelbutton.UseVisualStyleBackColor = false;
            this.LoginCancelbutton.Click += new System.EventHandler(this.LoginCancelbutton_Click_1);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonRegister.Location = new System.Drawing.Point(248, 339);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(122, 29);
            this.buttonRegister.TabIndex = 6;
            this.buttonRegister.Text = "REGISTRATION";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(194, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(218, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login";
            // 
            // PasswordRegisterField
            // 
            this.PasswordRegisterField.Location = new System.Drawing.Point(270, 214);
            this.PasswordRegisterField.Name = "PasswordRegisterField";
            this.PasswordRegisterField.Size = new System.Drawing.Size(265, 27);
            this.PasswordRegisterField.TabIndex = 9;
            this.PasswordRegisterField.UseSystemPasswordChar = true;
            this.PasswordRegisterField.Enter += new System.EventHandler(this.PasswordRegisterField_Enter);
            this.PasswordRegisterField.Leave += new System.EventHandler(this.PasswordRegisterField_Leave);
            // 
            // RegisterField
            // 
            this.RegisterField.Location = new System.Drawing.Point(270, 141);
            this.RegisterField.Name = "RegisterField";
            this.RegisterField.Size = new System.Drawing.Size(265, 27);
            this.RegisterField.TabIndex = 2;
            this.RegisterField.Enter += new System.EventHandler(this.RegisterField_Enter);
            this.RegisterField.Leave += new System.EventHandler(this.RegisterField_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(118, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Не Стим";
            // 
            // mainPanelRegister
            // 
            this.mainPanelRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.mainPanelRegister.Controls.Add(this.label5);
            this.mainPanelRegister.Controls.Add(this.label4);
            this.mainPanelRegister.Controls.Add(this.PasswordConfirmField);
            this.mainPanelRegister.Controls.Add(this.CloseButton);
            this.mainPanelRegister.Controls.Add(this.LoginCancelbutton);
            this.mainPanelRegister.Controls.Add(this.buttonRegister);
            this.mainPanelRegister.Controls.Add(this.label3);
            this.mainPanelRegister.Controls.Add(this.label2);
            this.mainPanelRegister.Controls.Add(this.PasswordRegisterField);
            this.mainPanelRegister.Controls.Add(this.RegisterField);
            this.mainPanelRegister.Controls.Add(this.pictureBox1);
            this.mainPanelRegister.Controls.Add(this.label1);
            this.mainPanelRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelRegister.Location = new System.Drawing.Point(0, 0);
            this.mainPanelRegister.Name = "mainPanelRegister";
            this.mainPanelRegister.Size = new System.Drawing.Size(800, 450);
            this.mainPanelRegister.TabIndex = 1;
            this.mainPanelRegister.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanelRegister_MouseDown);
            this.mainPanelRegister.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanelRegister_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label5.Location = new System.Drawing.Point(346, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Регистрация";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(102, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Confirm your password";
            // 
            // PasswordConfirmField
            // 
            this.PasswordConfirmField.Location = new System.Drawing.Point(270, 263);
            this.PasswordConfirmField.Name = "PasswordConfirmField";
            this.PasswordConfirmField.Size = new System.Drawing.Size(265, 27);
            this.PasswordConfirmField.TabIndex = 9;
            this.PasswordConfirmField.UseSystemPasswordChar = true;
            this.PasswordConfirmField.Enter += new System.EventHandler(this.PasswordConfirmField_Enter);
            this.PasswordConfirmField.Leave += new System.EventHandler(this.PasswordConfirmField_Leave);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanelRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainPanelRegister.ResumeLayout(false);
            this.mainPanelRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label CloseButton;
        private Button LoginCancelbutton;
        private Button buttonRegister;
        private Label label3;
        private Label label2;
        private TextBox PasswordRegisterField;
        private TextBox RegisterField;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel mainPanelRegister;
        private Label label4;
        private TextBox PasswordConfirmField;
        private Label label5;
    }
}