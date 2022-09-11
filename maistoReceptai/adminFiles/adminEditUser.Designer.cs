
namespace maistoReceptai
{
    partial class adminEditUser
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
            this.editUserID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editUserNick = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.editUserName = new System.Windows.Forms.TextBox();
            this.editUserLastName = new System.Windows.Forms.TextBox();
            this.editUserEmail = new System.Windows.Forms.TextBox();
            this.editUserDoB = new System.Windows.Forms.DateTimePicker();
            this.editUserAtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.editUserRecType = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // editUserID
            // 
            this.editUserID.Location = new System.Drawing.Point(196, 63);
            this.editUserID.Name = "editUserID";
            this.editUserID.ReadOnly = true;
            this.editUserID.Size = new System.Drawing.Size(55, 22);
            this.editUserID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Slapyvardis";
            // 
            // editUserNick
            // 
            this.editUserNick.Location = new System.Drawing.Point(196, 110);
            this.editUserNick.Name = "editUserNick";
            this.editUserNick.Size = new System.Drawing.Size(207, 22);
            this.editUserNick.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vardas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pavardė";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "El. paštas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Gim. data";
            // 
            // editUserName
            // 
            this.editUserName.Location = new System.Drawing.Point(196, 156);
            this.editUserName.Name = "editUserName";
            this.editUserName.Size = new System.Drawing.Size(207, 22);
            this.editUserName.TabIndex = 10;
            this.editUserName.TextChanged += new System.EventHandler(this.editUserName_TextChanged);
            this.editUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editUserName_KeyPress);
            // 
            // editUserLastName
            // 
            this.editUserLastName.Location = new System.Drawing.Point(196, 198);
            this.editUserLastName.Name = "editUserLastName";
            this.editUserLastName.Size = new System.Drawing.Size(207, 22);
            this.editUserLastName.TabIndex = 11;
            this.editUserLastName.TextChanged += new System.EventHandler(this.editUserLastName_TextChanged);
            this.editUserLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editUserLastName_KeyPress);
            // 
            // editUserEmail
            // 
            this.editUserEmail.Location = new System.Drawing.Point(196, 242);
            this.editUserEmail.Name = "editUserEmail";
            this.editUserEmail.Size = new System.Drawing.Size(207, 22);
            this.editUserEmail.TabIndex = 12;
            // 
            // editUserDoB
            // 
            this.editUserDoB.Location = new System.Drawing.Point(196, 282);
            this.editUserDoB.Name = "editUserDoB";
            this.editUserDoB.Size = new System.Drawing.Size(207, 22);
            this.editUserDoB.TabIndex = 13;
            // 
            // editUserAtn
            // 
            this.editUserAtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.editUserAtn.Location = new System.Drawing.Point(457, 183);
            this.editUserAtn.Name = "editUserAtn";
            this.editUserAtn.Size = new System.Drawing.Size(111, 53);
            this.editUserAtn.TabIndex = 16;
            this.editUserAtn.Text = "Atnaujinti vartotoją";
            this.editUserAtn.UseVisualStyleBackColor = false;
            this.editUserAtn.Click += new System.EventHandler(this.editUserAtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tipas";
            // 
            // editUserRecType
            // 
            this.editUserRecType.FormattingEnabled = true;
            this.editUserRecType.ItemHeight = 16;
            this.editUserRecType.Items.AddRange(new object[] {
            "Vegetariškas",
            "Nevegetariškas"});
            this.editUserRecType.Location = new System.Drawing.Point(196, 323);
            this.editUserRecType.Name = "editUserRecType";
            this.editUserRecType.Size = new System.Drawing.Size(124, 36);
            this.editUserRecType.TabIndex = 19;
            // 
            // adminEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.editUserRecType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.editUserAtn);
            this.Controls.Add(this.editUserDoB);
            this.Controls.Add(this.editUserEmail);
            this.Controls.Add(this.editUserLastName);
            this.Controls.Add(this.editUserName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editUserNick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editUserID);
            this.Controls.Add(this.label1);
            this.Name = "adminEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminEditUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox editUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox editUserNick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox editUserName;
        public System.Windows.Forms.TextBox editUserLastName;
        public System.Windows.Forms.TextBox editUserEmail;
        private System.Windows.Forms.Button editUserAtn;
        public System.Windows.Forms.DateTimePicker editUserDoB;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ListBox editUserRecType;
    }
}