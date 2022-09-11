
namespace maistoReceptai
{
    partial class RegistracijosLangas
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rgstrVardas = new System.Windows.Forms.TextBox();
            this.rgstrSlaptazodis = new System.Windows.Forms.TextBox();
            this.rgstrSlaptazodisPak = new System.Windows.Forms.TextBox();
            this.registerWindowRegister = new System.Windows.Forms.Button();
            this.registerWindowGrizti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(281, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Slapyvardis";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(281, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Slaptažodis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(192, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "Pakartoti slaptažodį";
            // 
            // rgstrVardas
            // 
            this.rgstrVardas.Location = new System.Drawing.Point(424, 105);
            this.rgstrVardas.Name = "rgstrVardas";
            this.rgstrVardas.Size = new System.Drawing.Size(145, 22);
            this.rgstrVardas.TabIndex = 4;
            this.rgstrVardas.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rgstrSlaptazodis
            // 
            this.rgstrSlaptazodis.Location = new System.Drawing.Point(424, 142);
            this.rgstrSlaptazodis.Name = "rgstrSlaptazodis";
            this.rgstrSlaptazodis.Size = new System.Drawing.Size(145, 22);
            this.rgstrSlaptazodis.TabIndex = 5;
            this.rgstrSlaptazodis.UseSystemPasswordChar = true;
            this.rgstrSlaptazodis.TextChanged += new System.EventHandler(this.rgstrSlaptazodis_TextChanged);
            // 
            // rgstrSlaptazodisPak
            // 
            this.rgstrSlaptazodisPak.Location = new System.Drawing.Point(424, 176);
            this.rgstrSlaptazodisPak.Name = "rgstrSlaptazodisPak";
            this.rgstrSlaptazodisPak.Size = new System.Drawing.Size(145, 22);
            this.rgstrSlaptazodisPak.TabIndex = 6;
            this.rgstrSlaptazodisPak.UseSystemPasswordChar = true;
            // 
            // registerWindowRegister
            // 
            this.registerWindowRegister.BackColor = System.Drawing.Color.CornflowerBlue;
            this.registerWindowRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.registerWindowRegister.ForeColor = System.Drawing.Color.White;
            this.registerWindowRegister.Location = new System.Drawing.Point(315, 242);
            this.registerWindowRegister.Name = "registerWindowRegister";
            this.registerWindowRegister.Size = new System.Drawing.Size(161, 51);
            this.registerWindowRegister.TabIndex = 7;
            this.registerWindowRegister.Text = "Registruotis";
            this.registerWindowRegister.UseVisualStyleBackColor = false;
            this.registerWindowRegister.Click += new System.EventHandler(this.registerWindowRegister_Click);
            // 
            // registerWindowGrizti
            // 
            this.registerWindowGrizti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.registerWindowGrizti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.registerWindowGrizti.ForeColor = System.Drawing.Color.White;
            this.registerWindowGrizti.Location = new System.Drawing.Point(302, 309);
            this.registerWindowGrizti.Name = "registerWindowGrizti";
            this.registerWindowGrizti.Size = new System.Drawing.Size(198, 129);
            this.registerWindowGrizti.TabIndex = 8;
            this.registerWindowGrizti.Text = "Grįžti į prisijungimo langą";
            this.registerWindowGrizti.UseVisualStyleBackColor = false;
            this.registerWindowGrizti.Click += new System.EventHandler(this.registerWindowGrizti_Click);
            // 
            // RegistracijosLangas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerWindowGrizti);
            this.Controls.Add(this.registerWindowRegister);
            this.Controls.Add(this.rgstrSlaptazodisPak);
            this.Controls.Add(this.rgstrSlaptazodis);
            this.Controls.Add(this.rgstrVardas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "RegistracijosLangas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registracijos langas";
            this.Load += new System.EventHandler(this.RegistracijosLangas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rgstrVardas;
        private System.Windows.Forms.TextBox rgstrSlaptazodis;
        private System.Windows.Forms.TextBox rgstrSlaptazodisPak;
        private System.Windows.Forms.Button registerWindowRegister;
        private System.Windows.Forms.Button registerWindowGrizti;
    }
}