
namespace maistoReceptai
{
    partial class userSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saveUserSetting = new System.Windows.Forms.Button();
            this.userVeg = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.userNonVeg = new System.Windows.Forms.RadioButton();
            this.userNickname = new System.Windows.Forms.TextBox();
            this.userEmail = new System.Windows.Forms.TextBox();
            this.userLastName = new System.Windows.Forms.TextBox();
            this.userFirstName = new System.Windows.Forms.TextBox();
            this.userDoB = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.userPass = new System.Windows.Forms.TextBox();
            this.appDataSet = new maistoReceptai.AppDataSet();
            this.vartotojaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vartotojaiTableAdapter = new maistoReceptai.AppDataSetTableAdapters.VartotojaiTableAdapter();
            this.userImportRefre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vartotojaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vartotojo nustatymai";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vardas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pavardė";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(233, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "El. paštas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(221, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Slapyvardis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(212, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Gimimo data";
            // 
            // saveUserSetting
            // 
            this.saveUserSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveUserSetting.Location = new System.Drawing.Point(408, 434);
            this.saveUserSetting.Name = "saveUserSetting";
            this.saveUserSetting.Size = new System.Drawing.Size(101, 48);
            this.saveUserSetting.TabIndex = 8;
            this.saveUserSetting.Text = "Išsaugoti";
            this.saveUserSetting.UseVisualStyleBackColor = true;
            this.saveUserSetting.Click += new System.EventHandler(this.saveUserSetting_Click);
            // 
            // userVeg
            // 
            this.userVeg.AutoSize = true;
            this.userVeg.Location = new System.Drawing.Point(355, 359);
            this.userVeg.Name = "userVeg";
            this.userVeg.Size = new System.Drawing.Size(111, 21);
            this.userVeg.TabIndex = 9;
            this.userVeg.TabStop = true;
            this.userVeg.Text = "Vegetariškas";
            this.userVeg.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(216, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Maisto tipas";
            // 
            // userNonVeg
            // 
            this.userNonVeg.AutoSize = true;
            this.userNonVeg.Location = new System.Drawing.Point(490, 359);
            this.userNonVeg.Name = "userNonVeg";
            this.userNonVeg.Size = new System.Drawing.Size(127, 21);
            this.userNonVeg.TabIndex = 11;
            this.userNonVeg.TabStop = true;
            this.userNonVeg.Text = "Nevegetariškas";
            this.userNonVeg.UseVisualStyleBackColor = true;
            // 
            // userNickname
            // 
            this.userNickname.Location = new System.Drawing.Point(355, 240);
            this.userNickname.Name = "userNickname";
            this.userNickname.Size = new System.Drawing.Size(240, 22);
            this.userNickname.TabIndex = 13;
            this.userNickname.TextChanged += new System.EventHandler(this.userNickname_TextChanged);
            // 
            // userEmail
            // 
            this.userEmail.Location = new System.Drawing.Point(355, 196);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(240, 22);
            this.userEmail.TabIndex = 14;
            // 
            // userLastName
            // 
            this.userLastName.Location = new System.Drawing.Point(355, 155);
            this.userLastName.Name = "userLastName";
            this.userLastName.Size = new System.Drawing.Size(240, 22);
            this.userLastName.TabIndex = 15;
            this.userLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userLastName_KeyPress);
            // 
            // userFirstName
            // 
            this.userFirstName.Location = new System.Drawing.Point(355, 111);
            this.userFirstName.Name = "userFirstName";
            this.userFirstName.Size = new System.Drawing.Size(240, 22);
            this.userFirstName.TabIndex = 16;
            this.userFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userFirstName_KeyPress);
            // 
            // userDoB
            // 
            this.userDoB.Location = new System.Drawing.Point(355, 320);
            this.userDoB.Name = "userDoB";
            this.userDoB.Size = new System.Drawing.Size(240, 22);
            this.userDoB.TabIndex = 17;
            this.userDoB.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(220, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Slaptažodis";
            // 
            // userPass
            // 
            this.userPass.Location = new System.Drawing.Point(355, 279);
            this.userPass.Name = "userPass";
            this.userPass.Size = new System.Drawing.Size(240, 22);
            this.userPass.TabIndex = 19;
            this.userPass.UseSystemPasswordChar = true;
            // 
            // appDataSet
            // 
            this.appDataSet.DataSetName = "AppDataSet";
            this.appDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vartotojaiBindingSource
            // 
            this.vartotojaiBindingSource.DataMember = "Vartotojai";
            this.vartotojaiBindingSource.DataSource = this.appDataSet;
            // 
            // vartotojaiTableAdapter
            // 
            this.vartotojaiTableAdapter.ClearBeforeFill = true;
            // 
            // userImportRefre
            // 
            this.userImportRefre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userImportRefre.Location = new System.Drawing.Point(658, 181);
            this.userImportRefre.Name = "userImportRefre";
            this.userImportRefre.Size = new System.Drawing.Size(168, 59);
            this.userImportRefre.TabIndex = 20;
            this.userImportRefre.Text = "Įkelti/atnaujinti duomenis";
            this.userImportRefre.UseVisualStyleBackColor = true;
            this.userImportRefre.Click += new System.EventHandler(this.userImportRefre_Click);
            // 
            // userSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userImportRefre);
            this.Controls.Add(this.userPass);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.userDoB);
            this.Controls.Add(this.userFirstName);
            this.Controls.Add(this.userLastName);
            this.Controls.Add(this.userEmail);
            this.Controls.Add(this.userNickname);
            this.Controls.Add(this.userNonVeg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.userVeg);
            this.Controls.Add(this.saveUserSetting);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "userSettings";
            this.Size = new System.Drawing.Size(949, 520);
            this.Load += new System.EventHandler(this.userSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vartotojaiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveUserSetting;
        private System.Windows.Forms.RadioButton userVeg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton userNonVeg;
        private System.Windows.Forms.TextBox userNickname;
        private System.Windows.Forms.TextBox userEmail;
        private System.Windows.Forms.TextBox userLastName;
        private System.Windows.Forms.TextBox userFirstName;
        private System.Windows.Forms.DateTimePicker userDoB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox userPass;
        private System.Windows.Forms.BindingSource vartotojaiBindingSource;
        private AppDataSet appDataSet;
        private AppDataSetTableAdapters.VartotojaiTableAdapter vartotojaiTableAdapter;
        private System.Windows.Forms.Button userImportRefre;
    }
}
