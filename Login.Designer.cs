namespace assignment2
    {
    partial class Login
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.usernameTitle = new System.Windows.Forms.Label();
            this.passwordTitle = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(67, 246);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(175, 45);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_click);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(267, 142);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(218, 30);
            this.username.TabIndex = 1;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(267, 191);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(218, 30);
            this.password.TabIndex = 2;
            this.password.UseSystemPasswordChar = true;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(267, 246);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(175, 45);
            this.createBtn.TabIndex = 4;
            this.createBtn.Text = "Create a new User";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(473, 246);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(175, 45);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_click);
            // 
            // usernameTitle
            // 
            this.usernameTitle.AutoSize = true;
            this.usernameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTitle.Location = new System.Drawing.Point(103, 142);
            this.usernameTitle.Name = "usernameTitle";
            this.usernameTitle.Size = new System.Drawing.Size(139, 29);
            this.usernameTitle.TabIndex = 6;
            this.usernameTitle.Text = "Username:";
            // 
            // passwordTitle
            // 
            this.passwordTitle.AutoSize = true;
            this.passwordTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTitle.Location = new System.Drawing.Point(103, 191);
            this.passwordTitle.Name = "passwordTitle";
            this.passwordTitle.Size = new System.Drawing.Size(135, 29);
            this.passwordTitle.TabIndex = 7;
            this.passwordTitle.Text = "Password:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(60, 74);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(618, 37);
            this.labelTitle.TabIndex = 9;
            this.labelTitle.Text = "Welcome to the simple editor program!";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 390);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.passwordTitle);
            this.Controls.Add(this.usernameTitle);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.loginBtn);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label usernameTitle;
        private System.Windows.Forms.Label passwordTitle;
        private System.Windows.Forms.Label labelTitle;
        }
    }

