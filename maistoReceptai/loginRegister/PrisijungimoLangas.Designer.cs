
namespace maistoReceptai
{
    partial class PrisijungimoLangas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrisijungimoLangas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prisijungVardas = new System.Windows.Forms.TextBox();
            this.prisijungSlaptazodis = new System.Windows.Forms.TextBox();
            this.prisijungPrisijungti = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.prisijungAdmin = new System.Windows.Forms.Button();
            this.loginExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(274, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Slapyvardis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(274, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Slaptažodis";
            // 
            // prisijungVardas
            // 
            this.prisijungVardas.Location = new System.Drawing.Point(442, 106);
            this.prisijungVardas.Name = "prisijungVardas";
            this.prisijungVardas.Size = new System.Drawing.Size(145, 22);
            this.prisijungVardas.TabIndex = 2;
            this.prisijungVardas.TextChanged += new System.EventHandler(this.prisijungVardas_TextChanged);
            // 
            // prisijungSlaptazodis
            // 
            this.prisijungSlaptazodis.Location = new System.Drawing.Point(442, 147);
            this.prisijungSlaptazodis.Name = "prisijungSlaptazodis";
            this.prisijungSlaptazodis.Size = new System.Drawing.Size(145, 22);
            this.prisijungSlaptazodis.TabIndex = 3;
            this.prisijungSlaptazodis.UseSystemPasswordChar = true;
            this.prisijungSlaptazodis.TextChanged += new System.EventHandler(this.prisijungSlaptazodis_TextChanged);
            // 
            // prisijungPrisijungti
            // 
            this.prisijungPrisijungti.BackColor = System.Drawing.Color.CornflowerBlue;
            this.prisijungPrisijungti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prisijungPrisijungti.ForeColor = System.Drawing.Color.White;
            this.prisijungPrisijungti.Location = new System.Drawing.Point(238, 199);
            this.prisijungPrisijungti.Name = "prisijungPrisijungti";
            this.prisijungPrisijungti.Size = new System.Drawing.Size(161, 72);
            this.prisijungPrisijungti.TabIndex = 4;
            this.prisijungPrisijungti.Text = "Vartotojo prisijungimas";
            this.prisijungPrisijungti.UseVisualStyleBackColor = false;
            this.prisijungPrisijungti.Click += new System.EventHandler(this.prisijungPrisijungti_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(325, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 128);
            this.button2.TabIndex = 5;
            this.button2.Text = "Neturi paskyros? Registruokis";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // prisijungAdmin
            // 
            this.prisijungAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.prisijungAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prisijungAdmin.ForeColor = System.Drawing.Color.White;
            this.prisijungAdmin.Location = new System.Drawing.Point(459, 199);
            this.prisijungAdmin.Name = "prisijungAdmin";
            this.prisijungAdmin.Size = new System.Drawing.Size(161, 72);
            this.prisijungAdmin.TabIndex = 6;
            this.prisijungAdmin.Text = "Admin prisijungimas";
            this.prisijungAdmin.UseVisualStyleBackColor = false;
            this.prisijungAdmin.Click += new System.EventHandler(this.prisijungAdmin_Click);
            // 
            // loginExit
            // 
            this.loginExit.BackColor = System.Drawing.Color.Red;
            this.loginExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginExit.ForeColor = System.Drawing.Color.White;
            this.loginExit.Location = new System.Drawing.Point(649, 349);
            this.loginExit.Name = "loginExit";
            this.loginExit.Size = new System.Drawing.Size(119, 56);
            this.loginExit.TabIndex = 7;
            this.loginExit.Text = "Išeiti";
            this.loginExit.UseVisualStyleBackColor = false;
            this.loginExit.Click += new System.EventHandler(this.loginExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(359, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // PrisijungimoLangas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginExit);
            this.Controls.Add(this.prisijungAdmin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.prisijungPrisijungti);
            this.Controls.Add(this.prisijungSlaptazodis);
            this.Controls.Add(this.prisijungVardas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PrisijungimoLangas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prisijungimo langas";
            this.Load += new System.EventHandler(this.PrisijungimoLangas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prisijungVardas;
        private System.Windows.Forms.TextBox prisijungSlaptazodis;
        private System.Windows.Forms.Button prisijungPrisijungti;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button prisijungAdmin;
        private System.Windows.Forms.Button loginExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

