namespace Entrega
{
    partial class Form4
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
            this.btn_singup = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.lk_fotpass = new System.Windows.Forms.LinkLabel();
            this.tx_pass = new System.Windows.Forms.TextBox();
            this.tx_user = new System.Windows.Forms.TextBox();
            this.lb_pass = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_singup
            // 
            this.btn_singup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_singup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btn_singup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_singup.Font = new System.Drawing.Font("Calibri", 18F);
            this.btn_singup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_singup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_singup.Location = new System.Drawing.Point(394, 352);
            this.btn_singup.Name = "btn_singup";
            this.btn_singup.Size = new System.Drawing.Size(161, 52);
            this.btn_singup.TabIndex = 20;
            this.btn_singup.Text = "Registrar";
            this.btn_singup.UseVisualStyleBackColor = false;
            this.btn_singup.Click += new System.EventHandler(this.btn_singup_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Calibri", 18F);
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_login.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_login.Location = new System.Drawing.Point(163, 352);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(151, 52);
            this.btn_login.TabIndex = 19;
            this.btn_login.Text = "Ingresar";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lk_fotpass
            // 
            this.lk_fotpass.AutoSize = true;
            this.lk_fotpass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lk_fotpass.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lk_fotpass.Location = new System.Drawing.Point(614, 404);
            this.lk_fotpass.Name = "lk_fotpass";
            this.lk_fotpass.Size = new System.Drawing.Size(133, 16);
            this.lk_fotpass.TabIndex = 18;
            this.lk_fotpass.TabStop = true;
            this.lk_fotpass.Text = "Olvido su contraseña";
            // 
            // tx_pass
            // 
            this.tx_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.tx_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_pass.Location = new System.Drawing.Point(211, 279);
            this.tx_pass.Multiline = true;
            this.tx_pass.Name = "tx_pass";
            this.tx_pass.Size = new System.Drawing.Size(364, 30);
            this.tx_pass.TabIndex = 17;
            // 
            // tx_user
            // 
            this.tx_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.tx_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_user.Location = new System.Drawing.Point(211, 217);
            this.tx_user.Multiline = true;
            this.tx_user.Name = "tx_user";
            this.tx_user.Size = new System.Drawing.Size(364, 30);
            this.tx_user.TabIndex = 16;
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold);
            this.lb_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lb_pass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_pass.Location = new System.Drawing.Point(102, 264);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(103, 45);
            this.lb_pass.TabIndex = 15;
            this.lb_pass.Text = "Clave";
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold);
            this.lb_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lb_user.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_user.Location = new System.Drawing.Point(66, 202);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(139, 45);
            this.lb_user.TabIndex = 14;
            this.lb_user.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 64.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(189, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 132);
            this.label1.TabIndex = 21;
            this.label1.Text = "MathIA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_singup);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lk_fotpass);
            this.Controls.Add(this.tx_pass);
            this.Controls.Add(this.tx_user);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.lb_user);
            this.Name = "Form4";
            this.Text = "Inicio de sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_singup;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.LinkLabel lk_fotpass;
        private System.Windows.Forms.TextBox tx_pass;
        private System.Windows.Forms.TextBox tx_user;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label label1;
    }
}