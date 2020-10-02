namespace Opp
{
    partial class Form3
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
            this.textUmonto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textUestatus = new System.Windows.Forms.ComboBox();
            this.textUid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegisterUser = new System.Windows.Forms.Button();
            this.textUemail = new System.Windows.Forms.TextBox();
            this.textUtel = new System.Windows.Forms.TextBox();
            this.textUdireccion = new System.Windows.Forms.TextBox();
            this.textUname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textUmonto
            // 
            this.textUmonto.Location = new System.Drawing.Point(379, 180);
            this.textUmonto.Name = "textUmonto";
            this.textUmonto.Size = new System.Drawing.Size(100, 20);
            this.textUmonto.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 26);
            this.label8.TabIndex = 31;
            this.label8.Text = "  Pago Mensual\r\n(Para facturación)";
            // 
            // textUestatus
            // 
            this.textUestatus.FormattingEnabled = true;
            this.textUestatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.textUestatus.Location = new System.Drawing.Point(140, 216);
            this.textUestatus.Name = "textUestatus";
            this.textUestatus.Size = new System.Drawing.Size(100, 21);
            this.textUestatus.TabIndex = 7;
            // 
            // textUid
            // 
            this.textUid.Location = new System.Drawing.Point(140, 89);
            this.textUid.Name = "textUid";
            this.textUid.Size = new System.Drawing.Size(100, 20);
            this.textUid.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "ID";
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.Location = new System.Drawing.Point(404, 261);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterUser.TabIndex = 8;
            this.btnRegisterUser.Text = "Registrar";
            this.btnRegisterUser.UseVisualStyleBackColor = true;
            this.btnRegisterUser.Click += new System.EventHandler(this.btnRegisterUser_Click);
            // 
            // textUemail
            // 
            this.textUemail.Location = new System.Drawing.Point(379, 133);
            this.textUemail.Name = "textUemail";
            this.textUemail.Size = new System.Drawing.Size(100, 20);
            this.textUemail.TabIndex = 4;
            // 
            // textUtel
            // 
            this.textUtel.Location = new System.Drawing.Point(140, 177);
            this.textUtel.Name = "textUtel";
            this.textUtel.Size = new System.Drawing.Size(100, 20);
            this.textUtel.TabIndex = 5;
            // 
            // textUdireccion
            // 
            this.textUdireccion.Location = new System.Drawing.Point(379, 86);
            this.textUdireccion.Name = "textUdireccion";
            this.textUdireccion.Size = new System.Drawing.Size(100, 20);
            this.textUdireccion.TabIndex = 2;
            // 
            // textUname
            // 
            this.textUname.Location = new System.Drawing.Point(140, 133);
            this.textUname.Name = "textUname";
            this.textUname.Size = new System.Drawing.Size(100, 20);
            this.textUname.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Estatus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Crear Usuario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(529, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textUmonto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textUestatus);
            this.Controls.Add(this.textUid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRegisterUser);
            this.Controls.Add(this.textUemail);
            this.Controls.Add(this.textUtel);
            this.Controls.Add(this.textUdireccion);
            this.Controls.Add(this.textUname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUmonto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox textUestatus;
        private System.Windows.Forms.TextBox textUid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegisterUser;
        private System.Windows.Forms.TextBox textUemail;
        private System.Windows.Forms.TextBox textUtel;
        private System.Windows.Forms.TextBox textUdireccion;
        private System.Windows.Forms.TextBox textUname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}