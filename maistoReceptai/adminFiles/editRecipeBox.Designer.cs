
namespace maistoReceptai
{
    partial class editRecipeBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.editRecID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.editRecName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.editRecTime = new System.Windows.Forms.NumericUpDown();
            this.editRecAtn = new System.Windows.Forms.Button();
            this.editRecType = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.editRecRID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.editRecTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // editRecID
            // 
            this.editRecID.Location = new System.Drawing.Point(235, 51);
            this.editRecID.Name = "editRecID";
            this.editRecID.ReadOnly = true;
            this.editRecID.Size = new System.Drawing.Size(55, 22);
            this.editRecID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pavadinimas";
            // 
            // editRecName
            // 
            this.editRecName.Location = new System.Drawing.Point(235, 95);
            this.editRecName.Name = "editRecName";
            this.editRecName.Size = new System.Drawing.Size(207, 22);
            this.editRecName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Paruošimo laikas";
            // 
            // editRecTime
            // 
            this.editRecTime.Location = new System.Drawing.Point(235, 206);
            this.editRecTime.Name = "editRecTime";
            this.editRecTime.Size = new System.Drawing.Size(114, 22);
            this.editRecTime.TabIndex = 14;
            // 
            // editRecAtn
            // 
            this.editRecAtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.editRecAtn.Location = new System.Drawing.Point(486, 121);
            this.editRecAtn.Name = "editRecAtn";
            this.editRecAtn.Size = new System.Drawing.Size(111, 53);
            this.editRecAtn.TabIndex = 15;
            this.editRecAtn.Text = "Atnaujinti elementą";
            this.editRecAtn.UseVisualStyleBackColor = false;
            this.editRecAtn.Click += new System.EventHandler(this.editRecAtn_Click);
            // 
            // editRecType
            // 
            this.editRecType.FormattingEnabled = true;
            this.editRecType.ItemHeight = 16;
            this.editRecType.Items.AddRange(new object[] {
            "Vegetariškas",
            "Nevegetariškas"});
            this.editRecType.Location = new System.Drawing.Point(235, 138);
            this.editRecType.Name = "editRecType";
            this.editRecType.Size = new System.Drawing.Size(125, 36);
            this.editRecType.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(329, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "rID";
            // 
            // editRecRID
            // 
            this.editRecRID.Location = new System.Drawing.Point(375, 51);
            this.editRecRID.Name = "editRecRID";
            this.editRecRID.ReadOnly = true;
            this.editRecRID.Size = new System.Drawing.Size(55, 22);
            this.editRecRID.TabIndex = 20;
            // 
            // editRecipeBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 298);
            this.Controls.Add(this.editRecRID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.editRecType);
            this.Controls.Add(this.editRecAtn);
            this.Controls.Add(this.editRecTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.editRecName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editRecID);
            this.Controls.Add(this.label1);
            this.Name = "editRecipeBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editRecipeBox";
            this.Load += new System.EventHandler(this.editRecipeBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editRecTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button editRecAtn;
        public System.Windows.Forms.TextBox editRecID;
        public System.Windows.Forms.TextBox editRecName;
        public System.Windows.Forms.NumericUpDown editRecTime;
        public System.Windows.Forms.ListBox editRecType;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox editRecRID;
    }
}