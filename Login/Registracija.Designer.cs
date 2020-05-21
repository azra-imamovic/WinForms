using System;
using System.ComponentModel;

namespace Login
{
    partial class Registracija
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
            System.Windows.Forms.Label labelLastName;
            System.Windows.Forms.Label labelName;
            System.Windows.Forms.Label labelUsername;
            System.Windows.Forms.Label txtPassword;
            System.Windows.Forms.Label lblspol;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registracija));
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbDodajSliku = new System.Windows.Forms.PictureBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.ofdUcitajSliku = new System.Windows.Forms.OpenFileDialog();
            this.cmbSpol = new System.Windows.Forms.ComboBox();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            labelLastName = new System.Windows.Forms.Label();
            labelName = new System.Windows.Forms.Label();
            labelUsername = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.Label();
            lblspol = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDodajSliku)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            labelLastName.Location = new System.Drawing.Point(192, 53);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new System.Drawing.Size(96, 20);
            labelLastName.TabIndex = 8;
            labelLastName.Text = "Last Name:";
        
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            labelName.Location = new System.Drawing.Point(192, 13);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(58, 20);
            labelName.TabIndex = 7;
            labelName.Text = "Name:";
           
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            labelUsername.Location = new System.Drawing.Point(192, 124);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new System.Drawing.Size(91, 20);
            labelUsername.TabIndex = 10;
            labelUsername.Text = "Username:";
            
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            txtPassword.Location = new System.Drawing.Point(192, 158);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(88, 20);
            txtPassword.TabIndex = 12;
            txtPassword.Text = "Password:";
            txtPassword.Click += new System.EventHandler(this.TxtPassword_Click);
            // 
            // lblspol
            // 
            lblspol.AutoSize = true;
            lblspol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            lblspol.Location = new System.Drawing.Point(192, 88);
            lblspol.Name = "lblspol";
            lblspol.Size = new System.Drawing.Size(74, 20);
            lblspol.TabIndex = 18;
            lblspol.Text = "Gender: ";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLastName.Location = new System.Drawing.Point(304, 50);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(274, 24);
            this.txtLastName.TabIndex = 6;
            this.txtLastName.TextChanged += new System.EventHandler(this.TxtLastName_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtName.Location = new System.Drawing.Point(304, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(274, 24);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUsername.Location = new System.Drawing.Point(304, 118);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(274, 24);
            this.txtUsername.TabIndex = 9;
           
            // 
            // txtLozinka
            // 
            this.txtLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLozinka.Location = new System.Drawing.Point(304, 154);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.ReadOnly = true;
            this.txtLozinka.Size = new System.Drawing.Size(225, 24);
            this.txtLozinka.TabIndex = 11;
            this.txtLozinka.TextChanged += new System.EventHandler(this.TxtLozinka_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(446, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 36);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(535, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pbDodajSliku
            // 
            this.pbDodajSliku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDodajSliku.Location = new System.Drawing.Point(13, 13);
            this.pbDodajSliku.Name = "pbDodajSliku";
            this.pbDodajSliku.Size = new System.Drawing.Size(163, 165);
            this.pbDodajSliku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDodajSliku.TabIndex = 15;
            this.pbDodajSliku.TabStop = false;
            this.pbDodajSliku.Click += new System.EventHandler(this.PbDodajSliku_Click);
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(12, 184);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(164, 36);
            this.btnDodajSliku.TabIndex = 16;
            this.btnDodajSliku.Text = "Load image";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.BtnDodajSliku_Click);
            // 
            // ofdUcitajSliku
            // 
            this.ofdUcitajSliku.FileName = "openFileDialog1";
            // 
            // cmbSpol
            // 
            this.cmbSpol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbSpol.FormattingEnabled = true;
            this.cmbSpol.Location = new System.Drawing.Point(304, 82);
            this.cmbSpol.Name = "cmbSpol";
            this.cmbSpol.Size = new System.Drawing.Size(274, 26);
            this.cmbSpol.TabIndex = 19;
            this.cmbSpol.SelectedIndexChanged += new System.EventHandler(this.CmbSpol_SelectedIndexChanged);
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbAdmin.Location = new System.Drawing.Point(298, 196);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(131, 24);
            this.cbAdmin.TabIndex = 20;
            this.cbAdmin.Text = "Administrator";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // Registracija
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 234);
            this.Controls.Add(this.cbAdmin);
            this.Controls.Add(this.cmbSpol);
            this.Controls.Add(lblspol);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.pbDodajSliku);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(txtPassword);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(labelUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(labelLastName);
            this.Controls.Add(labelName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Name = "Registracija";
            this.Text = "Regsitracija";
            this.Load += new System.EventHandler(this.Registracija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDodajSliku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.PictureBox pbDodajSliku;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog ofdUcitajSliku;
        private System.Windows.Forms.CheckBox cbAdmin;
        private System.Windows.Forms.ComboBox cmbSpol;
    }
}