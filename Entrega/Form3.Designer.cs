namespace Entrega
{
    partial class form_regisro
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
            System.Windows.Forms.TextBox tx_npass;
            this.btn_login = new System.Windows.Forms.Button();
            this.tx_username = new System.Windows.Forms.TextBox();
            this.lb_npass = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.tx_renpass = new System.Windows.Forms.TextBox();
            this.lb_renpass = new System.Windows.Forms.Label();
            tx_npass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_login.Location = new System.Drawing.Point(324, 311);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(151, 52);
            this.btn_login.TabIndex = 19;
            this.btn_login.Text = "Ingresar";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // tx_npass
            // 
            tx_npass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            tx_npass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tx_npass.Location = new System.Drawing.Point(324, 146);
            tx_npass.Multiline = true;
            tx_npass.Name = "tx_npass";
            tx_npass.Size = new System.Drawing.Size(364, 30);
            tx_npass.TabIndex = 17;
            // 
            // tx_username
            // 
            this.tx_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.tx_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_username.Location = new System.Drawing.Point(324, 96);
            this.tx_username.Multiline = true;
            this.tx_username.Name = "tx_username";
            this.tx_username.Size = new System.Drawing.Size(364, 30);
            this.tx_username.TabIndex = 16;
            // 
            // lb_npass
            // 
            this.lb_npass.AutoSize = true;
            this.lb_npass.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_npass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lb_npass.Location = new System.Drawing.Point(200, 139);
            this.lb_npass.Name = "lb_npass";
            this.lb_npass.Size = new System.Drawing.Size(84, 37);
            this.lb_npass.TabIndex = 15;
            this.lb_npass.Text = "Clave";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lb_username.Location = new System.Drawing.Point(27, 96);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(257, 37);
            this.lb_username.TabIndex = 14;
            this.lb_username.Text = "Nombre de usuario";
            this.lb_username.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 45);
            this.btn_back.TabIndex = 21;
            this.btn_back.Text = "←";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.button5_Click);
            // 
            // tx_renpass
            // 
            this.tx_renpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.tx_renpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_renpass.Location = new System.Drawing.Point(324, 193);
            this.tx_renpass.Multiline = true;
            this.tx_renpass.Name = "tx_renpass";
            this.tx_renpass.Size = new System.Drawing.Size(364, 30);
            this.tx_renpass.TabIndex = 23;
            // 
            // lb_renpass
            // 
            this.lb_renpass.AutoSize = true;
            this.lb_renpass.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_renpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lb_renpass.Location = new System.Drawing.Point(104, 186);
            this.lb_renpass.Name = "lb_renpass";
            this.lb_renpass.Size = new System.Drawing.Size(180, 37);
            this.lb_renpass.TabIndex = 22;
            this.lb_renpass.Text = "Repetir clave";
            // 
            // form_regisro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tx_renpass);
            this.Controls.Add(this.lb_renpass);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(tx_npass);
            this.Controls.Add(this.tx_username);
            this.Controls.Add(this.lb_npass);
            this.Controls.Add(this.lb_username);
            this.Name = "form_regisro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tx_username;
        private System.Windows.Forms.Label lb_npass;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox tx_renpass;
        private System.Windows.Forms.Label lb_renpass;
    }
}