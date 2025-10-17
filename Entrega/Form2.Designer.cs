namespace Entrega
{
    partial class form_interfaz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_interfaz));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_intback = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pl_intertop = new System.Windows.Forms.Panel();
            this.tx_search = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.pic_search = new System.Windows.Forms.PictureBox();
            this.pl_interight = new System.Windows.Forms.Panel();
            this.bt_cs = new System.Windows.Forms.Button();
            this.bt_user = new System.Windows.Forms.Button();
            this.bt_ase = new System.Windows.Forms.Button();
            this.dgv_ser = new System.Windows.Forms.DataGridView();
            this.prom1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prom2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prom3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_new = new System.Windows.Forms.Button();
            this.bt_exp = new System.Windows.Forms.Button();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.pl_intertop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).BeginInit();
            this.pl_interight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ser)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_intback
            // 
            this.btn_intback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btn_intback.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btn_intback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_intback.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_intback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_intback.Location = new System.Drawing.Point(12, 29);
            this.btn_intback.Name = "btn_intback";
            this.btn_intback.Size = new System.Drawing.Size(75, 45);
            this.btn_intback.TabIndex = 22;
            this.btn_intback.Text = "←";
            this.btn_intback.UseVisualStyleBackColor = false;
            this.btn_intback.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Dr Stone 1.jpg");
            // 
            // pl_intertop
            // 
            this.pl_intertop.Controls.Add(this.tx_search);
            this.pl_intertop.Controls.Add(this.btn_back);
            this.pl_intertop.Controls.Add(this.pic_search);
            this.pl_intertop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_intertop.Location = new System.Drawing.Point(0, 0);
            this.pl_intertop.Name = "pl_intertop";
            this.pl_intertop.Size = new System.Drawing.Size(979, 74);
            this.pl_intertop.TabIndex = 23;
            this.pl_intertop.Paint += new System.Windows.Forms.PaintEventHandler(this.pl_intertop_Paint);
            // 
            // tx_search
            // 
            this.tx_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.tx_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_search.Location = new System.Drawing.Point(269, 27);
            this.tx_search.Multiline = true;
            this.tx_search.Name = "tx_search";
            this.tx_search.Size = new System.Drawing.Size(478, 30);
            this.tx_search.TabIndex = 32;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 45);
            this.btn_back.TabIndex = 33;
            this.btn_back.Text = "←";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pic_search
            // 
            this.pic_search.Image = global::Entrega.Properties.Resources.wlupa;
            this.pic_search.Location = new System.Drawing.Point(213, 19);
            this.pic_search.Name = "pic_search";
            this.pic_search.Size = new System.Drawing.Size(35, 38);
            this.pic_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_search.TabIndex = 31;
            this.pic_search.TabStop = false;
            this.pic_search.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pl_interight
            // 
            this.pl_interight.Controls.Add(this.bt_cs);
            this.pl_interight.Controls.Add(this.bt_user);
            this.pl_interight.Controls.Add(this.bt_ase);
            this.pl_interight.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_interight.Location = new System.Drawing.Point(0, 74);
            this.pl_interight.Name = "pl_interight";
            this.pl_interight.Size = new System.Drawing.Size(200, 478);
            this.pl_interight.TabIndex = 24;
            // 
            // bt_cs
            // 
            this.bt_cs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.bt_cs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.bt_cs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.bt_cs.Location = new System.Drawing.Point(41, 324);
            this.bt_cs.Name = "bt_cs";
            this.bt_cs.Size = new System.Drawing.Size(116, 58);
            this.bt_cs.TabIndex = 27;
            this.bt_cs.Text = "Consultas";
            this.bt_cs.UseVisualStyleBackColor = false;
            this.bt_cs.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_user
            // 
            this.bt_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.bt_user.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.bt_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.bt_user.Location = new System.Drawing.Point(41, 211);
            this.bt_user.Name = "bt_user";
            this.bt_user.Size = new System.Drawing.Size(116, 58);
            this.bt_user.TabIndex = 26;
            this.bt_user.Text = "Usuarios";
            this.bt_user.UseVisualStyleBackColor = false;
            this.bt_user.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_ase
            // 
            this.bt_ase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.bt_ase.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.bt_ase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.bt_ase.Location = new System.Drawing.Point(41, 99);
            this.bt_ase.Name = "bt_ase";
            this.bt_ase.Size = new System.Drawing.Size(116, 58);
            this.bt_ase.TabIndex = 25;
            this.bt_ase.Text = "Asesorias";
            this.bt_ase.UseVisualStyleBackColor = false;
            this.bt_ase.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dgv_ser
            // 
            this.dgv_ser.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgv_ser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ser.ColumnHeadersHeight = 29;
            this.dgv_ser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prom1,
            this.prom2,
            this.prom3,
            this.datos});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ser.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.dgv_ser.Location = new System.Drawing.Point(230, 136);
            this.dgv_ser.Name = "dgv_ser";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ser.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ser.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ser.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ser.RowTemplate.Height = 24;
            this.dgv_ser.Size = new System.Drawing.Size(555, 381);
            this.dgv_ser.TabIndex = 25;
            this.dgv_ser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // prom1
            // 
            this.prom1.HeaderText = "Consultas";
            this.prom1.MinimumWidth = 6;
            this.prom1.Name = "prom1";
            this.prom1.Width = 125;
            // 
            // prom2
            // 
            this.prom2.HeaderText = "Asesoria";
            this.prom2.MinimumWidth = 6;
            this.prom2.Name = "prom2";
            this.prom2.Width = 125;
            // 
            // prom3
            // 
            this.prom3.HeaderText = "Usuarios";
            this.prom3.MinimumWidth = 6;
            this.prom3.Name = "prom3";
            this.prom3.Width = 125;
            // 
            // datos
            // 
            this.datos.HeaderText = "Reportes";
            this.datos.MinimumWidth = 6;
            this.datos.Name = "datos";
            this.datos.Width = 125;
            // 
            // bt_new
            // 
            this.bt_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.bt_new.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.bt_new.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.bt_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_new.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.bt_new.Location = new System.Drawing.Point(845, 398);
            this.bt_new.Name = "bt_new";
            this.bt_new.Size = new System.Drawing.Size(97, 58);
            this.bt_new.TabIndex = 30;
            this.bt_new.Text = "Crear";
            this.bt_new.UseVisualStyleBackColor = false;
            this.bt_new.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt_exp
            // 
            this.bt_exp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.bt_exp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.bt_exp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.bt_exp.Location = new System.Drawing.Point(845, 285);
            this.bt_exp.Name = "bt_exp";
            this.bt_exp.Size = new System.Drawing.Size(97, 58);
            this.bt_exp.TabIndex = 29;
            this.bt_exp.Text = "Exportar";
            this.bt_exp.UseVisualStyleBackColor = false;
            this.bt_exp.Click += new System.EventHandler(this.button5_Click_2);
            // 
            // bt_refresh
            // 
            this.bt_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.bt_refresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.bt_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.bt_refresh.Location = new System.Drawing.Point(845, 173);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(97, 58);
            this.bt_refresh.TabIndex = 28;
            this.bt_refresh.Text = "Actualizar";
            this.bt_refresh.UseVisualStyleBackColor = false;
            this.bt_refresh.Click += new System.EventHandler(this.button6_Click);
            // 
            // form_interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(979, 552);
            this.Controls.Add(this.bt_new);
            this.Controls.Add(this.bt_exp);
            this.Controls.Add(this.bt_refresh);
            this.Controls.Add(this.dgv_ser);
            this.Controls.Add(this.pl_interight);
            this.Controls.Add(this.pl_intertop);
            this.Controls.Add(this.btn_intback);
            this.Name = "form_interfaz";
            this.Text = "Interfaz";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pl_intertop.ResumeLayout(false);
            this.pl_intertop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).EndInit();
            this.pl_interight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_intback;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pl_intertop;
        private System.Windows.Forms.Panel pl_interight;
        private System.Windows.Forms.Button bt_user;
        private System.Windows.Forms.Button bt_ase;
        private System.Windows.Forms.Button bt_cs;
        private System.Windows.Forms.DataGridView dgv_ser;
        private System.Windows.Forms.DataGridViewTextBoxColumn prom1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prom2;
        private System.Windows.Forms.DataGridViewTextBoxColumn prom3;
        private System.Windows.Forms.DataGridViewTextBoxColumn datos;
        private System.Windows.Forms.PictureBox pic_search;
        private System.Windows.Forms.Button bt_new;
        private System.Windows.Forms.Button bt_exp;
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.TextBox tx_search;
        private System.Windows.Forms.Button btn_back;
    }
}