namespace Winforms_Class_Example
{
    partial class AppForm
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
            this.LoginView = new System.Windows.Forms.Panel();
            this.LoginViewUserLabel = new System.Windows.Forms.Label();
            this.LoginViewPasswordLabel = new System.Windows.Forms.Label();
            this.LoginViewTitleLabel = new System.Windows.Forms.Label();
            this.LoginViewUserInput = new System.Windows.Forms.TextBox();
            this.LoginViewPasswordInput = new System.Windows.Forms.TextBox();
            this.LoginViewInvalidPasswordLabel = new System.Windows.Forms.Label();
            this.LoginViewLoginButton = new System.Windows.Forms.Button();
            this.ProfileView = new System.Windows.Forms.Panel();
            this.ProfileViewUserNameLabel = new System.Windows.Forms.Label();
            this.ProfileViewUserAgeLabel = new System.Windows.Forms.Label();
            this.ProfileViewUserNameInput = new System.Windows.Forms.Label();
            this.ProfileViewUserAgeInput = new System.Windows.Forms.Label();
            this.ProfileViewLogoutButton = new System.Windows.Forms.Button();
            this.LoginView.SuspendLayout();
            this.ProfileView.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginView
            // 
            this.LoginView.Controls.Add(this.LoginViewLoginButton);
            this.LoginView.Controls.Add(this.LoginViewInvalidPasswordLabel);
            this.LoginView.Controls.Add(this.LoginViewPasswordInput);
            this.LoginView.Controls.Add(this.LoginViewUserInput);
            this.LoginView.Controls.Add(this.LoginViewTitleLabel);
            this.LoginView.Controls.Add(this.LoginViewPasswordLabel);
            this.LoginView.Controls.Add(this.LoginViewUserLabel);
            this.LoginView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginView.Location = new System.Drawing.Point(0, 0);
            this.LoginView.Name = "LoginView";
            this.LoginView.Size = new System.Drawing.Size(292, 262);
            this.LoginView.TabIndex = 0;
            // 
            // LoginViewUserLabel
            // 
            this.LoginViewUserLabel.AutoSize = true;
            this.LoginViewUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoginViewUserLabel.Location = new System.Drawing.Point(45, 108);
            this.LoginViewUserLabel.Name = "LoginViewUserLabel";
            this.LoginViewUserLabel.Size = new System.Drawing.Size(64, 20);
            this.LoginViewUserLabel.TabIndex = 0;
            this.LoginViewUserLabel.Text = "Usuario";
            // 
            // LoginViewPasswordLabel
            // 
            this.LoginViewPasswordLabel.AutoSize = true;
            this.LoginViewPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoginViewPasswordLabel.Location = new System.Drawing.Point(45, 147);
            this.LoginViewPasswordLabel.Name = "LoginViewPasswordLabel";
            this.LoginViewPasswordLabel.Size = new System.Drawing.Size(92, 20);
            this.LoginViewPasswordLabel.TabIndex = 1;
            this.LoginViewPasswordLabel.Text = "Contraseña";
            // 
            // LoginViewTitleLabel
            // 
            this.LoginViewTitleLabel.AutoSize = true;
            this.LoginViewTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.LoginViewTitleLabel.Location = new System.Drawing.Point(52, 41);
            this.LoginViewTitleLabel.Name = "LoginViewTitleLabel";
            this.LoginViewTitleLabel.Size = new System.Drawing.Size(182, 37);
            this.LoginViewTitleLabel.TabIndex = 2;
            this.LoginViewTitleLabel.Text = "Bienvenido!";
            // 
            // LoginViewUserInput
            // 
            this.LoginViewUserInput.Location = new System.Drawing.Point(143, 108);
            this.LoginViewUserInput.Name = "LoginViewUserInput";
            this.LoginViewUserInput.Size = new System.Drawing.Size(100, 20);
            this.LoginViewUserInput.TabIndex = 3;
            // 
            // LoginViewPasswordInput
            // 
            this.LoginViewPasswordInput.Location = new System.Drawing.Point(143, 147);
            this.LoginViewPasswordInput.Name = "LoginViewPasswordInput";
            this.LoginViewPasswordInput.PasswordChar = '*';
            this.LoginViewPasswordInput.Size = new System.Drawing.Size(100, 20);
            this.LoginViewPasswordInput.TabIndex = 4;
            // 
            // LoginViewInvalidPasswordLabel
            // 
            this.LoginViewInvalidPasswordLabel.AutoSize = true;
            this.LoginViewInvalidPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LoginViewInvalidPasswordLabel.Location = new System.Drawing.Point(140, 170);
            this.LoginViewInvalidPasswordLabel.Name = "LoginViewInvalidPasswordLabel";
            this.LoginViewInvalidPasswordLabel.Size = new System.Drawing.Size(113, 13);
            this.LoginViewInvalidPasswordLabel.TabIndex = 5;
            this.LoginViewInvalidPasswordLabel.Text = "Credenciales Invalidas";
            this.LoginViewInvalidPasswordLabel.Visible = false;
            // 
            // LoginViewLoginButton
            // 
            this.LoginViewLoginButton.Location = new System.Drawing.Point(98, 204);
            this.LoginViewLoginButton.Name = "LoginViewLoginButton";
            this.LoginViewLoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginViewLoginButton.TabIndex = 6;
            this.LoginViewLoginButton.Text = "Login";
            this.LoginViewLoginButton.UseVisualStyleBackColor = true;
            this.LoginViewLoginButton.Click += new System.EventHandler(this.LoginViewLoginButton_Click);
            // 
            // ProfileView
            // 
            this.ProfileView.Controls.Add(this.ProfileViewLogoutButton);
            this.ProfileView.Controls.Add(this.ProfileViewUserAgeInput);
            this.ProfileView.Controls.Add(this.ProfileViewUserNameInput);
            this.ProfileView.Controls.Add(this.ProfileViewUserAgeLabel);
            this.ProfileView.Controls.Add(this.ProfileViewUserNameLabel);
            this.ProfileView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfileView.Location = new System.Drawing.Point(0, 0);
            this.ProfileView.Name = "ProfileView";
            this.ProfileView.Size = new System.Drawing.Size(292, 262);
            this.ProfileView.TabIndex = 1;
            // 
            // ProfileViewUserNameLabel
            // 
            this.ProfileViewUserNameLabel.AutoSize = true;
            this.ProfileViewUserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProfileViewUserNameLabel.Location = new System.Drawing.Point(42, 42);
            this.ProfileViewUserNameLabel.Name = "ProfileViewUserNameLabel";
            this.ProfileViewUserNameLabel.Size = new System.Drawing.Size(69, 20);
            this.ProfileViewUserNameLabel.TabIndex = 0;
            this.ProfileViewUserNameLabel.Text = "Nombre:";
            // 
            // ProfileViewUserAgeLabel
            // 
            this.ProfileViewUserAgeLabel.AutoSize = true;
            this.ProfileViewUserAgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProfileViewUserAgeLabel.Location = new System.Drawing.Point(60, 81);
            this.ProfileViewUserAgeLabel.Name = "ProfileViewUserAgeLabel";
            this.ProfileViewUserAgeLabel.Size = new System.Drawing.Size(51, 20);
            this.ProfileViewUserAgeLabel.TabIndex = 1;
            this.ProfileViewUserAgeLabel.Text = "Edad:";
            // 
            // ProfileViewUserNameInput
            // 
            this.ProfileViewUserNameInput.AutoSize = true;
            this.ProfileViewUserNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProfileViewUserNameInput.Location = new System.Drawing.Point(117, 42);
            this.ProfileViewUserNameInput.Name = "ProfileViewUserNameInput";
            this.ProfileViewUserNameInput.Size = new System.Drawing.Size(89, 20);
            this.ProfileViewUserNameInput.TabIndex = 2;
            this.ProfileViewUserNameInput.Text = "User Name";
            // 
            // ProfileViewUserAgeInput
            // 
            this.ProfileViewUserAgeInput.AutoSize = true;
            this.ProfileViewUserAgeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProfileViewUserAgeInput.Location = new System.Drawing.Point(117, 81);
            this.ProfileViewUserAgeInput.Name = "ProfileViewUserAgeInput";
            this.ProfileViewUserAgeInput.Size = new System.Drawing.Size(27, 20);
            this.ProfileViewUserAgeInput.TabIndex = 3;
            this.ProfileViewUserAgeInput.Text = "99";
            // 
            // ProfileViewLogoutButton
            // 
            this.ProfileViewLogoutButton.Location = new System.Drawing.Point(98, 134);
            this.ProfileViewLogoutButton.Name = "ProfileViewLogoutButton";
            this.ProfileViewLogoutButton.Size = new System.Drawing.Size(75, 23);
            this.ProfileViewLogoutButton.TabIndex = 4;
            this.ProfileViewLogoutButton.Text = "Logout";
            this.ProfileViewLogoutButton.UseVisualStyleBackColor = true;
            this.ProfileViewLogoutButton.Click += new System.EventHandler(this.ProfileViewLogoutButton_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.ProfileView);
            this.Controls.Add(this.LoginView);
            this.Name = "AppForm";
            this.Text = "AppForm";
            this.LoginView.ResumeLayout(false);
            this.LoginView.PerformLayout();
            this.ProfileView.ResumeLayout(false);
            this.ProfileView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginView;
        private System.Windows.Forms.Label LoginViewTitleLabel;
        private System.Windows.Forms.Label LoginViewPasswordLabel;
        private System.Windows.Forms.Label LoginViewUserLabel;
        private System.Windows.Forms.TextBox LoginViewPasswordInput;
        private System.Windows.Forms.TextBox LoginViewUserInput;
        private System.Windows.Forms.Button LoginViewLoginButton;
        private System.Windows.Forms.Label LoginViewInvalidPasswordLabel;
        private System.Windows.Forms.Panel ProfileView;
        private System.Windows.Forms.Label ProfileViewUserAgeInput;
        private System.Windows.Forms.Label ProfileViewUserNameInput;
        private System.Windows.Forms.Label ProfileViewUserAgeLabel;
        private System.Windows.Forms.Label ProfileViewUserNameLabel;
        private System.Windows.Forms.Button ProfileViewLogoutButton;
    }
}